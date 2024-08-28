# NVP_Common

## Группа NVP_Common.Wait

### Нод Wait_2

**Описание** = Задержка для двух значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;

### Нод Wait_3

**Описание** = Задержка для трех значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;

### Нод Wait_4

**Описание** = Задержка для четырех значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;

### Нод Wait_5

**Описание** = Задержка для пяти значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;
* (System.Object)Объект 5;

### Нод Wait_6

**Описание** = Задержка для шести значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;
* (System.Object)Объект 5;
* (System.Object)Объект 6;

### Нод Wait_7

**Описание** = Задержка для семи значений;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;
* (System.Object)Объект 5;
* (System.Object)Объект 6;
* (System.Object)Объект 7;

## Группа NVP_Common.Task.Kvartirografiya

### Нод Kvartirografiya_Rooms_Living

**Описание** = Возвращает список ЖИЛЫХ помещений по умолчанию;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_NonLiving

**Описание** = Возвращает список НЕЖИЛЫХ помещений по умолчанию;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_Other

**Описание** = Возвращает список ЛЕТНИХ (и прочих) помещений по умолчанию;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_WithoutOtd

**Описание** = Возвращает список помещений без отделки;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_Coefficients2Areas

**Описание** = Возвращает сопоставление названий помещений с коэффициентами к площадям;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Calculate

**Описание** = Расчитывает параметры квартирографии для заданных условий (см. справку);

**Папка** = NVP_Common.Task.Kvartirografiya;

**Входные данные**:

* (System.Collections.IList)Свойства помещений;
* (System.Collections.IDictionary)Уровень2Помещения;
* (System.String)Свойство Идентификатор;
* (System.String)Свойство Имя;
* (System.String)Свойство Квартира;
* (System.String)Свойство Площадь;
* (System.String)Свойство Площадь с отделкой;
* (System.String)Итог.Площадь Жилая;
* (System.String)Итог.Площадь Общая;
* (System.String)Итог.Площадь Квартиры;
* (System.String)Итог.Число помещений;
* (System.Collections.IList)Жилые помещения;
* (System.Collections.IList)Нежилые помещения;
* (System.Collections.IList)Летние помещения;
* (System.Collections.IList)Помещения без отделки;
* (System.Collections.IDictionary)Коэффициенты площади;
* (System.Int32)Точность округления;
* (System.Int32)Игнорировать;

## Группа NVP_Common.List

### Нод CreateByCycleObject

**Описание** = Создает список путем копирования значения N раз;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Объект;
* (System.Int32)Количество повторений;

### Нод AddItem

**Описание** = Добавляет объект в список;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Объект;

### Нод AddItems

**Описание** = Добавляет объекты в список;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Список объектов;

### Нод FilterByCondition

**Описание** = Делает выборку из списка для сравниваемого объекта, если режим = true, то ищется прямое соответствие, если false -- то частичное (только для строк). Если Режим возврата = true, то вернутся только позиции удовлетворяющие запросы, если false -- то не удовлетворяющие;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Сравниваемый объект;
* (System.Boolean)Режим сравнения строк;
* (System.Boolean)Режим возврата;

### Нод FilterByBoolMask

**Описание** = Делает выборку из списка по заданной маске (одноразмерному списку bool);

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Collections.Generic.List`1[System.Boolean])Маска;

## Группа NVP_Common.Dictionary

### Нод Dictionary_CreateEmpty

**Описание** = Создает пустой словарь;

**Папка** = NVP_Common.Dictionary;


### Нод Dictionary_CreateFromData

**Описание** = Создает словарь по исходным данным;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Список ключей;
* (System.Object)Список значений;

### Нод Dictionary_RemoveKeys

**Описание** = Удаляет в заданном словаре значения по ключам и возвращает измененный словарь;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.Object)Список ключей;

### Нод Dictionary_SetValueAtKey

**Описание** = Задает одиночное значение по ключу и возвращает измененный словарь;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Ключ;
* (System.Object)Значение;

### Нод Dictionary_SetValuesAtKeys

**Описание** = Задает значения по ключам и возвращает измененный словарь;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Список ключей;
* (System.Object)Список значений;

### Нод Dictionary_GetValueAtKey

**Описание** = Возвращает значение по ключу;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Ключ;

### Нод Dictionary_GetValuesAtKeys

**Описание** = Возвращает значения по списку ключей;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Список ключей;

### Нод Dictionary_GetKeys

**Описание** = Возвращает все ключи словаря в виде списка строк;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

### Нод Dictionary_GetValues

**Описание** = Возвращает все значения словаря в виде списка;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

### Нод Dictionary_GetCount

**Описание** = Возвращает количество сущностей в словаре;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

## Группа NVP_Common.Common

### Нод Null

**Описание** = Возвращает значение null;

**Папка** = NVP_Common.Common;


### Нод IsNull

**Описание** = Проверяет объект на null (true if null);

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)Object;

### Нод StringToNumber_Double

**Описание** = Преобразует строку в число с плавающей точкой;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)String;

### Нод StringToNumber_Int64

**Описание** = Преобразует строку в целое число;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)String;

### Нод ToString

**Описание** = Преобразует объект в строку;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)Object;

