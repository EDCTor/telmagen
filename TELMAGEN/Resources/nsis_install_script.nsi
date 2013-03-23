########################################################################################
##
## Install Script
## 
## This script will build an installer
## 
## Built-time define's supported:
##      SOURCE    		Required    Value: Path to the source i.e. "c:\Source\TELMAGEN"
##      FILENAME        Required    Value: Name of the Setup program i.e. "Setup.exe"
##										   be sure this directory actually exists before NSIS runs
##      VERSION         Required    Value: TELMAGEN Build Version i.e. "1.0.0.0"
##      BUILD_FOLDER    Required    Value: Subdir within SOURCE for resulting setup.exe i.e. "Builds"
##
########################################################################################

#########################################################################################
## 
## How to do a build
##
## Within VS > Project > Application - Set the version number 
## Compile Telmagen.exe
## Modify the NSI script to set the version number and installer exe name
## Launch NSIS, load the NSI script and generate the installer
##
#########################################################################################

#########################################################################################
## 
## TESTING
##
## To test NSIS installer, you can manually set some of the values that the build script 
## bat does for you. Just uncomment the lines below and set as needed.
##
#########################################################################################
!define SOURCE "C:\gigator\TELMAGEN\TELMAGEN"
!define FILENAME "TELMAGEN.1.0.0.5.Setup.exe"
!define VERSION "1.0.0.5"
!define BUILD_FOLDER "Builds"
#########################################################################################	

#########################################################################################
## Global Installer Settings
#########################################################################################
!define NAME "TELMAGEN"
!define COMPANY "Torrance Jones"
!define URL "http://www.itsmetor.com/wp/"
!define COPYRIGHT "(c)2013 Torrance Jones"

Name ${NAME}
InstallDir $PROGRAMFILES\${NAME}
OutFile "${BUILD_FOLDER}\${FILENAME}"

CRCCheck on
XPStyle on

ShowInstDetails show
ShowUninstDetails show

VIProductVersion "${VERSION}"
VIAddVersionKey ProductName "${NAME}"
VIAddVersionKey ProductVersion "${VERSION}"
VIAddVersionKey CompanyName "${COMPANY}"
VIAddVersionKey CompanyWebsite "${URL}"
VIAddVersionKey FileVersion ""
VIAddVersionKey FileDescription ""
VIAddVersionKey LegalCopyright "${COPYRIGHT}"
!define REGKEY "SOFTWARE\${NAME}"
InstallDirRegKey HKLM "${REGKEY}" Path

#########################################################################################
## Helper Macros
#########################################################################################

!macro UNDEFINE_VARS
    # this is to fix an error in some included libraries
    !undef VAR_0
    !undef VAR_1
    !undef VAR_2
    !undef VAR_3
    !undef VAR_4
    !undef VAR_5
    !undef VAR_6
    !undef VAR_7
    !undef VAR_8
    !undef VAR_9
!macroend

!macro IsUserAdmin RESULT
	; Macro is from http://nsis.sourceforge.net/Check_if_the_current_user_is_an_Administrator
	; Example Use:
	; !insertmacro IsUserAdmin $0
	; $0 = 1 if the user belongs to the administrator's group
	; $0 = 0 if not
	; $0 = -1 if there was an error (only for the 1st Macro)

	!define Index "Line${__LINE__}"
		StrCpy ${RESULT} 0
		System::Call '*(&i1 0,&i4 0,&i1 5)i.r0'
		System::Call 'advapi32::AllocateAndInitializeSid(i r0,i 2,i 32,i 544,i 0,i 0,i 0,i 0,i 0, \
		i 0,*i .R0)i.r5'
		System::Free $0
		System::Call 'advapi32::CheckTokenMembership(i n,i R0,*i .R1)i.r5'
		StrCmp $5 0 ${Index}_Error
		StrCpy ${RESULT} $R1
		Goto ${Index}_End
	${Index}_Error:
		StrCpy ${RESULT} -1
	${Index}_End:
		System::Call 'advapi32::FreeSid(i R0)i.r5'
	!undef Index
!macroend

