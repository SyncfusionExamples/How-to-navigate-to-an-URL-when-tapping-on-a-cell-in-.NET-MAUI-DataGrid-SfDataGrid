# How to navigate to an URL when tapping on a cell in .NET MAUI DataGrid SfDataGrid
[SfDataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) enables you to navigate to a URL upon tapping a grid cell using the [CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped) event. The [DataGridCellTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs.html) provides the 'RowColumnIndex' of the tapped cell, allowing you to navigate to the desired URL based on the argument values.

Refer to the code example below to navigate to a URL when the first cell of the record is tapped.

##### Behavior:
 
 ```XML
 protected override void OnAttachedTo(SfDataGrid dataGrid)
{
    dataGrid.CellTapped += DataGrid_CellTapped;
    base.OnAttachedTo(dataGrid);
}

private void DataGrid_CellTapped(object? sender, DataGridCellTappedEventArgs e)
{
    if (e.RowColumnIndex.RowIndex == 1 && e.RowColumnIndex.ColumnIndex == 0)
    {
        Uri uri = new Uri("https://help.syncfusion.com/");
        Launcher.TryOpenAsync(uri);
    }
}

protected override void OnDetachingFrom(SfDataGrid dataGrid)
{
    dataGrid.CellTapped -= DataGrid_CellTapped;
    base.OnDetachingFrom(dataGrid);
} 
 ```
 

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-navigate-to-an-URL-when-tapping-on-a-cell-in-.NET-MAUI-DataGrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

##### Conclusion

I hope you enjoyed learning about how to navigate to an URL when tapping on a cell in .NET MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 

For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!