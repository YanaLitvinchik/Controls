namespace Game
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SellPeopletrackBar1 = new System.Windows.Forms.TrackBar();
            this.AttacktrackBar2 = new System.Windows.Forms.TrackBar();
            this.HiretrackBar3 = new System.Windows.Forms.TrackBar();
            this.Sellbutton1 = new System.Windows.Forms.Button();
            this.Hirebutton2 = new System.Windows.Forms.Button();
            this.Attackbutton3 = new System.Windows.Forms.Button();
            this.HumantextBox1 = new System.Windows.Forms.TextBox();
            this.WarrioustextBox2 = new System.Windows.Forms.TextBox();
            this.MoneytextBox3 = new System.Windows.Forms.TextBox();
            this.Hirelabel8 = new System.Windows.Forms.Label();
            this.Attacklabel9 = new System.Windows.Forms.Label();
            this.Selllabel7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SellPeopletrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttacktrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiretrackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Human :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warrious :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Money :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sell people";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hire people";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Attack";
            // 
            // SellPeopletrackBar1
            // 
            this.SellPeopletrackBar1.Location = new System.Drawing.Point(73, 244);
            this.SellPeopletrackBar1.Maximum = 100;
            this.SellPeopletrackBar1.Name = "SellPeopletrackBar1";
            this.SellPeopletrackBar1.Size = new System.Drawing.Size(147, 45);
            this.SellPeopletrackBar1.TabIndex = 8;
            this.SellPeopletrackBar1.Scroll += new System.EventHandler(this.SellPeopletrackBar1_Scroll);
            this.SellPeopletrackBar1.ValueChanged += new System.EventHandler(this.SellPeopletrackBar1_ValueChanged);
            // 
            // AttacktrackBar2
            // 
            this.AttacktrackBar2.Location = new System.Drawing.Point(73, 409);
            this.AttacktrackBar2.Name = "AttacktrackBar2";
            this.AttacktrackBar2.Size = new System.Drawing.Size(147, 45);
            this.AttacktrackBar2.TabIndex = 9;
            // 
            // HiretrackBar3
            // 
            this.HiretrackBar3.Location = new System.Drawing.Point(73, 332);
            this.HiretrackBar3.Name = "HiretrackBar3";
            this.HiretrackBar3.Size = new System.Drawing.Size(147, 45);
            this.HiretrackBar3.TabIndex = 10;
            // 
            // Sellbutton1
            // 
            this.Sellbutton1.Location = new System.Drawing.Point(226, 244);
            this.Sellbutton1.Name = "Sellbutton1";
            this.Sellbutton1.Size = new System.Drawing.Size(75, 23);
            this.Sellbutton1.TabIndex = 11;
            this.Sellbutton1.Text = "OK";
            this.Sellbutton1.UseVisualStyleBackColor = true;
            this.Sellbutton1.Click += new System.EventHandler(this.Sellbutton1_Click);
            // 
            // Hirebutton2
            // 
            this.Hirebutton2.Location = new System.Drawing.Point(228, 332);
            this.Hirebutton2.Name = "Hirebutton2";
            this.Hirebutton2.Size = new System.Drawing.Size(75, 23);
            this.Hirebutton2.TabIndex = 12;
            this.Hirebutton2.Text = "OK";
            this.Hirebutton2.UseVisualStyleBackColor = true;
            this.Hirebutton2.Click += new System.EventHandler(this.Hirebutton2_Click);
            // 
            // Attackbutton3
            // 
            this.Attackbutton3.Location = new System.Drawing.Point(228, 409);
            this.Attackbutton3.Name = "Attackbutton3";
            this.Attackbutton3.Size = new System.Drawing.Size(75, 23);
            this.Attackbutton3.TabIndex = 13;
            this.Attackbutton3.Text = "OK";
            this.Attackbutton3.UseVisualStyleBackColor = true;
            this.Attackbutton3.Click += new System.EventHandler(this.Attackbutton3_Click);
            // 
            // HumantextBox1
            // 
            this.HumantextBox1.Location = new System.Drawing.Point(107, 75);
            this.HumantextBox1.Name = "HumantextBox1";
            this.HumantextBox1.Size = new System.Drawing.Size(100, 20);
            this.HumantextBox1.TabIndex = 14;
            this.HumantextBox1.TextChanged += new System.EventHandler(this.HumantextBox1_TextChanged);
            // 
            // WarrioustextBox2
            // 
            this.WarrioustextBox2.Location = new System.Drawing.Point(107, 120);
            this.WarrioustextBox2.Name = "WarrioustextBox2";
            this.WarrioustextBox2.Size = new System.Drawing.Size(100, 20);
            this.WarrioustextBox2.TabIndex = 15;
            // 
            // MoneytextBox3
            // 
            this.MoneytextBox3.Location = new System.Drawing.Point(107, 162);
            this.MoneytextBox3.Name = "MoneytextBox3";
            this.MoneytextBox3.Size = new System.Drawing.Size(100, 20);
            this.MoneytextBox3.TabIndex = 16;
            // 
            // Hirelabel8
            // 
            this.Hirelabel8.AutoSize = true;
            this.Hirelabel8.Location = new System.Drawing.Point(181, 316);
            this.Hirelabel8.Name = "Hirelabel8";
            this.Hirelabel8.Size = new System.Drawing.Size(13, 13);
            this.Hirelabel8.TabIndex = 18;
            this.Hirelabel8.Text = "0";
            // 
            // Attacklabel9
            // 
            this.Attacklabel9.AutoSize = true;
            this.Attacklabel9.Location = new System.Drawing.Point(181, 393);
            this.Attacklabel9.Name = "Attacklabel9";
            this.Attacklabel9.Size = new System.Drawing.Size(13, 13);
            this.Attacklabel9.TabIndex = 19;
            this.Attacklabel9.Text = "0";
            // 
            // Selllabel7
            // 
            this.Selllabel7.AutoSize = true;
            this.Selllabel7.Location = new System.Drawing.Point(181, 228);
            this.Selllabel7.Name = "Selllabel7";
            this.Selllabel7.Size = new System.Drawing.Size(13, 13);
            this.Selllabel7.TabIndex = 20;
            this.Selllabel7.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 474);
            this.Controls.Add(this.Selllabel7);
            this.Controls.Add(this.Attacklabel9);
            this.Controls.Add(this.Hirelabel8);
            this.Controls.Add(this.MoneytextBox3);
            this.Controls.Add(this.WarrioustextBox2);
            this.Controls.Add(this.HumantextBox1);
            this.Controls.Add(this.Attackbutton3);
            this.Controls.Add(this.Hirebutton2);
            this.Controls.Add(this.Sellbutton1);
            this.Controls.Add(this.HiretrackBar3);
            this.Controls.Add(this.AttacktrackBar2);
            this.Controls.Add(this.SellPeopletrackBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SellPeopletrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttacktrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiretrackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar SellPeopletrackBar1;
        private System.Windows.Forms.TrackBar AttacktrackBar2;
        private System.Windows.Forms.TrackBar HiretrackBar3;
        private System.Windows.Forms.Button Sellbutton1;
        private System.Windows.Forms.Button Hirebutton2;
        private System.Windows.Forms.Button Attackbutton3;
        private System.Windows.Forms.TextBox HumantextBox1;
        private System.Windows.Forms.TextBox WarrioustextBox2;
        private System.Windows.Forms.TextBox MoneytextBox3;
        private System.Windows.Forms.Label Hirelabel8;
        private System.Windows.Forms.Label Attacklabel9;
        private System.Windows.Forms.Label Selllabel7;
    }
}

