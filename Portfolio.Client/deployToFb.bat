call npm run build
mkdir c:\tempDeploy\public
xcopy /s .\dist c:\tempDeploy\public\ /Y
rmdir /s /q .\dist
cd c:\tempDeploy 
call firebase login
call firebase -P portfolio-66a1b init hosting
call firebase -P portfolio-66a1b deploy
