Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc

Namespace DXWebApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Return GridViewPartialCore()
		End Function
		Public Function GridViewPartialCustom(ByVal searchString As String) As ActionResult
			ViewData("SearchString") = searchString
			Return GridViewPartialCore()
		End Function
		Public Function GridViewPartialCore() As ActionResult
			Dim model = GetModel()
			Return PartialView("GridViewPartial", model)
		End Function
		Private Function GetModel() As IEnumerable(Of DataEntry)
			Return Enumerable.Range(0, 100).Select(Function(i) New DataEntry With {.ID = i, .Text = "Text " & i})
		End Function
	End Class
	Public Class DataEntry
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
	End Class
End Namespace