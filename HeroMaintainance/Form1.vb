'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Option Explicit On
Option Strict Off
Friend Class Form1
    Inherits System.Windows.Forms.Form

    Protected m_IsInitializing As Boolean
    Protected ReadOnly Property IsInitializing() As Boolean
        Get
            Return m_IsInitializing
        End Get
    End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ApplInit()

        Call SetAddr(LEVEL0, "bxtHero", bxtHero, nxtHero)
        Call SetAddr(NOLEVEL, "bHeroBuffer", bHeroBuffer, nHeroBuffer)

        Call SqlCursorEx(Csr_xtHero, LEVEL0, "Csr_xtHero", "bxtHero", "bxtHero")
        Call SqlCursorEx(Csr_HeroBuffer, NOLEVEL, "Csr_HeroBuffer", "bHeroBuffer", "bHeroBuffer")

        Call ScreenInit()

        ' another init
        bHeroBuffer.HeroID = ApplGetParms()
        bHeroBuffer.Companyid = ApplGetParms()
        Call DispFields(Me, PNULL, PNULL)

        Mem_xtHero = DetailSetup(Csr_xtHero, DslGrid1, PNULL, bxtHero, PNULL, PNULL, PNULL)
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub Update1_NewLevelEvent(Level As Short, ByRef RetVal As Short) Handles Update1.NewLevelEvent
        If Level = LEVEL0 Then
            bxtHero.CpnyID = bpes.CpnyID
        End If
    End Sub

    Private Sub DslGrid1_LineChkEvent(ByRef Action As Short, ByRef MaintFlg As Short, ByRef RetVal As Short) Handles DslGrid1.LineChkEvent
        bxtHero.CpnyID = bpes.CpnyID
    End Sub
End Class
