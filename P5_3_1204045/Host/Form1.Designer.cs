namespace Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.npm = new P5_3_1204045.NumericTextBox();
            this.nama = new CharTextBox.CharTextBox();
            this.pria = new System.Windows.Forms.RadioButton();
            this.wanita = new System.Windows.Forms.RadioButton();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.matkul = new System.Windows.Forms.Button();
            this.prodi = new System.Windows.Forms.ComboBox();
            this.sems = new P5_3_1204045.NumericTextBox();
            this.tahun = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.wrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.correct = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kur06RB = new System.Windows.Forms.RadioButton();
            this.Kur10RB = new System.Windows.Forms.RadioButton();
            this.Kur14RB = new System.Windows.Forms.RadioButton();
            this.MatematikaCB = new System.Windows.Forms.CheckBox();
            this.Pemrog1CB = new System.Windows.Forms.CheckBox();
            this.Pemrog2CB = new System.Windows.Forms.CheckBox();
            this.Pemrog3CB = new System.Windows.Forms.CheckBox();
            this.Pemrog4CB = new System.Windows.Forms.CheckBox();
            this.Pemrog5CB = new System.Windows.Forms.CheckBox();
            this.Pemrog6CB = new System.Windows.Forms.CheckBox();
            this.Pemrog7CB = new System.Windows.Forms.CheckBox();
            this.PLCB = new System.Windows.Forms.CheckBox();
            this.JarkomCB = new System.Windows.Forms.CheckBox();
            this.MRPCB = new System.Windows.Forms.CheckBox();
            this.SisOpCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilihan Mata Kuliah Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(154, 112);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(200, 20);
            this.npm.TabIndex = 5;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(154, 172);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(200, 20);
            this.nama.TabIndex = 6;
            // 
            // pria
            // 
            this.pria.AutoSize = true;
            this.pria.Location = new System.Drawing.Point(154, 226);
            this.pria.Name = "pria";
            this.pria.Size = new System.Drawing.Size(43, 17);
            this.pria.TabIndex = 7;
            this.pria.TabStop = true;
            this.pria.Text = "Pria";
            this.pria.UseVisualStyleBackColor = true;
            // 
            // wanita
            // 
            this.wanita.AutoSize = true;
            this.wanita.Location = new System.Drawing.Point(221, 226);
            this.wanita.Name = "wanita";
            this.wanita.Size = new System.Drawing.Size(59, 17);
            this.wanita.TabIndex = 8;
            this.wanita.TabStop = true;
            this.wanita.Text = "Wanita";
            this.wanita.UseVisualStyleBackColor = true;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(154, 272);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(200, 20);
            this.alamat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Semester";
            // 
            // matkul
            // 
            this.matkul.Location = new System.Drawing.Point(511, 269);
            this.matkul.Name = "matkul";
            this.matkul.Size = new System.Drawing.Size(106, 23);
            this.matkul.TabIndex = 13;
            this.matkul.Text = "Pilih Mata Kuliah";
            this.matkul.UseVisualStyleBackColor = true;
            this.matkul.Click += new System.EventHandler(this.matkul_Click);
            // 
            // prodi
            // 
            this.prodi.FormattingEnabled = true;
            this.prodi.Items.AddRange(new object[] {
            "D4 Teknik Informatika"});
            this.prodi.Location = new System.Drawing.Point(511, 111);
            this.prodi.Name = "prodi";
            this.prodi.Size = new System.Drawing.Size(200, 21);
            this.prodi.TabIndex = 14;
            this.prodi.Text = "– Pilih Program Studi –";
            // 
            // sems
            // 
            this.sems.Location = new System.Drawing.Point(511, 223);
            this.sems.Name = "sems";
            this.sems.Size = new System.Drawing.Size(200, 20);
            this.sems.TabIndex = 16;
            // 
            // tahun
            // 
            this.tahun.Location = new System.Drawing.Point(511, 171);
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(200, 20);
            this.tahun.TabIndex = 17;
            this.tahun.TextChanged += new System.EventHandler(this.tahun_TextChanged);
            // 
            // warning
            // 
            this.warning.ContainerControl = this;
            this.warning.Icon = ((System.Drawing.Icon)(resources.GetObject("warning.Icon")));
            // 
            // wrong
            // 
            this.wrong.ContainerControl = this;
            this.wrong.Icon = ((System.Drawing.Icon)(resources.GetObject("wrong.Icon")));
            // 
            // correct
            // 
            this.correct.ContainerControl = this;
            this.correct.Icon = ((System.Drawing.Icon)(resources.GetObject("correct.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kur14RB);
            this.groupBox1.Controls.Add(this.Kur10RB);
            this.groupBox1.Controls.Add(this.Kur06RB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Kurikulum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SisOpCB);
            this.groupBox2.Controls.Add(this.MRPCB);
            this.groupBox2.Controls.Add(this.JarkomCB);
            this.groupBox2.Controls.Add(this.PLCB);
            this.groupBox2.Controls.Add(this.Pemrog7CB);
            this.groupBox2.Controls.Add(this.Pemrog6CB);
            this.groupBox2.Controls.Add(this.Pemrog5CB);
            this.groupBox2.Controls.Add(this.Pemrog4CB);
            this.groupBox2.Controls.Add(this.Pemrog3CB);
            this.groupBox2.Controls.Add(this.Pemrog2CB);
            this.groupBox2.Controls.Add(this.Pemrog1CB);
            this.groupBox2.Controls.Add(this.MatematikaCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(308, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 139);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Kuliah Pilihan";
            // 
            // Kur06RB
            // 
            this.Kur06RB.AutoSize = true;
            this.Kur06RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kur06RB.Location = new System.Drawing.Point(17, 28);
            this.Kur06RB.Name = "Kur06RB";
            this.Kur06RB.Size = new System.Drawing.Size(98, 17);
            this.Kur06RB.TabIndex = 0;
            this.Kur06RB.TabStop = true;
            this.Kur06RB.Text = "Kurikulum 2006";
            this.Kur06RB.UseVisualStyleBackColor = true;
            this.Kur06RB.CheckedChanged += new System.EventHandler(this.Kur06RB_CheckedChanged);
            // 
            // Kur10RB
            // 
            this.Kur10RB.AutoSize = true;
            this.Kur10RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kur10RB.Location = new System.Drawing.Point(17, 51);
            this.Kur10RB.Name = "Kur10RB";
            this.Kur10RB.Size = new System.Drawing.Size(98, 17);
            this.Kur10RB.TabIndex = 1;
            this.Kur10RB.TabStop = true;
            this.Kur10RB.Text = "Kurikulum 2010";
            this.Kur10RB.UseVisualStyleBackColor = true;
            this.Kur10RB.CheckedChanged += new System.EventHandler(this.Kur10RB_CheckedChanged);
            // 
            // Kur14RB
            // 
            this.Kur14RB.AutoSize = true;
            this.Kur14RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kur14RB.Location = new System.Drawing.Point(17, 74);
            this.Kur14RB.Name = "Kur14RB";
            this.Kur14RB.Size = new System.Drawing.Size(98, 17);
            this.Kur14RB.TabIndex = 2;
            this.Kur14RB.TabStop = true;
            this.Kur14RB.Text = "Kurikulum 2014";
            this.Kur14RB.UseVisualStyleBackColor = true;
            this.Kur14RB.CheckedChanged += new System.EventHandler(this.Kur14RB_CheckedChanged);
            // 
            // MatematikaCB
            // 
            this.MatematikaCB.AutoSize = true;
            this.MatematikaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatematikaCB.Location = new System.Drawing.Point(15, 28);
            this.MatematikaCB.Name = "MatematikaCB";
            this.MatematikaCB.Size = new System.Drawing.Size(81, 17);
            this.MatematikaCB.TabIndex = 0;
            this.MatematikaCB.Text = "Matematika";
            this.MatematikaCB.UseVisualStyleBackColor = true;
            // 
            // Pemrog1CB
            // 
            this.Pemrog1CB.AutoSize = true;
            this.Pemrog1CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog1CB.Location = new System.Drawing.Point(15, 51);
            this.Pemrog1CB.Name = "Pemrog1CB";
            this.Pemrog1CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog1CB.TabIndex = 1;
            this.Pemrog1CB.Text = "Pemrograman 1";
            this.Pemrog1CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog2CB
            // 
            this.Pemrog2CB.AutoSize = true;
            this.Pemrog2CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog2CB.Location = new System.Drawing.Point(15, 74);
            this.Pemrog2CB.Name = "Pemrog2CB";
            this.Pemrog2CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog2CB.TabIndex = 2;
            this.Pemrog2CB.Text = "Pemrograman 2";
            this.Pemrog2CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog3CB
            // 
            this.Pemrog3CB.AutoSize = true;
            this.Pemrog3CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog3CB.Location = new System.Drawing.Point(15, 98);
            this.Pemrog3CB.Name = "Pemrog3CB";
            this.Pemrog3CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog3CB.TabIndex = 3;
            this.Pemrog3CB.Text = "Pemrograman 3";
            this.Pemrog3CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog4CB
            // 
            this.Pemrog4CB.AutoSize = true;
            this.Pemrog4CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog4CB.Location = new System.Drawing.Point(138, 28);
            this.Pemrog4CB.Name = "Pemrog4CB";
            this.Pemrog4CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog4CB.TabIndex = 4;
            this.Pemrog4CB.Text = "Pemrograman 4";
            this.Pemrog4CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog5CB
            // 
            this.Pemrog5CB.AutoSize = true;
            this.Pemrog5CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog5CB.Location = new System.Drawing.Point(138, 51);
            this.Pemrog5CB.Name = "Pemrog5CB";
            this.Pemrog5CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog5CB.TabIndex = 5;
            this.Pemrog5CB.Text = "Pemrograman 5";
            this.Pemrog5CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog6CB
            // 
            this.Pemrog6CB.AutoSize = true;
            this.Pemrog6CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog6CB.Location = new System.Drawing.Point(138, 74);
            this.Pemrog6CB.Name = "Pemrog6CB";
            this.Pemrog6CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog6CB.TabIndex = 6;
            this.Pemrog6CB.Text = "Pemrograman 6";
            this.Pemrog6CB.UseVisualStyleBackColor = true;
            // 
            // Pemrog7CB
            // 
            this.Pemrog7CB.AutoSize = true;
            this.Pemrog7CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemrog7CB.Location = new System.Drawing.Point(138, 98);
            this.Pemrog7CB.Name = "Pemrog7CB";
            this.Pemrog7CB.Size = new System.Drawing.Size(100, 17);
            this.Pemrog7CB.TabIndex = 7;
            this.Pemrog7CB.Text = "Pemrograman 7";
            this.Pemrog7CB.UseVisualStyleBackColor = true;
            // 
            // PLCB
            // 
            this.PLCB.AutoSize = true;
            this.PLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLCB.Location = new System.Drawing.Point(255, 28);
            this.PLCB.Name = "PLCB";
            this.PLCB.Size = new System.Drawing.Size(114, 17);
            this.PLCB.TabIndex = 8;
            this.PLCB.Text = "Pengantar Logistik";
            this.PLCB.UseVisualStyleBackColor = true;
            // 
            // JarkomCB
            // 
            this.JarkomCB.AutoSize = true;
            this.JarkomCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JarkomCB.Location = new System.Drawing.Point(255, 52);
            this.JarkomCB.Name = "JarkomCB";
            this.JarkomCB.Size = new System.Drawing.Size(114, 17);
            this.JarkomCB.TabIndex = 9;
            this.JarkomCB.Text = "Jaringan Komputer";
            this.JarkomCB.UseVisualStyleBackColor = true;
            // 
            // MRPCB
            // 
            this.MRPCB.AutoSize = true;
            this.MRPCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRPCB.Location = new System.Drawing.Point(255, 98);
            this.MRPCB.Name = "MRPCB";
            this.MRPCB.Size = new System.Drawing.Size(148, 17);
            this.MRPCB.TabIndex = 10;
            this.MRPCB.Text = "Manajemen Rantai Pasok";
            this.MRPCB.UseVisualStyleBackColor = true;
            // 
            // SisOpCB
            // 
            this.SisOpCB.AutoSize = true;
            this.SisOpCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisOpCB.Location = new System.Drawing.Point(255, 74);
            this.SisOpCB.Name = "SisOpCB";
            this.SisOpCB.Size = new System.Drawing.Size(96, 17);
            this.SisOpCB.TabIndex = 11;
            this.SisOpCB.Text = "Sistem Operasi";
            this.SisOpCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tahun);
            this.Controls.Add(this.sems);
            this.Controls.Add(this.prodi);
            this.Controls.Add(this.matkul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.wanita);
            this.Controls.Add(this.pria);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.npm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private P5_3_1204045.NumericTextBox npm;
        private CharTextBox.CharTextBox nama;
        private System.Windows.Forms.RadioButton pria;
        private System.Windows.Forms.RadioButton wanita;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button matkul;
        private System.Windows.Forms.ComboBox prodi;
        private P5_3_1204045.NumericTextBox sems;
        private System.Windows.Forms.TextBox tahun;
        private System.Windows.Forms.ErrorProvider warning;
        private System.Windows.Forms.ErrorProvider wrong;
        private System.Windows.Forms.ErrorProvider correct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Kur14RB;
        private System.Windows.Forms.RadioButton Kur10RB;
        private System.Windows.Forms.RadioButton Kur06RB;
        private System.Windows.Forms.CheckBox MRPCB;
        private System.Windows.Forms.CheckBox JarkomCB;
        private System.Windows.Forms.CheckBox PLCB;
        private System.Windows.Forms.CheckBox Pemrog7CB;
        private System.Windows.Forms.CheckBox Pemrog6CB;
        private System.Windows.Forms.CheckBox Pemrog5CB;
        private System.Windows.Forms.CheckBox Pemrog4CB;
        private System.Windows.Forms.CheckBox Pemrog3CB;
        private System.Windows.Forms.CheckBox Pemrog2CB;
        private System.Windows.Forms.CheckBox Pemrog1CB;
        private System.Windows.Forms.CheckBox MatematikaCB;
        private System.Windows.Forms.CheckBox SisOpCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

