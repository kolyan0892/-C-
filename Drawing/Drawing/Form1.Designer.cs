namespace Drawing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.refreshButton = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.drawRectangleButton = new System.Windows.Forms.Button();
            this.rectangleTextBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.drawLineButton = new System.Windows.Forms.Button();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.drawCircleButton = new System.Windows.Forms.Button();
            this.triangleY2TextBox = new System.Windows.Forms.TextBox();
            this.triangleX2TextBox = new System.Windows.Forms.TextBox();
            this.triangleY1TextBox = new System.Windows.Forms.TextBox();
            this.triangleX1TextBox = new System.Windows.Forms.TextBox();
            this.drawTriangleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(103, 74);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(90, 34);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Выбор цвета";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(16, 74);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(81, 35);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Очистить холст";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(35, 19);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(137, 20);
            this.xTextBox.TabIndex = 3;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(35, 45);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(137, 20);
            this.yTextBox.TabIndex = 4;
            // 
            // drawRectangleButton
            // 
            this.drawRectangleButton.Location = new System.Drawing.Point(103, 61);
            this.drawRectangleButton.Name = "drawRectangleButton";
            this.drawRectangleButton.Size = new System.Drawing.Size(92, 35);
            this.drawRectangleButton.TabIndex = 5;
            this.drawRectangleButton.Text = "Нарисовать квадрат";
            this.drawRectangleButton.UseVisualStyleBackColor = true;
            this.drawRectangleButton.Click += new System.EventHandler(this.DrawRectangleButton_Click);
            // 
            // rectangleTextBox
            // 
            this.rectangleTextBox.Location = new System.Drawing.Point(103, 35);
            this.rectangleTextBox.Name = "rectangleTextBox";
            this.rectangleTextBox.Size = new System.Drawing.Size(91, 20);
            this.rectangleTextBox.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(422, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(514, 368);
            this.panel.TabIndex = 7;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Location = new System.Drawing.Point(35, 46);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(137, 20);
            this.y1TextBox.TabIndex = 9;
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(35, 20);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(137, 20);
            this.x1TextBox.TabIndex = 8;
            // 
            // drawLineButton
            // 
            this.drawLineButton.Location = new System.Drawing.Point(103, 73);
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(91, 35);
            this.drawLineButton.TabIndex = 10;
            this.drawLineButton.Text = "Нарисовать линию";
            this.drawLineButton.UseVisualStyleBackColor = true;
            this.drawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(35, 19);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(137, 20);
            this.radiusTextBox.TabIndex = 12;
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.Location = new System.Drawing.Point(103, 66);
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(90, 35);
            this.drawCircleButton.TabIndex = 11;
            this.drawCircleButton.Text = "Нарисовать круг";
            this.drawCircleButton.UseVisualStyleBackColor = true;
            this.drawCircleButton.Click += new System.EventHandler(this.DrawCircleButton_Click);
            // 
            // triangleY2TextBox
            // 
            this.triangleY2TextBox.Location = new System.Drawing.Point(42, 123);
            this.triangleY2TextBox.Name = "triangleY2TextBox";
            this.triangleY2TextBox.Size = new System.Drawing.Size(130, 20);
            this.triangleY2TextBox.TabIndex = 14;
            // 
            // triangleX2TextBox
            // 
            this.triangleX2TextBox.Location = new System.Drawing.Point(42, 97);
            this.triangleX2TextBox.Name = "triangleX2TextBox";
            this.triangleX2TextBox.Size = new System.Drawing.Size(130, 20);
            this.triangleX2TextBox.TabIndex = 13;
            // 
            // triangleY1TextBox
            // 
            this.triangleY1TextBox.Location = new System.Drawing.Point(42, 71);
            this.triangleY1TextBox.Name = "triangleY1TextBox";
            this.triangleY1TextBox.Size = new System.Drawing.Size(130, 20);
            this.triangleY1TextBox.TabIndex = 16;
            // 
            // triangleX1TextBox
            // 
            this.triangleX1TextBox.Location = new System.Drawing.Point(42, 45);
            this.triangleX1TextBox.Name = "triangleX1TextBox";
            this.triangleX1TextBox.Size = new System.Drawing.Size(130, 20);
            this.triangleX1TextBox.TabIndex = 15;
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.Location = new System.Drawing.Point(100, 157);
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(94, 35);
            this.drawTriangleButton.TabIndex = 17;
            this.drawTriangleButton.Text = "Нарисовать треугольник";
            this.drawTriangleButton.UseVisualStyleBackColor = true;
            this.drawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colorButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.yTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальная точка любого объекта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rectangleTextBox);
            this.groupBox2.Controls.Add(this.drawRectangleButton);
            this.groupBox2.Location = new System.Drawing.Point(216, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 104);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Квадрат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Сторона квадрата";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.x1TextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.y1TextBox);
            this.groupBox3.Controls.Add(this.drawLineButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 114);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Линия (координата второй точки)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.radiusTextBox);
            this.groupBox4.Controls.Add(this.drawCircleButton);
            this.groupBox4.Location = new System.Drawing.Point(10, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 113);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Круг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "R";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.triangleX1TextBox);
            this.groupBox5.Controls.Add(this.drawTriangleButton);
            this.groupBox5.Controls.Add(this.triangleY1TextBox);
            this.groupBox5.Controls.Add(this.triangleX2TextBox);
            this.groupBox5.Controls.Add(this.triangleY2TextBox);
            this.groupBox5.Location = new System.Drawing.Point(216, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 199);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Треугольник (координаты второй и третьей точки)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 401);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Drawing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button drawRectangleButton;
        private System.Windows.Forms.TextBox rectangleTextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Button drawLineButton;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button drawCircleButton;
        private System.Windows.Forms.TextBox triangleY2TextBox;
        private System.Windows.Forms.TextBox triangleX2TextBox;
        private System.Windows.Forms.TextBox triangleY1TextBox;
        private System.Windows.Forms.TextBox triangleX1TextBox;
        private System.Windows.Forms.Button drawTriangleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

