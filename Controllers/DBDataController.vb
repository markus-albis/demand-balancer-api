Imports System.Web.Http
Imports Breeze.ContextProvider
Imports Breeze.ContextProvider.EF6
Imports Breeze.WebApi2
Imports Newtonsoft.Json.Linq

<BreezeController>
Public Class DBDataController

    Inherits ApiController

    ReadOnly _contextProvider As New EFContextProvider(Of dbEntities)()

    ' ~/breeze/DBData/Metadata 
    <HttpGet>
    Public Function Metadata() As String
        Return _contextProvider.Metadata()
    End Function

    ' ~/breeze/DBData/Products
    <HttpGet>
    Public Function Products() As IQueryable
        Return _contextProvider.Context.Products
    End Function

    ' ~/breeze/DBData/ProductDemand
    <HttpGet>
    Public Function ProductDemands() As IQueryable
        Return _contextProvider.Context.ProductDemands
    End Function

    ' ~/breeze/DBData/RCItems
    <HttpGet>
    Public Function RCItems() As IQueryable
        Return _contextProvider.Context.RCItems
    End Function

    ' ~/breeze/DBData/RCDemand
    <HttpGet>
    Public Function RCDemands() As IQueryable
        Return _contextProvider.Context.RCDemands
    End Function

    ' ~/breeze/DBData/SummaryItems
    <HttpGet>
    Public Function SummaryItems() As IQueryable
        Return _contextProvider.Context.SummaryItems
    End Function

    ' ~/breeze/DBData/SaveChanges
    <HttpPost>
    Public Function SaveChanges(saveBundle As JObject) As SaveResult
        Return _contextProvider.SaveChanges(saveBundle)
    End Function

End Class