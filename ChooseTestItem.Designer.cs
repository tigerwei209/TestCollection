﻿namespace TestCollection
{
    partial class ChooseTestItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbGrade = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbSemester = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ceChoose = new DevExpress.XtraEditors.CheckEdit();
            this.ceFill = new DevExpress.XtraEditors.CheckEdit();
            this.ceQAndA = new DevExpress.XtraEditors.CheckEdit();
            this.ceTrueFalse = new DevExpress.XtraEditors.CheckEdit();
            this.seChoose = new DevExpress.XtraEditors.SpinEdit();
            this.seTrueFalse = new DevExpress.XtraEditors.SpinEdit();
            this.seFill = new DevExpress.XtraEditors.SpinEdit();
            this.seQAndA = new DevExpress.XtraEditors.SpinEdit();
            this.ceNoLimit = new DevExpress.XtraEditors.CheckEdit();
            this.seNoLimit = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rcScore = new DevExpress.XtraEditors.RatingControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceQAndA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTrueFalse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrueFalse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQAndA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNoLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seNoLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcScore.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGrade
            // 
            this.cbGrade.Location = new System.Drawing.Point(71, 28);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrade.Size = new System.Drawing.Size(100, 20);
            this.cbGrade.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "年级：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "学期：";
            // 
            // cbSemester
            // 
            this.cbSemester.Location = new System.Drawing.Point(261, 28);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSemester.Size = new System.Drawing.Size(100, 20);
            this.cbSemester.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "标签：";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(71, 61);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(198, 283, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(439, 121);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 121);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(439, 121);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(191, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            // 
            // ceChoose
            // 
            this.ceChoose.Location = new System.Drawing.Point(29, 262);
            this.ceChoose.Name = "ceChoose";
            this.ceChoose.Properties.Caption = "选择题";
            this.ceChoose.Size = new System.Drawing.Size(75, 19);
            this.ceChoose.TabIndex = 5;
            this.ceChoose.CheckedChanged += new System.EventHandler(this.TestItemType_CheckedChanged);
            // 
            // ceFill
            // 
            this.ceFill.Location = new System.Drawing.Point(29, 294);
            this.ceFill.Name = "ceFill";
            this.ceFill.Properties.Caption = "填空题";
            this.ceFill.Size = new System.Drawing.Size(75, 19);
            this.ceFill.TabIndex = 5;
            this.ceFill.CheckedChanged += new System.EventHandler(this.TestItemType_CheckedChanged);
            // 
            // ceQAndA
            // 
            this.ceQAndA.Location = new System.Drawing.Point(232, 294);
            this.ceQAndA.Name = "ceQAndA";
            this.ceQAndA.Properties.Caption = "问答题";
            this.ceQAndA.Size = new System.Drawing.Size(75, 19);
            this.ceQAndA.TabIndex = 5;
            this.ceQAndA.CheckedChanged += new System.EventHandler(this.TestItemType_CheckedChanged);
            // 
            // ceTrueFalse
            // 
            this.ceTrueFalse.Location = new System.Drawing.Point(232, 262);
            this.ceTrueFalse.Name = "ceTrueFalse";
            this.ceTrueFalse.Properties.Caption = "判断题";
            this.ceTrueFalse.Size = new System.Drawing.Size(75, 19);
            this.ceTrueFalse.TabIndex = 5;
            this.ceTrueFalse.CheckedChanged += new System.EventHandler(this.TestItemType_CheckedChanged);
            // 
            // seChoose
            // 
            this.seChoose.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seChoose.Location = new System.Drawing.Point(110, 261);
            this.seChoose.Name = "seChoose";
            this.seChoose.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seChoose.Properties.IsFloatValue = false;
            this.seChoose.Properties.Mask.EditMask = "N00";
            this.seChoose.Size = new System.Drawing.Size(51, 20);
            this.seChoose.TabIndex = 6;
            this.seChoose.Visible = false;
            // 
            // seTrueFalse
            // 
            this.seTrueFalse.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seTrueFalse.Location = new System.Drawing.Point(313, 261);
            this.seTrueFalse.Name = "seTrueFalse";
            this.seTrueFalse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTrueFalse.Properties.IsFloatValue = false;
            this.seTrueFalse.Properties.Mask.EditMask = "N00";
            this.seTrueFalse.Size = new System.Drawing.Size(51, 20);
            this.seTrueFalse.TabIndex = 6;
            this.seTrueFalse.Visible = false;
            // 
            // seFill
            // 
            this.seFill.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seFill.Location = new System.Drawing.Point(110, 293);
            this.seFill.Name = "seFill";
            this.seFill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFill.Properties.IsFloatValue = false;
            this.seFill.Properties.Mask.EditMask = "N00";
            this.seFill.Size = new System.Drawing.Size(51, 20);
            this.seFill.TabIndex = 6;
            this.seFill.Visible = false;
            // 
            // seQAndA
            // 
            this.seQAndA.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seQAndA.Location = new System.Drawing.Point(313, 293);
            this.seQAndA.Name = "seQAndA";
            this.seQAndA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seQAndA.Properties.IsFloatValue = false;
            this.seQAndA.Properties.Mask.EditMask = "N00";
            this.seQAndA.Size = new System.Drawing.Size(51, 20);
            this.seQAndA.TabIndex = 6;
            this.seQAndA.Visible = false;
            // 
            // ceNoLimit
            // 
            this.ceNoLimit.EditValue = true;
            this.ceNoLimit.Location = new System.Drawing.Point(29, 228);
            this.ceNoLimit.Name = "ceNoLimit";
            this.ceNoLimit.Properties.Caption = "不限题型";
            this.ceNoLimit.Size = new System.Drawing.Size(75, 19);
            this.ceNoLimit.TabIndex = 5;
            this.ceNoLimit.CheckedChanged += new System.EventHandler(this.TestItemType_CheckedChanged);
            // 
            // seNoLimit
            // 
            this.seNoLimit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seNoLimit.Location = new System.Drawing.Point(110, 227);
            this.seNoLimit.Name = "seNoLimit";
            this.seNoLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seNoLimit.Properties.IsFloatValue = false;
            this.seNoLimit.Properties.Mask.EditMask = "N00";
            this.seNoLimit.Size = new System.Drawing.Size(51, 20);
            this.seNoLimit.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(96, 341);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "重置";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "评分：";
            // 
            // rcScore
            // 
            this.rcScore.Location = new System.Drawing.Point(71, 198);
            this.rcScore.Name = "rcScore";
            this.rcScore.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rcScore.Size = new System.Drawing.Size(87, 16);
            this.rcScore.TabIndex = 9;
            this.rcScore.Text = "ratingControl1";
            // 
            // ChooseTestItem
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 385);
            this.Controls.Add(this.rcScore);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.seQAndA);
            this.Controls.Add(this.seFill);
            this.Controls.Add(this.seTrueFalse);
            this.Controls.Add(this.seNoLimit);
            this.Controls.Add(this.seChoose);
            this.Controls.Add(this.ceTrueFalse);
            this.Controls.Add(this.ceQAndA);
            this.Controls.Add(this.ceFill);
            this.Controls.Add(this.ceNoLimit);
            this.Controls.Add(this.ceChoose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.cbGrade);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseTestItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTestItem";
            this.Load += new System.EventHandler(this.ChooseTestItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceQAndA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTrueFalse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTrueFalse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQAndA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNoLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seNoLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcScore.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit cbGrade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbSemester;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.CheckEdit ceChoose;
        private DevExpress.XtraEditors.CheckEdit ceFill;
        private DevExpress.XtraEditors.CheckEdit ceQAndA;
        private DevExpress.XtraEditors.CheckEdit ceTrueFalse;
        private DevExpress.XtraEditors.SpinEdit seChoose;
        private DevExpress.XtraEditors.SpinEdit seTrueFalse;
        private DevExpress.XtraEditors.SpinEdit seFill;
        private DevExpress.XtraEditors.SpinEdit seQAndA;
        private DevExpress.XtraEditors.CheckEdit ceNoLimit;
        private DevExpress.XtraEditors.SpinEdit seNoLimit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RatingControl rcScore;
    }
}