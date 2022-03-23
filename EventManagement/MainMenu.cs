using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement {
    public partial class MainMenu : Form {

        // Initilizing Forms
        private ArenaMaintenance am;
        private CompetitorMaintenance comM;
        private EventMaintenance em;
        private ChallengeMaintenance chalM;
        private EnterCompetitorIntoChallenge ecic;
        private EventReport er;
        private CompetitorReport cr;
        private DataModule dm;

        // Defining Dark Mode/Default Colors
        public Color darkModeBackColor = Color.FromArgb(64, 64, 64);
        public Color darkModeForeColor = Color.White;
        public Color darkModeBtnBackColor = Color.Gray;

        public Color defaultBackColor = Color.FromArgb(180, 202, 228);
        public Color defaultForeColor = Color.Black;
        public Color defaultBtnBackColor = Color.FromArgb(113, 167, 232);

        // darkMode trigger
        public bool darkModeBool;

        public MainMenu() {
            InitializeComponent();
        }

        // Exit button eventHandler
        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // functions below if forms aren't null open on click handler
        private void arenaMainBtn_Click(object sender, EventArgs e) {
            if (am == null)
                am = new ArenaMaintenance(dm, this);
            am.ShowDialog();
        }

        private void compMainBtn_Click(object sender, EventArgs e) {
            if (comM == null)
                comM = new CompetitorMaintenance(dm, this);
            comM.ShowDialog();
        }

        private void eventMainBtn_Click(object sender, EventArgs e) {
            if (em == null)
                em = new EventMaintenance(dm, this);
            em.ShowDialog();
        }

        private void challMainBtn_Click(object sender, EventArgs e) {
            if (chalM == null)
                chalM = new ChallengeMaintenance(dm, this);
            chalM.ShowDialog();
        }

        private void enterCompIntoChalBtn_Click(object sender, EventArgs e) {
            if (ecic == null)
                ecic = new EnterCompetitorIntoChallenge(dm, this);
            ecic.ShowDialog();
        }

        private void eventReportBtn_Click(object sender, EventArgs e) {
            if (er == null)
                er = new EventReport(dm, this);
            er.ShowDialog();
        }

        private void compReportBtn_Click(object sender, EventArgs e) {
            if (cr == null)
                cr = new CompetitorReport(dm, this);
            cr.ShowDialog();
        }

        // Load Data Module Form on MainMenu load and connect to database
        private void MainMenu_Load(object sender, EventArgs e) {
            dm = new DataModule();
        }

        // Switch case inside event handler, handling dark mode
        private void darkModeButton_Click(object sender, EventArgs e)
        {
            switch (darkModeBool)
            {
                case true: darkModeBool = false;
                    disableDarkMode();
                    break;
                case false: darkModeBool = true;
                    enableDarkMode();
                    break;
                default: darkModeBool = true;
                    enableDarkMode();
                    break;
            }
        }

        // helper function, what to do when disabling darkmode
        private void disableDarkMode()
        {
            BackColor = defaultBackColor;
            ForeColor = defaultForeColor;
            mainGroupBox.ForeColor = defaultForeColor;
            reportingGroupBox.ForeColor = defaultForeColor;

            // foreach looping through form and groupboxes to get all the buttons and change their color
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = defaultBtnBackColor;
            foreach (RoundButton button in mainGroupBox.Controls.OfType<RoundButton>())
                button.BackColor = defaultBtnBackColor;
            foreach (RoundButton button in reportingGroupBox.Controls.OfType<RoundButton>())
                button.BackColor = defaultBtnBackColor;
        }

        // helper function - what happens when enabling dark mode
        private void enableDarkMode()
        {
            BackColor = darkModeBackColor;
            ForeColor = darkModeForeColor;
            mainGroupBox.ForeColor = darkModeForeColor;
            reportingGroupBox.ForeColor = darkModeForeColor;

            // same as disableDarkMode
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = darkModeBtnBackColor;
            foreach (RoundButton button in mainGroupBox.Controls.OfType<RoundButton>())
                button.BackColor = darkModeBtnBackColor;
            foreach (RoundButton button in reportingGroupBox.Controls.OfType<RoundButton>())
                button.BackColor = darkModeBtnBackColor;
        }
    }
}
