'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Product
    Public Property ProductId As Integer
    Public Property ProductCode As String
    Public Property DiePerWafer As Nullable(Of Integer)
    Public Property FGS As Nullable(Of Integer)
    Public Property AverageDemand As Nullable(Of Integer)

    Public Overridable Property ProductDemands As ICollection(Of ProductDemand) = New HashSet(Of ProductDemand)

End Class
