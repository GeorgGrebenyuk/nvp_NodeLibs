# История обновления версий

## v0.0.2

05.08.2024

**Добавлено**:

* [NVP_nanoCAD_COM] Библиотека McCOM2 для доступа к объектам модулей nanoCAD СПДС и Механика;

* `NVP_COM_Common.ProgID` - добавлены идентификаторы для БД компонентов (CADLib) и McCOM2 сервера (СПДС и Механика);

* [NVP_nanoCAD_COM] Переопределен нод `AppendOuterLoop` для AcadHatch: он переименован в `AppendOuterLoop_Single`, добавлен новый нод `AppendOuterLoop_Group`. Нод AppendOuterLoop_Single ожидает единичный объект (интерфейс AcadEntity), а AppendOuterLoop_Group -- массив интерфейсов AcadEntity;

* [NVP_nanoCAD_COM] Функции ModelStudio выведены в отдельную библиотеку нодов `NVP_ModelStudio_COM`;

* [NVP_Renga_COM] Удалены группы нодов для событий и UI, не нужные в работе;

* [NVP_Renga_COM] Для работы с DrawingCollection, GuidCollection, QuantityContainer, ParameterContainer, PropertyContainer добавлены вспомогательные ноды, возвращающие все объекты коллекций;

* [NVP_Renga_COM] добавлен нод QuantityContainer.QuantityIds, возвращающий все идентификаторы расчетных свойств Quantity;

* [NVP_Renga_COM] добавлен нод PropertyContainer.GetAll_Properties2, возвращающий информацию всех обычных свойствах в виде словаря (имя свойства и значение)

* [NVP_Renga_COM] добавлен нод QuantityContainer.GetAll_Quantities2, возвращающий информацию всех расчетных свойствах в виде словаря (имя свойства и значение);

* [NVP_Renga_COM] добавлен нод ParameterContainer.GetAll_Parameters2, возвращающий информацию всех параметрах в виде словаря (имя параметраи значение);

**Обновлено**:

* Пример нодов nanoCAD для отрисовки окружности и штриховки;
* Пример нодов Renga для получения свойств проекта;
* Скрипты сборки проектов `bat`;

## v0.0.1

03.08.2024

Первая версия пакета нодов -- поддержка nanoCAD, ModelStudio CS, Renga;
