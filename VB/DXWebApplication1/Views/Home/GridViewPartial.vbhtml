@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gv"
    
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.CustomActionRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialCustom"}
    
            settings.KeyFieldName = "ID"
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
    
            settings.Columns.Add("ID")
            settings.Columns.Add("Text")
    
            settings.BeforeGetCallbackResult = _
                Sub(s, e)
                        If ViewData("SearchString") IsNot Nothing Then
                            Dim gridView = CType(s, MVCxGridView)
                            gridView.Selection.UnselectAll()

                            Dim columnValue As String
                            Dim searchString As String = ViewData("SearchString").ToString()

                            For index As Integer = 0 To gridView.VisibleRowCount - 1
                                columnValue = gridView.GetRowValues(index, "Text").ToString().ToLower()
                                If (columnValue.Contains(searchString)) Then gridView.Selection.SelectRow(index)
                            Next index
                        End If
                End Sub
    End Sub).Bind(Model).GetHtml()