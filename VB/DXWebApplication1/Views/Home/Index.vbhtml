<script type="text/javascript">
    function OnButtonClick(s, e) {
        gv.PerformCallback({ searchString : s.GetValue() });
    }
</script>

@Html.DevExpress().ButtonEdit( _
    Sub(settings)
            settings.Name = "beSearchString"
            settings.Properties.Buttons.Add("...")
            settings.Properties.ClientSideEvents.ButtonClick = "OnButtonClick"
    End Sub).GetHtml()

@Html.Action("GridViewPartial")