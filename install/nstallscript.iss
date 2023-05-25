#define SETUPFILENAME = "ContactsApp_" + GetDateTimeString('yyyy/mm/dd','','') + "_setup"
[Setup]
AppId={{81BC2621-CE04-49FF-8802-56FC58142D37}
AppName=ContactsApp
AppVersion=1.0
WizardStyle=modern
DefaultDirName={pf}\Golubev\ContactsApp
DefaultGroupName=ContactsApp
UninstallDisplayIcon={app}\Unistal.exe
Compression=lzma2
SolidCompression=yes
OutputDir="Output"
OutputBaseFilename={#SETUPFILENAME}

[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.exe"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.Model.dll"; DestDir: "{app}"
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"

[Icons]
Name: "{group}\ContactsApp"; Filename: "{app}\ContactsApp.exe"  
Name: "{group}\ContactsApp"; Filename: "{app}\unins000.exe"  
Name: "{commondesktop}\ContactsApp"; Filename: "{app}\ContactsApp"; Tasks: desktopicon