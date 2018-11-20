namespace FahrenheitToCelsius
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputOne = new System.Windows.Forms.TextBox();
            this.txtInputTwo = new System.Windows.Forms.TextBox();
            this.txtInputThree = new System.Windows.Forms.TextBox();
            this.lblUnitIn = new System.Windows.Forms.Label();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.lblOutputOne = new System.Windows.Forms.Label();
            this.lblOutputTwo = new System.Windows.Forms.Label();
            this.lblOutputThree = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblUnitOut = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.pcToF = new System.Windows.Forms.PictureBox();
            this.pcToC = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcToF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcToC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "8:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "12:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(64, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "17:00";
            // 
            // txtInputOne
            // 
            this.txtInputOne.Location = new System.Drawing.Point(142, 69);
            this.txtInputOne.Name = "txtInputOne";
            this.txtInputOne.Size = new System.Drawing.Size(100, 20);
            this.txtInputOne.TabIndex = 3;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.Location = new System.Drawing.Point(142, 123);
            this.txtInputTwo.Name = "txtInputTwo";
            this.txtInputTwo.Size = new System.Drawing.Size(100, 20);
            this.txtInputTwo.TabIndex = 4;
            // 
            // txtInputThree
            // 
            this.txtInputThree.Location = new System.Drawing.Point(142, 179);
            this.txtInputThree.Name = "txtInputThree";
            this.txtInputThree.Size = new System.Drawing.Size(100, 20);
            this.txtInputThree.TabIndex = 5;
            // 
            // lblUnitIn
            // 
            this.lblUnitIn.AutoSize = true;
            this.lblUnitIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnitIn.Location = new System.Drawing.Point(29, 21);
            this.lblUnitIn.Name = "lblUnitIn";
            this.lblUnitIn.Size = new System.Drawing.Size(293, 17);
            this.lblUnitIn.TabIndex = 6;
            this.lblUnitIn.Text = "Please enter the temperature in desired units";
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(306, 92);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnFahrenheit.TabIndex = 7;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutputOne
            // 
            this.lblOutputOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutputOne.Location = new System.Drawing.Point(440, 63);
            this.lblOutputOne.Name = "lblOutputOne";
            this.lblOutputOne.Size = new System.Drawing.Size(314, 23);
            this.lblOutputOne.TabIndex = 8;
            // 
            // lblOutputTwo
            // 
            this.lblOutputTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutputTwo.Location = new System.Drawing.Point(440, 120);
            this.lblOutputTwo.Name = "lblOutputTwo";
            this.lblOutputTwo.Size = new System.Drawing.Size(314, 23);
            this.lblOutputTwo.TabIndex = 9;
            // 
            // lblOutputThree
            // 
            this.lblOutputThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutputThree.Location = new System.Drawing.Point(440, 176);
            this.lblOutputThree.Name = "lblOutputThree";
            this.lblOutputThree.Size = new System.Drawing.Size(314, 23);
            this.lblOutputThree.TabIndex = 10;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAverage.Location = new System.Drawing.Point(12, 375);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(448, 23);
            this.lblAverage.TabIndex = 11;
            // 
            // lblWord
            // 
            this.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWord.Location = new System.Drawing.Point(466, 375);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(111, 23);
            this.lblWord.TabIndex = 12;
            // 
            // lblUnitOut
            // 
            this.lblUnitOut.AutoSize = true;
            this.lblUnitOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnitOut.Location = new System.Drawing.Point(440, 21);
            this.lblUnitOut.Name = "lblUnitOut";
            this.lblUnitOut.Size = new System.Drawing.Size(154, 17);
            this.lblUnitOut.TabIndex = 13;
            this.lblUnitOut.Text = "Converted temperature";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(306, 154);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 14;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // pcToF
            // 
            this.pcToF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcToF.Image = ((System.Drawing.Image)(resources.GetObject("pcToF.Image")));
            this.pcToF.Location = new System.Drawing.Point(92, 205);
            this.pcToF.Name = "pcToF";
            this.pcToF.Size = new System.Drawing.Size(253, 148);
            this.pcToF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcToF.TabIndex = 15;
            this.pcToF.TabStop = false;
            this.pcToF.Visible = false;
            // 
            // pcToC
            // 
            this.pcToC.Image = ((System.Drawing.Image)(resources.GetObject("pcToC.Image")));
            this.pcToC.Location = new System.Drawing.Point(408, 205);
            this.pcToC.Name = "pcToC";
            this.pcToC.Size = new System.Drawing.Size(254, 148);
            this.pcToC.TabIndex = 16;
            this.pcToC.TabStop = false;
            this.pcToC.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(153, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Average Temperature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pcToC);
            this.Controls.Add(this.pcToF);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblUnitOut);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblOutputThree);
            this.Controls.Add(this.lblOutputTwo);
            this.Controls.Add(this.lblOutputOne);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.lblUnitIn);
            this.Controls.Add(this.txtInputThree);
            this.Controls.Add(this.txtInputTwo);
            this.Controls.Add(this.txtInputOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcToF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcToC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputOne;
        private System.Windows.Forms.TextBox txtInputTwo;
        private System.Windows.Forms.TextBox txtInputThree;
        private System.Windows.Forms.Label lblUnitIn;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Label lblOutputOne;
        private System.Windows.Forms.Label lblOutputTwo;
        private System.Windows.Forms.Label lblOutputThree;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblUnitOut;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.PictureBox pcToF;
        private System.Windows.Forms.PictureBox pcToC;
        private System.Windows.Forms.Label label4;
    }
}

