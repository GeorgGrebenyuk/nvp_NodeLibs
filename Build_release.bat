REM Step 1: Autobuild solution in Release-mode
set VSVER=[17.0^,18.0^)

::Edit path if VS 2022 is installed on other path
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvarsall.bat" x64

devenv NVP_Node_Libs.sln /Build "Release|Any CPU"

REM Step 2: Autobuild *.nodeitem-files with project 
call "bin\Release\net6.0\NVP_Manifest_CreatorExe.exe"
call "bin\Release\net48\NVP_Manifest_CreatorExe.exe"

REM Step 3: Copy all useful dlls (node-libraries) and *.nodeitem to catalog with NVP nodes
::Create temp catalogs for store all compilled and created resources (dll, nodeitem, pdb ...). Clean before
IF NOT EXIST "bin\Release\net6.0\NPV_Data" mkdir "bin\Release\net6.0\NPV_Data"
del "bin\Release\net6.0\NPV_Data" /S /Q
IF NOT EXIST "bin\Release\net48\NPV_Data" mkdir "bin\Release\net48\NPV_Data\"
del "bin\Release\net48\NPV_Data" /S /Q

REM Step 3.1 For net6.0
::Copy the dll with our custom manifest
xcopy "bin\Release\net6.0\NVP_Manifest_Creator.dll" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Release\net6.0\NVP_nanoCAD_COM.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_ModelStudio_COM
xcopy "bin\Release\net6.0\NVP_ModelStudio_COM.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Release\net6.0\NVP_COM_Common.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Release\net6.0\NVP_Renga_COM.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy all *.nodeitem
xcopy "bin\Release\net6.0\*.nodeitem" "bin\Release\net6.0\NPV_Data\" /Y /I
::Move all data to ZIP in root of repository
IF EXIST "NPV_NodeLibs_net6.0" del "NPV_NodeLibs_net6.0" /S /Q
xcopy "bin\Release\net6.0\NPV_Data\*.*" "NPV_NodeLibs_net6.0\"  /Y /I
"C:\Program Files\7-Zip\7z" a -tzip "NPV_NodeLibs_net6.0.zip" "NPV_NodeLibs_net6.0"
rmdir "NPV_NodeLibs_net6.0" /S /Q
REM Step 3.2 For net48

::Copy the dll with our custom manifest
xcopy "bin\Release\net48\NVP_Manifest_Creator.dll" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Release\net48\NVP_nanoCAD_COM.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_ModelStudio_COM
xcopy "bin\Release\net48\NVP_ModelStudio_COM.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Release\net48\NVP_COM_Common.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Release\net48\NVP_Renga_COM.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy all *.nodeitem
xcopy "bin\Release\net48\*.nodeitem" "bin\Release\net48\NPV_Data\" /Y /I
::Move all data to ZIP in root of repository
IF EXIST "NPV_NodeLibs_net48" del "NPV_NodeLibs_net48" /S /Q
xcopy "bin\Release\net48\NPV_Data\*.*" "NPV_NodeLibs_net48\" /Y /I
"C:\Program Files\7-Zip\7z" a -tzip "NPV_NodeLibs_net48.zip" "NPV_NodeLibs_net48"
rmdir "NPV_NodeLibs_net48" /S /Q
::pause >nul
