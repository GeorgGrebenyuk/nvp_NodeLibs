# История обновления версий

## v0.0.6

26.08.2024

**Изменения в нодах**:

* [NVP_Common] Добавлена группа нодов Common с нодами Null и IsNull;

* [NVP_Common] В группу нодов List добавлены ноды AddItem, AddItems;

* [NVP_Common] Сформирована группа нодов Task, куда включена группа Kvartirografiya для решения задач по расчету квартирографии (расчет + вспомогательные значения);

* [NVP_Renga_COM] В группу Selection добавлен нод GetObjectsFromModelByTypeAndLevel;

* [NVP_Renga_COM] В группу Utilities добавлен нод CreateProperties для пакетного создания новых свойств и регистрации в модели;

**Прочие изменения**:

* Добавлено новое руководство для скриптов под рабочие задачи (на примере Квартирографии);

## v0.0.5

23.08.2024

**Изменения в нодах:**

* [NVP_Renga_COM] Добавлена группа нодов Utilities с функциями групповых изменений модели в составе нодов SetPropertyToObject, SetPropertiesToObject, SetPropertiesToObjects, SetPropertyToObjects, каждая из которых внутри имеет транзакцию для записи;

* [NVP_Renga_COM] Группа нодов Selection - удалены ноды-конструкторы, как ненужные и переопределена механика нодов GetSelectedObjects и SetSelectedObjects

* [NVP_Renga_COM] ModelObject - добавлены новые ноды GetProperties2, GetQuantities2, GetParameters2 возвращающие целевые свойства сразу в виде "классов-конструкторов";

* [NVP_Renga_COM] ModelObject добавлен нод UniqueIdS, возвращающий идентификатор объекта в виде строкового guid;

* [NVP_Renga_COM] enum_SelectionType: добавлены режимы выбора для Помещений (enum_SelectionType_IRoom) и Сборок (enum_SelectionType_IModel);

* [NVP_Renga_COM] В группе enum_ParameterType изменения: нод enum_ParameterType_IntEnumeration переименован в enum_ParameterType_AppDefinedEnum, добавлен enum_ParameterType_UserDefinedEnum

* [NVP_Renga_COM] Удалены группы нодов Operation, ApplicationEvents (неактуальны для NVP);

* [NVP_Common] Добавлена группа нодов по работе со словарями (Dictionary), состав функций перенесён из стандартной поставки нодов Autodesk Dynamo и расширен некоторыми иными методами;

* Создан новый проект и группа нодов NVP_Common, куда перенесена группа нодов по работе со списками из состава NVP_COM_Common.List, идентификаторы нодов остались теми же (изменений в скриптах делать не потребуется);

* Все ноды, имеющие в названии "\_Constructor" теперь отображаются в группах нодов с префиксом "\_", чтобы находиться в начале списка нодов группы;

**Прочие изменения**:

* [NVP_Renga_COM] Добавлен пример `NVP_Renga_COM_Sample_Квартирография 1.nvproj` и обновлены ранние примеры;

* [NVP_Renga_COM] Библиотека `Renga.NET.PluginUtility.dll` была обновлена для новейшего SDK версии 2.35;

* [NVP_Renga_COM] Удалена зависимость от `Renga.NET.PluginUtility.dll`;

## v0.0.4

11.08.2024

**Изменения в нодах**:

* [NVP_nanoCAD_COM] Добавлены вспомогательные ноды в AcadBlock: GetAll_EntitiesMST , GetAll_EntitiesByName и GetAll_EntitiesByNames (все объекты по имени типу - одиночному или в виде списка), а также GetAll_EntitiesMST (все объекты ModelStudioCS);
* [NVP_nanoCAD_COM] Добавлены вспомогательные ноды в AcadSummaryInfo: GetAll_CustomInfo (возвращают словарь со всеми пользовательскими свойствами) и Add_GroupOfCustomInfo (добавляют набор новых пользовательских свойств с режимом поведения при наличии таковых);
* [NVP_ModelStudio_COM] Добавлен вспомогательный нод GetAll_EntitiesMST2 в группу mdsUnitsLib.Selection (возвращают все объекты ModelStudioCS в виде mdsUnitsLib.Element);
* [NVP_ModelStudio_COM] Удалены классы ironObjComLib.ConcreteDiaProp, ironObjComLib.ConcreteMarkProp, ironObjComLib.ConcreteParentProp, ironObjComLib.WrConcreteBeam, ironObjComLib.WrConcreteColumn, ironObjComLib.WrIronBoltJoint, ironObjComLib.WrReinfAsm, ironObjComLib.WrReinfSpiral (недоступны в релизы MST от 05.07.2024);
* [NVP_ModelStudio_COM] Удалены классы mdsLINEComLib.enum___MIDL___MIDL_itf_ProfileViewCOM_0001_0079_0001, mdsLibManagerLib.enum___MIDL___MIDL_itf_LibManager_0000_0000_0002, mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0001, mdsURSLib.enum___MIDL___MIDL_itf_URS_0000_0006_0002;
* [NVP_COM_Common] Удалены ноды из NVP_COM_Common.List и заменены новыми: FilterByCondition, FilterByBoolMask;
* [NVP_Renga_COM] В группу Selection добавлены вспомогательные ноды GetObjectsFromModelByClass, GetObjectsFromModelByType, GetObjectsFromModelByTypes, для них же добавлены группы нодов ObjectTypes и enum_SelectionType;
* [NVP_Renga_COM] В группу Application добавлен нод ActiveProject, возвращающий Project_Constructor для активного проекта в активном сеансе Renga; 

**Прочие изменения**:

* Добавлены примеры `NVP_NCAD_COM_Sample_Explore document.nvproj`, `NVP_MST_COM_Sample_Explore objects.nvproj`;

* Добавлен раздел с [документацией по нодам](./docs/UserGuide.md) (добавлены отдельные руководство по пакетам для nanoCAD, ModelStudio CS, Renga);

* Настоящий репозиторий сменил название с `nvp_NodeLibs_ActiveX` на `NPV_NodeLibs`;

* Библиотеки `NVP_Renga_COM.dll` и `NVP_nanoCAD_COM.dll` теперь зависят от `NVP_COM_Common.dll` и потому должны использоваться совместно;

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
