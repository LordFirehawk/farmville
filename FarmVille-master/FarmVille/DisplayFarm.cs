using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace FarmVille
{

    public partial class DisplayFarm : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;
        Farm farmWorkingWith;
        Farmer farmerWorkingWith;

        public DisplayFarm(Farm farmRecived, Farmer farmerRecived)
        {
            InitializeComponent();
            farmWorkingWith = farmRecived;
            farmerWorkingWith = farmerRecived;
            Paint();

            //frm.Show();

        }



        private void frm_Shown(object sender, EventArgs e)
        {
            Paint();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            DisplayPanel.Refresh();
            Paint();
        }


        private void DrawLine(int startX, int startY, int cageSize, int angle)
        {
            for (int i = 0; i < 4; i++)
            {
                int endX = (int)(startX + Math.Round(Math.Cos(angle * .017453292519)) * cageSize);
                int endY = (int)(startY + Math.Round(Math.Sin(angle * .017453292519)) * cageSize);

                angle = angle + 90;

                Point[] points =
                {
                new Point(startX,startY),
                new Point(endX,endY)
            };
                g.DrawLines(myPen, points);

                startX = endX;
                startY = endY;
            }

        }
        public void Paint()
        {
            SaveLoad saveLoad = new SaveLoad();
            List<string> getFarmInfo = saveLoad.LoadThis(farmWorkingWith.FarmName, farmerWorkingWith);
            Calculations algorithm = new Calculations();
            List<string> theCoOrdinate = algorithm.CreateTheFarm(getFarmInfo);
            //algorithm.HandleNewAnimals(getFarmInfo, farmWorkingWith.FarmName);

            int startX;
            int startY;
            int cageSize;
            int angle = 0;
            myPen.Width = 1;
            g = DisplayPanel.CreateGraphics();

            foreach (string item in theCoOrdinate)
            {
                string[] lines = item.Split(',');
                startX = int.Parse(lines[1]);
                startY = int.Parse(lines[2]);
                cageSize = int.Parse(lines[3]);
                if (lines[4] == "Prey") myPen.Color = Color.Blue;
                if (lines[4] == "Predator") myPen.Color = Color.Red;
                if (lines[4] == "Other") myPen.Color = Color.Green;

                DrawLine(startX, startY, cageSize, angle);
            }


            //DrawLine(950, 950, 50, angle);

        }
    }
}
