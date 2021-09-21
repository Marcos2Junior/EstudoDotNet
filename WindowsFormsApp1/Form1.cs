using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void SetBorder(Control control)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(1, 1, control.Width, control.Height));
            


            graphicsPath.AddRectangle(new Rectangle(1, 1, 10, 10));
            graphicsPath.AddPie(1, 1, 20, 20, 180, 90);



            graphicsPath.AddRectangle(new Rectangle(control.Width - 12, 1, 12, 13));
            graphicsPath.AddPie(control.Width - 24, 1, 24, 26, 270, 90);



            graphicsPath.AddRectangle(new Rectangle(1, control.Height - 10, 10, 10));
            graphicsPath.AddPie(1, control.Height - 20, 20, 20, 90, 90);



            graphicsPath.AddRectangle(new Rectangle(control.Width - 12, control.Height - 13, 13, 13));
            graphicsPath.AddPie(control.Width - 24, control.Height - 26, 24, 26, 0, 90);
            
            graphicsPath.SetMarkers();
            control.Region = new Region(graphicsPath);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            SetBorder(comboBox1);
        }
    }
}
