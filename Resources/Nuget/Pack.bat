@ECHO OFF
set projectPath="../../src/Estate.Umbraco.Core/Estate.Umbraco.Core.csproj"

ECHO ---- MSBuild ---------
ECHO ----------------------
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe "%projectPath%" /p:Configuration="Release" /verbosity:quiet
ECHO ----------------------
ECHO ---- MSBuild DONE ----
ECHO ----------------------
ECHO ---- Nuget PACK ------
ECHO ----------------------
ECHO Nuget Pack
nuget.exe pack "%projectPath%" -OutputDirectory "Release" -Prop Configuration="Release"
ECHO ----------------------
ECHO ---- DONE ------------
ECHO ----------------------