using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            ceNoLimit.Tag = 0;

            testItemTypeControls.Add(ceChoose, seChoose);
            ceChoose.Tag = (int)Core.TestItemType.Choose;

            testItemTypeControls.Add(ceTrueFalse, seTrueFalse);
            ceTrueFalse.Tag = (int)Core.TestItemType.TrueFalse;

            testItemTypeControls.Add(ceQAndA, seQAndA);
            ceQAndA.Tag = (int)Core.TestItemType.QAndA;

            testItemTypeControls.Add(ceFill, seFill);
            ceFill.Tag = (int)Core.TestItemType.Fill;
        }

        public DialogResult ShowDialog(IEnumerable<string> tags)
        {
            cbGrade.EditValue = Main.conditions.Grade;
            cbSemester.EditValue = Main.conditions.Semester;

            var checkedTags = Main.conditions.Tags;
            tagsList.Clear();
            layoutControlGroup2.Clear();
            foreach (var tag in tags)
            {
                var isChecked = checkedTags?.Exists(t => t == tag);
                var checkEdit = new CheckEdit() { Text = tag, AutoSizeInLayoutControl = true, Checked = isChecked ?? false };
                tagsList.Add(checkEdit);
                layoutControlGroup2.AddItem("", checkEdit);
            }

            if (Main.conditions.ItemTypes != null)
            {
                foreach (var item in testItemTypeControls)
                {
                    if (Main.conditions.ItemTypes.ContainsKey((int)item.Key.Tag))
                    {
                        item.Key.Checked = true;
                        item.Value.Value = Main.conditions.ItemTypes[(int)item.Key.Tag];
                    }
                }
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
            //List<string> filters = new List<string>();
            //if (cbGrade.EditValue != null)
            //{
            //    filters.Add($"[Grade] = {(int)cbGrade.EditValue}");
            //}
            //if (cbSemester.EditValue != null)
            //{
            //    filters.Add($"[Semester] = {(int)cbSemester.EditValue}");
            //}
            //FilterString = string.Join(" AND ", filters);

            Main.conditions.Grade = cbGrade.EditValue as Core.GradeEnum?;
            Main.conditions.Semester = cbSemester.EditValue as Core.SemesterEnum?;

            List<string> tags = new List<string>();
            foreach (var tag in tagsList)
            {
                if (tag.Checked)
                {
                    tags.Add(tag.Text);
                }
            }
            Main.conditions.Tags = tags;

            Main.conditions.Score = Convert.ToInt32(rcScore.EditValue);

            Dictionary<int, int> itemTypes = new Dictionary<int, int>();
            foreach (var item in testItemTypeControls)
            {
                if (item.Key.Checked)
                {
                    itemTypes.Add((int)item.Key.Tag, (int)item.Value.Value);
                }
            }
            Main.conditions.ItemTypes = itemTypes;
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cbGrade.EditValue = null;
            cbSemester.EditValue = null;
            foreach (var tag in tagsList)
            {
                tag.Checked = false;
            }
            foreach (var item in testItemTypeControls)
            {
                item.Key.Checked = false;
            }
        }
    }


    public class Conditions
    {
        public string Course { get; set; }
        public Core.GradeEnum? Grade { get; set; }
        public Core.SemesterEnum? Semester { get; set; }
        public List<string> Tags { get; set; }
        /// <summary>
        /// 题型 0全部
        /// </summary>
        public Dictionary<int, int> ItemTypes { get; set; }
        public int? Score { get; set; }
    }
}