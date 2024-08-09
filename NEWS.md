# История обновления версий

## v0.0.3

 09.08.2024

**Изменения в нодах**:

* [NVP_ModelStudio_COM] Корректировка для всех функций проекта папки в дереве NVP-студии;

* [NVP_COM_Common] Изменение всех идентификаторов функций, изменение иерархии в дереве NVP-студии;

* [NVP_nanoCAD_COM] Добавлены новые ноды для возврата всех объектов коллекций nanoCAD.nanoCADDocuments, OdaX.AcadBlock, OdaX.AcadBlocks, OdaX.AcadGroups, OdaX.AcadHyperlinks, OdaX.AcadLayers, OdaX.AcadLayouts, OdaX.AcadLineTypes, OdaX.AcadMaterials, OdaX.AcadPlotConfigurations, OdaX.AcadRegisteredApplications, OdaX.AcadUCSs, OdaX.AcadViewports, OdaX.AcadViews;

* [NVP_nanoCAD_COM] удалены ненужные коллекции нодов nanoCAD.enum___MIDL___MIDL_itf_NCAuto_0000_0000_0001, OdaX.AcadObjectEvents, OdaX.OPMPropertyExpander, OdaX.OPMPropertyExtension, nanoCAD.ALoader, nanoCAD.ACommand, nanoCAD.AHelper, nanoCAD.Arguments, nanoCAD.EnuVal, nanoCAD.nanoCADMenuBar, nanoCAD.nanoCADMenuGroups, nanoCAD.nanoCADMenuGroup, nanoCAD.nanoCADPopupMenu,  nanoCAD.nanoCADPopupMenuItem, nanoCAD.nanoCADPopupMenus, nanoCAD.nanoCADToolbar, nanoCAD.nanoCADToolbarItem,  nanoCAD.nanoCADToolbars, nanoCAD.Params ;

* [NVP_Renga_COM] Скорректированы описания к DrawingCollection.GetAll_Drawings, ParameterContainer.GetAll_Parameters, PropertyContainer.GetAll_Properties, QuantityContainer.GetAll_Quantities: добавлен тип объекта, в котором возвращаются данные;

**Прочие изменения**:

* Внутренняя логика учета и создания файлов манифеста по атрибутам классов (оставлены только ViewType, Text);

* Корректировка файлов примеров (для новых изменений нодов);

* Добавлено небольшое руководство разработчику [см. отдельный файл](./docs/DevGuide.md), будет пополняться в дальнейшем;

## v0.0.2

05.08.2024

**Изменения в нодах**:

* [NVP_nanoCAD_COM] Библиотека McCOM2 для доступа к объектам модулей nanoCAD СПДС и Механика;

* `NVP_COM_Common.ProgID` - добавлены идентификаторы для БД компонентов (CADLib) и McCOM2 сервера (СПДС и Механика);

* [NVP_nanoCAD_COM] Переопределен нод `AppendOuterLoop` для AcadHatch: он переименован в `AppendOuterLoop_Single`, добавлен новый нод `AppendOuterLoop_Group`. Нод AppendOuterLoop_Single ожидает единичный объект (интерфейс AcadEntity), а AppendOuterLoop_Group -- массив интерфейсов AcadEntity;

* [NVP_nanoCAD_COM] Функции ModelStudio выведены в отдельную библиотеку нодов `NVP_ModelStudio_COM`;

* [NVP_Renga_COM] Удалены группы нодов для событий и UI, не нужные в работе;

* [NVP_Renga_COM] Для работы с DrawingCollection, GuidCollection, QuantityContainer, ParameterContainer, PropertyContainer добавлены вспомогательные ноды, возвращающие все объекты коллекций;

* [NVP_Renga_COM] добавлен нод QuantityContainer.QuantityIds, возвращающий все идентификаторы расчетных свойств Quantity;

* [NVP_Renga_COM] добавлен нод PropertyContainer.GetAll_Properties2, возвращающий информацию всех обычных свойствах в виде словаря (имя свойства и значение)

* [NVP_Renga_COM] добавлен нод QuantityContainer.GetAll_Quantities2, возвращающий информацию всех расчетных свойствах в виде словаря (имя свойства и значение);

* [NVP_Renga_COM] добавлен нод ParameterContainer.GetAll_Parameters2, возвращающий информацию всех параметрах в виде словаря (имя параметра и значение);

**Прочие изменения**:

* Пример нодов nanoCAD для отрисовки окружности и штриховки;
* Пример нодов Renga для получения свойств проекта;
* Скрипты сборки проектов `bat`;

## v0.0.1

03.08.2024

Первая версия пакета нодов -- поддержка nanoCAD, ModelStudio CS, Renga;
