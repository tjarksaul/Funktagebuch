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
    public partial class SettingsForm : Form
    {
        mainForm mainForm;
        public SettingsForm(mainForm mainForm)
        {
            InitializeComponent();
            InitializeToolTips();
            this.mainForm = mainForm;
        }

        private void InitializeToolTips()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(orgaLabel, "Die Behörden- oder Organisationskennung ist der erste Teil eines Funkrufnamens."
                + " Er dient der Zuordnung zu einer Behörde oder Organisation (z.B. \"Pelikan\" für die DLRG).");
            toolTip1.SetToolTip(gliederungLabel, "Die Gliederung ist der zweite Teil eines Funkrufnamens."
                + " Er dient der der lokalen Zuordnung (z.B. Landkreis, Gemeinde, Vereinsgliederungsebene)."); 
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            organisationBox.Text = Properties.Settings.Default.OrgaKennung;
            gliederungBox.Text = Properties.Settings.Default.Gliederung;
            funkerBox.Text = mainForm.Funker;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Ok();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ok();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Ok()
        {
            Properties.Settings.Default.OrgaKennung = organisationBox.Text.Trim();
            Properties.Settings.Default.Gliederung = gliederungBox.Text.Trim();
            if (funkerBox.Text.Trim() != "")
            {
                mainForm.Funker = funkerBox.Text.Trim();
            }
            Close();
        }
    }
}
