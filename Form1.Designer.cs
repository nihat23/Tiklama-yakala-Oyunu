namespace Tıklama___yakalama__Oyunu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2artipuan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1Sifirla = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2eksipuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1istegeBagli = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2artipuan
            // 
            this.label2artipuan.AutoSize = true;
            this.label2artipuan.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2artipuan.ForeColor = System.Drawing.Color.Red;
            this.label2artipuan.Location = new System.Drawing.Point(638, 40);
            this.label2artipuan.Name = "label2artipuan";
            this.label2artipuan.Size = new System.Drawing.Size(21, 24);
            this.label2artipuan.TabIndex = 2;
            this.label2artipuan.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1Sifirla
            // 
            this.button1Sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Sifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Sifirla.Location = new System.Drawing.Point(613, 399);
            this.button1Sifirla.Name = "button1Sifirla";
            this.button1Sifirla.Size = new System.Drawing.Size(99, 23);
            this.button1Sifirla.TabIndex = 3;
            this.button1Sifirla.Text = "Yeniden";
            this.button1Sifirla.UseVisualStyleBackColor = true;
            this.button1Sifirla.Click += new System.EventHandler(this.button1Sifirla_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(604, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nihat Beyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2eksipuan
            // 
            this.label2eksipuan.AutoSize = true;
            this.label2eksipuan.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2eksipuan.ForeColor = System.Drawing.Color.Red;
            this.label2eksipuan.Location = new System.Drawing.Point(644, 109);
            this.label2eksipuan.Name = "label2eksipuan";
            this.label2eksipuan.Size = new System.Drawing.Size(21, 24);
            this.label2eksipuan.TabIndex = 5;
            this.label2eksipuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tıklanmayan ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tıklanan ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(636, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = " puan gir";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(613, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // button1istegeBagli
            // 
            this.button1istegeBagli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1istegeBagli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1istegeBagli.Location = new System.Drawing.Point(613, 251);
            this.button1istegeBagli.Name = "button1istegeBagli";
            this.button1istegeBagli.Size = new System.Drawing.Size(115, 37);
            this.button1istegeBagli.TabIndex = 10;
            this.button1istegeBagli.Text = "İstege baglı ";
            this.button1istegeBagli.UseVisualStyleBackColor = true;
            this.button1istegeBagli.Click += new System.EventHandler(this.button1istegeBagli_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(753, 454);
            this.Controls.Add(this.button1istegeBagli);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2eksipuan);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1Sifirla);
            this.Controls.Add(this.label2artipuan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rastgele Tıklamak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2artipuan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1Sifirla;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2eksipuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1istegeBagli;
        private System.Windows.Forms.Timer timer2;
    }
}

