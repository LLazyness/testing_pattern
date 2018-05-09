using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.FillMainform
{
    class ComboBoxElementSe
    {
        ComboBox combobox = new ComboBox();
        public ComboBoxElementSe()
        {
            
            combobox.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            combobox.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            combobox.Width = 130;
            combobox.Height = 30;
            combobox.Items.Add("Выбрать атрибут");
            combobox.Items.Add("class");
            combobox.Items.Add("contenteditable");
            combobox.Items.Add("dir");
            combobox.Items.Add("draggable");
            combobox.Items.Add("id");
            combobox.Items.Add("lang");
            combobox.Items.Add("title");
            combobox.Items.Add("translate");
            combobox.Items.Add("hidden");
            combobox.Items.Add("dropzone");
            combobox.Items.Add("spellcheck");
            combobox.Items.Add("contextmenu");
            combobox.SelectedItem = combobox.Items.GetItemAt(0);

        }
        public ComboBox cmb {get{ return combobox; } }
    }
}
