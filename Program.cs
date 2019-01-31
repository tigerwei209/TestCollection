using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using DevExpress.XtraEditors;
using System.IO;

namespace TestCollection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashForm));
            //创建数据库目录
            //var dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            //if (Directory.Exists(dataPath) == false)
            //{
            //    Directory.CreateDirectory(dataPath);
            //}
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            //异常处理
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();

            var culture = System.Globalization.CultureInfo.CreateSpecificCulture("zh-Hans");
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            culture.DateTimeFormat.ShortTimePattern = "HH:mm";
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("宋体", 10.5f);  //默认字体
            WindowsFormsSettings.DefaultFont = DevExpress.Utils.AppearanceObject.DefaultFont;
            WindowsFormsSettings.DefaultMenuFont = DevExpress.Utils.AppearanceObject.DefaultFont;
            
            Application.Run(new Main());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            UnhandledException((Exception)e.ExceptionObject);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            UnhandledException(e.Exception);
        }

        private static void UnhandledException(Exception ex)
        {
            //Core.ServiceFactory.LogService.Error("error", ex);
            XtraMessageBox.Show($"发生捕获的异常，错误信息：{ (ex.InnerException ?? ex).Message}", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
