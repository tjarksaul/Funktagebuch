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
    public partial class ModalQuestion : Form
    {
        public static string Ask(string title, string question, bool cancelEnabled)
        {
            ModalQuestion qtn = new ModalQuestion(title, question, cancelEnabled);
            qtn.ShowDialog();
            if (qtn.ExitState)
            {
                return qtn.Value;
            }
            else
            {
                throw new NotAnsweredException();
            }
        }

        private string title;
        private string question;
        private bool cancelEnabled;

        private bool exitState;
        public string Value
        {
            get
            {
                return answerBox.Text;
            }
        }
        public bool ExitState
        {
            get
            {
                return exitState;
            }
        }

        public ModalQuestion(string title, string question, bool cancelEnabled)
        {
            this.title = title;
            this.question = question;
            this.cancelEnabled = cancelEnabled;
            InitializeComponent();
            ProcessInput();
        }

        public ModalQuestion(string title, string question)
            : this(title, question, true)
        {

        }

        private void answerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Okay();
            }
            else if (e.KeyCode == Keys.Escape && cancelEnabled)
            {
                Cancel();
            }
        }

        private void Okay()
        {
            if (answerBox.Text.Trim() == "" && cancelEnabled)
            {
                exitState = false;
                Close();
            }
            else if (answerBox.Text.Trim() == "")
            {
                MessageBox.Show("Bitte geben Sie einen Text ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                exitState = true;
                Close();
            }
        }

        private void Cancel()
        {
            exitState = false;
            Close();
        }

        private void ProcessInput()
        {
            Text = title;
            questionLabel.Text = question;
            ControlBox = cancelEnabled;
            cancelButton.Enabled = cancelEnabled;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Okay();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void ModalQuestion_Shown(object sender, EventArgs e)
        {
            answerBox.Focus();
        }
    }
}
