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
        Public Property Companyid() As String
            Get
                Return Me.GetPropertyValue("Companyid")
            End Get
            Set(ByVal value As String)
                Me.SetPropertyValue("Companyid", value)
            End Set
        End Property
    End Class
    Public bHeroBuffer As HeroBuffer = New HeroBuffer, nHeroBuffer As HeroBuffer = New HeroBuffer
    Public Csr_HeroBuffer As Integer
End Module
