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
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraEditors.Controls;

namespace TestCollection
{
    public partial class ChooseTestItem : XtraForm
    {
        private List<CheckEdit> tagsList = new List<CheckEdit>();
        public static Lazy<ChooseTestItem> Instance = new Lazy<ChooseTestItem>(() => new ChooseTestItem());
        private Dictionary<CheckEdit, SpinEdit> TestItemTypeControls = new Dictionary<CheckEdit, SpinEdit>();

        public string FilterString { get; set; }
        private ChooseTestItem()
        {
            InitializeComponent();
            cbGrade.Properties.AddEnum<Core.GradeEnum>();
            cbGrade.Properties.Items.Insert(0, new ImageComboBoxItem("", null));
            cbSemester.Properties.AddEnum<Core.SemesterEnum>();
            cbSemester.Properties.Items.Insert(0, new ImageComboBoxItem("", null));

            TestItemTypeControls.Add(ceChoose, seChoose);
            TestItemTypeControls.Add(ceTrueFalse, seTrueFalse);
            TestItemTypeControls.Add(ceQAndA, seQAndA);
            TestItemTypeControls.Add(ceFill, seFill);
        }
        
        public DialogResult ShowDialog(IEnumerable<string> tags)
        {
            var checkedTags = tagsList.Where(c => c.Checked == true).ToList();
            tagsList.Clear();
            layoutControlGroup2.Clear();
            foreach (var tag in tags)
            {
                var isChecked = checkedTags.Exists(c => c.Text == tag);
                var checkEdit = new CheckEdit() { Text = tag, AutoSizeInLayoutControl = true, Checked = isChecked };
                tagsList.Add(checkEdit);
                layoutControlGroup2.AddItem("", checkEdit);
            }
            return ShowDialog();
        }
        private void ChooseTestItem_Load(object sender, EventArgs e)
        {

        }

        private void TestItemType_CheckedChanged(object sender, EventArgs e)
        {
            var checkEdit = sender as CheckEdit;
            TestItemTypeControls[checkEdit].Visible = checkEdit.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();
            if (cbGrade.EditValue != null)
            {
                filters.Add($"[Grade] = {(int)cbGrade.EditValue}");
            }
            if (cbSemester.EditValue != null)
            {
                filters.Add($"[Semester] = {(int)cbSemester.EditValue}");
            }
            FilterString = string.Join(" AND ", filters);
        }
    }
}