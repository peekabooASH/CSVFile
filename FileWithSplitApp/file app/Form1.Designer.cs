namespace file_app
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTesxtbox = new System.Windows.Forms.TextBox();
            this.idLebel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.amountLebel = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(119, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(457, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Name";
            // 
            // idTesxtbox
            // 
            this.idTesxtbox.Location = new System.Drawing.Point(119, 78);
            this.idTesxtbox.Name = "idTesxtbox";
            this.idTesxtbox.Size = new System.Drawing.Size(457, 22);
            this.idTesxtbox.TabIndex = 2;
            // 
            // idLebel
            // 
            this.idLebel.AutoSize = true;
            this.idLebel.Location = new System.Drawing.Point(16, 78);
            this.idLebel.Name = "idLebel";
            this.idLebel.Size = new System.Drawing.Size(25, 17);
            this.idLebel.TabIndex = 3;
            this.idLebel.Text = "ID ";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(13, 125);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(100, 17);
            this.salaryLabel.TabIndex = 4;
            this.salaryLabel.Text = "Salary Amount";
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(119, 125);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(457, 22);
            this.salarytextBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(501, 202);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(501, 164);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 148);
            this.listBox1.TabIndex = 8;
            // 
            // amountLebel
            // 
            this.amountLebel.AutoSize = true;
            this.amountLebel.Location = new System.Drawing.Point(366, 427);
            this.amountLebel.Name = "amountLebel";
            this.amountLebel.Size = new System.Drawing.Size(92, 17);
            this.amountLebel.TabIndex = 9;
            this.amountLebel.Text = "Total Amount";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(476, 424);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(100, 22);
            this.amountTextbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 456);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.amountLebel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.idLebel);
            this.Controls.Add(this.idTesxtbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "employee Salary UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTesxtbox;
        private System.Windows.Forms.Label idLebel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label amountLebel;
        private System.Windows.Forms.TextBox amountTextbox;
    }
}

