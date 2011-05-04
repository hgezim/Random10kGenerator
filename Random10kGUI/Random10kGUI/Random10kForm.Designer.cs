namespace Random10kGUI
{
    partial class Random10kGUIForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.randomNumberListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.iWantLabel = new System.Windows.Forms.Label();
            this.randomNumbersBetweenLabel = new System.Windows.Forms.Label();
            this.andLabel = new System.Windows.Forms.Label();
            this.numberOfRandomNumbersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowestNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.highestNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxHeaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRandomNumbersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(600, 93);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(96, 29);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // randomNumberListBox
            // 
            this.randomNumberListBox.FormattingEnabled = true;
            this.randomNumberListBox.ItemHeight = 16;
            this.randomNumberListBox.Location = new System.Drawing.Point(15, 171);
            this.randomNumberListBox.Name = "randomNumberListBox";
            this.randomNumberListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.randomNumberListBox.Size = new System.Drawing.Size(681, 260);
            this.randomNumberListBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Helonia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(284, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(232, 25);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Random 10k Generator";
            // 
            // iWantLabel
            // 
            this.iWantLabel.AutoSize = true;
            this.iWantLabel.Font = new System.Drawing.Font("Helonia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iWantLabel.Location = new System.Drawing.Point(20, 95);
            this.iWantLabel.Name = "iWantLabel";
            this.iWantLabel.Size = new System.Drawing.Size(64, 24);
            this.iWantLabel.TabIndex = 5;
            this.iWantLabel.Text = "I want";
            // 
            // randomNumbersBetweenLabel
            // 
            this.randomNumbersBetweenLabel.AutoSize = true;
            this.randomNumbersBetweenLabel.Font = new System.Drawing.Font("Helonia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumbersBetweenLabel.Location = new System.Drawing.Point(154, 95);
            this.randomNumbersBetweenLabel.Name = "randomNumbersBetweenLabel";
            this.randomNumbersBetweenLabel.Size = new System.Drawing.Size(243, 24);
            this.randomNumbersBetweenLabel.TabIndex = 6;
            this.randomNumbersBetweenLabel.Text = "random numbers between";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Font = new System.Drawing.Font("Helonia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andLabel.Location = new System.Drawing.Point(478, 95);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(43, 24);
            this.andLabel.TabIndex = 7;
            this.andLabel.Text = "and";
            // 
            // numberOfRandomNumbersNumericUpDown
            // 
            this.numberOfRandomNumbersNumericUpDown.Location = new System.Drawing.Point(84, 96);
            this.numberOfRandomNumbersNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfRandomNumbersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfRandomNumbersNumericUpDown.Name = "numberOfRandomNumbersNumericUpDown";
            this.numberOfRandomNumbersNumericUpDown.Size = new System.Drawing.Size(70, 22);
            this.numberOfRandomNumbersNumericUpDown.TabIndex = 8;
            this.numberOfRandomNumbersNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lowestNumberNumericUpDown
            // 
            this.lowestNumberNumericUpDown.Location = new System.Drawing.Point(409, 96);
            this.lowestNumberNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.lowestNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowestNumberNumericUpDown.Name = "lowestNumberNumericUpDown";
            this.lowestNumberNumericUpDown.Size = new System.Drawing.Size(69, 22);
            this.lowestNumberNumericUpDown.TabIndex = 9;
            this.lowestNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // highestNumberNumericUpDown
            // 
            this.highestNumberNumericUpDown.Location = new System.Drawing.Point(527, 96);
            this.highestNumberNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.highestNumberNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.highestNumberNumericUpDown.Name = "highestNumberNumericUpDown";
            this.highestNumberNumericUpDown.Size = new System.Drawing.Size(67, 22);
            this.highestNumberNumericUpDown.TabIndex = 10;
            this.highestNumberNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Image = global::Random10kGUI.Properties.Resources.remove_selected_small;
            this.RemoveSelectedButton.Location = new System.Drawing.Point(516, 437);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(180, 34);
            this.RemoveSelectedButton.TabIndex = 11;
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Image = global::Random10kGUI.Properties.Resources.icon_048;
            this.titlePictureBox.Location = new System.Drawing.Point(211, 12);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(67, 63);
            this.titlePictureBox.TabIndex = 4;
            this.titlePictureBox.TabStop = false;
            // 
            // listBoxHeaderLabel
            // 
            this.listBoxHeaderLabel.AutoSize = true;
            this.listBoxHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHeaderLabel.Location = new System.Drawing.Point(262, 143);
            this.listBoxHeaderLabel.Name = "listBoxHeaderLabel";
            this.listBoxHeaderLabel.Size = new System.Drawing.Size(169, 25);
            this.listBoxHeaderLabel.TabIndex = 12;
            this.listBoxHeaderLabel.Text = "Random Numbers";
            // 
            // Random10kGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 137);
            this.Controls.Add(this.listBoxHeaderLabel);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.highestNumberNumericUpDown);
            this.Controls.Add(this.lowestNumberNumericUpDown);
            this.Controls.Add(this.numberOfRandomNumbersNumericUpDown);
            this.Controls.Add(this.andLabel);
            this.Controls.Add(this.randomNumbersBetweenLabel);
            this.Controls.Add(this.iWantLabel);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.randomNumberListBox);
            this.Controls.Add(this.generateButton);
            this.Name = "Random10kGUIForm";
            this.Text = "Random 10k Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRandomNumbersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox randomNumberListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.Label iWantLabel;
        private System.Windows.Forms.Label randomNumbersBetweenLabel;
        private System.Windows.Forms.Label andLabel;
        private System.Windows.Forms.NumericUpDown numberOfRandomNumbersNumericUpDown;
        private System.Windows.Forms.NumericUpDown lowestNumberNumericUpDown;
        private System.Windows.Forms.NumericUpDown highestNumberNumericUpDown;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Label listBoxHeaderLabel;
    }
}

