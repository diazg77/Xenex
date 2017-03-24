@echo off
cls
msbuild.exe "xenexdemobuild.proj" /p:configuration=release

xcopy "c:\xenexbuild\source" "C:\xenexbuild\destination"
pause