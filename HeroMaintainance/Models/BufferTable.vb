Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module BufferTable
    Public Class HeroBuffer
        Inherits SolomonDataObject
        <
        DataBinding(PropertyIndex:=0, StringSize:=10)
        >
        Public Property HeroID() As String

            Get
                Return Me.GetPropertyValue("HeroID")
            End Get

            Set(ByVal value As String)
                Me.SetPropertyValue("HeroID", value)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=1, StringSize:=10)
        >
        Public Property CompanyID() As String
            Get
                Return Me.GetPropertyValue("CompanyID")
            End Get
            Set(ByVal value As String)
                Me.SetPropertyValue("CompanyID", value)
            End Set
        End Property
    End Class
    Public bHeroBuffer As HeroBuffer = New HeroBuffer, nHeroBuffer As HeroBuffer = New HeroBuffer
    Public Csr_HeroBuffer As Integer
End Module
