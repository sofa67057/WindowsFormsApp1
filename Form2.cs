using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1._123;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Model1 DB = new Model1();

        List<Table_12> table_12s = DB.Table_12.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControl11.Fill(table_12s[AccNumber]);
            userControl12.Fill(table_12s[AccNumber + 1]);
        }
        private void Loading(bool Incr)
        {
            if (Incr == true && table_12s.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;

            Loading();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }
    }
}
