using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    class ComboBoxAttrCss
    {
        ComboBox cmb = new ComboBox();

        public ComboBoxAttrCss()
        {
            cmb.Items.Add("color");
            cmb.Items.Add("display");
            cmb.Items.Add("font - family");
            cmb.Items.Add("font - size");
            cmb.Items.Add("font-style");
            cmb.Items.Add("margin");
            cmb.Items.Add("position");
            cmb.Items.Add("text-align");
            cmb.Items.Add("vertical-align");
            cmb.Items.Add("visibility");
            cmb.Items.Add("width");
            cmb.Items.Add("left");
            cmb.Items.Add("top");
            cmb.Items.Add("right");
            cmb.Items.Add("bottom");
            cmb.Height = 30;
            cmb.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            cmb.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;

        }
        public ComboBox cmbcss { get { return cmb; } }

    }
}
