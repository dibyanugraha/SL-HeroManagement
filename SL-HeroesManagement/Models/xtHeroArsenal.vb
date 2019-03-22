
'------------------------------------------------------------------------------
' <copyright file="xtHeroArsenal.sdo.vb" company="Microsoft">
'     Copyright (c) Microsoft Corporation.  All rights reserved.
' </copyright>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxtHeroArsenal

    Public Class xtHeroArsenal
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
        DataBinding(PropertyIndex:=1, StringSize:=30)
        >
        Public Property ArsenalID() As String

            Get
                Return Me.GetPropertyValue("ArsenalID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ArsenalID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=2, StringSize:=60)
        >
        Public Property Description() As String

            Get
                Return Me.GetPropertyValue("Description")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Description", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=3, StringSize:=6)
        >
        Public Property ProdClassID() As String

            Get
                Return Me.GetPropertyValue("ProdClassID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("ProdClassID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=4, StringSize:=6)
        >
        Public Property UOM() As String

            Get
                Return Me.GetPropertyValue("UOM")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("UOM", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=5, StringSize:=10)
        >
        Public Property CpnyID() As String

            Get
                Return Me.GetPropertyValue("CpnyID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("CpnyID", setval)
            End Set

        End Property
    End Class
    Public bxtHeroArsenal As xtHeroArsenal = New xtHeroArsenal, nxtHeroArsenal As xtHeroArsenal = New xtHeroArsenal
    Public Csr_xtHeroArsenal As Integer, Mem_xtHeroArsenal As Integer
End Module