;;=======================================================================================
;; Get a command line parameter
;; Usage: 
;;	!insertmacro GetParameterValue "/LANG=" "English"
;;	pop $R0
;;	MessageBox MB_OK "Value of /LANG parameter is '$R0'"
;;
;; command line calls should look like this:
;; C:\> Setup.exe "/LANG=English" /DD="C:\Program Files\Fooey"
;;
;; Note: originally taken from here: http://nsis.sourceforge.net/Get_Parameter_Value
;; I modified their version to fix an issue where by you couldnt call the macro twice in the same section
;;
!macro GETPARAMETERVALUE SWITCH DEFAULT
	!define UniqueID "Line${__LINE__}"
	Push $0
	Push $1
	Push $2
	Push $3
	Push $4
 
	;$CMDLINE='"My Setup\Setup.exe" /L=1033 /S'
	Push "$CMDLINE"
	Push '${SWITCH}"'
	!insertmacro StrStr
	Pop $0
	StrCmp "$0" "" gpv_notquoted_${UniqueID}
	;$0='/L="1033" /S'
	StrLen $2 "$0"
	Strlen $1 "${SWITCH}"
	IntOp $1 $1 + 1
	StrCpy $0 "$0" $2 $1
	;$0='1033" /S'
	Push "$0"
	Push '"'
	!insertmacro StrStr
	Pop $1
	StrLen $2 "$0"
	StrLen $3 "$1"
	IntOp $4 $2 - $3
	StrCpy $0 $0 $4 0
	Goto gpv_done_${UniqueID}
 
	gpv_notquoted_${UniqueID}:
		Push "$CMDLINE"
		Push "${SWITCH}"
		!insertmacro StrStr
		Pop $0
		StrCmp "$0" "" gpv_done_${UniqueID}
		;$0='/L="1033" /S'
		StrLen $2 "$0"
		Strlen $1 "${SWITCH}"
		StrCpy $0 "$0" $2 $1
		;$0=1033 /S'
		Push "$0"
		Push ' '
		!insertmacro StrStr
		Pop $1
		StrLen $2 "$0"
		StrLen $3 "$1"
		IntOp $4 $2 - $3
		StrCpy $0 $0 $4 0
		Goto gpv_done_${UniqueID}
 
    gpv_done_${UniqueID}:
		StrCmp "$0" "" 0 +2
		StrCpy $0 "${DEFAULT}"
 
		Pop $4
		Pop $3
		Pop $2
		Pop $1
		Exch $0

		!undef UniqueID
!macroend
 
; And I had to modify StrStr a tiny bit.
; Possible upgrade switch the goto's to use ${__LINE__}
!macro STRSTR
  Exch $R1 ; st=haystack,old$R1, $R1=needle
  Exch    ; st=old$R1,haystack
  Exch $R2 ; st=old$R1,old$R2, $R2=haystack
  Push $R3
  Push $R4
  Push $R5
  StrLen $R3 $R1
  StrCpy $R4 0
  ; $R1=needle
  ; $R2=haystack
  ; $R3=len(needle)
  ; $R4=cnt
  ; $R5=tmp
  ;  loop;
    StrCpy $R5 $R2 $R3 $R4
    StrCmp $R5 $R1 +4
    StrCmp $R5 "" +3
    IntOp $R4 $R4 + 1
    Goto -4
  ;  done;
  StrCpy $R1 $R2 "" $R4
  Pop $R5
  Pop $R4
  Pop $R3
  Pop $R2
  Exch $R1
!macroend
;;=======================================================================================

#########################################################################################
## GUI Setup
#########################################################################################
!define MUI_ICON "${SOURCE}\Resources\T.ico"

!define MUI_FINISHPAGE_NOAUTOCLOSE
!define MUI_STARTMENUPAGE_REGISTRY_ROOT HKLM
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_REGISTRY_KEY "Software\${NAME}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME StartMenuGroup
!define MUI_STARTMENUPAGE_DEFAULT_FOLDER $NAME

!define MUI_UNICON "${MUI_ICON}"
!define MUI_UNPAGE_CONFIRM
!define MUI_UNCONFIRMPAGE_TEXT_TOP "!!! NOTE: The uninstaller will delete all TELMAGEN related files on this computer!!!!"
!define MUI_UNFINISHPAGE_NOAUTOCLOSE

