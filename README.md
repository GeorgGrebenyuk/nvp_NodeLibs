# nvp_NodeLibs_ActiveX
Исходный код библиотек нодов NVP для САПР с COM API (ActiveX) : Renga, nanoCAD, ModelStudioCS
Срздано при помощи https://github.com/GeorgGrebenyuk/idl2nvp_converter.

# Пользователю

Загрузить из Releases последнюю версию и распаковать в папку \Nodepack для используемой версии NVP в зависимости от целевого фрейморка: `net48` -- `NPV_NodeLibs_ActiveX_net48.zip` или `net6.0` -- `NPV_NodeLibs_ActiveX_net6.0.zip`. 

## Примеры

См. папку `.\samples` и [файл описания доступных примеров](./samples/SAMPLES_README.md) (скриптов `*.nvproj`).

## История обновлений

См. файл [NEWS](./NEWS.md)


# Разработчику

Сборка через сценарии `Build_debug.bat` и `Build_release.bat`. В сценарии изменить путь к папке с NVP, где будете проиводить отладку нодов, а также настроить этот путь в профиле отладки.