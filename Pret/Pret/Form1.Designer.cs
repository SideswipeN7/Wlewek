namespace Pret
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
            this.pnLicz = new System.Windows.Forms.Panel();
            this.rdLicz2 = new System.Windows.Forms.RadioButton();
            this.rdLicz1 = new System.Windows.Forms.RadioButton();
            this.pbPret = new System.Windows.Forms.Panel();
            this.lbUzysk = new System.Windows.Forms.Label();
            this.lbRod = new System.Windows.Forms.Label();
            this.txPole = new System.Windows.Forms.TextBox();
            this.txProm = new System.Windows.Forms.TextBox();
            this.txWys = new System.Windows.Forms.TextBox();
            this.lbPole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDim2 = new System.Windows.Forms.Label();
            this.lbDimension = new System.Windows.Forms.Label();
            this.lbProm = new System.Windows.Forms.Label();
            this.lnWys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdSquare = new System.Windows.Forms.RadioButton();
            this.rdTriangle = new System.Windows.Forms.RadioButton();
            this.rdWheel = new System.Windows.Forms.RadioButton();
            this.pnLicz.SuspendLayout();
            this.pbPret.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLicz
            // 
            this.pnLicz.Controls.Add(this.rdLicz2);
            this.pnLicz.Controls.Add(this.rdLicz1);
            this.pnLicz.Location = new System.Drawing.Point(12, 12);
            this.pnLicz.Name = "pnLicz";
            this.pnLicz.Size = new System.Drawing.Size(333, 36);
            this.pnLicz.TabIndex = 0;
            // 
            // rdLicz2
            // 
            this.rdLicz2.AutoSize = true;
            this.rdLicz2.Location = new System.Drawing.Point(187, 3);
            this.rdLicz2.Name = "rdLicz2";
            this.rdLicz2.Size = new System.Drawing.Size(126, 17);
            this.rdLicz2.TabIndex = 0;
            this.rdLicz2.Text = "Licz objetość wlewka";
            this.rdLicz2.UseVisualStyleBackColor = true;
            this.rdLicz2.CheckedChanged += new System.EventHandler(this.rdLicz2_CheckedChanged);
            // 
            // rdLicz1
            // 
            this.rdLicz1.AutoSize = true;
            this.rdLicz1.Checked = true;
            this.rdLicz1.Location = new System.Drawing.Point(34, 3);
            this.rdLicz1.Name = "rdLicz1";
            this.rdLicz1.Size = new System.Drawing.Size(113, 17);
            this.rdLicz1.TabIndex = 0;
            this.rdLicz1.TabStop = true;
            this.rdLicz1.Text = "Licz długość pręta";
            this.rdLicz1.UseVisualStyleBackColor = true;
            this.rdLicz1.CheckedChanged += new System.EventHandler(this.rdLicz1_CheckedChanged);
            // 
            // pbPret
            // 
            this.pbPret.Controls.Add(this.lbUzysk);
            this.pbPret.Controls.Add(this.lbRod);
            this.pbPret.Controls.Add(this.txPole);
            this.pbPret.Controls.Add(this.txProm);
            this.pbPret.Controls.Add(this.txWys);
            this.pbPret.Controls.Add(this.lbPole);
            this.pbPret.Controls.Add(this.label2);
            this.pbPret.Controls.Add(this.lbDim2);
            this.pbPret.Controls.Add(this.lbDimension);
            this.pbPret.Controls.Add(this.lbProm);
            this.pbPret.Controls.Add(this.lnWys);
            this.pbPret.Controls.Add(this.label1);
            this.pbPret.Controls.Add(this.rdAll);
            this.pbPret.Controls.Add(this.rdSquare);
            this.pbPret.Controls.Add(this.rdTriangle);
            this.pbPret.Controls.Add(this.rdWheel);
            this.pbPret.Location = new System.Drawing.Point(15, 69);
            this.pbPret.Name = "pbPret";
            this.pbPret.Size = new System.Drawing.Size(330, 232);
            this.pbPret.TabIndex = 1;
            // 
            // lbUzysk
            // 
            this.lbUzysk.AutoSize = true;
            this.lbUzysk.Location = new System.Drawing.Point(9, 185);
            this.lbUzysk.Name = "lbUzysk";
            this.lbUzysk.Size = new System.Drawing.Size(39, 13);
            this.lbUzysk.TabIndex = 4;
            this.lbUzysk.Text = "Uzysk:";
            // 
            // lbRod
            // 
            this.lbRod.AutoSize = true;
            this.lbRod.Location = new System.Drawing.Point(9, 208);
            this.lbRod.Name = "lbRod";
            this.lbRod.Size = new System.Drawing.Size(19, 13);
            this.lbRod.TabIndex = 4;
            this.lbRod.Text = "Dł";
            // 
            // txPole
            // 
            this.txPole.Location = new System.Drawing.Point(184, 122);
            this.txPole.Name = "txPole";
            this.txPole.Size = new System.Drawing.Size(100, 20);
            this.txPole.TabIndex = 3;
            this.txPole.TextChanged += new System.EventHandler(this.txDim_TextChanged);
            // 
            // txProm
            // 
            this.txProm.Location = new System.Drawing.Point(184, 94);
            this.txProm.Name = "txProm";
            this.txProm.Size = new System.Drawing.Size(100, 20);
            this.txProm.TabIndex = 3;
            this.txProm.TextChanged += new System.EventHandler(this.txDim_TextChanged);
            // 
            // txWys
            // 
            this.txWys.Location = new System.Drawing.Point(184, 68);
            this.txWys.Name = "txWys";
            this.txWys.Size = new System.Drawing.Size(100, 20);
            this.txWys.TabIndex = 3;
            this.txWys.TextChanged += new System.EventHandler(this.txDim_TextChanged);
            // 
            // lbPole
            // 
            this.lbPole.AutoSize = true;
            this.lbPole.Location = new System.Drawing.Point(6, 122);
            this.lbPole.Name = "lbPole";
            this.lbPole.Size = new System.Drawing.Size(42, 13);
            this.lbPole.TabIndex = 2;
            this.lbPole.Text = "lbValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " mm";
            // 
            // lbDim2
            // 
            this.lbDim2.AutoSize = true;
            this.lbDim2.Location = new System.Drawing.Point(290, 122);
            this.lbDim2.Name = "lbDim2";
            this.lbDim2.Size = new System.Drawing.Size(26, 13);
            this.lbDim2.TabIndex = 2;
            this.lbDim2.Text = " mm";
            // 
            // lbDimension
            // 
            this.lbDimension.AutoSize = true;
            this.lbDimension.Location = new System.Drawing.Point(290, 71);
            this.lbDimension.Name = "lbDimension";
            this.lbDimension.Size = new System.Drawing.Size(26, 13);
            this.lbDimension.TabIndex = 2;
            this.lbDimension.Text = " mm";
            // 
            // lbProm
            // 
            this.lbProm.AutoSize = true;
            this.lbProm.Location = new System.Drawing.Point(3, 94);
            this.lbProm.Name = "lbProm";
            this.lbProm.Size = new System.Drawing.Size(88, 13);
            this.lbProm.TabIndex = 2;
            this.lbProm.Text = "Średnica wlewka";
            // 
            // lnWys
            // 
            this.lnWys.AutoSize = true;
            this.lnWys.Location = new System.Drawing.Point(3, 68);
            this.lnWys.Name = "lnWys";
            this.lnWys.Size = new System.Drawing.Size(96, 13);
            this.lnWys.TabIndex = 2;
            this.lnWys.Text = "Wysokość wlewka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz kształt matrycy";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(239, 35);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(66, 17);
            this.rdAll.TabIndex = 0;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Dowolny";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // rdSquare
            // 
            this.rdSquare.AutoSize = true;
            this.rdSquare.Location = new System.Drawing.Point(150, 35);
            this.rdSquare.Name = "rdSquare";
            this.rdSquare.Size = new System.Drawing.Size(83, 17);
            this.rdSquare.TabIndex = 0;
            this.rdSquare.TabStop = true;
            this.rdSquare.Text = "Kwadratowy";
            this.rdSquare.UseVisualStyleBackColor = true;
            this.rdSquare.CheckedChanged += new System.EventHandler(this.rdSquare_CheckedChanged);
            // 
            // rdTriangle
            // 
            this.rdTriangle.AutoSize = true;
            this.rdTriangle.Location = new System.Drawing.Point(75, 35);
            this.rdTriangle.Name = "rdTriangle";
            this.rdTriangle.Size = new System.Drawing.Size(69, 17);
            this.rdTriangle.TabIndex = 0;
            this.rdTriangle.TabStop = true;
            this.rdTriangle.Text = "Trójkątny";
            this.rdTriangle.UseVisualStyleBackColor = true;
            this.rdTriangle.CheckedChanged += new System.EventHandler(this.rdTriangle_CheckedChanged);
            // 
            // rdWheel
            // 
            this.rdWheel.AutoSize = true;
            this.rdWheel.Checked = true;
            this.rdWheel.Location = new System.Drawing.Point(6, 35);
            this.rdWheel.Name = "rdWheel";
            this.rdWheel.Size = new System.Drawing.Size(63, 17);
            this.rdWheel.TabIndex = 0;
            this.rdWheel.TabStop = true;
            this.rdWheel.Text = "Okrągły";
            this.rdWheel.UseVisualStyleBackColor = true;
            this.rdWheel.CheckedChanged += new System.EventHandler(this.rdWheel_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 313);
            this.Controls.Add(this.pbPret);
            this.Controls.Add(this.pnLicz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator Wlewków";
            this.pnLicz.ResumeLayout(false);
            this.pnLicz.PerformLayout();
            this.pbPret.ResumeLayout(false);
            this.pbPret.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLicz;
        private System.Windows.Forms.RadioButton rdLicz2;
        private System.Windows.Forms.RadioButton rdLicz1;
        private System.Windows.Forms.Panel pbPret;
        private System.Windows.Forms.RadioButton rdTriangle;
        private System.Windows.Forms.RadioButton rdWheel;
        private System.Windows.Forms.TextBox txPole;
        private System.Windows.Forms.TextBox txWys;
        private System.Windows.Forms.Label lbPole;
        private System.Windows.Forms.Label lbDimension;
        private System.Windows.Forms.Label lnWys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdSquare;
        private System.Windows.Forms.Label lbRod;
        private System.Windows.Forms.Label lbDim2;
        private System.Windows.Forms.Label lbUzysk;
        private System.Windows.Forms.TextBox txProm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProm;
    }
}

