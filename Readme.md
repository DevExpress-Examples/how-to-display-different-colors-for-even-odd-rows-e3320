<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SLGridExample/MainPage.xaml) (VB: [MainPage.xaml](./VB/SLGridExample/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SLGridExample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/SLGridExample/MainPage.xaml.vb))
* [PersonsDataSource.cs](./CS/SLGridExample/PersonsDataSource.cs) (VB: [PersonsDataSource.vb](./VB/SLGridExample/PersonsDataSource.vb))
* [SelectionStateToVisibilityConverter.cs](./CS/SLGridExample/SelectionStateToVisibilityConverter.cs) (VB: [SelectionStateToVisibilityConverter.vb](./VB/SLGridExample/SelectionStateToVisibilityConverter.vb))
<!-- default file list end -->
# How to display different colors for even/odd rows


<p><strong>Update: </strong>In version 12.2.7, we implemented the AlternateRowBackground and AlternationCount properties. You can use them to alter row background without creating custom templates.</p><p>This sample shows how to change the background color for even and odd rows separately. It is necessary to create custom data row template and bind its background to the <strong>EvenRow</strong> property via converter.</p>

<br/>


