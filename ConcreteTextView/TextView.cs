using System.Windows.Forms;
using SampleForm;

namespace ConcreteTextViewImpl
{
    public partial class TextView : UserControl
    {
        public TextView()
        {
            InitializeComponent();
        }

        public void SetData(ControlData data)
        {
            textBox1.Text = data.Str1 ?? "";
            textBox2.Text = data.Str2 ?? "";
            textBox3.Text = data.Str3 ?? "";
        }

        public ControlData GetData()
        {
            return new ControlData()
                {
                    Str1 = textBox1.Text,
                    Str2 = textBox1.Text,
                    Str3 = textBox1.Text,
                };
        }
    }
}
