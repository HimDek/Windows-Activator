#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
#SingleInstance Force
#NoTrayIcon
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

versionnumber:="1.1"
version:=StrReplace("vnumber", "number", versionnumber)
versionname:=StrReplace("Version number", "number", versionnumber)

full_command_line := DllCall("GetCommandLine", "str")

if not (A_IsAdmin or RegExMatch(full_command_line, " /restart(?!\S)"))
{
    try ; leads to having the script re-launching itself as administrator
    {
        if A_IsCompiled
            Run *RunAs "%A_ScriptFullPath%" /restart
        else
            Run *RunAs "%A_AhkPath%" /restart "%A_ScriptFullPath%"
    }
    ExitApp
}

GUI:
	GUI, Main:New, -MinimizeBox +HwndMain, Activate
	GUI, Main:Margin, 10, 10
    GUI, Add, Text, xm+10 ym+15 w50 h30 vTxt, Windows
    GUI, Add, DropDownList, xp+50 yp-5 w40 vWindows gWindows, 8|8.1|10|11
    GUI, Add, DropDownList, xp+50 yp w134 vWin8Ed gActivate, Home|Home Single Language|Professional|Professional N|Professional WMC|Enterprice|Enterprice N
    GUI, Add, DropDownList, xp yp wp vWin8p1Ed gActivate, Home|Home N|Home Single Language|Professional|Professional N|Professional WMC|Enterprice|Enterprice N
    GUI, Add, DropDownList, xp yp wp vWin10Ed gActivate, Home|Home N|Home Single Language|Home Country Specific|Professional|Professional N|Education|Education N|Enterprice|Enterprice N
    GUI, Add, DropDownList, xp yp wp vWin11Ed gActivate, Home|Home N|Home Single Language|Home Country Specific|Professional|Professional N|Education|Education N|Enterprice|Enterprice N
    GUI, Add, Text, xm w254 0x1 yp+5 vActtext,
    GUIControl, Main:Hide, Win8Ed
    GUIControl, Main:Hide, Win8p1Ed
    GUIControl, Main:Hide, Win10Ed
    GUIControl, Main:Hide, Win11Ed
    GUIControl, Main:Hide, Acttext
    GUI, Main:Show, w130
Return

MainGUIClose:
	ExitApp
Return

Windows:
	If (Windows=="") {
		Resize(Main, 280, , 5)
	}
    Gui, Submit , NoHide
    GUIControl, Main:Hide, Win8Ed
    GUIControl, Main:Hide, Win8p1Ed
    GUIControl, Main:Hide, Win10Ed
    GUIControl, Main:Hide, Win11Ed
    If (Windows=="8") {
        GUIControl, Main:Show, Win8Ed
    }
    If (Windows=="8.1") {
        GUIControl, Main:Show, Win8p1Ed
    }
    If (Windows=="10") {
        GUIControl, Main:Show, Win10Ed
    }
    If (Windows=="11") {
        GUIControl, Main:Show, Win11Ed
    }
Return

Activate:
    Gui, Submit , NoHide
    GoSub, GenerateKey
    GoSub, InstallKey
    GoSub, KMS
    GoSub, FinalActivate
    ExitApp
Return

InstallKey:
    GUIControl, Main:, Acttext, Installing Product Key!
    RunWait, cmd.exe /c slmgr /ipk %key%,, Hide
Return

KMS:
    GUIControl, Main:, Acttext, Setting Key Management Service!
    RunWait, cmd.exe /c slmgr /skms kms8.msguides.com,, Hide
Return

FinalActivate:
    GUIControl, Main:, Acttext, Activating Windows %Windows% %Edition%!
    RunWait, cmd.exe /c slmgr /ato,, Hide
Return

