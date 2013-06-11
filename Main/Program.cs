using System;
using System.Windows.Forms;
using ConcreteGridViewImpl;
using SampleForm;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm {View = new ConcreteGridView()};

            Application.Run(mainForm);
        }
    }
}
