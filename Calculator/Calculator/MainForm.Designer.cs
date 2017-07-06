namespace Calculator
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SecondOperandTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.FirstOperandTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FractionalButton = new System.Windows.Forms.Button();
            this.CubeExpButton = new System.Windows.Forms.Button();
            this.SquareExpButton = new System.Windows.Forms.Button();
            this.AbsButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.LnButton = new System.Windows.Forms.Button();
            this.ExpButton = new System.Windows.Forms.Button();
            this.CotangensButton = new System.Windows.Forms.Button();
            this.TangensButton = new System.Windows.Forms.Button();
            this.CosinusButton = new System.Windows.Forms.Button();
            this.SinusButton = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonSubstraction = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.CalculateModeGroupBox = new System.Windows.Forms.GroupBox();
            this.TwoOperandsButton = new System.Windows.Forms.RadioButton();
            this.OneOperandButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CalculateModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SecondOperandTextBox);
            this.groupBox1.Controls.Add(this.ResultTextBox);
            this.groupBox1.Controls.Add(this.FirstOperandTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(237, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SecondOperandTextBox
            // 
            this.SecondOperandTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SecondOperandTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondOperandTextBox.Location = new System.Drawing.Point(5, 55);
            this.SecondOperandTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SecondOperandTextBox.Name = "SecondOperandTextBox";
            this.SecondOperandTextBox.Size = new System.Drawing.Size(227, 35);
            this.SecondOperandTextBox.TabIndex = 1;
            this.SecondOperandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondOperandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyHandler);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(5, 98);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(227, 35);
            this.ResultTextBox.TabIndex = 2;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstOperandTextBox
            // 
            this.FirstOperandTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstOperandTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstOperandTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstOperandTextBox.Location = new System.Drawing.Point(5, 13);
            this.FirstOperandTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FirstOperandTextBox.Name = "FirstOperandTextBox";
            this.FirstOperandTextBox.Size = new System.Drawing.Size(227, 35);
            this.FirstOperandTextBox.TabIndex = 0;
            this.FirstOperandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstOperandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyHandler);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FractionalButton);
            this.groupBox2.Controls.Add(this.CubeExpButton);
            this.groupBox2.Controls.Add(this.SquareExpButton);
            this.groupBox2.Controls.Add(this.AbsButton);
            this.groupBox2.Controls.Add(this.SqrtButton);
            this.groupBox2.Controls.Add(this.LnButton);
            this.groupBox2.Controls.Add(this.ExpButton);
            this.groupBox2.Controls.Add(this.CotangensButton);
            this.groupBox2.Controls.Add(this.TangensButton);
            this.groupBox2.Controls.Add(this.CosinusButton);
            this.groupBox2.Controls.Add(this.SinusButton);
            this.groupBox2.Controls.Add(this.ButtonDivision);
            this.groupBox2.Controls.Add(this.ButtonMultiplication);
            this.groupBox2.Controls.Add(this.ButtonSubstraction);
            this.groupBox2.Controls.Add(this.ButtonAddition);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(237, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // FractionalButton
            // 
            this.FractionalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FractionalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.FractionalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.FractionalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FractionalButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FractionalButton.ForeColor = System.Drawing.Color.Black;
            this.FractionalButton.Location = new System.Drawing.Point(122, 190);
            this.FractionalButton.Name = "FractionalButton";
            this.FractionalButton.Size = new System.Drawing.Size(50, 50);
            this.FractionalButton.TabIndex = 14;
            this.FractionalButton.Text = "1/x";
            this.FractionalButton.UseVisualStyleBackColor = true;
            this.FractionalButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // CubeExpButton
            // 
            this.CubeExpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CubeExpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CubeExpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CubeExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CubeExpButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CubeExpButton.ForeColor = System.Drawing.Color.Black;
            this.CubeExpButton.Location = new System.Drawing.Point(66, 190);
            this.CubeExpButton.Name = "CubeExpButton";
            this.CubeExpButton.Size = new System.Drawing.Size(50, 50);
            this.CubeExpButton.TabIndex = 13;
            this.CubeExpButton.Text = "x^3";
            this.CubeExpButton.UseVisualStyleBackColor = true;
            this.CubeExpButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // SquareExpButton
            // 
            this.SquareExpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SquareExpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SquareExpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SquareExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareExpButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareExpButton.ForeColor = System.Drawing.Color.Black;
            this.SquareExpButton.Location = new System.Drawing.Point(9, 190);
            this.SquareExpButton.Name = "SquareExpButton";
            this.SquareExpButton.Size = new System.Drawing.Size(50, 50);
            this.SquareExpButton.TabIndex = 12;
            this.SquareExpButton.Text = "x^2";
            this.SquareExpButton.UseVisualStyleBackColor = true;
            this.SquareExpButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // AbsButton
            // 
            this.AbsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AbsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AbsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AbsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbsButton.ForeColor = System.Drawing.Color.Black;
            this.AbsButton.Location = new System.Drawing.Point(178, 132);
            this.AbsButton.Name = "AbsButton";
            this.AbsButton.Size = new System.Drawing.Size(50, 50);
            this.AbsButton.TabIndex = 11;
            this.AbsButton.Text = "Abs";
            this.AbsButton.UseVisualStyleBackColor = true;
            this.AbsButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // SqrtButton
            // 
            this.SqrtButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SqrtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SqrtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqrtButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqrtButton.ForeColor = System.Drawing.Color.Black;
            this.SqrtButton.Location = new System.Drawing.Point(122, 132);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(50, 50);
            this.SqrtButton.TabIndex = 10;
            this.SqrtButton.Text = "Sqrt";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // LnButton
            // 
            this.LnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.LnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LnButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LnButton.ForeColor = System.Drawing.Color.Black;
            this.LnButton.Location = new System.Drawing.Point(66, 132);
            this.LnButton.Name = "LnButton";
            this.LnButton.Size = new System.Drawing.Size(50, 50);
            this.LnButton.TabIndex = 9;
            this.LnButton.Text = "Ln";
            this.LnButton.UseVisualStyleBackColor = true;
            this.LnButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // ExpButton
            // 
            this.ExpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ExpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpButton.ForeColor = System.Drawing.Color.Black;
            this.ExpButton.Location = new System.Drawing.Point(9, 132);
            this.ExpButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExpButton.Name = "ExpButton";
            this.ExpButton.Size = new System.Drawing.Size(50, 50);
            this.ExpButton.TabIndex = 8;
            this.ExpButton.Text = "Exp";
            this.ExpButton.UseVisualStyleBackColor = true;
            this.ExpButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // CotangensButton
            // 
            this.CotangensButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CotangensButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CotangensButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CotangensButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CotangensButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CotangensButton.ForeColor = System.Drawing.Color.Black;
            this.CotangensButton.Location = new System.Drawing.Point(178, 76);
            this.CotangensButton.Name = "CotangensButton";
            this.CotangensButton.Size = new System.Drawing.Size(50, 50);
            this.CotangensButton.TabIndex = 7;
            this.CotangensButton.Text = "Ctg";
            this.CotangensButton.UseVisualStyleBackColor = true;
            this.CotangensButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // TangensButton
            // 
            this.TangensButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TangensButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TangensButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.TangensButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TangensButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TangensButton.ForeColor = System.Drawing.Color.Black;
            this.TangensButton.Location = new System.Drawing.Point(122, 76);
            this.TangensButton.Name = "TangensButton";
            this.TangensButton.Size = new System.Drawing.Size(50, 50);
            this.TangensButton.TabIndex = 6;
            this.TangensButton.Text = "Tg";
            this.TangensButton.UseVisualStyleBackColor = true;
            this.TangensButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // CosinusButton
            // 
            this.CosinusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CosinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CosinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CosinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosinusButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosinusButton.ForeColor = System.Drawing.Color.Black;
            this.CosinusButton.Location = new System.Drawing.Point(66, 76);
            this.CosinusButton.Name = "CosinusButton";
            this.CosinusButton.Size = new System.Drawing.Size(50, 50);
            this.CosinusButton.TabIndex = 5;
            this.CosinusButton.Text = "Cos";
            this.CosinusButton.UseVisualStyleBackColor = true;
            this.CosinusButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // SinusButton
            // 
            this.SinusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SinusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SinusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinusButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinusButton.ForeColor = System.Drawing.Color.Black;
            this.SinusButton.Location = new System.Drawing.Point(9, 76);
            this.SinusButton.Name = "SinusButton";
            this.SinusButton.Size = new System.Drawing.Size(50, 50);
            this.SinusButton.TabIndex = 4;
            this.SinusButton.Text = "Sin";
            this.SinusButton.UseVisualStyleBackColor = true;
            this.SinusButton.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivision.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivision.ForeColor = System.Drawing.Color.Black;
            this.ButtonDivision.Location = new System.Drawing.Point(178, 18);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(50, 50);
            this.ButtonDivision.TabIndex = 3;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButtonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiplication.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiplication.ForeColor = System.Drawing.Color.Black;
            this.ButtonMultiplication.Location = new System.Drawing.Point(122, 18);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(50, 50);
            this.ButtonMultiplication.TabIndex = 2;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // ButtonSubstraction
            // 
            this.ButtonSubstraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonSubstraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonSubstraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButtonSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubstraction.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSubstraction.ForeColor = System.Drawing.Color.Black;
            this.ButtonSubstraction.Location = new System.Drawing.Point(66, 18);
            this.ButtonSubstraction.Name = "ButtonSubstraction";
            this.ButtonSubstraction.Size = new System.Drawing.Size(50, 50);
            this.ButtonSubstraction.TabIndex = 1;
            this.ButtonSubstraction.Text = "-";
            this.ButtonSubstraction.UseVisualStyleBackColor = true;
            this.ButtonSubstraction.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddition.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddition.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddition.Location = new System.Drawing.Point(9, 18);
            this.ButtonAddition.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(50, 50);
            this.ButtonAddition.TabIndex = 0;
            this.ButtonAddition.Text = "+";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // CalculateModeGroupBox
            // 
            this.CalculateModeGroupBox.Controls.Add(this.TwoOperandsButton);
            this.CalculateModeGroupBox.Controls.Add(this.OneOperandButton);
            this.CalculateModeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateModeGroupBox.Location = new System.Drawing.Point(0, 143);
            this.CalculateModeGroupBox.Name = "CalculateModeGroupBox";
            this.CalculateModeGroupBox.Size = new System.Drawing.Size(237, 51);
            this.CalculateModeGroupBox.TabIndex = 2;
            this.CalculateModeGroupBox.TabStop = false;
            // 
            // TwoOperandsButton
            // 
            this.TwoOperandsButton.AutoSize = true;
            this.TwoOperandsButton.Checked = true;
            this.TwoOperandsButton.Location = new System.Drawing.Point(122, 20);
            this.TwoOperandsButton.Name = "TwoOperandsButton";
            this.TwoOperandsButton.Size = new System.Drawing.Size(97, 17);
            this.TwoOperandsButton.TabIndex = 1;
            this.TwoOperandsButton.TabStop = true;
            this.TwoOperandsButton.Text = "Два операнда";
            this.TwoOperandsButton.UseVisualStyleBackColor = true;
            this.TwoOperandsButton.CheckedChanged += new System.EventHandler(this.TwoOperandsOn);
            // 
            // OneOperandButton
            // 
            this.OneOperandButton.AutoSize = true;
            this.OneOperandButton.Location = new System.Drawing.Point(13, 20);
            this.OneOperandButton.Name = "OneOperandButton";
            this.OneOperandButton.Size = new System.Drawing.Size(96, 17);
            this.OneOperandButton.TabIndex = 0;
            this.OneOperandButton.Text = "Один операнд";
            this.OneOperandButton.UseVisualStyleBackColor = true;
            this.OneOperandButton.CheckedChanged += new System.EventHandler(this.OneOperandOn);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(237, 443);
            this.Controls.Add(this.CalculateModeGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.CalculateModeGroupBox.ResumeLayout(false);
            this.CalculateModeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox FirstOperandTextBox;
        private System.Windows.Forms.TextBox SecondOperandTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FractionalButton;
        private System.Windows.Forms.Button CubeExpButton;
        private System.Windows.Forms.Button SquareExpButton;
        private System.Windows.Forms.Button AbsButton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button LnButton;
        private System.Windows.Forms.Button ExpButton;
        private System.Windows.Forms.Button CotangensButton;
        private System.Windows.Forms.Button TangensButton;
        private System.Windows.Forms.Button CosinusButton;
        private System.Windows.Forms.Button SinusButton;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonSubstraction;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.GroupBox CalculateModeGroupBox;
        private System.Windows.Forms.RadioButton TwoOperandsButton;
        private System.Windows.Forms.RadioButton OneOperandButton;
    }
}

