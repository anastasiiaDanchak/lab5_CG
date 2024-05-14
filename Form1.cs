using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace lab5_CG
{

    public partial class Form1 : Form
    {
        List<PointF> square;
        Point bottomRight;
        Point topLeft;

        bool exist = false;
        float scale;
        int size;
        float unitSegment;
        Pen pen = new Pen(Color.Black, 2);
        Bitmap image;


        private Timer timer;
        private float angle;
        private float deltaY;
        private const float VerticalSpeed = 5;
        private Matrix transformMatrix;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(500, 500);
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(image).Clear(Color.White);
            pictureBox1.Image = image;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += btn_rotateRectangle_Click;
            transformMatrix = new Matrix();



            textBox_A_X.Text = "50";
            textBox_A_Y.Text = "150";
            textBox_B_X.Text = "150";
            textBox_B_Y.Text = "150";
            textBox_C_X.Text = "150";
            textBox_C_Y.Text = "50";
            textBox_D_X.Text = "50";
            textBox_D_Y.Text = "50";
            textBox_scale.Text = "100";

            textBox_rotationAngle.Text = "45";

            textBox_unitSegment.Text = "5";

        }
        public struct HomogeneousPoint
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float W { get; set; }

            public HomogeneousPoint(float x, float y, float w)
            {
                X = x;
                Y = y;
                W = w;
            }
        }
        private HomogeneousPoint ConvertToHomogeneous(PointF point)
        {
            return new HomogeneousPoint(point.X, -point.Y, 1); 
        }

        private void btn_drawRectangle_Click(object sender, EventArgs e)
        {
            angle = 0.0f;
            deltaY = 0.0f;

            if (textBox_unitSegment.Text != "")
            {
                timer.Stop();
                scale = Convert.ToSingle(textBox_scale.Text);
                unitSegment = Convert.ToSingle(textBox_unitSegment.Text);
                Graphics.FromImage(image).Clear(Color.White);

                DrawArea.FillArea(image, pictureBox1, scale, unitSegment);

                if (textBox_A_X.Text == "" || textBox_A_Y.Text == "" || textBox_B_X.Text == "" || textBox_B_Y.Text == "" || textBox_C_X.Text == "" || textBox_C_Y.Text == "" || textBox_D_X.Text == "" || textBox_D_Y.Text == "")
                {
                    MessageBox.Show("Please enter all the coordinates of the points");
                }
                else
                {
                    drawSquare();
                }
            }
            else
            {

                MessageBox.Show("Please enter a unit segment");
            }
        }
        void drawSquare()
        {

            float w = pictureBox1.Width / 2;
            float h = pictureBox1.Height / 2;
            float A_X = Convert.ToSingle(textBox_A_X.Text) * scale / 100 + w;
            float A_Y = -Convert.ToSingle(textBox_A_Y.Text) * scale / 100 + h;

            float B_X = Convert.ToSingle(textBox_B_X.Text) * scale / 100 + w;
            float B_Y = -Convert.ToSingle(textBox_B_Y.Text) * scale / 100 + h;

            float C_X = Convert.ToSingle(textBox_C_X.Text) * scale / 100 + w;
            float C_Y = -Convert.ToSingle(textBox_C_Y.Text) * scale / 100 + h;

            float D_X = Convert.ToSingle(textBox_D_X.Text) * scale / 100 + w;
            float D_Y = -Convert.ToSingle(textBox_D_Y.Text) * scale / 100 + h;

            square = new List<PointF>
                   {
                new PointF(A_X, A_Y),
                new PointF(B_X, B_Y),
                new PointF(C_X, C_Y),
                new PointF(D_X, D_Y)
                   };


            if (IsSquare(square))
            {
                topLeft = new Point((int)(square[0].X), (int)(square[0].Y));
                bottomRight = new Point((int)(square[2].X), (int)(square[2].Y));


                if (topLeft != null && bottomRight != null)
                {
                    size = (int)square[1].X - (int)square[0].X;
                    Rectangle squareRect = new Rectangle(topLeft.X, topLeft.Y, size, size);
                    Graphics.FromImage(image).DrawRectangle(pen, squareRect);
                    pictureBox1.Image = image;
                    exist = true;
                }

            }
            else
            {
                MessageBox.Show("Incorrect coordinates of the vertices of the square!");
            }
        }

        bool IsSquare(List<PointF> points)
        {
            if (points.Count != 4)
                return false;


            float side1 = Distance(square[0], square[1]);
            float side2 = Distance(square[1], square[2]);
            float side3 = Distance(square[2], square[3]);
            float side4 = Distance(square[3], square[0]);


            return side1 == side2 && side2 == side3 && side3 == side4 && side4 == side1;
        }

        float Distance(PointF p1, PointF p2)
        {
            float dx = p2.X - p1.X;
            float dy = (-p2.Y) - (-p1.Y);
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
        public List<HomogeneousPoint> Rotate(List<PointF> square, float angle)
        {
            List<HomogeneousPoint> newSquare = new List<HomogeneousPoint>();
            float centerX = square[0].X + ((square[1].X - square[0].X) / 2);
            float centerY = square[0].Y + ((square[3].Y - square[0].Y) / 2);

            transformMatrix = new Matrix();
            transformMatrix.RotateAt(-angle, new PointF(centerX, centerY)); 
            foreach (var point in square)
            {
                PointF[] transformedPoints = new PointF[] { point };
                transformMatrix.TransformPoints(transformedPoints);
                newSquare.Add(new HomogeneousPoint(transformedPoints[0].X, transformedPoints[0].Y, 1));
            }

            return newSquare;
        }

        private void textBox_A_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_A_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_B_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_B_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_C_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_C_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_D_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }

        private void textBox_D_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == Convert.ToChar("-") || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }
        }


        private void btn_rotateRectangle_Click(object sender, EventArgs e)
        {
            if (exist)
            {
                if (textBox_rotationAngle.Text.Trim() != "")
                {
                    float rotationAngle = float.Parse(textBox_rotationAngle.Text);
                    angle += rotationAngle;
                    deltaY -= VerticalSpeed;
                    Graphics graphics = Graphics.FromImage(image);
                    graphics.Clear(Color.White);
                    DrawArea.FillArea(image, pictureBox1, scale, unitSegment);

                    List<HomogeneousPoint> rotatedSquare = Rotate(square, angle);

                    PointF[] rotatedPoints = new PointF[rotatedSquare.Count];
                    for (int i = 0; i < rotatedSquare.Count; i++)
                    {
                        rotatedPoints[i] = new PointF(rotatedSquare[i].X, rotatedSquare[i].Y + deltaY);
                    }


                    graphics.DrawPolygon(pen, rotatedPoints);

                    pictureBox1.Image = image;
                    timer.Start();

                }
                else
                {
                    MessageBox.Show("Enter the rotation angle, please.");
                }
            }
            else
            {
                MessageBox.Show("Please draw a square first.");
            }
        }





        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName + ".jpg");
                }
            }
            else
                MessageBox.Show("Please select an image.");


        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void saveMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transformMatrix != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Save Matrix File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Result Matrix:");
                        for (int i = 0; i < transformMatrix.Elements.GetLength(0); i++)
                        {
                            writer.WriteLine(string.Join(" ", transformMatrix.Elements[i]));
                        }
                    }

                    MessageBox.Show("Матрицю успішно збережено у файл.");
                }
            }
            else
            {
                MessageBox.Show("Немає матриці для збереження.");
            }
        }

        private void textBox_scale_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only positive numbers can be entered in this field.");
            }
        }

        private void textBox_rotationAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer.Stop();
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8)
            {

                string text = textBox_rotationAngle.Text + ch;
                if (!string.IsNullOrWhiteSpace(text) && float.TryParse(text, out float value) && value > 360)
                {
                    e.Handled = true;
                    MessageBox.Show("Rotation angle cannot exceed 360 degrees.");
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only positive numbers can be entered in this field.");
            }
        }

        private void textBox_unitSegment_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only positive numbers can be entered in this field.");
            }

        }
    }
}