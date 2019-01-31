using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using TestCollection.UI;

namespace TestCollection
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TestItemEdit editForm = new TestItemEdit();
        
        private DevExpress.XtraRichEdit.RichEditControl richEditControl;

        private string courseFilter = string.Empty;
        private string otherFilter = string.Empty;
        public Main()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            InitializeComponent();
            gridControl.SetDefaultOptions();
            gridView.OptionsView.RowAutoHeight = true;
            gridView.AddColumn("Course", "科目");
            gridView.AddColumn("Grade", "年级");
            gridView.AddColumn("ItemType", "题目类型");
            gridView.AddColumn("ItemContent", "题目", 300, c =>
             {
                 var re = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
                 re.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
                 re.Encoding = Encoding.UTF8;
                 re.ShowCaretInReadOnly = false;
                 c.View.GridControl.RepositoryItems.Add(re);
                 c.ColumnEdit = re;
             }, false);

            LoadData();

            //编辑保存
            editForm.TestItemSaved += (o, args) =>
            {
                if (args.IsNew)
                {
                    var dataSource = gridControl.DataSource as List<Core.TestItem>;
                    dataSource.Add(args.Item);
                }
                gridView.RefreshData();
            };
            //选题
            foreach (var item in ribbonPageGroup3.ItemLinks.AsEnumerable())
            {
                item.Item.ItemClick += (s, e) => 
                {
                    StringBuilder filterString = new StringBuilder();
                    if (e.Item.Caption == "其他")
                    {
                        //其他
                        var dr = ChooseTestItem.Instance.Value.ShowDialog(editForm.Tags);
                        if (dr == DialogResult.OK)
                        {
                            otherFilter = ChooseTestItem.Instance.Value.FilterString;
                        }
                    }
                    else
                    {
                        var checkedItem = ribbonPageGroup3.ItemLinks.AsEnumerable().FirstOrDefault(b => b.Item != e.Item && (b.Item as BarButtonItem)?.Down == true);
                        if (checkedItem != null)
                        {
                            ((BarButtonItem)checkedItem.Item).Down = false;
                        }

                        if (e.Item.Caption == "全部")
                        {
                            courseFilter = string.Empty;
                        }
                        else
                        {
                            courseFilter = $"[Course] = '{e.Item.Caption}'";
                        }
                    }

                    filterString.Append(courseFilter);
                    if (!string.IsNullOrEmpty(courseFilter) && !string.IsNullOrEmpty(otherFilter))
                    {
                        filterString.Append(" AND ");
                    }
                    filterString.Append(otherFilter);
                    
                    gridView.ActiveFilterString = filterString.ToString();
                };
            }
            
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            //gridControl.ShowRibbonPrintPreview();
            if (richEditControl == null)
            {
                richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            }
            richEditControl.Views.SimpleView.WordWrap = false;
            //richEditControl.Document.
            richEditControl.Text = ""; //清空

            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                if (i > 0)
                {
                    richEditControl.Document.AppendText("\r\n\r\n");
                }
                var item = gridView.GetRow(i) as Core.TestItem;
                richEditControl.Document.AppendText($"{i + 1}.");
                richEditControl.Document.AppendHtmlText(item.ItemContent);
            }
            
            richEditControl.ShowPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            editForm.Item = null;
            editForm.ShowDialog();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var testItems = Service.TestItemService.GetTestItems().ToList();
            gridControl.DataSource = testItems;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var rows = gridView.GetSelectedRows();
            if (rows.Length > 0)
            {
                var item = gridView.GetRow(rows[0]) as Core.TestItem;
                EditItem(item);
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                //获取双击行数据对象
                var item = gridView.GetRow(e.RowHandle) as Core.TestItem;
                EditItem(item);
            }
        }

        private void EditItem(Core.TestItem item)
        {
            editForm.Item = item;
            editForm.ShowDialog();
        }
        
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var rows = gridView.GetSelectedRows();
            if (rows.Length > 0)
            {
                if (XtraMessageBox.Show("确定要删除选中题吗？", "确认提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                var item = gridView.GetRow(rows[0]) as Core.TestItem;
                Service.TestItemService.Delete(item.ItemId.Value);
                var dataSource = gridControl.DataSource as List<Core.TestItem>;
                dataSource.Remove(item);
                gridView.RefreshData();
            }
        }

        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            bsiRecordsCount.Caption = "题目数 : " + gridView.DataRowCount;
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void gridView_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            var dataSource = gridView.DataSource as List<Core.TestItem>;
            if (!dataSource[e.ListSourceRow].Tags.Split(',').Contains("其他"))
            {
                e.Visible = false;
                e.Handled = true;
            }
            //todo
            //gridView
        }
    }
}