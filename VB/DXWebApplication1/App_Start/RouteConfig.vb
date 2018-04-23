Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DXWebApplication1
    Public Class RouteConfig
        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")

            routes.MapRoute( _
                     name:="Default", _
                     url:="{controller}/{action}/{id}", _
                     defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
                 )
        End Sub
    End Class
End Namespace