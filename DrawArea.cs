using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_CG
{
    class DrawArea
    {
        public static void FillArea(Bitmap image, PictureBox pictureBox, float scale, float unitSegment)
        {
            float w = pictureBox.Width, h = pictureBox.Height;
            float step = (float)(scale * 10.0 / 100);

            Pen lightgray_pen = new Pen(Color.LightGray, 1);
            Pen gray_pen = new Pen(Color.Gray, 1);
            Pen black_pen = new Pen(Color.Black, 2);

            Draw_Net(image, w, h, gray_pen, lightgray_pen, step, unitSegment);
            Draw_Axes(image, w, h, gray_pen, black_pen, step, unitSegment);
            Draw_Numeration(image, w, h, step, unitSegment);
        }

        public static void Draw_Axes(Bitmap image, float width, float height, Pen gray_pen, Pen black_pen, float step, float unitSegment)
        {

            Graphics.FromImage(image).DrawLine(black_pen, width / 2, 0, width / 2, height);
            Graphics.FromImage(image).DrawLine(black_pen, 0, height / 2, width, height / 2);

            for (float i = 0; i < width / 2 - step; i += step)
            {
                Graphics.FromImage(image).DrawLine(gray_pen, width / 2 - i, height / 2 - step / 2, width / 2 - i, height / 2 + step / 2);
                Graphics.FromImage(image).DrawLine(gray_pen, width / 2 + i, height / 2 - step / 2, width / 2 + i, height / 2 + step / 2);
                if (i % (unitSegment * step) == 0)
                {
                    Graphics.FromImage(image).DrawLine(black_pen, width / 2 - i, height / 2 - step / 2, width / 2 - i, height / 2 + step / 2);
                    Graphics.FromImage(image).DrawLine(black_pen, width / 2 + i, height / 2 - step / 2, width / 2 + i, height / 2 + step / 2);
                }
            }

            for (float i = 0; i < height / 2 - step; i += step)
            {
                Graphics.FromImage(image).DrawLine(gray_pen, width / 2 - step / 2, height / 2 - i, width / 2 + step / 2, height / 2 - i);
                Graphics.FromImage(image).DrawLine(gray_pen, width / 2 - step / 2, height / 2 + i, width / 2 + step / 2, height / 2 + i);
                if (i % (unitSegment * step) == 0)
                {
                    Graphics.FromImage(image).DrawLine(black_pen, width / 2 - step / 2, height / 2 - i, width / 2 + step / 2, height / 2 - i);
                    Graphics.FromImage(image).DrawLine(black_pen, width / 2 - step / 2, height / 2 + i, width / 2 + step / 2, height / 2 + i);
                }
            }

            PointF[] x_arrow = { new PointF(width ,height/2),
                                new PointF(width - step, height/2 - step/2),
                                new PointF(width - step, height/2 + step/2) };

            PointF[] y_arrow = { new PointF(width/2, 0),
                                new PointF(width/2 - step/2, step),
                                new PointF(width/2 + step/2, step) };

            Graphics.FromImage(image).FillPolygon(Brushes.Black, x_arrow);
            Graphics.FromImage(image).DrawString("X", new Font("TimesNewRoman", step), Brushes.Black, (float)(width - (1.5 * step)), height / 2 + step / 2);
            Graphics.FromImage(image).FillPolygon(Brushes.Black, y_arrow);
            Graphics.FromImage(image).DrawString("Y", new Font("TimesNewRoman", step), Brushes.Black, width / 2 + step / 2, 0);
        }

        public static void Draw_Net(Bitmap image, float width, float height, Pen gray_pen, Pen lightgray_pen, float step, float unitSegment)
        {
            for (float i = 0; i < height / 2; i += step)
            {
                if (i % (unitSegment * step) == 0)
                {
                    Graphics.FromImage(image).DrawLine(gray_pen, 0, height / 2 - i, width, height / 2 - i);
                    Graphics.FromImage(image).DrawLine(gray_pen, 0, height / 2 + i, width, height / 2 + i);
                }
                else
                {
                    Graphics.FromImage(image).DrawLine(lightgray_pen, 0, height / 2 - i, width, height / 2 - i);
                    Graphics.FromImage(image).DrawLine(lightgray_pen, 0, height / 2 + i, width, height / 2 + i);
                }
            }

            for (float i = 0; i < width / 2; i += step)
            {
                if (i % (unitSegment * step) == 0)
                {
                    Graphics.FromImage(image).DrawLine(gray_pen, width / 2 - i, 0, width / 2 - i, height);
                    Graphics.FromImage(image).DrawLine(gray_pen, width / 2 + i, 0, width / 2 + i, height);
                }
                else
                {
                    Graphics.FromImage(image).DrawLine(lightgray_pen, width / 2 - i, 0, width / 2 - i, height);
                    Graphics.FromImage(image).DrawLine(lightgray_pen, width / 2 + i, 0, width / 2 + i, height);
                }
            }
        }

        public static void Draw_Numeration(Bitmap image, float width, float height, float step, float unitSegment)
        {
            Graphics.FromImage(image).DrawString("0", new Font("TimesNewRoman", step), new SolidBrush(Color.Black), width / 2, height / 2);

            for (float i = unitSegment * step; i < height / 2; i += unitSegment * step)
            {
                Graphics.FromImage(image).DrawString(Convert.ToString(i * 10 / step), new Font("TimesNewRoman", step), Brushes.Black, width / 2, height / 2 - i);
                Graphics.FromImage(image).DrawString(Convert.ToString("-" + i * 10 / step), new Font("TimesNewRoman", step), Brushes.Black, width / 2, height / 2 + i);
            }

            for (float i = unitSegment * step; i < width / 2; i += unitSegment * step)
            {
                Graphics.FromImage(image).DrawString("-" + Convert.ToString(i * 10 / step), new Font("TimesNewRoman", step), Brushes.Black, width / 2 - i, height / 2);
                Graphics.FromImage(image).DrawString(Convert.ToString(i * 10 / step), new Font("TimesNewRoman", step), Brushes.Black, width / 2 + i, height / 2);
            }
        }
    }
}