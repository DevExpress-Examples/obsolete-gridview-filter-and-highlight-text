Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Namespace DXWebApplication1
	Public NotInheritable Class WebApiConfig
		Private Sub New()
		End Sub
		Public Shared Sub Register(ByVal config As HttpConfiguration)
            config.Routes.MapHttpRoute( _
                     name:="DefaultApi", _
                     routeTemplate:="api/{controller}/{id}", _
                     defaults:=New With {.id = RouteParameter.Optional} _
                 )
		End Sub
	End Class
End Namespace