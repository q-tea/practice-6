namespace Calculator
{
    partial class Dashboard
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
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonDivided = new System.Windows.Forms.Button();
            this.buttonMultiplied = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.LightGray;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonEqual.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.Location = new System.Drawing.Point(9, 252);
            this.buttonEqual.MinimumSize = new System.Drawing.Size(210, 43);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEqual.Size = new System.Drawing.Size(216, 48);
            this.buttonEqual.TabIndex = 0;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.LightGray;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCE.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.Location = new System.Drawing.Point(9, 204);
            this.buttonCE.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(54, 48);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.LightGray;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button0.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(63, 204);
            this.button0.MinimumSize = new System.Drawing.Size(45, 43);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 48);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.LightGray;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonDot.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(117, 204);
            this.buttonDot.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(54, 48);
            this.buttonDot.TabIndex = 3;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivided
            // 
            this.buttonDivided.BackColor = System.Drawing.Color.LightGray;
            this.buttonDivided.FlatAppearance.BorderSize = 0;
            this.buttonDivided.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonDivided.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonDivided.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivided.Location = new System.Drawing.Point(171, 204);
            this.buttonDivided.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonDivided.Name = "buttonDivided";
            this.buttonDivided.Size = new System.Drawing.Size(54, 48);
            this.buttonDivided.TabIndex = 4;
            this.buttonDivided.Text = "/";
            this.buttonDivided.UseVisualStyleBackColor = true;
            this.buttonDivided.Click += new System.EventHandler(this.button_Operator_Click);
            // 
            // buttonMultiplied
            // 
            this.buttonMultiplied.BackColor = System.Drawing.Color.LightGray;
            this.buttonMultiplied.FlatAppearance.BorderSize = 0;
            this.buttonMultiplied.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonMultiplied.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMultiplied.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplied.Location = new System.Drawing.Point(171, 156);
            this.buttonMultiplied.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonMultiplied.Name = "buttonMultiplied";
            this.buttonMultiplied.Size = new System.Drawing.Size(54, 48);
            this.buttonMultiplied.TabIndex = 8;
            this.buttonMultiplied.Text = "*";
            this.buttonMultiplied.UseVisualStyleBackColor = true;
            this.buttonMultiplied.Click += new System.EventHandler(this.button_Operator_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(63, 156);
            this.button2.MinimumSize = new System.Drawing.Size(45, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 156);
            this.button1.MinimumSize = new System.Drawing.Size(45, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.LightGray;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMinus.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(171, 108);
            this.buttonMinus.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(54, 48);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Operator_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(117, 108);
            this.button6.MinimumSize = new System.Drawing.Size(45, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 48);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(63, 108);
            this.button5.MinimumSize = new System.Drawing.Size(45, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(9, 108);
            this.button4.MinimumSize = new System.Drawing.Size(45, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.LightGray;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonPlus.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(171, 60);
            this.buttonPlus.MinimumSize = new System.Drawing.Size(45, 43);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(54, 48);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button_Operator_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGray;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(117, 60);
            this.button9.MinimumSize = new System.Drawing.Size(45, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 48);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightGray;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(63, 60);
            this.button8.MinimumSize = new System.Drawing.Size(45, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 48);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGray;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(9, 60);
            this.button7.MinimumSize = new System.Drawing.Size(45, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 48);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(117, 156);
            this.button3.MinimumSize = new System.Drawing.Size(45, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxResult.Location = new System.Drawing.Point(12, 26);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(210, 25);
            this.textBoxResult.TabIndex = 17;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // textBoxSub
            // 
            this.textBoxSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSub.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSub.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSub.Location = new System.Drawing.Point(0, 0);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(234, 13);
            this.textBoxSub.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.textBoxSub);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiplied);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDivided);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonEqual);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonDivided;
        private System.Windows.Forms.Button buttonMultiplied;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}

