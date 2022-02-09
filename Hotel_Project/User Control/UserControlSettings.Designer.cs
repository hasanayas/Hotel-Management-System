namespace Hotel_Project.User_Control
{
    partial class UserControlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.müsteriTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel_Project.HotelDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView21 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textTCNO = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textAD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMAİL = new System.Windows.Forms.TextBox();
            this.textSOYAD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textULKE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTEL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView22 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView24 = new System.Windows.Forms.DataGridView();
            this.müsteriTablosuTableAdapter = new Hotel_Project.HotelDataSetTableAdapters.MüsteriTablosuTableAdapter();
            this.çıkışTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ülkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView21)).BeginInit();
            this.tabControlUser.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView22)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView24)).BeginInit();
            this.SuspendLayout();
            // 
            // müsteriTablosuBindingSource
            // 
            this.müsteriTablosuBindingSource.DataMember = "MüsteriTablosu";
            this.müsteriTablosuBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView21);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.textTCNO);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textAD);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textMAİL);
            this.tabPage1.Controls.Add(this.textSOYAD);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textULKE);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textTEL);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1259, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Güncelleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView21
            // 
            this.dataGridView21.AllowUserToAddRows = false;
            this.dataGridView21.AllowUserToDeleteRows = false;
            this.dataGridView21.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView21.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView21.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView21.Location = new System.Drawing.Point(3, 189);
            this.dataGridView21.Name = "dataGridView21";
            this.dataGridView21.ReadOnly = true;
            this.dataGridView21.Size = new System.Drawing.Size(1253, 356);
            this.dataGridView21.TabIndex = 47;
            this.dataGridView21.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView21_CellEnter);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(843, 136);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 36);
            this.buttonUpdate.TabIndex = 46;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri Güncelle";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(768, 103);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tc No";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(442, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 44;
            // 
            // textTCNO
            // 
            this.textTCNO.Location = new System.Drawing.Point(118, 49);
            this.textTCNO.Name = "textTCNO";
            this.textTCNO.Size = new System.Drawing.Size(200, 20);
            this.textTCNO.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(677, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Çıkış Tarihi";
            // 
            // textAD
            // 
            this.textAD.Location = new System.Drawing.Point(442, 49);
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(200, 20);
            this.textAD.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(347, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(677, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Soyad";
            // 
            // textMAİL
            // 
            this.textMAİL.Location = new System.Drawing.Point(768, 77);
            this.textMAİL.Name = "textMAİL";
            this.textMAİL.Size = new System.Drawing.Size(200, 20);
            this.textMAİL.TabIndex = 40;
            // 
            // textSOYAD
            // 
            this.textSOYAD.Location = new System.Drawing.Point(768, 49);
            this.textSOYAD.Name = "textSOYAD";
            this.textSOYAD.Size = new System.Drawing.Size(200, 20);
            this.textSOYAD.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(680, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ülke";
            // 
            // textULKE
            // 
            this.textULKE.Location = new System.Drawing.Point(118, 75);
            this.textULKE.Name = "textULKE";
            this.textULKE.Size = new System.Drawing.Size(200, 20);
            this.textULKE.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Doğum Tarihi";
            // 
            // textTEL
            // 
            this.textTEL.Location = new System.Drawing.Point(442, 76);
            this.textTEL.Name = "textTEL";
            this.textTEL.Size = new System.Drawing.Size(200, 20);
            this.textTEL.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(359, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefon";
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Controls.Add(this.tabPage3);
            this.tabControlUser.Controls.Add(this.tabPage4);
            this.tabControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUser.Location = new System.Drawing.Point(0, 0);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1267, 574);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView22);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1259, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Silme";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView22
            // 
            this.dataGridView22.AllowUserToAddRows = false;
            this.dataGridView22.AllowUserToDeleteRows = false;
            this.dataGridView22.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView22.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView22.Location = new System.Drawing.Point(3, 143);
            this.dataGridView22.Name = "dataGridView22";
            this.dataGridView22.ReadOnly = true;
            this.dataGridView22.Size = new System.Drawing.Size(1253, 402);
            this.dataGridView22.TabIndex = 48;
            this.dataGridView22.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView22_CellEnter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(20, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Silme";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(423, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Silme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(107, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(19, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "TcNO";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnKaydet);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.dataGridView24);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1259, 548);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Arama";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(21, 98);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(217, 33);
            this.btnKaydet.TabIndex = 61;
            this.btnKaydet.Text = "Tüm Kayıtları PDF\'\'ye Aktar";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(21, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 31);
            this.button5.TabIndex = 53;
            this.button5.Text = "Aranan Kayıtları PDF\'ye Aktar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 52;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ad";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label18.Location = new System.Drawing.Point(19, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Müşteri Arama";
            // 
            // dataGridView24
            // 
            this.dataGridView24.AllowUserToAddRows = false;
            this.dataGridView24.AllowUserToDeleteRows = false;
            this.dataGridView24.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView24.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView24.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView24.Location = new System.Drawing.Point(3, 174);
            this.dataGridView24.Name = "dataGridView24";
            this.dataGridView24.ReadOnly = true;
            this.dataGridView24.Size = new System.Drawing.Size(1253, 371);
            this.dataGridView24.TabIndex = 49;
            // 
            // müsteriTablosuTableAdapter
            // 
            this.müsteriTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // çıkışTarihiDataGridViewTextBoxColumn
            // 
            this.çıkışTarihiDataGridViewTextBoxColumn.DataPropertyName = "ÇıkışTarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.HeaderText = "ÇıkışTarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.Name = "çıkışTarihiDataGridViewTextBoxColumn";
            // 
            // girişTarihiDataGridViewTextBoxColumn
            // 
            this.girişTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirişTarihi";
            this.girişTarihiDataGridViewTextBoxColumn.HeaderText = "GirişTarihi";
            this.girişTarihiDataGridViewTextBoxColumn.Name = "girişTarihiDataGridViewTextBoxColumn";
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // ülkeDataGridViewTextBoxColumn
            // 
            this.ülkeDataGridViewTextBoxColumn.DataPropertyName = "Ülke";
            this.ülkeDataGridViewTextBoxColumn.HeaderText = "Ülke";
            this.ülkeDataGridViewTextBoxColumn.Name = "ülkeDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(1267, 574);
            ((System.ComponentModel.ISupportInitialize)(this.müsteriTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView21)).EndInit();
            this.tabControlUser.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView22)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSOYAD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView21;
        private System.Windows.Forms.DataGridView dataGridView22;
        private System.Windows.Forms.BindingSource müsteriTablosuBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.MüsteriTablosuTableAdapter müsteriTablosuTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView24;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox textTCNO;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox textMAİL;
        public System.Windows.Forms.TextBox textULKE;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn çıkışTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ülkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
    }
}
