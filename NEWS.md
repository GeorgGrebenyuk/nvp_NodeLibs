# История обновления версий

## v0.0.2

04.08.2024

**Добавлено**:

* Библиотека McCOM2 для доступа к объектам модулей nanoCAD СПДС и Механика;

* `NVP_COM_Common.ProgID` - добавлены идентификаторы для БД компонентов (CADLib) и McCOM2 сервера (СПДС и Механика);

* Переопределен нод `AppendOuterLoop` для AcadHatch: он переименован в `AppendOuterLoop_Single`, добавлен новый нод `AppendOuterLoop_Group`. Нод AppendOuterLoop_Single ожидает единичный объект (интерфейс AcadEntity), а AppendOuterLoop_Group -- массив интерфейсов AcadEntity;

**Обновлено**:

* Пример нодов nanoCAD для отрисовки окружности и штриховки;

## v0.0.1

03.08.2024

Первая версия пакета нодов -- поддержка nanoCAD, ModelStudio CS, Renga;
