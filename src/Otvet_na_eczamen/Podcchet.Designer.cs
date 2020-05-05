namespace Otvet_na_eczamen
{
    partial class Podcchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podcchet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.znaX = new System.Windows.Forms.TextBox();
            this.znaY = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proverka = new System.Windows.Forms.Label();
            this.otvet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // znaX
            // 
            this.znaX.Location = new System.Drawing.Point(41, 86);
            this.znaX.Name = "znaX";
            this.znaX.Size = new System.Drawing.Size(100, 20);
            this.znaX.TabIndex = 2;
            // 
            // znaY
            // 
            this.znaY.Location = new System.Drawing.Point(41, 213);
            this.znaY.Name = "znaY";
            this.znaY.Size = new System.Drawing.Size(100, 20);
            this.znaY.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(294, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 240);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // proverka
            // 
            this.proverka.AutoSize = true;
            this.proverka.Location = new System.Drawing.Point(187, 149);
            this.proverka.Name = "proverka";
            this.proverka.Size = new System.Drawing.Size(0, 13);
            this.proverka.TabIndex = 5;
            // 
            // otvet
            // 
            this.otvet.AutoSize = true;
            this.otvet.Location = new System.Drawing.Point(152, 279);
            this.otvet.Name = "otvet";
            this.otvet.Size = new System.Drawing.Size(0, 13);
            this.otvet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Podcchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otvet);
            this.Controls.Add(this.proverka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.znaY);
            this.Controls.Add(this.znaX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Podcchet";
            this.Text = "Podcchet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox znaX;
        private System.Windows.Forms.TextBox znaY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label proverka;
        private System.Windows.Forms.Label otvet;
        private System.Windows.Forms.Button button1;
    }
}