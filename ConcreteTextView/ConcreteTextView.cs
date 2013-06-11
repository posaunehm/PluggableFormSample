using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleForm;

namespace ConcreteTextViewImpl
{
    public class ConcreteTextView : IView
    {
        private readonly TextView _textView;

        public ConcreteTextView()
        {
            _textView = new TextView();
            Control = _textView;
        }

        public Control Control { get; private set; }

        public ControlData Data
        {
            get { return _textView.GetData(); }
            set { _textView.SetData(value); }
        }
    }
}
