﻿
'------------------------------------------------------------------------------
' <copyright file="xthero.sdo.vb" company="Microsoft">
'     Copyright (c) Microsoft Corporation.  All rights reserved.
' </copyright>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxthero

    Public Class xthero
        Inherits SolomonDataObject

        <
        DataBinding(PropertyIndex:=0, StringSize:=10)
        >
        Public Property HeroID() As String

            Get
                Return Me.GetPropertyValue("HeroID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("HeroID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=1, StringSize:=50)
        >
        Public Property Name() As String

            Get
                Return Me.GetPropertyValue("Name")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Name", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=2, StringSize:=1)
        >
        Public Property Type() As String

            Get
                Return Me.GetPropertyValue("Type")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Type", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=3, StringSize:=10)
        >
        Public Property CpnyID() As String

            Get
                Return Me.GetPropertyValue("CpnyID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("CpnyID", setval)
            End Set

        End Property

        Public Overrides Function ToString() As String
            Return TableName
        End Function

        Private Const DBName As String = "xtHero"
        Private Const TableName As String = "bxtHero"
    End Class
    Public bxthero As xthero = New xthero, nxthero As xthero = New xthero
    Public Csr_xthero As Integer, Mem_xthero As Integer
End Module