#########################################################################################
## Include 3rd Party Plugins
##
## Also install the DialogsEx, FontReg, AccessControl and nsisXML plugins.
## 
## Manually copy these files into the NSIS installdir
##	plugins/AccessControl.dll
##
#########################################################################################

!include Sections.nsh
!include MUI.nsh
!include LogicLib.nsh
!include WinVer.nsh

#########################################################################################
## The "Main" code to the installer
#########################################################################################

Var StartMenuGroup

InstType "Full Installation"

!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS		

# installer
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_COMPONENTS
Page custom DotNetCheckPage
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_STARTMENU Application $StartMenuGroup
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

# uninstaller
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_LANGUAGE English

#########################################################################################
## Installer Sections
#########################################################################################

Section -pre
    SectionIn 1 2    
SectionEnd

Section "-Common Components" SEC_COMMON
    SectionIn 1 2  
	
	#
	#no common files at this time
	#
	SetOutPath $INSTDIR
    SetOverwrite on
    DetailPrint "Creating Folder Structure"
    CreateDirectory "$INSTDIR\Projects"

	# Set file permissions to give everyone full access to the INSTALLDIR (to ensure future updates are 100% successful)
    DetailPrint "Setting File Permissions..."
    AccessControl::GrantOnFile $INSTDIR "Everyone" "FullAccess"
SectionEnd

SectionGroup /e "Telmagen"    
    Section "TELMAGEN" SEC_TELMAGEN
        SectionIn 1 2
        SetOutPath $INSTDIR
        SetOverwrite on
        DetailPrint "Installing TELMAGEN"
        File "${SOURCE}\bin\Release\TELMAGEN.exe"
		SetOutPath $DESKTOP
        CreateShortcut $DESKTOP\TELMAGEN.lnk $INSTDIR\TELMAGEN.exe    
        SetOutPath $SMPROGRAMS\$StartMenuGroup
        CreateShortcut "$SMPROGRAMS\$StartMenuGroup\TELMAGEN.lnk" "$INSTDIR\TELMAGEN.exe"
    SectionEnd
SectionGroupEnd

Section -post  
    SectionIn 1 2
	
	DetailPrint "Creating Uninstaller"
	WriteUninstaller $INSTDIR\uninstall.exe	
	
    DetailPrint "Writing Registry Keys"
    WriteRegStr HKLM "${REGKEY}" Path $INSTDIR       
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayName "$(^Name)"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayVersion "${VERSION}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" Publisher "${COMPANY}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" URLInfoAbout "${URL}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayIcon $INSTDIR\uninstall.exe
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" UninstallString $INSTDIR\uninstall.exe
    WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" NoModify 1
    WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" NoRepair 1    
    	
SectionEnd

#########################################################################################
## Uninstaller Sections
#########################################################################################

Function un.onInit
    ReadRegStr $INSTDIR HKLM "${REGKEY}" Path
    ReadRegStr $StartMenuGroup HKLM "${REGKEY}" StartMenuGroup
FunctionEnd

Section Uninstall    
    
	DetailPrint "Removing Program Files"	
    RmDir /r /REBOOTOK "$INSTDIR"     	
    
    DetailPrint "Removing Shortcuts"
	Delete /REBOOTOK "$DESKTOP\TELMAGEN.lnk"		
	RmDir /r /REBOOTOK "$SMPROGRAMS\$StartMenuGroup"
	SetShellVarContext current
	Delete /REBOOTOK "$DESKTOP\TELMAGEN.lnk"	
	RmDir /r /REBOOTOK "$SMPROGRAMS\$StartMenuGroup"		
	
	DetailPrint "Removing Registry Entries"
    DeleteRegValue HKLM "${REGKEY}" StartMenuGroup
    DeleteRegValue HKLM "${REGKEY}" Path
    DeleteRegKey /IfEmpty HKLM "${REGKEY}\Components"
    DeleteRegKey /IfEmpty HKLM "${REGKEY}"
	
	DetailPrint "Removing Uninstaller"
    DeleteRegKey HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)"          
	
SectionEnd

#########################################################################################
## Helper Functions
#########################################################################################

