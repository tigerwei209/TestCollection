using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace TestCollection.UI
{
    public static class GridViewExtensions
    {
        public static void SetDefaultOptions(this GridView gridView)
        {
            gridView.SetOptions(GridControlOption.Default);
        }
        public static void SetOptions(this GridView gridView, GridControlOption option)
        {
            gridView.RowHeight = option.RowHeight;
            gridView.ColumnPanelRowHeight = option.ColumnPanelRowHeight;
            gridView.FocusRectStyle = option.FocusRectStyle;
            gridView.OptionsBehavior.Editable = option.Editable;
            gridView.OptionsCustomization.AllowFilter = option.AllowFilter;
            //gridView.OptionsCustomization.AllowGroup = option.AllowGroup;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = option.EnableAppearanceFocusedCell;
            //gridView.OptionsView.ColumnAutoWidth = option.ColumnAutoWidth;
            gridView.OptionsView.EnableAppearanceEvenRow = option.EnableAppearanceEvenRow;
            gridView.OptionsView.ShowFilterPanelMode = option.ShowFilterPanelMode;
            gridView.OptionsView.ShowGroupPanel = option.ShowGroupPanel;

            if (option.HeaderTextAlignCenter)
            {
                gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
                gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            if (option.CellTextAlignCenter)
            {
                gridView.Appearance.Row.Options.UseTextOptions = true;
                gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            if (option.ShowRowIndex)
            {
                GridColumn rowIndexColumn = new GridColumn();
                rowIndexColumn.Caption = "序号";
                rowIndexColumn.Name = "_xh";
                rowIndexColumn.OptionsColumn.AllowEdit = false;
                rowIndexColumn.OptionsColumn.AllowFocus = false;
                rowIndexColumn.OptionsColumn.AllowMove = false;
                rowIndexColumn.OptionsColumn.AllowSize = false;
                rowIndexColumn.OptionsColumn.FixedWidth = true;
                //rowIndexColumn.OptionsColumn.ShowCaption = false;
                rowIndexColumn.OptionsFilter.AllowAutoFilter = false;
                rowIndexColumn.OptionsFilter.AllowFilter = false;
                rowIndexColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                rowIndexColumn.Visible = true;
                rowIndexColumn.VisibleIndex = 0;
                rowIndexColumn.Width = option.RowIndexWidth;
                //rowIndexColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                //rowIndexColumn.AppearanceCell.BackColor = Color.Red; //DevExpress.Utils.ColorUtils
                gridView.Columns.Insert(0, rowIndexColumn);
                gridView.CustomDrawCell += V_CustomDrawCell;
            }

            //取消默认选中第一行
            //会触发多次FocusedRowChanged事件 TODO
            //第一次加载完成
            gridView.GridControl.Load += (sender, e) =>
            {
                gridView.FocusedRowChanged += V_FocusedRowChanged;
                gridView.GridControl.DataSourceChanged += (o, a) =>
                {
                    gridView.FocusInvalidRow();
                };
                gridView.FocusInvalidRow();
            };

        }

        private static void V_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "_xh")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private static void V_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == 0)
            {
                var gridView = (GridView)sender;
                gridView.FocusedRowChanged -= V_FocusedRowChanged;
                gridView.FocusInvalidRow();
            }
        }

        public static void AddColumn(this GridView gridView, string fieldName, string caption, int width = 100, Action<GridColumn> action = null, bool fixedWidth = true)
        {
            GridColumn column = new GridColumn();
            column.Caption = caption;
            column.FieldName = fieldName;
            column.OptionsColumn.FixedWidth = fixedWidth;
            column.Width = width; //宋体 10.5磅默认宽度, 字体自适应todo
            column.Visible = true;
            gridView.Columns.Add(column);

            action?.Invoke(column);
        }
    }
}
