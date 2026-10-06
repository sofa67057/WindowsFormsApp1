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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Fill(Table_12 Motorbike)

        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");

        }

     
    }
}
