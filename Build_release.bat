REM Step 1: Autobuild solution in Release-mode
set VSVER=[17.0^,18.0^)

::Edit path if VS 2022 is installed on other path
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvarsall.bat" x64

devenv NVP_Node_Libs.sln /Build "Release|Any CPU"

::Create temp catalogs for store all compilled and created resources (dll, nodeitem, pdb ...)
IF NOT EXIST "bin\Release\net6.0\NPV_Data" mkdir "bin\Release\net6.0\NPV_Data"
RMDIR "bin\Release\net6.0\NPV_Data" /S /Q 

IF NOT EXIST "bin\Release\net48\NPV_Data" mkdir "bin\Release\net48\NPV_Data"
RMDIR "bin\Release\net48\NPV_Data" /S /Q 

REM Step 2: Autobuild *.nodeitem-files with project 
start /d "bin\Release\net6.0" NVP_Manifest_CreatorExe.exe
start /d "bin\Release\net48" NVP_Manifest_CreatorExe.exe

REM Step 3: Copy all useful dlls (node-libraries) and *.nodeitem to catalog with NVP nodes

REM Step 3.1 For net6.0
::Copy the dll with our custom manifest
xcopy "bin\Release\net6.0\NVP_Manifest_Creator.dll" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Release\net6.0\NVP_nanoCAD_COM.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Release\net6.0\NVP_COM_Common.*" "bin\Release\net6.0\NPV_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Release\net6.0\NVP_Renga_COM.*" "bin\Release\net6.0\NPV_Data\" /Y /I

xcopy "bin\Release\net6.0\NPV_Data\*.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I

REM Step 3.2 For net48
::Copy the dll with our custom manifest
xcopy "bin\Release\net48\NVP_Manifest_Creator.dll" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Release\net48\NVP_nanoCAD_COM.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Release\net48\NVP_COM_Common.*" "bin\Release\net48\NPV_Data\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Release\net48\NVP_Renga_COM.*" "bin\Release\net48\NPV_Data\" /Y /I

xcopy "bin\Release\net48\NPV_Data\*.*" "D:\PROCESSING\other\nvp\framework48\NodePacks\" /Y /I
