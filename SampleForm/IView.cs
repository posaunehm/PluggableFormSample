using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleForm
{
    public interface IView
    {
        Control Control { get; }

        ControlData Data { get; set; }


    }
}
