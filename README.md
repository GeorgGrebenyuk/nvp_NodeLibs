# nvp_NodeLibs

Исходный код библиотек нодов NVP ([https://nvp-studio.ru/](https://nvp-studio.ru/)) для САПР с COM API (ActiveX) : Renga, nanoCAD, ModelStudioCS, а также других проектов.

Проекты, использующие COM созданы при помощи https://github.com/GeorgGrebenyuk/idl2nvp_converter.

# Пользователю

Загрузить из [Releases](https://github.com/GeorgGrebenyuk/nvp_NodeLibs_ActiveX/releases/latest) последнюю версию и распаковать в папку \Nodepack для используемой версии NVP в зависимости от целевого фрейморка: `net48` -- `NPV_NodeLibs_net48.zip` или `net6.0` -- `NPV_NodeLibs_net6.0.zip`. 

## Использование и справка по нодам

* Информация о пакетах и особенностях их использования приведена см. [здесь](./docs/UserGuide.md);
* Примеры скриптов см. [здесь](./samples/SAMPLES_README.md);
* Готовые сценарии (скрипты) под рабочие задачи и об их применении см. [здесь](./docs/UserGuide_common_Tasks.md);
* Краткая справка по всем пакетам нодов:
  * [NVP_COM_Common](./docs/help/NVP_COM_Common_help.md);
  * [NVP_Common](./docs/help/NVP_Common_help.md);
  * [NVP_ModelStudio_COM](./docs/help/NVP_ModelStudio_COM_help.md);
  * [NVP_nanoCAD_COM](./docs/help/NVP_nanoCAD_COM_help.md);
  * [NVP_nanoCAD_Platform_NET](./docs/help/NVP_nanoCAD_Platform_NET_help.md);
  * [NVP_nBIM_NET](./docs/help/NVP_nBIM_NET_help.md);
  * [NVP_Renga_COM](./docs/help/NVP_Renga_COM_help.md);

## История обновлений

См. файл [NEWS](./NEWS.md)

## Состав пакета

Описываются библиотеки нодов. Если библиотека состоит из нескольких частей приводится таблица.

* `NVP_COM_Common` - методы для получения COM-приложений в системе. Также идентификаторы COM-приложений (nanoCAD, Renga, ModelStudio);
* `NVP_nanoCAD_COM` - взаимодейсвтие с платформой nanoCAD и некоторыми объектами модулей СПДС и Механика (McCOM2);

| **Группа нодов** | **Название COM библиотеки**    | **Предназначение**                                                                                                    |
| ---------------- | ------------------------------ | --------------------------------------------------------------------------------------------------------------------- |
| **nanoCAD**      | nanoCAD x64 Type Library       | Взаимодействие с приложением и документами nanoCAD                                                                    |
| **OdaX**         | OdaX 24.8 (x64) Type Library   | Работа с данными чертежей nanoCAD и объектами чертежа. Также первичный выбор объектов для всех остальных групп нодов. |
| McCOM2           | MechaniCS COM 2.0 type library | Взаимодействие с некоторыми объектами модулей СПДС и Механика                                                         |

* `NVP_ModelStudio_COM` - взаимодейсвтие с CSoft ModelStudio (MST далее) и Библиотекой стандартных компонентов. Для работы необходима библиотека `NVP_nanoCAD_COM`;

| **Группа нодов**     | **Название COM библиотеки**                             | **Предназначение**                                                                |
| -------------------- | ------------------------------------------------------- |:--------------------------------------------------------------------------------- |
| CSMSStormComLib      | Model Studio STORM Objects 1.0 Type Library             | MST Storm (Молниезащита)                                                          |
| ironObjComLib        | ironObjCom 1.0 Type Library                             | MST Строительные решения                                                          |
| mdsELAYComLib        | Model Studio ELAY Objects 1.0 Type Library              | MST ОРУ (Открытые распределительные устройства)                                   |
| **mdsLibManagerLib** | Model Studio Library Manager 1.0 Type Library           | Работа с библиотекой стандартных компонентов                                      |
| mdsLINEComLib        | Model Studio LINE Objects 1.0 Type Library              | Объекты элетросетей (MST Электрика)                                               |
| mdsMetalLib          | Model Studio Cable 1.0 Type Library                     | MST Cable (Кабельное хозяйство)                                                   |
| **mdsUnitsLib**      | Model Studio Objects 1.0 Type Library                   | Описание интерфейсов стандартного оборудования и доступ к параметрам объектов MST |
| mdsURSLib            | Model Studio Unified Reporting Service 1.0 Type Library | Система отчетов и документов MST                                                  |
| msCABComLib          | msCABCom 1.0 Type Library                               | Нет данных. Не реализовано                                                        |
| mstHVACCOMLib        | mstHVACCOM 1.0 Type Library                             | MST  HEATVENT (Отопление и вентиляция)                                            |
| mstmsMPHSLib         | Нет данных                                              | Нет данных. Не реализовано                                                        |
| mstProjectCOMLib     | mstProjectCOM 1.0 Type Library                          | Нет данных. MST Что-то для мастера экспликаций                                    |
| mstRouteCOMLib       | mstRouteCOM 1.0 Type Library                            | MST Cable (Кабельное хозяйство)                                                   |
| SchematiCSCOMLib     | Model Studio CS Schema 1.0 Type Library                 | MST ТХ (Технологические Системы)                                                  |
| vCSViperCSObjComLib  | vCSViperCSObjCom 1.0 Type Library                       | MST Трубопроводы                                                                  |

* `NVP_Renga_COM` - взаимодействие с Renga;

# Разработчику

Сборка через сценарии `Build_debug.bat` и `Build_release.bat`. В сценарии **debug** изменить путь к папке с NVP, где будете проиводить отладку нодов, а также настроить этот путь в профиле отладки. `Build_release.bat`формирует в корне репозитория целевые архивы для размещения в составе Релизов.

Подробнее о логике создания новых коллекций нодов [см. отдельный файл](./docs/DevGuide.md).
