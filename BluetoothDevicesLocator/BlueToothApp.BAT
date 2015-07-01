@echo off
rem Create Test
@echo Listing all the bluetooth enabled devices
btdiscovery -s
set _btlist= btdiscovery -s
FOR /F  %%G IN ('%_btlist%^|find "("') DO btobex -b(%%G) ..\..\testdata.txt 
@echo Success
pause
exit