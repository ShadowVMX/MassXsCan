@echo off

echo Vamos a llevar a cabo el escaneo, pulsa Enter en CMD si ves que no hay output.
echo.
echo [*]Escaneando para el siguiente rango (192.168.%1.X): 
echo.

for /L %%a in (1,1,255) do (
  ping 192.168.%1.%%a -w 1 -n 1 | find /i "bytes=" > nul
  if ErrorLevel 1 (break) else (echo [-]192.168.%1.%%a is UP.)
)