using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip tp = new ToolTip();
            tp.BackColor = Color.Aqua;
            tp.ForeColor = Color.Red;
            tp.IsBalloon = true;

            tp.SetToolTip(this.textBox2, "World");
            
        }
    }
}
