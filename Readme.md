<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* **[GridViewPartial.cshtml](./CS/DXWebApplication1/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to highlight / select rows according to search criteria
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t135656/)**
<!-- run online end -->


<strong>UPDATED:<br /></strong><br />Starting with version 14.2, GridView provides the built-in Search / Find Panel functionality with the capability to locate it outside grid boundaries. This allows accomplishing a similar task with less effort and does not require so much extra code. See the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/11/19/asp-net-data-grid-enhancements-coming-soon-in-v14-2.aspx">ASP.NET Data Grid: Enhancements</a> post to learn more about this new functionality.<br /><br />This example illustrates how to highlight/select rows according to search criteria via a custom MVC GridView callback.<br /><br />- Define an external filter editor (for example, the ButtonEdit with a single button);<br />- Handle the client-side <strong>ASPxClientButtonEdit.ButtonClick</strong> event;<br />- Perform a custom GridView callback via the client-side <strong>ASPxClientGridView.PerformCallback</strong> method;<br />- Pass the editor's value as a parameter;<br />- Handle the <strong>GridViewSettings.CustomActionRouteValues.Action</strong> method and retrieve the passed parameter. In general, it is possible to use the Action method specified for all GridView callbacks (GridViewSettings.CallbackRouteValues.Action). The illustrated technique allows handling a custom GridView's callback within a separate Action method, whose signature can be different. Usually, custom callbacks are used for changing the GridView's state programmatically in a custom manner;<br />- Pass the retrieved value to the GridView's PartialView via the ViewData key;<br />- Handle the <strong>GridViewSettings.BeforeGetCallbackResult</strong> event: if the ViewData key exists, iterate trough GridView rows and select the required one via the <strong>MVCxGridView.Selection</strong> API.

<br/>


