# nvp_NodeLibs_ActiveX

Исходный код библиотек нодов NVP для САПР с COM API (ActiveX) : Renga, nanoCAD, ModelStudioCS
Срздано при помощи https://github.com/GeorgGrebenyuk/idl2nvp_converter.

# Пользователю

Загрузить из [Releases](https://github.com/GeorgGrebenyuk/nvp_NodeLibs_ActiveX/releases/latest) последнюю версию и распаковать в папку \Nodepack для используемой версии NVP в зависимости от целевого фрейморка: `net48` -- `NPV_NodeLibs_ActiveX_net48.zip` или `net6.0` -- `NPV_NodeLibs_ActiveX_net6.0.zip`. 

## Примеры

См. папку `.\samples` и [файл описания доступных примеров](./samples/SAMPLES_README.md) (скриптов `*.nvproj`).

## История обновлений

См. файл [NEWS](./NEWS.md)

## Общие замечания

Настоящие пакеты нодов используют технологию "внешний COM" для взаимодействия с целевыми программами. Эта технология является специфичной для ОС Windows и потому на Linux не будет работать (внутренний COM в каком-то виде там есть, но для закрытия задач данных библиотек не годится).

## Состав пакета

* `NVP_COM_Common` - методы для получения COM-приложений в системе. Также идентификаторы COM-приложений (nanoCAD, Renga, ModelStudio);
* `NVP_nanoCAD_COM` - взаимодейсвтие с платформой nanoCAD и ModelStudio CS (далее MST), а также с некоторыми объектами СПДС и Механика (McCOM2);

Ниже представлены группы нодов в составе пакета и информация, для чего их использовать. Жирным помечены основные группы.

| **Группа нодов**     | **Название COM библиотеки**                             | **Предназначение**                                                                                                    |
| -------------------- | ------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **nanoCAD**          | nanoCAD x64 Type Library                                | Взаимодействие с приложением и документами nanoCAD                                                                    |
| **OdaX**             | OdaX 24.8 (x64) Type Library                            | Работа с данными чертежей nanoCAD и объектами чертежа. Также первичный выбор объектов для всех остальных групп нодов. |
| CSMSStormComLib      | Model Studio STORM Objects 1.0 Type Library             | MST Storm (Молниезащита)                                                                                              |
| ironObjComLib        | ironObjCom 1.0 Type Library                             | MST Строительные решения                                                                                              |
| McCOM2               | MechaniCS COM 2.0 type library                          | Взаимодействие с некоторыми объектами модулей СПДС и Механика                                                         |
| mdsELAYComLib        | Model Studio ELAY Objects 1.0 Type Library              | MST ОРУ (Открытые распределительные устройства)                                                                       |
| **mdsLibManagerLib** | Model Studio Library Manager 1.0 Type Library           | Работа с библиотекой стандартных компонентов                                                                          |
| mdsLINEComLib        | Model Studio LINE Objects 1.0 Type Library              | Объекты элетросетей (MST Электрика)                                                                                   |
| mdsMetalLib          | Model Studio Cable 1.0 Type Library                     | MST Cable (Кабельное хозяйство)                                                                                       |
| **mdsUnitsLib**      | Model Studio Objects 1.0 Type Library                   | Описание интерфейсов стандартного оборудования и доступ к параметрам объектов MST                                     |
| mdsURSLib            | Model Studio Unified Reporting Service 1.0 Type Library | Система отчетов и документов MST                                                                                      |
| msCABComLib          | msCABCom 1.0 Type Library                               | Нет данных. Не реализовано                                                                                            |
| mstHVACCOMLib        | mstHVACCOM 1.0 Type Library                             | MST  HEATVENT (Отопление и вентиляция)                                                                                |
| mstmsMPHSLib         | Нет данных                                              | Нет данных. Не реализовано                                                                                            |
| mstProjectCOMLib     | mstProjectCOM 1.0 Type Library                          | Нет данных. MST Что-то для мастера экспликаций                                                                        |
| mstRouteCOMLib       | mstRouteCOM 1.0 Type Library                            | MST Cable (Кабельное хозяйство)                                                                                       |
| SchematiCSCOMLib     | Model Studio CS Schema 1.0 Type Library                 | MST ТХ (Технологические Системы)                                                                                      |
| vCSViperCSObjComLib  | vCSViperCSObjCom 1.0 Type Library                       | MST Трубопроводы                                                                                                      |

* `NVP_Renga_COM` - взаимодействие с Renga;

# Разработчику

Сборка через сценарии `Build_debug.bat` и `Build_release.bat`. В сценарии изменить путь к папке с NVP, где будете проиводить отладку нодов, а также настроить этот путь в профиле отладки.