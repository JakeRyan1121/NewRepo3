using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Resources;

namespace Stephenson.j_Polygon_Area
{
    public partial class Polygons : Form
    {
        double dblSideLength;


        public class Polygon
        {
            public double Triangle;
            public double Square;
            public double Pentagon;
            public double Hexagon;
            public double Octagon;
        }
        public Polygons()
        {
            InitializeComponent();
        }

        private void Polygons_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                dblSideLength = Convert.ToDouble(txtbxSideLength.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number :)");

            }

            if (cmbxPolygons.SelectedIndex == 0)
            {
                pictureBox1.Image = Resource1.triangle;
                pictureBox2.Image = Resource1.Equilateral_Triangle;
            }
            else if (cmbxPolygons.SelectedIndex == 1)
            {
                pictureBox1.Image = Resource1.Square;
                pictureBox2.Image = Resource1.Square2;
            }
            else if (cmbxPolygons.SelectedIndex == 2)
            {
                pictureBox1.Image = Resource1.pentagon;
                pictureBox2.Image = Resource1.pentagon2;
            }
            else if (cmbxPolygons.SelectedIndex == 3)
            {
                pictureBox1.Image = Resource1.hexagon;
                pictureBox2.Image = Resource1.hexagon2;
            }
            else if (cmbxPolygons.SelectedIndex == 4)
            {
                pictureBox1.Image = Resource1.octagon;
                pictureBox2.Image = Resource1.octagon2;
            }

        }
            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }
    }
}
