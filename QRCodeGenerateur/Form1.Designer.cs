namespace QRCodeGenerateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generatedText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eccMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.barCodeImg = new System.Windows.Forms.PictureBox();
            this.saveQr = new System.Windows.Forms.Button();
            this.saveBar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(522, 364);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(150, 40);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.EnabledChanged += new System.EventHandler(this.generatedText_TextChanged);
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generatedText
            // 
            this.generatedText.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedText.Location = new System.Drawing.Point(79, 365);
            this.generatedText.MaxLength = 3276720;
            this.generatedText.Name = "generatedText";
            this.generatedText.Size = new System.Drawing.Size(437, 40);
            this.generatedText.TabIndex = 2;
            this.generatedText.TextChanged += new System.EventHandler(this.generatedText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "QR && Bar Code Generator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eccMenu
            // 
            this.eccMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.eccMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eccMenu.BackColor = System.Drawing.SystemColors.Window;
            this.eccMenu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eccMenu.FormattingEnabled = true;
            this.eccMenu.Items.AddRange(new object[] {
            "L   (07%)",
            "M (15%)",
            "Q (25%)",
            "H (30%)"});
            this.eccMenu.Location = new System.Drawing.Point(496, 74);
            this.eccMenu.Name = "eccMenu";
            this.eccMenu.Size = new System.Drawing.Size(176, 31);
            this.eccMenu.TabIndex = 5;
            this.eccMenu.SelectedIndexChanged += new System.EventHandler(this.eccMenu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Erroc Correction";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "ECI Mode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Default",
            "UTF-8",
            "ISO8859"});
            this.comboBox2.Location = new System.Drawing.Point(445, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 31);
            this.comboBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "QR Version";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Version 01\t(21*21)",
            "Version 02\t(25*25)",
            "Version 03\t(29*29)",
            "Version 04\t(33*33)",
            "Version 05\t(37*37)",
            "Version 06\t(41*41)",
            "Version 07\t(45*45)",
            "Version 08\t(49*49)",
            "Version 09\t(53*53)",
            "Version 10\t(57*57)",
            "Version 11\t(61*61)",
            "Version 12\t(65*65)",
            "Version 13\t(69*69)",
            "Version 14\t(73*73)",
            "Version 15\t(77*77)",
            "Version 16\t(81*81)",
            "Version 17\t(85*85)",
            "Version 18\t(89*89)",
            "Version 19\t(93*93)",
            "Version 20\t(97*97)",
            "Version 21\t(101*101)",
            "Version 22\t(105*105)",
            "Version 23\t(109*109)",
            "Version 24\t(113*113)",
            "Version 25\t(117*117)",
            "Version 26\t(121*121)",
            "Version 27\t(125*125)",
            "Version 28\t(129*129)",
            "Version 29\t(133*133)",
            "Version 30\t(137*137)",
            "Version 31\t(141*141)",
            "Version 32\t(145*145)",
            "Version 33\t(149*149)",
            "Version 34\t(153*153)",
            "Version 35\t(157*157)",
            "Version 36\t(161*161)",
            "Version 37\t(165*165)",
            "Version 38\t(169*169)",
            "Version 39\t(173*173)",
            "Version 40\t(177*177)"});
            this.comboBox1.Location = new System.Drawing.Point(445, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 31);
            this.comboBox1.TabIndex = 9;
            // 
            // barCodeImg
            // 
            this.barCodeImg.ErrorImage = null;
            this.barCodeImg.Location = new System.Drawing.Point(357, 246);
            this.barCodeImg.Name = "barCodeImg";
            this.barCodeImg.Size = new System.Drawing.Size(300, 69);
            this.barCodeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barCodeImg.TabIndex = 11;
            this.barCodeImg.TabStop = false;
            // 
            // saveQr
            // 
            this.saveQr.BackColor = System.Drawing.SystemColors.Window;
            this.saveQr.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQr.Location = new System.Drawing.Point(121, 321);
            this.saveQr.Name = "saveQr";
            this.saveQr.Size = new System.Drawing.Size(90, 35);
            this.saveQr.TabIndex = 12;
            this.saveQr.Text = "Save ";
            this.saveQr.UseVisualStyleBackColor = false;
            this.saveQr.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveBar
            // 
            this.saveBar.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBar.Location = new System.Drawing.Point(462, 321);
            this.saveBar.Name = "saveBar";
            this.saveBar.Size = new System.Drawing.Size(90, 35);
            this.saveBar.TabIndex = 13;
            this.saveBar.Text = "Save ";
            this.saveBar.UseVisualStyleBackColor = true;
            this.saveBar.Click += new System.EventHandler(this.saveBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.saveBar);
            this.Controls.Add(this.saveQr);
            this.Controls.Add(this.barCodeImg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eccMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generatedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCodeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generatedText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eccMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox barCodeImg;
        private System.Windows.Forms.Button saveQr;
        private System.Windows.Forms.Button saveBar;
    }
}

