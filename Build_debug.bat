REM Step 1: Autobuild solution in Debug-mode
set VSVER=[17.0^,18.0^)

::Edit path if VS 2022 is installed on other path
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvarsall.bat" x64

devenv NNP.sln /Build "Debug|Any CPU"

REM Step 2: Autobuild *.nodeitem-files with project 
start /d "bin\Debug\NVP_Manifest_CreatorExe"

REM Step 3: Copy all useful dlls (node-libraries) and *.nodeitem to catalog with NVP nodes
::set NVP_Install_Catalog_net60 = "D:\PROCESSING\other\nvp\net6.0\NodePacks\"

::Copy the dll with our custom manifest
xcopy "bin\Debug\NVP_Manifest_Creator.dll" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_nanoCAD_COM
xcopy "bin\Debug\NVP_nanoCAD_COM.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_COM_Common
xcopy "bin\Debug\NVP_COM_Common.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I
::Copy NVP_Renga_COM
xcopy "bin\Debug\NVP_Renga_COM.*" "D:\PROCESSING\other\nvp\net6.0\NodePacks\" /Y /I

::pause >nul
