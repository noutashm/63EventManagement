using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement {
    public partial class EnterCompetitorIntoChallenge : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cmComp, cmChal;
        private DataTable dtEntry;

        public EnterCompetitorIntoChallenge(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            cmComp = (CurrencyManager)BindingContext[dm.dsNZESL, "Competitor"];
            cmChal = (CurrencyManager)BindingContext[dm.dsNZESL, "Challenge"];
            BindControls();
        }

        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        // handling dark mode
        private void EnterCompetitorIntoChallenge_Load(object sender, EventArgs e)
        {
            if (mm.darkModeBool)
                enableDarkMode();
            else
                disableDarkMode();
        }

        // dark mode helper functions
        private void enableDarkMode()
        {
            BackColor = mm.darkModeBackColor;
            foreach (Label lab in Controls.OfType<Label>())
                lab.ForeColor = mm.darkModeForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = mm.darkModeBtnBackColor;
        }

        private void disableDarkMode()
        {
            BackColor = mm.defaultBackColor;
            foreach (Label lab in Controls.OfType<Label>())
                lab.ForeColor = mm.defaultForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = mm.defaultBtnBackColor;
        }

        // bind controls
        private void BindControls()
        {
            compDataGrid.DataSource = dm.dsNZESL;
            compDataGrid.DataMember = "Competitor";

            chalDataGrid.DataSource = dm.dsNZESL;
            chalDataGrid.DataMember = "Challenge";
        }

        // listen for challenge data grid clicks
        private void chalDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if it was clicked, get the current clicked record, get event status and populate status text box
            DataRow currentRecord = dm.dtChal.Rows[cmChal.Position];
            DataRow[] eventRecord = dm.dtEvent.Select("EventID = " + currentRecord["EventID"].ToString());
            eventStatusTxtBox.Text = eventRecord[0]["Status"].ToString();

            // if challenge data grid is clicked, get current challenge id, make temporary table, clone entry table
            // populate temporoary table the entries related to the chosed challenge
            dtEntry = dm.dtEntry.Clone();
            DataRow[] entryRecords = dm.dtEntry.Select("ChallengeID = " + currentRecord["ChallengeID"].ToString());
            // if it's not empty then import the records to our local datatable and make it entry data grid's datasource
            if (entryRecords != null)
            {
                foreach (DataRow dr in entryRecords)
                {
                    dtEntry.ImportRow(dr);
                }
                entryDataGrid.DataSource = dtEntry;
            }
        }

        // add entry listener
        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            // create new record
            DataRow newRecord = dm.dtEntry.NewRow();

            // get selected records
            DataRow chalRecord = dm.dtChal.Rows[cmChal.Position];
            DataRow compRecord = dm.dtComp.Rows[cmComp.Position];

            // validation if entry status is not choosen
            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please choose a status for entry!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                // validation if callenge status is not scheduled
            } else if (chalRecord["Status"].ToString() != "Scheduled")
            {
                MessageBox.Show("Competitors can only be entered to scheduled challenges!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                newRecord["ChallengeID"] = chalRecord["ChallengeID"];
                newRecord["CompetitorID"] = compRecord["CompetitorID"];
                newRecord["Status"] = statusComboBox.SelectedItem;
                dm.dtEntry.Rows.Add(newRecord);
                dm.UpdateEntry();
                MessageBox.Show("Entry added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // make combo box clear after sucessful adding ~ like clearFields functions for other forms
                statusComboBox.SelectedItem = null;
            }
        }

        // remove entry event listener
        private void removeEntryBtn_Click(object sender, EventArgs e)
        {
            // get current challenge record
            DataRow currentRecord = dm.dtChal.Rows[cmChal.Position];
            // get the current delete record based on challenge id
            DataRow[] deleteRecord = dm.dtEntry.Select("ChallengeID = " + currentRecord["ChallengeID"].ToString());
            // ask for confirmation and delete
            DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                deleteRecord[0].Delete();
                dm.UpdateEntry();
                MessageBox.Show("Entry removed successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
