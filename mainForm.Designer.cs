namespace Funktagebuch
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tagebuchList = new System.Windows.Forms.ListView();
            this.noHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timestampHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fromHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eOrtName = new System.Windows.Forms.Label();
            this.beginnName = new System.Windows.Forms.Label();
            this.funkerName = new System.Windows.Forms.Label();
            this.fKanalName = new System.Windows.Forms.Label();
            this.endeName = new System.Windows.Forms.Label();
            this.eOrtLabel = new System.Windows.Forms.Label();
            this.beginnLabel = new System.Windows.Forms.Label();
            this.kanalLabel = new System.Windows.Forms.Label();
            this.funkerLabel = new System.Windows.Forms.Label();
            this.endeLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.createPdfButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagebuchList
            // 
            this.tagebuchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noHeader,
            this.timestampHeader,
            this.fromHeader,
            this.toHeader,
            this.contentHeader});
            this.tagebuchList.Location = new System.Drawing.Point(12, 80);
            this.tagebuchList.Name = "tagebuchList";
            this.tagebuchList.Size = new System.Drawing.Size(810, 275);
            this.tagebuchList.TabIndex = 0;
            this.tagebuchList.UseCompatibleStateImageBehavior = false;
            this.tagebuchList.View = System.Windows.Forms.View.Details;
            // 
            // noHeader
            // 
            this.noHeader.Text = "Lfd. Nr.";
            this.noHeader.Width = 47;
            // 
            // timestampHeader
            // 
            this.timestampHeader.Text = "Zeit";
            this.timestampHeader.Width = 111;
            // 
            // fromHeader
            // 
            this.fromHeader.Text = "Von";
            this.fromHeader.Width = 139;
            // 
            // toHeader
            // 
            this.toHeader.Text = "An";
            this.toHeader.Width = 139;
            // 
            // contentHeader
            // 
            this.contentHeader.Text = "Inhalt";
            this.contentHeader.Width = 352;
            // 
            // eOrtName
            // 
            this.eOrtName.AutoSize = true;
            this.eOrtName.Location = new System.Drawing.Point(12, 29);
            this.eOrtName.Name = "eOrtName";
            this.eOrtName.Size = new System.Drawing.Size(56, 13);
            this.eOrtName.TabIndex = 1;
            this.eOrtName.Text = "Einsatzort:";
            // 
            // beginnName
            // 
            this.beginnName.AutoSize = true;
            this.beginnName.Location = new System.Drawing.Point(12, 49);
            this.beginnName.Name = "beginnName";
            this.beginnName.Size = new System.Drawing.Size(43, 13);
            this.beginnName.TabIndex = 2;
            this.beginnName.Text = "Beginn:";
            // 
            // funkerName
            // 
            this.funkerName.AutoSize = true;
            this.funkerName.Location = new System.Drawing.Point(425, 9);
            this.funkerName.Name = "funkerName";
            this.funkerName.Size = new System.Drawing.Size(43, 13);
            this.funkerName.TabIndex = 3;
            this.funkerName.Text = "Funker:";
            // 
            // fKanalName
            // 
            this.fKanalName.AutoSize = true;
            this.fKanalName.Location = new System.Drawing.Point(425, 29);
            this.fKanalName.Name = "fKanalName";
            this.fKanalName.Size = new System.Drawing.Size(60, 13);
            this.fKanalName.TabIndex = 4;
            this.fKanalName.Text = "Funkkanal:";
            // 
            // endeName
            // 
            this.endeName.AutoSize = true;
            this.endeName.Location = new System.Drawing.Point(425, 49);
            this.endeName.Name = "endeName";
            this.endeName.Size = new System.Drawing.Size(35, 13);
            this.endeName.TabIndex = 5;
            this.endeName.Text = "Ende:";
            // 
            // eOrtLabel
            // 
            this.eOrtLabel.Location = new System.Drawing.Point(74, 29);
            this.eOrtLabel.Name = "eOrtLabel";
            this.eOrtLabel.Size = new System.Drawing.Size(345, 13);
            this.eOrtLabel.TabIndex = 6;
            this.eOrtLabel.Text = "unbekannt";
            this.eOrtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // beginnLabel
            // 
            this.beginnLabel.Location = new System.Drawing.Point(74, 49);
            this.beginnLabel.Name = "beginnLabel";
            this.beginnLabel.Size = new System.Drawing.Size(345, 13);
            this.beginnLabel.TabIndex = 7;
            this.beginnLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kanalLabel
            // 
            this.kanalLabel.Location = new System.Drawing.Point(494, 29);
            this.kanalLabel.Name = "kanalLabel";
            this.kanalLabel.Size = new System.Drawing.Size(328, 13);
            this.kanalLabel.TabIndex = 8;
            this.kanalLabel.Text = "unbekannt";
            this.kanalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // funkerLabel
            // 
            this.funkerLabel.Location = new System.Drawing.Point(494, 9);
            this.funkerLabel.Name = "funkerLabel";
            this.funkerLabel.Size = new System.Drawing.Size(328, 13);
            this.funkerLabel.TabIndex = 9;
            this.funkerLabel.Text = "unbekannt";
            this.funkerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // endeLabel
            // 
            this.endeLabel.Location = new System.Drawing.Point(494, 49);
            this.endeLabel.Name = "endeLabel";
            this.endeLabel.Size = new System.Drawing.Size(328, 13);
            this.endeLabel.TabIndex = 10;
            this.endeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 373);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(26, 13);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "Von";
            // 
            // fromBox
            // 
            this.fromBox.Enabled = false;
            this.fromBox.Location = new System.Drawing.Point(44, 370);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(31, 20);
            this.fromBox.TabIndex = 12;
            this.fromBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fromBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(81, 373);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 13;
            this.toLabel.Text = "An";
            // 
            // toBox
            // 
            this.toBox.Enabled = false;
            this.toBox.Location = new System.Drawing.Point(107, 370);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(31, 20);
            this.toBox.TabIndex = 14;
            this.toBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(144, 373);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(36, 13);
            this.contentLabel.TabIndex = 15;
            this.contentLabel.Text = "Inhalt:";
            // 
            // contentBox
            // 
            this.contentBox.Enabled = false;
            this.contentBox.Location = new System.Drawing.Point(186, 370);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(636, 20);
            this.contentBox.TabIndex = 16;
            this.contentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(148, 396);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 23);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Einsatzbeginn";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // createPdfButton
            // 
            this.createPdfButton.Location = new System.Drawing.Point(284, 396);
            this.createPdfButton.Name = "createPdfButton";
            this.createPdfButton.Size = new System.Drawing.Size(130, 23);
            this.createPdfButton.TabIndex = 18;
            this.createPdfButton.Text = "PDF erstellen";
            this.createPdfButton.UseVisualStyleBackColor = true;
            this.createPdfButton.Click += new System.EventHandler(this.createPdfButton_Click);
            // 
            // endButton
            // 
            this.endButton.Enabled = false;
            this.endButton.Location = new System.Drawing.Point(420, 396);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(130, 23);
            this.endButton.TabIndex = 19;
            this.endButton.Text = "Einsatzende";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 396);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(130, 23);
            this.openButton.TabIndex = 20;
            this.openButton.Text = "Öffnen...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(556, 396);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 23);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Speichern...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(692, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Beenden";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(130, 23);
            this.settingsButton.TabIndex = 23;
            this.settingsButton.Text = "Einstellungen";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 431);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.createPdfButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.endeLabel);
            this.Controls.Add(this.funkerLabel);
            this.Controls.Add(this.kanalLabel);
            this.Controls.Add(this.beginnLabel);
            this.Controls.Add(this.eOrtLabel);
            this.Controls.Add(this.endeName);
            this.Controls.Add(this.fKanalName);
            this.Controls.Add(this.funkerName);
            this.Controls.Add(this.beginnName);
            this.Controls.Add(this.eOrtName);
            this.Controls.Add(this.tagebuchList);
            this.MinimumSize = new System.Drawing.Size(850, 469);
            this.Name = "mainForm";
            this.Text = "Funktagebuch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tagebuchList;
        private System.Windows.Forms.Label eOrtName;
        private System.Windows.Forms.Label beginnName;
        private System.Windows.Forms.Label funkerName;
        private System.Windows.Forms.Label fKanalName;
        private System.Windows.Forms.Label endeName;
        private System.Windows.Forms.Label eOrtLabel;
        private System.Windows.Forms.Label beginnLabel;
        private System.Windows.Forms.Label kanalLabel;
        private System.Windows.Forms.Label funkerLabel;
        private System.Windows.Forms.Label endeLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.ColumnHeader noHeader;
        private System.Windows.Forms.ColumnHeader timestampHeader;
        private System.Windows.Forms.ColumnHeader fromHeader;
        private System.Windows.Forms.ColumnHeader toHeader;
        private System.Windows.Forms.ColumnHeader contentHeader;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button createPdfButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

