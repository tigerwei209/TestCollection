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
        private Dictionary<CheckEdit, SpinEdit> testItemTypeControls = new Dictionary<CheckEdit, SpinEdit>();

        public static Lazy<ChooseTestItem> _instance = new Lazy<ChooseTestItem>(() => new ChooseTestItem());
        public static ChooseTestItem Instance { get { return _instance.Value; } }

        public string FilterString { get; set; }
        
        private ChooseTestItem()
        {
            InitializeComponent();
            cbGrade.Properties.AddEnum<Core.GradeEnum>();
            cbGrade.Properties.Items.Insert(0, new ImageComboBoxItem("", null));
            cbSemester.Properties.AddEnum<Core.SemesterEnum>();
            cbSemester.Properties.Items.Insert(0, new ImageComboBoxItem("", null));

            testItemTypeControls.Add(ceNoLimit, seNoLimit);
            testItemTypeControls.Add(ceChoose, seChoose);
            testItemTypeControls.Add(ceTrueFalse, seTrueFalse);
            testItemTypeControls.Add(ceQAndA, seQAndA);
            testItemTypeControls.Add(ceFill, seFill);
        }
        
        public DialogResult ShowDialog(IEnumerable<string> tags)
        {
            var checkedTags = Main.conditions.Tags; //tagsList.Where(c => c.Checked == true).ToList();
            tagsList.Clear();
            layoutControlGroup2.Clear();
            foreach (var tag in tags)
            {
                var isChecked = checkedTags?.Exists(t => t == tag);
                var checkEdit = new CheckEdit() { Text = tag, AutoSizeInLayoutControl = true, Checked = isChecked??false };
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
            testItemTypeControls[checkEdit].Visible = checkEdit.Checked;
            if (checkEdit == ceNoLimit && checkEdit.Checked)
            {
                foreach (var item in testItemTypeControls.Keys)
                {
                    if (item != ceNoLimit)
                    {
                        item.Checked = false;
                    }
                }
            }
            if (checkEdit != ceNoLimit && checkEdit.Checked)
            {
                ceNoLimit.Checked = false;
            }
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

            List<string> tags = new List<string>();
            foreach (var tag in tagsList)
            {
                if (tag.Checked)
                {
                    tags.Add(tag.Text);
                }
            }
            Main.conditions.Tags = tags;

            Dictionary<int, int> itemTypes = new Dictionary<int, int>();
            foreach (var item in testItemTypeControls)
            {
                if (item.Key.Checked)
                {
                    //todo
                }
            }
        }
    }


    public class Conditions
    {
        public string Course { get; set; }
        public Core.GradeEnum? Grade { get; set; }
        public Core.SemesterEnum? Semester { get; set; }
        public List<string> Tags { get; set; }
        public Dictionary<int, int> ItemTypes { get; set; }
    }
}