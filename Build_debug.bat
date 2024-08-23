REM Step 1: Autobuild solution in Debug-mode
set VSVER=[17.0^,18.0^)

::Edit path if VS 2022 is installed on other path
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvarsall.bat" x64

devenv NVP_Node_Libs.sln /Build "Debug|Any CPU"

REM Step 2: Autobuild *.nodeitem-files with project 
call "bin\Debug\net6.0\NVP_Manifest_CreatorExe.exe"
call "bin\Debug\net48\NVP_Manifest_CreatorExe.exe"

REM Step 3: Copy all useful dlls (node-libraries) and *.nodeitem to catalog with NVP nodes
::Create temp catalogs for store all compilled and created resources (dll, nodeitem, pdb ...). Clean before
IF NOT EXIST "bin\Debug\net6.0\NVP_Data" mkdir "bin\Debug\net6.0\NVP_Data"
del "bin\Debug\net6.0\NVP_Data" /S /Q
IF NOT EXIST "bin\Debug\net48\NVP_Data" mkdir "bin\Debug\net48\NVP_Data\"
del "bin\Debug\net48\NVP_Data" /S /Q

REM Step 3.1 For net6.0
::Copy the dll with our custom manifest
xcopy "bin\Debug\net6.0\NVP_Manifest_Creator.dll" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Debug\net6.0\NVP_nanoCAD_COM.*" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy NVP_ModelStudio_COM
xcopy "bin\Debug\net6.0\NVP_ModelStudio_COM.*" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Debug\net6.0\NVP_COM_Common.*" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy NVP_Common
xcopy "bin\Debug\net6.0\NVP_Common.*" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Debug\net6.0\NVP_Renga_COM.*" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy all *.nodeitem
xcopy "bin\Debug\net6.0\*.nodeitem" "bin\Debug\net6.0\NVP_Data\" /Y /I
::Copy all data to NVP dir
xcopy "bin\Debug\net6.0\NVP_Data\*.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\"  /Y /I

REM Step 3.2 For net48

::Copy the dll with our custom manifest
xcopy "bin\Debug\net48\NVP_Manifest_Creator.dll" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Debug\net48\NVP_nanoCAD_COM.*" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy NVP_ModelStudio_COM
xcopy "bin\Debug\net48\NVP_ModelStudio_COM.*" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Debug\net48\NVP_COM_Common.*" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy NVP_Common
xcopy "bin\Debug\net48\NVP_Common.*" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Debug\net48\NVP_Renga_COM.*" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy all *.nodeitem
xcopy "bin\Debug\net48\*.nodeitem" "bin\Debug\net48\NVP_Data\" /Y /I
::Copy all data to NVP dir
xcopy "bin\Debug\net48\NVP_Data\*.*" "D:\PROCESSING\other\nvp\framework4.8\NodePacks\" /Y /I
::pause >nul
