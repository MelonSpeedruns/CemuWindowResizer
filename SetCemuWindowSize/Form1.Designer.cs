namespace SetCemuWindowSize
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
            this.windowWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windowHeight = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(16, 28);
            this.windowWidth.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.windowWidth.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(123, 20);
            this.windowWidth.TabIndex = 1;
            this.windowWidth.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Cemu Window Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(166, 28);
            this.windowHeight.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.windowHeight.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(123, 20);
            this.windowHeight.TabIndex = 5;
            this.windowHeight.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 78);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resize Cemu Window!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.windowHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cemu Window Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown windowWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown windowHeight;
        private System.Windows.Forms.Button button1;
    }
}

