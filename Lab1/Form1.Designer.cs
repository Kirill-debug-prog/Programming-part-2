namespace Lab1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Сотрудник = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Language = new System.Windows.Forms.CheckBox();
            this.Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Experience = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Education = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Job_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Full_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._Fule_name = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this._Write = new System.Windows.Forms.Button();
            this.Transfer_ = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Increase_salary = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Сотрудник);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab1.Properties.Resources.Employee;
            this.pictureBox1.Location = new System.Drawing.Point(497, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Сотрудник
            // 
            this.Сотрудник.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Сотрудник.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сотрудник.Location = new System.Drawing.Point(0, 0);
            this.Сотрудник.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.Size = new System.Drawing.Size(1397, 70);
            this.Сотрудник.TabIndex = 0;
            this.Сотрудник.Text = "Сотрудник";
            this.Сотрудник.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 623);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.panel4.Controls.Add(this.Language);
            this.panel4.Controls.Add(this.Add);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.Salary);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Experience);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Year);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Education);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Job_title);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Full_name);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(696, 623);
            this.panel4.TabIndex = 2;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Language.Location = new System.Drawing.Point(235, 409);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(18, 17);
            this.Language.TabIndex = 15;
            this.Language.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(199, 524);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(225, 47);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Знание ИЯ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Зарплата";
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(235, 331);
            this.Salary.Margin = new System.Windows.Forms.Padding(4);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(353, 34);
            this.Salary.TabIndex = 10;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Стаж работы";
            // 
            // Experience
            // 
            this.Experience.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Experience.Location = new System.Drawing.Point(235, 270);
            this.Experience.Margin = new System.Windows.Forms.Padding(4);
            this.Experience.Multiline = true;
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(353, 34);
            this.Experience.TabIndex = 8;
            this.Experience.TextChanged += new System.EventHandler(this.Experience_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Год приема";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(235, 209);
            this.Year.Margin = new System.Windows.Forms.Padding(4);
            this.Year.Multiline = true;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(353, 34);
            this.Year.TabIndex = 6;
            this.Year.TextChanged += new System.EventHandler(this.Year_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Образование";
            // 
            // Education
            // 
            this.Education.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Education.Location = new System.Drawing.Point(235, 148);
            this.Education.Margin = new System.Windows.Forms.Padding(4);
            this.Education.Multiline = true;
            this.Education.Name = "Education";
            this.Education.Size = new System.Drawing.Size(353, 34);
            this.Education.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность";
            // 
            // Job_title
            // 
            this.Job_title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Job_title.Location = new System.Drawing.Point(235, 90);
            this.Job_title.Margin = new System.Windows.Forms.Padding(4);
            this.Job_title.Multiline = true;
            this.Job_title.Name = "Job_title";
            this.Job_title.Size = new System.Drawing.Size(353, 34);
            this.Job_title.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ф.И.О.";
            // 
            // Full_name
            // 
            this.Full_name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Full_name.Location = new System.Drawing.Point(235, 27);
            this.Full_name.Margin = new System.Windows.Forms.Padding(4);
            this.Full_name.Multiline = true;
            this.Full_name.Name = "Full_name";
            this.Full_name.Size = new System.Drawing.Size(353, 34);
            this.Full_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ф.И.О.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 34);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.panel3.Controls.Add(this._Fule_name);
            this.panel3.Controls.Add(this.Data);
            this.panel3.Controls.Add(this.Fire);
            this.panel3.Controls.Add(this._Write);
            this.panel3.Controls.Add(this.Transfer_);
            this.panel3.Controls.Add(this.Increase);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Transfer);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Increase_salary);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(701, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 623);
            this.panel3.TabIndex = 2;
            // 
            // _Fule_name
            // 
            this._Fule_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Fule_name.FlatAppearance.BorderSize = 2;
            this._Fule_name.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this._Fule_name.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this._Fule_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Fule_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Fule_name.Location = new System.Drawing.Point(477, 353);
            this._Fule_name.Margin = new System.Windows.Forms.Padding(4);
            this._Fule_name.Name = "_Fule_name";
            this._Fule_name.Size = new System.Drawing.Size(148, 107);
            this._Fule_name.TabIndex = 13;
            this._Fule_name.Text = "Получить \r\nФ.И.О.";
            this._Fule_name.UseVisualStyleBackColor = true;
            this._Fule_name.Click += new System.EventHandler(this._Fule_name_Click);
            // 
            // Data
            // 
            this.Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data.FlatAppearance.BorderSize = 2;
            this.Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Data.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(237, 351);
            this.Data.Margin = new System.Windows.Forms.Padding(4);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(200, 110);
            this.Data.TabIndex = 12;
            this.Data.Text = "Получить данные \r\nо содруднике";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Fire
            // 
            this.Fire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fire.FlatAppearance.BorderSize = 2;
            this.Fire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Fire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Fire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fire.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fire.Location = new System.Drawing.Point(56, 413);
            this.Fire.Margin = new System.Windows.Forms.Padding(4);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(148, 47);
            this.Fire.TabIndex = 11;
            this.Fire.Text = "Уволить";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // _Write
            // 
            this._Write.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Write.FlatAppearance.BorderSize = 2;
            this._Write.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this._Write.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this._Write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Write.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Write.Location = new System.Drawing.Point(47, 294);
            this._Write.Margin = new System.Windows.Forms.Padding(4);
            this._Write.Name = "_Write";
            this._Write.Size = new System.Drawing.Size(157, 73);
            this._Write.TabIndex = 10;
            this._Write.Text = "Выписать премию";
            this._Write.UseVisualStyleBackColor = true;
            this._Write.Click += new System.EventHandler(this._Write_Click);
            // 
            // Transfer_
            // 
            this.Transfer_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transfer_.FlatAppearance.BorderSize = 0;
            this.Transfer_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Transfer_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Transfer_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transfer_.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transfer_.Location = new System.Drawing.Point(416, 174);
            this.Transfer_.Margin = new System.Windows.Forms.Padding(4);
            this.Transfer_.Name = "Transfer_";
            this.Transfer_.Size = new System.Drawing.Size(148, 47);
            this.Transfer_.TabIndex = 9;
            this.Transfer_.Text = "Перевести ";
            this.Transfer_.UseVisualStyleBackColor = true;
            this.Transfer_.Click += new System.EventHandler(this.Transfer__Click);
            // 
            // Increase
            // 
            this.Increase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Increase.FlatAppearance.BorderSize = 0;
            this.Increase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Increase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increase.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increase.Location = new System.Drawing.Point(416, 69);
            this.Increase.Margin = new System.Windows.Forms.Padding(4);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(148, 47);
            this.Increase.TabIndex = 8;
            this.Increase.Text = "Повысить";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Increase_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(24, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 62);
            this.label10.TabIndex = 5;
            this.label10.Text = "Перевести на \r\nдругую должность";
            // 
            // Transfer
            // 
            this.Transfer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transfer.Location = new System.Drawing.Point(303, 132);
            this.Transfer.Margin = new System.Windows.Forms.Padding(4);
            this.Transfer.Multiline = true;
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(353, 34);
            this.Transfer.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Повысить з/п на ";
            // 
            // Increase_salary
            // 
            this.Increase_salary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increase_salary.Location = new System.Drawing.Point(303, 27);
            this.Increase_salary.Margin = new System.Windows.Forms.Padding(4);
            this.Increase_salary.Multiline = true;
            this.Increase_salary.Name = "Increase_salary";
            this.Increase_salary.Size = new System.Drawing.Size(353, 34);
            this.Increase_salary.TabIndex = 2;
            this.Increase_salary.TextChanged += new System.EventHandler(this.Increase_salary_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 693);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab1 Шкурко Кирилл 8И21";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Сотрудник;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Transfer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Increase_salary;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Transfer_;
        private System.Windows.Forms.Button _Fule_name;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button _Write;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox Language;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Education;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Job_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Full_name;
    }
}

