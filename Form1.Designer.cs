namespace lab5_CG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_stop = new System.Windows.Forms.Button();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_rotateRectangle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_rotationAngle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_drawRectangle = new System.Windows.Forms.Button();
            this.textBox_D_Y = new System.Windows.Forms.TextBox();
            this.textBox_D_X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_C_Y = new System.Windows.Forms.TextBox();
            this.textBox_C_X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_B_Y = new System.Windows.Forms.TextBox();
            this.textBox_B_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_A_Y = new System.Windows.Forms.TextBox();
            this.textBox_A_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_unitSegment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(158, 644);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(155, 63);
            this.btn_stop.TabIndex = 58;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // textBox_scale
            // 
            this.textBox_scale.Location = new System.Drawing.Point(91, 395);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(129, 34);
            this.textBox_scale.TabIndex = 57;
            this.textBox_scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_scale_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 26);
            this.label15.TabIndex = 56;
            this.label15.Text = "Scale";
            // 
            // btn_rotateRectangle
            // 
            this.btn_rotateRectangle.Location = new System.Drawing.Point(330, 644);
            this.btn_rotateRectangle.Name = "btn_rotateRectangle";
            this.btn_rotateRectangle.Size = new System.Drawing.Size(155, 63);
            this.btn_rotateRectangle.TabIndex = 55;
            this.btn_rotateRectangle.Text = "Rotate";
            this.btn_rotateRectangle.UseVisualStyleBackColor = true;
            this.btn_rotateRectangle.Click += new System.EventHandler(this.btn_rotateRectangle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 592);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 26);
            this.label14.TabIndex = 54;
            this.label14.Text = "Enter the rotation angle";
            // 
            // textBox_rotationAngle
            // 
            this.textBox_rotationAngle.Location = new System.Drawing.Point(266, 584);
            this.textBox_rotationAngle.Name = "textBox_rotationAngle";
            this.textBox_rotationAngle.Size = new System.Drawing.Size(100, 34);
            this.textBox_rotationAngle.TabIndex = 53;
            this.textBox_rotationAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_rotationAngle_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(521, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 601);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btn_drawRectangle
            // 
            this.btn_drawRectangle.Location = new System.Drawing.Point(143, 503);
            this.btn_drawRectangle.Name = "btn_drawRectangle";
            this.btn_drawRectangle.Size = new System.Drawing.Size(155, 63);
            this.btn_drawRectangle.TabIndex = 51;
            this.btn_drawRectangle.Text = "Draw";
            this.btn_drawRectangle.UseVisualStyleBackColor = true;
            this.btn_drawRectangle.Click += new System.EventHandler(this.btn_drawRectangle_Click);
            // 
            // textBox_D_Y
            // 
            this.textBox_D_Y.Location = new System.Drawing.Point(255, 320);
            this.textBox_D_Y.Name = "textBox_D_Y";
            this.textBox_D_Y.Size = new System.Drawing.Size(100, 34);
            this.textBox_D_Y.TabIndex = 50;
            this.textBox_D_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_D_Y_KeyPress);
            // 
            // textBox_D_X
            // 
            this.textBox_D_X.Location = new System.Drawing.Point(255, 275);
            this.textBox_D_X.Name = "textBox_D_X";
            this.textBox_D_X.Size = new System.Drawing.Size(100, 34);
            this.textBox_D_X.TabIndex = 49;
            this.textBox_D_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_D_X_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 26);
            this.label11.TabIndex = 48;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 26);
            this.label12.TabIndex = 47;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 46;
            this.label13.Text = "Point D:";
            // 
            // textBox_C_Y
            // 
            this.textBox_C_Y.Location = new System.Drawing.Point(58, 320);
            this.textBox_C_Y.Name = "textBox_C_Y";
            this.textBox_C_Y.Size = new System.Drawing.Size(100, 34);
            this.textBox_C_Y.TabIndex = 45;
            this.textBox_C_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_C_Y_KeyPress);
            // 
            // textBox_C_X
            // 
            this.textBox_C_X.Location = new System.Drawing.Point(58, 275);
            this.textBox_C_X.Name = "textBox_C_X";
            this.textBox_C_X.Size = new System.Drawing.Size(100, 34);
            this.textBox_C_X.TabIndex = 44;
            this.textBox_C_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_C_X_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 26);
            this.label9.TabIndex = 42;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 26);
            this.label10.TabIndex = 41;
            this.label10.Text = "Point C:";
            // 
            // textBox_B_Y
            // 
            this.textBox_B_Y.Location = new System.Drawing.Point(255, 160);
            this.textBox_B_Y.Name = "textBox_B_Y";
            this.textBox_B_Y.Size = new System.Drawing.Size(100, 34);
            this.textBox_B_Y.TabIndex = 40;
            this.textBox_B_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_Y_KeyPress);
            // 
            // textBox_B_X
            // 
            this.textBox_B_X.Location = new System.Drawing.Point(255, 115);
            this.textBox_B_X.Name = "textBox_B_X";
            this.textBox_B_X.Size = new System.Drawing.Size(100, 34);
            this.textBox_B_X.TabIndex = 39;
            this.textBox_B_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_X_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "Point B:";
            // 
            // textBox_A_Y
            // 
            this.textBox_A_Y.Location = new System.Drawing.Point(58, 160);
            this.textBox_A_Y.Name = "textBox_A_Y";
            this.textBox_A_Y.Size = new System.Drawing.Size(100, 34);
            this.textBox_A_Y.TabIndex = 35;
            this.textBox_A_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_Y_KeyPress);
            // 
            // textBox_A_X
            // 
            this.textBox_A_X.Location = new System.Drawing.Point(58, 115);
            this.textBox_A_X.Name = "textBox_A_X";
            this.textBox_A_X.Size = new System.Drawing.Size(100, 34);
            this.textBox_A_X.TabIndex = 34;
            this.textBox_A_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_X_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Point A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter the coordinates of the rectangle\'s vertices";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 30);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMatrixToolStripMenuItem,
            this.savePictureToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMatrixToolStripMenuItem
            // 
            this.saveMatrixToolStripMenuItem.Name = "saveMatrixToolStripMenuItem";
            this.saveMatrixToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveMatrixToolStripMenuItem.Text = "Save matrix";
            this.saveMatrixToolStripMenuItem.Click += new System.EventHandler(this.saveMatrixToolStripMenuItem_Click);
            // 
            // savePictureToolStripMenuItem
            // 
            this.savePictureToolStripMenuItem.Name = "savePictureToolStripMenuItem";
            this.savePictureToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.savePictureToolStripMenuItem.Text = "Save picture";
            this.savePictureToolStripMenuItem.Click += new System.EventHandler(this.savePictureToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.btn_rotateRectangle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 453);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 26);
            this.label16.TabIndex = 60;
            this.label16.Text = "Change the unit segment";
            // 
            // textBox_unitSegment
            // 
            this.textBox_unitSegment.Location = new System.Drawing.Point(266, 450);
            this.textBox_unitSegment.Name = "textBox_unitSegment";
            this.textBox_unitSegment.Size = new System.Drawing.Size(100, 34);
            this.textBox_unitSegment.TabIndex = 61;
            this.textBox_unitSegment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_unitSegment_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 902);
            this.Controls.Add(this.textBox_unitSegment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.textBox_scale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_rotateRectangle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_rotationAngle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_drawRectangle);
            this.Controls.Add(this.textBox_D_Y);
            this.Controls.Add(this.textBox_D_X);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_C_Y);
            this.Controls.Add(this.textBox_C_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_B_Y);
            this.Controls.Add(this.textBox_B_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_A_Y);
            this.Controls.Add(this.textBox_A_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_rotateRectangle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_rotationAngle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_drawRectangle;
        private System.Windows.Forms.TextBox textBox_D_Y;
        private System.Windows.Forms.TextBox textBox_D_X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_C_Y;
        private System.Windows.Forms.TextBox textBox_C_X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_B_Y;
        private System.Windows.Forms.TextBox textBox_B_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_A_Y;
        private System.Windows.Forms.TextBox textBox_A_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePictureToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_unitSegment;
    }
}

