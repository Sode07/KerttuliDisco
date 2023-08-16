@echo off

:: Define the path to the startup script
set "startup_script=%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup\startup_script.bat"

:: Generate the startup script and the VBScript
(
echo @echo off
echo :: Define the path to the VBScript file
echo set "vbs_script=%%temp%%\fullscreen.vbs"

echo :: Generate and execute the VBScript
echo ^(echo Set objShell = CreateObject^^^("WScript.Shell"^^^)
echo echo objShell.AppActivate "Command Prompt"
echo echo WScript.Sleep 500
echo echo objShell.SendKeys "{F11}"
echo ^) ^> "%%vbs_script%%"

echo :: Run the VBScript
echo wscript "%%vbs_script%%"

echo :: Clean up the temporary VBScript
echo del "%%vbs_script%%"

echo :A
echo color f1
echo color 12
echo color 23
echo color 34
echo color 45
echo color 56
echo color 67
echo color 78
echo color 89
echo color 9a
echo color ab
echo color bc 
echo color cd
echo color de
echo color ef
echo goto :A
) > "%startup_script%"

:: Display a message
echo Startup script has been generated in the startup folder.
pause

exit
