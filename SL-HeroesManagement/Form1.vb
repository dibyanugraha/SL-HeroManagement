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

        Call SetAddr(LEVEL0, "bxtHero", bxthero, nxthero)
        Call SetAddr(LEVEL1, "bxtHeroArsenal", bxtHeroArsenal, nxtHeroArsenal)
        Call SetAddr(NOLEVEL, "bInventory", bInventory, nInventory)

        Call SqlCursorEx(Csr_xthero, LEVEL0, "Csr_xthero", "bxthero", "bxthero")
        Call SqlCursorEx(Csr_xtHeroArsenal, LEVEL1, "Csr_xtHeroArsenal", "bxtHeroArsenal", "bxtHeroArsenal")
        Call SqlCursorEx(Csr_Inventory, NOLEVEL, "Csr_Inventory", "bxtInventory", "bxtInventory")

        Call ScreenInit()
        Mem_xtHeroArsenal = DetailSetup(Csr_xtHeroArsenal, DslGrid1, PNULL, bxtHeroArsenal, PNULL, PNULL, PNULL)
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Call ScreenExit("", "")

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Call SetProps(Me, cHeroType_0, cHeroType_0, PROP_CUSTLIST, "W;Wizard,K;Knight,B;Barbarian,T;Thief")
    End Sub
End Class