GenerateKey:
    GUIControl, Main:Hide, Txt
    GUIControl, Main:Hide, Windows
    GUIControl, Main:Hide, Win8Ed
    GUIControl, Main:Hide, Win8p1Ed
    GUIControl, Main:Hide, Win10Ed
    GUIControl, Main:Hide, Win11Ed
    GUIControl, Main:, Acttext, Generating Product Key!
    GUIControl, Main:Show, Acttext
    If (Windows=="8") {
        Edition:=Win8Ed
        If (Win8Ed=="Home") {
            key:="BN3D2-R7TKB-3YPBD-8DRP2-27GG4"
        }
        If (Win8Ed=="Home Single Language") {
            key:="2WN2H-YGCQR-KFX6K-CD6TF-84YXQ"
        }
        If (Win8Ed=="Professional") {
            key:="NG4HW-VH26C-733KW-K6F98-J8CK4"
        }
        If (Win8Ed=="Professional N") {
            key:="XCVCF-2NXM9-723PB-MHCB7-2RYQQ"
        }
        If (Win8Ed=="Professional WMC") {
            key:="GNBB8-YVD74-QJHX6-27H4K-8QHDG"
        }
        If (Win8Ed=="Enterprice") {
            key:="32JNW-9KQ84-P47T8-D8GGY-CWCK7"
        }
        If (Win8Ed=="Enterprice N") {
            key:="JMNMF-RHW7P-DMY6X-RF3DR-X2BQT"
        }
    }
    If (Windows=="8.1") {
        Edition:=Win8p1Ed
        If (Win8p1Ed=="Home") {
            key:="M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK"
        }
        If (Win8p1Ed=="Home N") {
            key:="7B9N3-D94CG-YTVHR-QBPX3-RJP64"
        }
        If (Win8p1Ed=="Home Single Language") {
            key:="BB6NG-PQ82V-VRDPW-8XVD2-V8P66"
        }
        If (Win8p1Ed=="Professional") {
            key:="GCRJD-8NW9H-F2CDX-CCM8D-9D6T9"
        }
        If (Win8p1Ed=="Professional N") {
            key:="HMCNV-VVBFX-7HMBH-CTY9B-B4FXY"
        }
        If (Win8p1Ed=="Professional WMC") {
            key:="789NJ-TQK6T-6XTH8-J39CJ-J8D3P"
        }
        If (Win8p1Ed=="Enterprice") {
            key:="MHF9N-XY6XB-WVXMC-BTDCT-MKKG7"
        }
        If (Win8p1Ed=="Enterprice N") {
            key:="TT4HM-HN7YT-62K67-RGRQJ-JFFXW"
        }
    }
    If (Windows=="10") {
        Edition:=Win10Ed
        If (Win10Ed=="Home") {
            key:="TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"
        }
        If (Win10Ed=="Home N") {
            key:="3KHY7-WNT83-DGQKR-F7HPR-844BM"
        }
        If (Win10Ed=="Home Single Language") {
            key:="7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"
        }
        If (Win10Ed=="Home Country Specific") {
            key:="PVMJN-6DFY6-9CCP6-7BKTT-D3WVR"
        }
        If (Win10Ed=="Professional") {
            key:="W269N-WFGWX-YVC9B-4J6C9-T83GX"
        }
        If (Win10Ed=="Professional N") {
            key:="MH37W-N47XK-V7XM9-C7227-GCQG9"
        }
        If (Win10Ed=="Education") {
            key:="NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
        }
        If (Win10Ed=="Education N") {
            key:="2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
        }
        If (Win10Ed=="Enterprice") {
            key:="NPPR9-FWDCX-D2C8J-H872K-2YT43"
        }
        If (Win10Ed=="Enterprice N") {
            key:="DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
        }
    }
    If (Windows=="11") {
        Edition:=Win11Ed
        If (Win11Ed=="Home") {
            key:="TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"
        }
        If (Win11Ed=="Home N") {
            key:="3KHY7-WNT83-DGQKR-F7HPR-844BM"
        }
        If (Win11Ed=="Home Single Language") {
            key:="7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH"
        }
        If (Win11Ed=="Home Country Specific") {
            key:="PVMJN-6DFY6-9CCP6-7BKTT-D3WVR"
        }
        If (Win11Ed=="Professional") {
            key:="W269N-WFGWX-YVC9B-4J6C9-T83GX"
        }
        If (Win11Ed=="Professional N") {
            key:="MH37W-N47XK-V7XM9-C7227-GCQG9"
        }
        If (Win11Ed=="Education") {
            key:="NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
        }
        If (Win11Ed=="Education N") {
            key:="2WH4N-8QGBV-H22JP-CT43Q-MDWWJ"
        }
        If (Win11Ed=="Enterprice") {
            key:="NPPR9-FWDCX-D2C8J-H872K-2YT43"
        }
        If (Win11Ed=="Enterprice N") {
            key:="DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4"
        }
    }
Return


Resize(GUIHwnd, Width:="same", Height:="same", Frames:=1, Rate:=16) {
	WinDelay := A_WinDelay
	SetWinDelay, %Rate% 
	WinGetPos, X, Y, W, H, ahk_id %GUIHwnd%
	If (Width=="same") {
		Width:=W
	}
	If (Height=="same") {
		Height:=H
	}
	WidthpF:=(Width-W)//Frames
	HeightpF:=(Height-H)//Frames
	Loop, %Frames% {
		WinGetPos, X, Y, W, H, ahk_id %GUIHwnd%
		X -= (WidthpF // 2)
		Y -= (HeightpF // 2)
		W += WidthpF
		H += HeightpF
		WinMove, ahk_id %GUIHwnd%, , X, Y, W, H
	}
	SetWinDelay, %WinDelay%
	WinMove, ahk_id %GUIHwnd%, , , , Width, Height
	Return
}
