REM Step 1: Autobuild solution in Debug-mode
set VSVER=[17.0^,18.0^)

::Edit path if VS 2022 is installed on other path
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvarsall.bat" x64

devenv NNP.sln /Build "Release|Any CPU"

REM Step 2: Autobuild *.nodeitem-files with project 
start /d "bin\Release\NVP_Manifest_CreatorExe"

REM Step 3: Copy all useful dlls (node-libraries) and *.nodeitem to catalog with NVP nodes

::Copy the dll with our custom manifest
xcopy "bin\Release\NVP_Manifest_Creator.dll" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Release\NVP_nanoCAD_COM.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Release\NVP_COM_Common.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Release\NVP_Renga_COM.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I

::pause >nul
