using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<SfDataGrid>
    {
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
    }
}
