using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        MyArmy myarmy = new MyArmy();
        public Form1()
        {
            InitializeComponent();
            Show();
            progressBar1.PerformStep();
        }

        private void SellPeopletrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void HumantextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Show()
        {
            SellPeopletrackBar1.Maximum = myarmy.Human;
            HiretrackBar3.Maximum = myarmy.Human;
            AttacktrackBar2.Maximum = myarmy.Warrious;
            HumantextBox1.Text = Convert.ToString(myarmy.Human);
            WarrioustextBox2.Text = Convert.ToString(myarmy.Warrious);
            MoneytextBox3.Text = Convert.ToString(myarmy.Money);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Sellbutton1_Click(object sender, EventArgs e)
        {
            myarmy.Human -= SellPeopletrackBar1.Value;
            Show();
        }

        private void Hirebutton2_Click(object sender, EventArgs e)
        {
            myarmy.Human += HiretrackBar3.Value;
        }

        private void Attackbutton3_Click(object sender, EventArgs e)
        {
            myarmy.Human -= AttacktrackBar2.Value;
        }

        private void SellPeopletrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Selllabel7.Text = SellPeopletrackBar1.Value.ToString();
        }
    }
}
