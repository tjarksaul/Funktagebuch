namespace Funktagebuch
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gliederungLabel = new System.Windows.Forms.Label();
            this.gliederungBox = new System.Windows.Forms.TextBox();
            this.orgaLabel = new System.Windows.Forms.Label();
            this.organisationBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gliederungLabel);
            this.groupBox1.Controls.Add(this.gliederungBox);
            this.groupBox1.Controls.Add(this.orgaLabel);
            this.groupBox1.Controls.Add(this.organisationBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkrufnamen";
            // 
            // gliederungLabel
            // 
            this.gliederungLabel.AutoSize = true;
            this.gliederungLabel.Location = new System.Drawing.Point(67, 48);
            this.gliederungLabel.Name = "gliederungLabel";
            this.gliederungLabel.Size = new System.Drawing.Size(61, 13);
            this.gliederungLabel.TabIndex = 3;
            this.gliederungLabel.Text = "Gliederung:";
            this.gliederungLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gliederungBox
            // 
            this.gliederungBox.Location = new System.Drawing.Point(134, 45);
            this.gliederungBox.Name = "gliederungBox";
            this.gliederungBox.Size = new System.Drawing.Size(250, 20);
            this.gliederungBox.TabIndex = 2;
            this.gliederungBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // orgaLabel
            // 
            this.orgaLabel.AutoSize = true;
            this.orgaLabel.Location = new System.Drawing.Point(12, 22);
            this.orgaLabel.Name = "orgaLabel";
            this.orgaLabel.Size = new System.Drawing.Size(116, 13);
            this.orgaLabel.TabIndex = 1;
            this.orgaLabel.Text = "Organisationskennung:";
            this.orgaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // organisationBox
            // 
            this.organisationBox.Location = new System.Drawing.Point(134, 19);
            this.organisationBox.Name = "organisationBox";
            this.organisationBox.Size = new System.Drawing.Size(250, 20);
            this.organisationBox.TabIndex = 0;
            this.organisationBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(246, 124);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            this.okButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(327, 124);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 159);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Einstellungen";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gliederungLabel;
        private System.Windows.Forms.TextBox gliederungBox;
        private System.Windows.Forms.Label orgaLabel;
        private System.Windows.Forms.TextBox organisationBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}