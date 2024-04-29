using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab12_Novak_prp
{
    public partial class MainForm : Form
    {
        private int offsetX = 0;
        private int offsetY = 0;
        private bool isFigureVisible = true;
        int circleDiameterDD = 100;
        public MainForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(MainForm_Paint);
            btnUp.Click += new EventHandler(btnUp_Click);
            btnDown.Click += new EventHandler(btnDown_Click);
            btnLeft.Click += new EventHandler(btnLeft_Click);
            btnRight.Click += new EventHandler(btnRight_Click);
            btnToggleVisibility.Click += new EventHandler(btnToggleVisibility_Click);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int circleDiameter = circleDiameterDD;
            int triangleSquareSide = circleDiameter;
            int squareSide = triangleSquareSide;

            int marginX = 20 + offsetX;
            int marginY = 20 + offsetY;

            Pen pen = new Pen(Color.Black);

            if (isFigureVisible)
                g.DrawEllipse(pen, marginX, marginY, circleDiameter, circleDiameter);

            Point[] trianglePoints =
            {
                new Point(marginX + circleDiameter,marginY+circleDiameter),
                new Point(marginX + circleDiameter, marginY),
                new Point(marginX + (circleDiameter /100)*87 + squareSide, marginY + squareSide / 2)
            };
            if (isFigureVisible)
                g.DrawPolygon(pen, trianglePoints);

            Point[] squarePoints =
            {
                new Point(marginX + (circleDiameter /100)*87 + circleDiameter, (marginY - squareSide / 2)+(circleDiameter/2)),
                new Point(marginX + (circleDiameter /100)*87 + squareSide +circleDiameter, (marginY - squareSide / 2)+(circleDiameter/2)),
                new Point(marginX + (circleDiameter /100)*87 + squareSide + circleDiameter, (marginY + squareSide / 2)+(circleDiameter/2)),
                new Point(marginX + (circleDiameter /100)*87 + circleDiameter, (marginY + squareSide / 2)+(circleDiameter/2))
            };
            if (isFigureVisible)
                g.DrawPolygon(pen, squarePoints);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            offsetY -= 10;
            Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            offsetY += 10;
            Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            offsetX -= 10;
            Refresh();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            offsetX += 10;
            Refresh();
        }

        private void btnToggleVisibility_Click(object sender, EventArgs e)
        {
            isFigureVisible = !isFigureVisible;
            btnToggleVisibility.Text = isFigureVisible ? "Приховати фігуру" : "Показати фігуру";
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circleDiameterDD += 10;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circleDiameterDD -= 10;
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
