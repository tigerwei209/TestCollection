using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace TestCollection.UI
{
    public static class GridControlExtensions
    {
        public static void SetDefaultOptions(this GridControl grid)
        {
            grid.SetOptions(GridControlOption.Default);
        }
        public static void SetOptions(this GridControl grid, GridControlOption option)
        {
            foreach (var view in grid.ViewCollection)
            {
                if (view is GridView gridView)
                {
                    gridView.SetOptions(option);
                }
            }
        }
    }

    public class GridControlOption
    {
        public static readonly GridControlOption Default = new GridControlOption();
        /// <summary>
        /// 行高
        /// </summary>
        public int RowHeight { get; set; } = 28;
        /// <summary>
        /// 表头高
        /// </summary>
        public int ColumnPanelRowHeight { get; set; } = 28;
        /// <summary>
        /// 是否显示序号
        /// </summary>
        public bool ShowRowIndex { get; set; } = true;
        /// <summary>
        /// 序号列宽度
        /// </summary>
        public int RowIndexWidth { get; set; } = 38;
        public DrawFocusRectStyle FocusRectStyle { get; set; } = DrawFocusRectStyle.None;
        public bool EnableAppearanceFocusedCell { get; set; }

        public bool AllowFilter { get; set; }
        //public bool AllowGroup { get; set; }
        //public bool ColumnAutoWidth { get; set; }
        public bool EnableAppearanceEvenRow { get; set; } = true;

        public ShowFilterPanelMode ShowFilterPanelMode { get; set; } = ShowFilterPanelMode.Never;

        public bool ShowGroupPanel { get; set; }

        public bool Editable { get; set; }

        public bool HeaderTextAlignCenter { get; set; } = true;
        public bool CellTextAlignCenter { get; set; } = true;
    }
}
