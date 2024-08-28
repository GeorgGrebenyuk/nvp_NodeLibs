# NVP_Common

## Группа NVP_Common.Wait

### Нод Wait_2

**Имя нода** = Wait_2;

**Описание** = Задержка для двух значений;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;

### Нод Wait_3

**Имя нода** = Wait_3;

**Описание** = Задержка для трех значений;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;

### Нод Wait_4

**Имя нода** = Wait_4;

**Описание** = Задержка для четырех значений;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;

### Нод Wait_5

**Имя нода** = Wait_5;

**Описание** = Задержка для пяти значений;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;
* (System.Object)Объект 5;

### Нод Wait_6

**Имя нода** = Wait_6;

**Описание** = Задержка для шести значений;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Wait;

**Входные данные**:

* (System.Object)Объект 1;
* (System.Object)Объект 2;
* (System.Object)Объект 3;
* (System.Object)Объект 4;
* (System.Object)Объект 5;
* (System.Object)Объект 6;

### Нод Wait_7

**Имя нода** = Wait_7;

**Описание** = Задержка для семи значений;

**Автор** = GeorgGrebenyuk;

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

**Имя нода** = Kvartirografiya_Rooms_Living;

**Описание** = Возвращает список ЖИЛЫХ помещений по умолчанию;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_NonLiving

**Имя нода** = Kvartirografiya_Rooms_NonLiving;

**Описание** = Возвращает список НЕЖИЛЫХ помещений по умолчанию;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_Other

**Имя нода** = Kvartirografiya_Rooms_Other;

**Описание** = Возвращает список ЛЕТНИХ (и прочих) помещений по умолчанию;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_WithoutOtd

**Имя нода** = Kvartirografiya_Rooms_WithoutOtd;

**Описание** = Возвращает список помещений без отделки;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Rooms_Coefficients2Areas

**Имя нода** = Kvartirografiya_Rooms_Coefficients2Areas;

**Описание** = Возвращает сопоставление названий помещений с коэффициентами к площадям;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Task.Kvartirografiya;


### Нод Kvartirografiya_Calculate

**Имя нода** = Kvartirografiya_Calculate;

**Описание** = Расчитывает параметры квартирографии для заданных условий (см. справку);

**Автор** = GeorgGrebenyuk;

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

**Имя нода** = CreateByCycleObject;

**Описание** = Создает список путем копирования значения N раз;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Объект;
* (System.Int32)Количество повторений;

### Нод AddItem

**Имя нода** = AddItem;

**Описание** = Добавляет объект в список;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Объект;

### Нод AddItems

**Имя нода** = AddItems;

**Описание** = Добавляет объекты в список;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Список объектов;

### Нод FilterByCondition

**Имя нода** = FilterByCondition;

**Описание** = Делает выборку из списка для сравниваемого объекта, если режим = true, то ищется прямое соответствие, если false -- то частичное (только для строк). Если Режим возврата = true, то вернутся только позиции удовлетворяющие запросы, если false -- то не удовлетворяющие;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Object)Сравниваемый объект;
* (System.Boolean)Режим сравнения строк;
* (System.Boolean)Режим возврата;

### Нод FilterByBoolMask

**Имя нода** = FilterByBoolMask;

**Описание** = Делает выборку из списка по заданной маске (одноразмерному списку bool);

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.List;

**Входные данные**:

* (System.Object)Исходный список;
* (System.Collections.Generic.List`1[System.Boolean])Маска;

## Группа NVP_Common.Dictionary

### Нод Dictionary_CreateEmpty

**Имя нода** = Dictionary_CreateEmpty;

**Описание** = Создает пустой словарь;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;


### Нод Dictionary_CreateFromData

**Имя нода** = Dictionary_CreateFromData;

**Описание** = Создает словарь по исходным данным;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Список ключей;
* (System.Object)Список значений;

### Нод Dictionary_RemoveKeys

**Имя нода** = Dictionary_RemoveKeys;

**Описание** = Удаляет в заданном словаре значения по ключам и возвращает измененный словарь;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.Object)Список ключей;

### Нод Dictionary_SetValueAtKey

**Имя нода** = Dictionary_SetValueAtKey;

**Описание** = Задает одиночное значение по ключу и возвращает измененный словарь;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Ключ;
* (System.Object)Значение;

### Нод Dictionary_SetValuesAtKeys

**Имя нода** = Dictionary_SetValuesAtKeys;

**Описание** = Задает значения по ключам и возвращает измененный словарь;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Список ключей;
* (System.Object)Список значений;

### Нод Dictionary_GetValueAtKey

**Имя нода** = Dictionary_GetValueAtKey;

**Описание** = Возвращает значение по ключу;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Ключ;

### Нод Dictionary_GetValuesAtKeys

**Имя нода** = Dictionary_GetValuesAtKeys;

**Описание** = Возвращает значения по списку ключей;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;
* (System.String)Список ключей;

### Нод Dictionary_GetKeys

**Имя нода** = Dictionary_GetKeys;

**Описание** = Возвращает все ключи словаря в виде списка строк;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

### Нод Dictionary_GetValues

**Имя нода** = Dictionary_GetValues;

**Описание** = Возвращает все значения словаря в виде списка;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

### Нод Dictionary_GetCount

**Имя нода** = Dictionary_GetCount;

**Описание** = Возвращает количество сущностей в словаре;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Dictionary;

**Входные данные**:

* (System.Object)Словарь;

## Группа NVP_Common.Common

### Нод Null

**Имя нода** = Null;

**Описание** = Возвращает значение null;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Common;


### Нод IsNull

**Имя нода** = IsNull;

**Описание** = Проверяет объект на null (true if null);

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)Object;

### Нод StringToNumber_Double

**Имя нода** = StringToNumber_Double;

**Описание** = Преобразует строку в число с плавающей точкой;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)String;

### Нод StringToNumber_Int64

**Имя нода** = StringToNumber_Int64;

**Описание** = Преобразует строку в целое число;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)String;

### Нод ToString

**Имя нода** = ToString;

**Описание** = Преобразует объект в строку;

**Автор** = GeorgGrebenyuk;

**Папка** = NVP_Common.Common;

**Входные данные**:

* (System.Object)Object;

