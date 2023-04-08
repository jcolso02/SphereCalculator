// Lab 3
// Cis 199-50
// Due: 09/26/2021
// By: S5034

// This program shows diameter, surface area, and volume of a circle from a given radius.



namespace Lab2
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.surfaceAreaTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.topLeftImage = new System.Windows.Forms.PictureBox();
            this.bottomRightImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(171, 85);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(92, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Radius of Sphere:";
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(38, 200);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 1;
            this.diameterLabel.Text = "Diameter";
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.AutoSize = true;
            this.surfaceAreaLabel.Location = new System.Drawing.Point(18, 237);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLabel.TabIndex = 2;
            this.surfaceAreaLabel.Text = "Surface Area";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(45, 277);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 3;
            this.volumeLabel.Text = "Volume";
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Location = new System.Drawing.Point(272, 83);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterTextBox.Enabled = false;
            this.diameterTextBox.Location = new System.Drawing.Point(93, 198);
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.diameterTextBox.TabIndex = 5;
            // 
            // surfaceAreaTextBox
            // 
            this.surfaceAreaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaTextBox.Enabled = false;
            this.surfaceAreaTextBox.Location = new System.Drawing.Point(93, 235);
            this.surfaceAreaTextBox.Name = "surfaceAreaTextBox";
            this.surfaceAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.surfaceAreaTextBox.TabIndex = 6;
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeTextBox.Enabled = false;
            this.volumeTextBox.Location = new System.Drawing.Point(93, 275);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.volumeTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(272, 121);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(79, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // topLeftImage
            // 
            this.topLeftImage.Image = global::Lab2.Properties.Resources.Lab_3_Sphere;
            this.topLeftImage.Location = new System.Drawing.Point(15, 12);
            this.topLeftImage.Name = "topLeftImage";
            this.topLeftImage.Size = new System.Drawing.Size(150, 150);
            this.topLeftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topLeftImage.TabIndex = 9;
            this.topLeftImage.TabStop = false;
            // 
            // bottomRightImage
            // 
            this.bottomRightImage.Image = global::Lab2.Properties.Resources.Lab_3_Sphere;
            this.bottomRightImage.Location = new System.Drawing.Point(211, 189);
            this.bottomRightImage.Name = "bottomRightImage";
            this.bottomRightImage.Size = new System.Drawing.Size(150, 150);
            this.bottomRightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomRightImage.TabIndex = 10;
            this.bottomRightImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.bottomRightImage);
            this.Controls.Add(this.topLeftImage);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.surfaceAreaTextBox);
            this.Controls.Add(this.diameterTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.surfaceAreaLabel);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.topLeftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declaring UI classes

        private System.Windows.Forms.Label inputLabel; 
        private System.Windows.Forms.Label diameterLabel; 
        private System.Windows.Forms.Label surfaceAreaLabel; 
        private System.Windows.Forms.Label volumeLabel; 
        private System.Windows.Forms.TextBox inputTextBox; 
        private System.Windows.Forms.TextBox diameterTextBox; 
        private System.Windows.Forms.TextBox surfaceAreaTextBox; 
        private System.Windows.Forms.TextBox volumeTextBox; 
        private System.Windows.Forms.Button calculateButton; 
        private System.Windows.Forms.PictureBox topLeftImage; 
        private System.Windows.Forms.PictureBox bottomRightImage; 
    }
}

