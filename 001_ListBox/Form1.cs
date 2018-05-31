using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("First");
            var lst = new List<String>();
            lst.Add("Second");
            lst.Add("Third");
            listBox1.Items.AddRange(lst.ToArray());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Так как внутри листбокса находяться строки, то мы берем из 
            //выбранного элемента .ToString()
            Text = listBox1.SelectedItem.ToString();
        }
    }
}