;;=======================================================================================
Function .onInit
    
	InitPluginsDir   
    SetShellVarContext all
    
    # Check for if the user has Admin rights, we require this
    !insertmacro IsUserAdmin $0
    ${If} $0 != 1
		MessageBox MB_OK|MB_ICONEXCLAMATION "You must have admin rights to install this application"
		Quit
    ${EndIf}

	# if the computer is XP, requires SP3
	${If} ${IsWinXP}
	${AndIfNot} ${AtLeastServicePack} 3
	MessageBox MB_OK "Windows XP Service Pack 3 is required to run this program.  Please install SP3 or upgrade your OS to a compatible version."
	Quit
	${EndIf}

	# if the computer is Server 2003, requires SP2
	${If} ${IsWin2003}
	${AndIfNot} ${AtLeastServicePack} 2
	MessageBox MB_OK "Windows Server 2003 Service Pack 2 is required to run this program.  Please install SP2 or upgrade your OS to a compatible version."
	Quit
	${EndIf}

	# Load the previous install path (if any)
	ReadRegStr $INSTDIR HKLM "${REGKEY}" Path
    ReadRegStr $StartMenuGroup HKLM "${REGKEY}" StartMenuGroup		
	${If} $INSTDIR == ""
		# no previous install path found (new install)
		
		# check to see if we are passing an installdir into the setup.exe
		# if we are not then use the standard location 
		# else use the value passed into the installer
		!insertmacro GetParameterValue "/INSTALLPATH=" ""
		pop $R0
		${If} $R0 == ""
			# default to standard place
			StrCpy $INSTDIR "$PROGRAMFILES\${NAME}"
		${Else}
			# default to our override
			StrCpy $INSTDIR "$R0"
		${EndIf}
	${EndIf}
	
	#override the components selected based on any command line options
	!insertmacro GetParameterValue "/INSTALLTYPE=" ""
	pop $R0
	${If} $R0 == "FULL"
		SectionSetFlags ${SEC_TELMAGEN} ${SF_SELECTED}
	${EndIf}
FunctionEnd
;;=======================================================================================

;;=======================================================================================
;; Usage: Page custom DotNetCheckPage
;;
;; Insert this page in the main section and a check for the proper version of dot net
;; will be done depending on what components the customer installed.  Client installs
;; only need the v4 client profiler intall of dotnet 4.  Server installs need the full
;; version of dotnet 4 in order to host the web services.
;;
Function DotNetCheckPage	
	; Check for the proper version of dot net
	Call HasDotNet4Client
FunctionEnd
;;=======================================================================================

;;=======================================================================================
;; Function to determine if the PC has dotnet 4 client edition.  Exits if not found.
;;
;; USAGE: Call HasDotNet4Client
;;
;; Use the registry to detect the specific version of dotnet 4 (client or full)
;; http://support.microsoft.com/kb/318785
;;
Function HasDotNet4Client
	Push $0			;save the variable in-case its used else where
	ReadRegStr $0 HKLM "Software\Microsoft\NET Framework Setup\NDP\v4\Client" 'Install'
	;
	; variable will be empty if reg key is not found
	; variable will have the value of the reg key if found (should be either 0 or 1)
	;
	;MessageBox MB_OK "The value found is: $0"

	;Have we got the framework we need?  Compare the registry value to "1" to check.
	IntCmp $0 1 done
	
	IfSilent +1 0
	MessageBox MB_OK|MB_ICONEXCLAMATION "The Microsoft .NET Framework 4.0 (Client Edition) must be installed to use this application.$\n$\n\
		After installing the .NET Framework run the installer again. $\n$\n\
		Click 'OK' to proceed to the Microsoft .NET 4 Framework Installer website..."

    ExecShell Open "http://www.microsoft.com/en-us/download/details.aspx?id=24872"
	Quit

	done:
	Pop $0			;release the variable in-case its used else where
FunctionEnd
;;=======================================================================================

#########################################################################################
## Section Descriptions
#########################################################################################

!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN    
    !insertmacro MUI_DESCRIPTION_TEXT ${SEC_TELMAGEN} "Installs TELMAGEN"    
!insertmacro MUI_FUNCTION_DESCRIPTION_END