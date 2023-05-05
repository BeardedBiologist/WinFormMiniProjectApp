namespace WinFormMiniProject
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(266, 215);
            this.cityText.Margin = new System.Windows.Forms.Padding(2);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(346, 38);
            this.cityText.TabIndex = 6;
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(266, 140);
            this.streetAddressText.Margin = new System.Windows.Forms.Padding(2);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(346, 38);
            this.streetAddressText.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(190, 215);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(62, 31);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(58, 140);
            this.streetAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(194, 31);
            this.streetAddressLabel.TabIndex = 4;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(264, 371);
            this.zipCodeText.Margin = new System.Windows.Forms.Padding(2);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(346, 38);
            this.zipCodeText.TabIndex = 10;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(264, 296);
            this.stateText.Margin = new System.Windows.Forms.Padding(2);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(346, 38);
            this.stateText.TabIndex = 9;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(135, 371);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(117, 31);
            this.zipCodeLabel.TabIndex = 7;
            this.zipCodeLabel.Text = "ZipCode";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(174, 296);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(78, 31);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(186, 55);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(339, 55);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Address Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(266, 454);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 46);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 576);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddressEntry";
            this.Text = "Address Entry form by Joshua James";
            this.Load += new System.EventHandler(this.AddressEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button saveButton;
    }
}