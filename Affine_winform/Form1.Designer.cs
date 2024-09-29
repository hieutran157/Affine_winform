namespace Affine_winform
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
            this.plaintext = new System.Windows.Forms.TextBox();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.keyb = new System.Windows.Forms.TextBox();
            this.keya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.plaintext1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUploadtxt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnUpload1 = new System.Windows.Forms.Button();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.ciphertext1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAttention = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plaintext
            // 
            this.plaintext.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintext.Location = new System.Drawing.Point(39, 60);
            this.plaintext.Margin = new System.Windows.Forms.Padding(4);
            this.plaintext.Multiline = true;
            this.plaintext.Name = "plaintext";
            this.plaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plaintext.Size = new System.Drawing.Size(293, 79);
            this.plaintext.TabIndex = 0;
            this.plaintext.WordWrap = false;
            this.plaintext.TextChanged += new System.EventHandler(this.plaintext_TextChanged);
            // 
            // ciphertext
            // 
            this.ciphertext.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciphertext.Location = new System.Drawing.Point(456, 60);
            this.ciphertext.Margin = new System.Windows.Forms.Padding(4);
            this.ciphertext.Multiline = true;
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ciphertext.Size = new System.Drawing.Size(312, 79);
            this.ciphertext.TabIndex = 1;
            this.ciphertext.WordWrap = false;
            this.ciphertext.TextChanged += new System.EventHandler(this.ciphertext_TextChanged);
            // 
            // keyb
            // 
            this.keyb.Location = new System.Drawing.Point(213, 21);
            this.keyb.Margin = new System.Windows.Forms.Padding(4);
            this.keyb.Name = "keyb";
            this.keyb.Size = new System.Drawing.Size(58, 27);
            this.keyb.TabIndex = 2;
            this.keyb.TextChanged += new System.EventHandler(this.keyb_TextChanged);
            // 
            // keya
            // 
            this.keya.Location = new System.Drawing.Point(64, 21);
            this.keya.Margin = new System.Windows.Forms.Padding(4);
            this.keya.Name = "keya";
            this.keya.Size = new System.Drawing.Size(64, 27);
            this.keya.TabIndex = 3;
            this.keya.TextChanged += new System.EventHandler(this.keya_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Văn bản cần mã hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Văn bản sau khi mã hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "a";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(356, 80);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(84, 47);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
            this.btnEncrypt.MouseEnter += new System.EventHandler(this.btnEncrypt_MouseEnter);
            this.btnEncrypt.MouseLeave += new System.EventHandler(this.btnEncrypt_MouseLeave);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(356, 77);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(88, 47);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            this.btnDecrypt.MouseEnter += new System.EventHandler(this.btnDecrypt_MouseEnter);
            this.btnDecrypt.MouseLeave += new System.EventHandler(this.btnDecrypt_MouseLeave);
            // 
            // plaintext1
            // 
            this.plaintext1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintext1.Location = new System.Drawing.Point(457, 63);
            this.plaintext1.Margin = new System.Windows.Forms.Padding(4);
            this.plaintext1.Multiline = true;
            this.plaintext1.Name = "plaintext1";
            this.plaintext1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plaintext1.Size = new System.Drawing.Size(311, 85);
            this.plaintext1.TabIndex = 10;
            this.plaintext1.WordWrap = false;
            this.plaintext1.TextChanged += new System.EventHandler(this.plaintext1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Văn bản sau khi giải mã";
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Location = new System.Drawing.Point(850, 113);
            this.txtAlphabet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlphabet.Multiline = true;
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(267, 195);
            this.txtAlphabet.TabIndex = 13;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(932, 331);
            this.txtm.Margin = new System.Windows.Forms.Padding(4);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 25);
            this.txtm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(846, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bảng ký tự";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(850, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số ký tự";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUploadtxt);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.plaintext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ciphertext);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(794, 199);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa Affine";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 41);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnUploadtxt
            // 
            this.btnUploadtxt.Location = new System.Drawing.Point(257, 21);
            this.btnUploadtxt.Name = "btnUploadtxt";
            this.btnUploadtxt.Size = new System.Drawing.Size(75, 35);
            this.btnUploadtxt.TabIndex = 16;
            this.btnUploadtxt.Text = "Open";
            this.btnUploadtxt.UseVisualStyleBackColor = true;
            this.btnUploadtxt.Click += new System.EventHandler(this.btnUploadtxt_Click);
            this.btnUploadtxt.MouseEnter += new System.EventHandler(this.btnUploadtxt_MouseEnter);
            this.btnUploadtxt.MouseLeave += new System.EventHandler(this.btnUploadtxt_MouseLeave);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(674, 143);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(94, 41);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseEnter += new System.EventHandler(this.btnCopy_MouseEnter);
            this.btnCopy.MouseLeave += new System.EventHandler(this.btnCopy_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(39, 147);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 44);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.btnRandom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.keyb);
            this.groupBox2.Controls.Add(this.keya);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(306, 99);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khóa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(187, 63);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(84, 28);
            this.btnReset2.TabIndex = 10;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            this.btnReset2.MouseEnter += new System.EventHandler(this.btnReset2_MouseEnter);
            this.btnReset2.MouseLeave += new System.EventHandler(this.btnReset2_MouseLeave);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(64, 63);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(83, 28);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            this.btnRandom.MouseEnter += new System.EventHandler(this.btnRandom_MouseEnter);
            this.btnRandom.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lime;
            this.groupBox3.Controls.Add(this.btnSave1);
            this.groupBox3.Controls.Add(this.btnUpload1);
            this.groupBox3.Controls.Add(this.btnCopy1);
            this.groupBox3.Controls.Add(this.btnReset1);
            this.groupBox3.Controls.Add(this.ciphertext1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.plaintext1);
            this.groupBox3.Controls.Add(this.btnDecrypt);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 217);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giải mã Affine";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(456, 155);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(97, 41);
            this.btnSave1.TabIndex = 28;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            this.btnSave1.MouseEnter += new System.EventHandler(this.btnSave1_MouseEnter);
            this.btnSave1.MouseLeave += new System.EventHandler(this.btnSave1_MouseLeave);
            // 
            // btnUpload1
            // 
            this.btnUpload1.Location = new System.Drawing.Point(257, 24);
            this.btnUpload1.Name = "btnUpload1";
            this.btnUpload1.Size = new System.Drawing.Size(75, 35);
            this.btnUpload1.TabIndex = 27;
            this.btnUpload1.Text = "Open";
            this.btnUpload1.UseVisualStyleBackColor = true;
            this.btnUpload1.Click += new System.EventHandler(this.btnUpload1_Click);
            this.btnUpload1.MouseEnter += new System.EventHandler(this.btnUpload1_MouseEnter);
            this.btnUpload1.MouseLeave += new System.EventHandler(this.btnUpload1_MouseLeave);
            // 
            // btnCopy1
            // 
            this.btnCopy1.Location = new System.Drawing.Point(674, 153);
            this.btnCopy1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(94, 41);
            this.btnCopy1.TabIndex = 26;
            this.btnCopy1.Text = "Copy";
            this.btnCopy1.UseVisualStyleBackColor = true;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            this.btnCopy1.MouseEnter += new System.EventHandler(this.btnCopy1_MouseEnter);
            this.btnCopy1.MouseLeave += new System.EventHandler(this.btnCopy1_MouseLeave);
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(39, 153);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(88, 44);
            this.btnReset1.TabIndex = 25;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            this.btnReset1.MouseEnter += new System.EventHandler(this.btnReset1_MouseEnter);
            this.btnReset1.MouseLeave += new System.EventHandler(this.btnReset1_MouseLeave);
            // 
            // ciphertext1
            // 
            this.ciphertext1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciphertext1.Location = new System.Drawing.Point(39, 63);
            this.ciphertext1.Margin = new System.Windows.Forms.Padding(4);
            this.ciphertext1.Multiline = true;
            this.ciphertext1.Name = "ciphertext1";
            this.ciphertext1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ciphertext1.Size = new System.Drawing.Size(293, 85);
            this.ciphertext1.TabIndex = 16;
            this.ciphertext1.WordWrap = false;
            this.ciphertext1.TextChanged += new System.EventHandler(this.ciphertext1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Văn bản cần giải mã";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Controls.Add(this.txtAttention);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(360, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 100);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chú ý!!!";
            // 
            // txtAttention
            // 
            this.txtAttention.Location = new System.Drawing.Point(6, 25);
            this.txtAttention.Multiline = true;
            this.txtAttention.Name = "txtAttention";
            this.txtAttention.Size = new System.Drawing.Size(451, 67);
            this.txtAttention.TabIndex = 0;
            this.txtAttention.Text = "+) b là các số nguyên\r\n+) a là các số nguyên dương\r\n+) a và 229 có ước chung lớn " +
    "nhất là 1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(891, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 62);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 44);
            this.panel1.TabIndex = 26;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(9, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1027, 25);
            this.label.TabIndex = 0;
            this.label.Text = "XIN CHÀO! ĐÂY LÀ PHẦN MỀM MÃ HÓA VÀ GIẢI MÃ SỬ DỤNG THUẬT TOÁN MẬT MÃ AFFINE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(891, 476);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(146, 61);
            this.btnClearData.TabIndex = 27;
            this.btnClearData.Text = "CLEAR DATA";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            this.btnClearData.MouseEnter += new System.EventHandler(this.btnClearData_MouseEnter);
            this.btnClearData.MouseLeave += new System.EventHandler(this.btnClearData_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 29);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinToolStripMenuItem.Image = global::Affine_winform.Properties.Resources.info;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Affine_winform.Properties.Resources.background_matma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 678);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtAlphabet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mật mã Affine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintext;
        private System.Windows.Forms.TextBox ciphertext;
        private System.Windows.Forms.TextBox keyb;
        private System.Windows.Forms.TextBox keya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox plaintext1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.TextBox ciphertext1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAttention;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUploadtxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnUpload1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Button btnReset2;
    }
}

