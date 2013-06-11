using System;
using System.Windows.Forms;

namespace SampleForm
{
    public partial class MainForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            panel1.Controls.Add(View.Control);
            View.Control.Dock = DockStyle.Fill;

            View.Data = new ControlData()
                {
                    Str1 = "hoge",
                    Str2 = "fuga",
                    Str3 = "piyo",
                };

            base.OnLoad(e);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public IView View { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Str1={0}\r\nStr2={1}\r\nStr3={2}", View.Data.Str1, View.Data.Str2, View.Data.Str3));
        }
    }
}
