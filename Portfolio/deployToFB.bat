REM SendGrid key is already added to the config of firebase.
mkdir c:\tempDeployFunctions\functions
xcopy /s .\src c:\tempDeployFunctions\functions\ /Y
copy .\package.json c:\tempDeployFunctions\functions\ /Y
cd c:\tempDeployFunctions 
call firebase login
call firebase -P portfolio-66a1b init functions
call firebase -P portfolio-66a1b deploy --only functions

