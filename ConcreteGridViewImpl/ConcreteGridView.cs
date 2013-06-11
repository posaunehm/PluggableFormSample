using System.Windows.Forms;
using SampleForm;

namespace ConcreteGridViewImpl
{
    public class ConcreteGridView : IView
    {
        private readonly DataGridView _gridView;

        public ConcreteGridView()
        {
            _gridView = new DataGridView();
            _gridView.Columns.Add("Value", "Value");

            Control = _gridView;
        }

        public Control Control { get; private set; }

        public ControlData Data
        {
            get { return new ControlData()
                {
                    Str1 = _gridView.Rows[0].Cells["Value"].Value.ToString(),
                    Str2 = _gridView.Rows[1].Cells["Value"].Value.ToString(),
                    Str3 = _gridView.Rows[2].Cells["Value"].Value.ToString(),
                }; }
            set
            {
                _gridView.Rows.Clear();
                _gridView.Rows.Add(new object[] {value.Str1});
                _gridView.Rows.Add(new object[] {value.Str2});
                _gridView.Rows.Add(new object[] {value.Str3});
            }
        }
    }
}
