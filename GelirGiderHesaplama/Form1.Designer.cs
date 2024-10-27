namespace IncomeExpenseTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIncomeType = new System.Windows.Forms.Label();
            this.txtIncomeType = new System.Windows.Forms.TextBox();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.txtExpenseType = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSaveToExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncomeType
            // 
            this.lblIncomeType.AutoSize = true;
            this.lblIncomeType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblIncomeType.Location = new System.Drawing.Point(184, 30);
            this.lblIncomeType.Name = "lblIncomeType";
            this.lblIncomeType.Size = new System.Drawing.Size(88, 21);
            this.lblIncomeType.TabIndex = 0;
            this.lblIncomeType.Text = "Gelir Türü:";
            // 
            // txtIncomeType
            // 
            this.txtIncomeType.Location = new System.Drawing.Point(311, 32);
            this.txtIncomeType.Name = "txtIncomeType";
            this.txtIncomeType.Size = new System.Drawing.Size(200, 20);
            this.txtIncomeType.TabIndex = 1;
            this.txtIncomeType.TextChanged += new System.EventHandler(this.txtIncomeType_TextChanged);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(311, 82);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(200, 20);
            this.txtIncomeAmount.TabIndex = 3;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnAddIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIncome.Location = new System.Drawing.Point(311, 138);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(200, 27);
            this.btnAddIncome.TabIndex = 4;
            this.btnAddIncome.Text = "Gelir Ekle";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.Location = new System.Drawing.Point(311, 209);
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.Size = new System.Drawing.Size(200, 20);
            this.txtExpenseType.TabIndex = 6;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(311, 261);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(200, 20);
            this.txtExpenseAmount.TabIndex = 8;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Location = new System.Drawing.Point(311, 312);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(200, 27);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "Gider Ekle";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(311, 349);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 27);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSaveToExcel
            // 
            this.btnSaveToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnSaveToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToExcel.Location = new System.Drawing.Point(311, 406);
            this.btnSaveToExcel.Name = "btnSaveToExcel";
            this.btnSaveToExcel.Size = new System.Drawing.Size(200, 27);
            this.btnSaveToExcel.TabIndex = 12;
            this.btnSaveToExcel.Text = "Excel\'e Kaydet";
            this.btnSaveToExcel.UseVisualStyleBackColor = false;
            this.btnSaveToExcel.Click += new System.EventHandler(this.btnSaveToExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 463);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(29, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Emirhan Dalgıran\r\nTarafından Eğitim\r\nAmacıyla Yapıldı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 60);
            this.label5.TabIndex = 17;
            this.label5.Text = " Gelir Gider \r\nHesaplayıcı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(184, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gelir Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(184, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gider Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(184, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gider Miktarı:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Elegantthemes-Beautiful-Flat-Money.1024.png");
            this.ımageList1.Images.SetKeyName(1, "Elegantthemes-Beautiful-Flat-Money.32.png");
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblResult.Location = new System.Drawing.Point(185, 359);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(549, 460);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveToExcel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.txtExpenseType);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.txtIncomeAmount);
            this.Controls.Add(this.txtIncomeType);
            this.Controls.Add(this.lblIncomeType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir ve Gider Hesaplayıcı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblIncomeType;
        private System.Windows.Forms.TextBox txtIncomeType;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.TextBox txtExpenseType;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSaveToExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
