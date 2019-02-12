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

namespace TestCollection
{
    public partial class PrintForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            richEditControl1.Text = ""; //清空
        }
        public void DocAppendText(string text)
        {
            richEditControl1.Document.AppendText(text);
        }

        public void DocAppendHtmlText(string htmlText)
        {
            richEditControl1.Document.AppendHtmlText(htmlText);
        }
    }
}