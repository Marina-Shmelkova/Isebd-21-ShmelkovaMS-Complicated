﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBus
{
    class RoundDoors : IDoorsElements
    {
        private ViewDoorsEnum viewForm;

        public int ViewDoors { set => viewForm = (ViewDoorsEnum)value; }

        public Color DopColor { private set; get; }

        public RoundDoors(int digit, Color dopColor)
        {
            ViewDoors = digit;
            DopColor = dopColor;
        }
        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen penFramework = new Pen(Color.White);

            g.FillEllipse(brush, x + 10, y + 10, 30, 40);
            g.FillEllipse(brush, x + 80, y + 10, 30, 40);
            g.FillEllipse(brush, x + 150, y + 10, 30, 40);

            //Рамки

            g.DrawLine(penFramework, x + 25, y + 11, x + 25, y + 49);//левая
            g.DrawLine(penFramework, x + 10, y + 30, x + 40, y + 30);

            g.DrawLine(penFramework, x + 95, y + 11, x + 95, y + 49);//середина
            g.DrawLine(penFramework, x + 80, y + 30, x + 110, y + 30);

            g.DrawLine(penFramework, x + 165, y + 11, x + 165, y + 49);//правая
            g.DrawLine(penFramework, x + 150, y + 30, x + 180, y + 30);

        }
    }
}
