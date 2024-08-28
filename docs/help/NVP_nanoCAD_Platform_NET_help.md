# NVP_nanoCAD_Platform_NET

## Группа NVP_nanoCAD_Platform_NET.Teigha

### Нод _Entity_Constructor

**Имя нода** = _Entity_Constructor;
**Описание** = Возвращает Entity (режим чтения) по строковому значению Handle;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Teigha;
**Входные данные**:
* (System.String)dynamic;

## Группа NVP_nanoCAD_Platform_NET.Selection

### Нод GetEntityByHandle

**Имя нода** = GetEntityByHandle;
**Описание** = Возвращает Entity (режим чтения) по строковому значению Handle;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Selection;
**Входные данные**:
* (System.Object)Document;
* (System.String)Handle;
* (System.Boolean)For read;

### Нод GetEntityByObjectId

**Имя нода** = GetEntityByObjectId;
**Описание** = Возвращает Entity (режим чтения) по численному значению ObjectId;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Selection;
**Входные данные**:
* (System.Object)Document;
* (System.Int64)ObjectId;
* (System.Boolean)Для чтения;

### Нод GetEntitiesByClassType

**Имя нода** = GetEntitiesByClassType;
**Описание** = Возвращает список Entity для заданного типа объекта;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Selection;
**Входные данные**:
* (System.Object)Document;
* (System.String)Тип (ноды ObjectTypes);
* (System.Boolean)Для чтения;

### Нод GetEntitiesByClassTypes

**Имя нода** = GetEntitiesByClassTypes;
**Описание** = Возвращает список Entity для заданных типов объектов;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Selection;
**Входные данные**:
* (System.Object)Document;
* (System.Collections.IList)Список типов (ноды ObjectTypes);
* (System.Boolean)Для чтения;

## Группа NVP_nanoCAD_Platform_NET.Application.Document

### Нод _DocumentCurrent_Constructor

**Имя нода** = _DocumentCurrent_Constructor;
**Описание** = Возвращает текущий активный документ (модель) nanoCAD;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Document;

### Нод Get_COM_AcadDocument

**Имя нода** = Get_COM_AcadDocument;
**Описание** = Возвращает COM-оболочку документа (nanoCAD.AcadDocument) для пакета NVP_nanoCAD_COM;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Document;
**Входные данные**:
* (System.Object)Document;

### Нод Get_Name

**Имя нода** = Get_Name;
**Описание** = Возвращает наименование документа;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Document;
**Входные данные**:
* (System.Object)Document;

### Нод Get_Database

**Имя нода** = Get_Database;
**Описание** = Возвращает Базу данных модели (Database) в виде нода Database_Constructor;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Document;
**Входные данные**:
* (System.Object)Document;

## Группа NVP_nanoCAD_Platform_NET.Application.Database

### Нод _Database_Constructor

**Имя нода** = _Database_Constructor;
**Описание** = Инициализирует Базу данных модели nanoCAD;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Database;
**Входные данные**:
* (System.Object)dynamic;

### Нод Get_Filename

**Имя нода** = Get_Filename;
**Описание** = Возвращает имя документа или его полный файловый путь сохранения;
**Автор** = GeorgGrebenyuk;
**Папка** = NVP_nanoCAD_Platform_NET.Application.Database;
**Входные данные**:
* (System.Object)Database;

