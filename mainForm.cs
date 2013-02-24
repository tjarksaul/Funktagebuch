using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funktagebuch
{
    public partial class mainForm : Form
    {
        const string DATE_FORMAT = "dd.MM.yyyy HH:mm";

        private Funktagebuch funktagebuch;

        private string funker
        {
            get { return funktagebuch.Funker; }
            set { funktagebuch.Funker = value; }
        }
        private string einsatzgebiet
        {
            get { return funktagebuch.Einsatzgebiet; }
            set { funktagebuch.Einsatzgebiet = value; }
        }
        private DateTime beginn
        {
            get { return funktagebuch.Beginn; }
            set { funktagebuch.Beginn = value; }
        }
        private DateTime ende
        {
            get { return funktagebuch.Ende; }
            set { funktagebuch.Ende = value; }
        }
        private int funkkanal
        {
            get { return funktagebuch.Funkkanal; }
            set { funktagebuch.Funkkanal = value; }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            tagebuchList.Size = new Size(this.Size.Width - 40, this.Size.Height - 194);

            eOrtLabel.Size = new Size(this.Size.Width / 2 - 80, eOrtLabel.Size.Height);
            beginnLabel.Size = new Size(this.Size.Width / 2 - 80, beginnLabel.Size.Height);

            funkerName.Location = new Point(this.Size.Width / 2, funkerName.Location.Y);
            funkerLabel.Location = new Point(funkerName.Location.X + 69, funkerLabel.Location.Y);
            funkerLabel.Size = new Size(this.Size.Width / 2 - 97, funkerLabel.Size.Height);
            fKanalName.Location = new Point(this.Size.Width / 2, fKanalName.Location.Y);
            kanalLabel.Location = new Point(fKanalName.Location.X + 69, kanalLabel.Location.Y);
            kanalLabel.Size = new Size(this.Size.Width / 2 - 97, kanalLabel.Size.Height);
            endeName.Location = new Point(this.Size.Width / 2, endeName.Location.Y);
            endeLabel.Location = new Point(endeName.Location.X + 69, endeLabel.Location.Y);
            endeLabel.Size = new Size(this.Size.Width / 2 - 97, endeLabel.Size.Height);

            fromLabel.Location = new Point(fromLabel.Location.X, this.Size.Height - 96);
            fromBox.Location = new Point(fromBox.Location.X, this.Size.Height - 99);
            toLabel.Location = new Point(toLabel.Location.X, this.Size.Height - 96);
            toBox.Location = new Point(toBox.Location.X, this.Size.Height - 99);
            contentLabel.Location = new Point(contentLabel.Location.X, this.Size.Height - 96);
            contentBox.Location = new Point(contentBox.Location.X, this.Size.Height - 99);
            contentBox.Size = new Size(this.Size.Width - 214, contentBox.Size.Height);

            openButton.Location = new Point(openButton.Location.X, this.Size.Height - 73);
            startButton.Location = new Point((this.Size.Width - 24) / 6 + 12, this.Size.Height - 73);
            changeFunkerButton.Location = new Point(2 * ((this.Size.Width - 24) / 6) + 12, this.Size.Height - 73);
            endButton.Location = new Point(3 * ((this.Size.Width - 24) / 6) + 12, this.Size.Height - 73);
            saveButton.Location = new Point(4 * ((this.Size.Width - 24) / 6) + 12, this.Size.Height - 73);
            exitButton.Location = new Point(5 * ((this.Size.Width - 24) / 6) + 12, this.Size.Height - 73);
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    funktagebuch.AddEntry(fromBox.Text, toBox.Text, contentBox.Text, funker);
                    fromBox.Clear();
                    toBox.Clear();
                    contentBox.Clear();
                }
                catch (Exception ex)
                {
                    // TODO: Fehlerbehandlung
                }
                finally
                {
                    UpdateViews();
                }
            }
        }

        private void AskForInfos()
        {
#if DEBUG
            funker = "Tjark Saul";
            einsatzgebiet = "Sieverner See";
            funkkanal = 3;
#else
            funker = ModalQuestion.Ask("Frage", "Funker:", false);
            einsatzgebiet = ModalQuestion.Ask("Frage", "Einsatzgebiet:", false);
            bool parsed = false;
            while (!parsed)
            {
                try
                {
                    funkkanal = Convert.ToInt32(ModalQuestion.Ask("Frage", "Funkkanal:", false));
                    parsed = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bitte geben Sie eine Zahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    parsed = false;
                }
            }
#endif
        }

        private void UpdateViews()
        {
            // Labels beschriften
            funkerLabel.Text = funker;
            eOrtLabel.Text = einsatzgebiet;
            beginnLabel.Text = beginn == DateTime.MinValue ? "unbekannt" : beginn.ToString(DATE_FORMAT);
            endeLabel.Text = ende == DateTime.MinValue ? "unbekannt" : ende.ToString(DATE_FORMAT);
            kanalLabel.Text = funkkanal == 0 ? "unbekannt" : funkkanal.ToString();

            // Liste füllen
            tagebuchList.Items.Clear();
            foreach (KeyValuePair<int, FunktagebuchEntry> kvp in funktagebuch.Entries)
            {
                string[] row = {
                    kvp.Key.ToString(), kvp.Value.Timestamp.ToString(DATE_FORMAT), 
                    kvp.Value.From, kvp.Value.To,
                    kvp.Value.Content
                };
                var item = new ListViewItem(row);
                tagebuchList.Items.Add(item);
                /*
                tagebuchList.Update();
                tagebuchList.Refresh();
                 */
            }
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            funktagebuch = new Funktagebuch();
            AskForInfos();
            UpdateViews();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            beginn = DateTime.Now;
            startButton.Enabled = false;
            endButton.Enabled = true;
            fromBox.Enabled = true;
            toBox.Enabled = true;
            contentBox.Enabled = true;
            UpdateViews();
            fromBox.Focus();
            funktagebuch.Save();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            ende = DateTime.Now;
            endButton.Enabled = false;
            fromBox.Enabled = false;
            toBox.Enabled = false;
            contentBox.Enabled = false;
            UpdateViews();
            funktagebuch.Save();
        }

        private void changeFunkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                funkerLabel.Text = ModalQuestion.Ask("Frage", "Neuer Funker:", true);
            }
            catch (NotAnsweredException)
            {
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.AddExtension = true;
            dialog.DefaultExt = ".futb";
            dialog.Filter = "Funktagebuch|*.futb";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                funktagebuch = Funktagebuch.Open(dialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = ".futb";
            dialog.Filter = "Funktagebuch|*.futb";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                funktagebuch.Save(dialog.FileName);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            if (Properties.Settings.Default.BeendenAbfrage)
            {
                e.Cancel = true;
                if (MessageBox.Show("Wollen Sie wirklich beenden?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                }
            }
#endif
        }
    }
}
