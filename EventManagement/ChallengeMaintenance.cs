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
    public partial class ChallengeMaintenance : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cm;

        public ChallengeMaintenance(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            BindControls();
        }

        // dark mode handling on load
        private void ChallengeMaintenance_Load(object sender, EventArgs e)
        {
            if (mm.darkModeBool)
                enableDarkMode();
            else
                disableDarkMode();
        }

        // helper functions for dark mode ~ explained on other forms
        private void enableDarkMode()
        {
            BackColor = mm.darkModeBackColor;
            ForeColor = mm.darkModeForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = mm.darkModeBtnBackColor;
            foreach (RoundButton button in addPanel.Controls.OfType<RoundButton>())
                button.BackColor = mm.darkModeBtnBackColor;
            foreach (RoundButton button in updatePanel.Controls.OfType<RoundButton>())
                button.BackColor = mm.darkModeBtnBackColor;
        }

        private void disableDarkMode()
        {
            BackColor = mm.defaultBackColor;
            ForeColor = mm.defaultForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
                button.BackColor = mm.defaultBtnBackColor;
            foreach (RoundButton button in addPanel.Controls.OfType<RoundButton>())
                button.BackColor = mm.defaultBtnBackColor;
            foreach (RoundButton button in updatePanel.Controls.OfType<RoundButton>())
                button.BackColor = mm.defaultBtnBackColor;
        }

        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void addChalBtn_Click(object sender, EventArgs e) {
            disableExcept(addChalBtn);

            // when clicking addEventBtn ~ populate Event with EventID list
            if (addEventIDComboBox.Items.Count == 0)
            {
                for (int i = 0; i < dm.dtEvent.Rows.Count; i++)
                {
                    addEventIDComboBox.Items.Add(dm.dtEvent.Rows[i]["EventID"]);
                }
            }

            addPanel.Enabled = true;
            addPanel.Visible = true;
        }

        // populate eventName according to selected eventID in addEventComboBox
        private void addEventIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int eventID = Convert.ToInt32(addEventIDComboBox.SelectedItem);
            DataRow[] eventRecord = dm.dtEvent.Select("EventID = " + eventID);
            addEventNameTxtBox.Text = eventRecord[0]["EventName"].ToString();
        }

        // updateButton event handler ~ explained ~ populate the fields according to previous selected record
        private void updateChalBtn_Click(object sender, EventArgs e) {
            disableExcept(updateChalBtn);

            DataRow currentRecord = dm.dtChal.Rows[cm.Position];
            DataRow[] eventRecord = dm.dtEvent.Select("EventID = " + currentRecord["EventID"].ToString());
            updateNameTxtBox.Text = currentRecord["ChallengeName"].ToString();
            updateEventIDTxtBox.Text = currentRecord["EventID"].ToString();
            updateEventNameTxtBox.Text = eventRecord[0]["EventName"].ToString();
            updateStartTime.Value = (DateTime)currentRecord["StartTime"];
            updateStatusTxtBox.Text = currentRecord["Status"].ToString();
            updateCapacityTxtBox.Value = (int)currentRecord["Capacity"];

            updatePanel.Enabled = true;
            updatePanel.Visible = true;
        }

        // delete challenge event handler
        private void deleteChalBtn_Click(object sender, EventArgs e) {
            DataRow deleteRecord = dm.dtChal.Rows[cm.Position];

            // check if the selected record has any entries
            DataRow[] entryRows = dm.dtEntry.Select("ChallengeID = " + idTxtBox.Text);
            
            // validation if it has entries
            if (entryRows.Length != 0)
                MessageBox.Show("You may only delete a challenge that has no entries!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // if validated, ask for confirmation
                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    deleteRecord.Delete();
                    dm.UpdateChallenge();
                    MessageBox.Show("Challenge deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // mark challenge as finished button event handler
        private void finishChalBtn_Click(object sender, EventArgs e) {
            DataRow currentRow = dm.dtChal.Rows[cm.Position];
            // check if challenge is scheduled
            if (currentRow["Status"].ToString() == "Scheduled")
            {
                currentRow["Status"] = "Finished";
                cm.EndCurrentEdit();
                dm.UpdateChallenge();
                MessageBox.Show("Challenge marked as finished!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                // if challenge is not ~ show message box error
                MessageBox.Show("Only scheduled challenges can be marked as finished!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // similar to above function but for complete
        private void completeChalBtn_Click(object sender, EventArgs e) {
            DataRow currentRow = dm.dtChal.Rows[cm.Position];
            // check if challenge is finished
            if (currentRow["Status"].ToString() == "Finished")
            {
                currentRow["Status"] = "Completed";
                cm.EndCurrentEdit();
                dm.UpdateChallenge();
                MessageBox.Show("Challenge marked as completed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // and if not finished ~ show message box error
            else
            {
                MessageBox.Show("Only finished challenges can be marked as completed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // save button with validation ~ expalined in other forms
        private void addSave_Click(object sender, EventArgs e) {
            DataRow newRecord = dm.dtChal.NewRow();

            if (addNameTxtBox.Text == "" || addEventIDComboBox.SelectedItem == null || addStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                newRecord["ChallengeName"] = addNameTxtBox.Text;
                newRecord["EventID"] = addEventIDComboBox.SelectedItem;
                newRecord["StartTime"] = addStartTime.Text;
                newRecord["Status"] = addStatusComboBox.SelectedItem;
                newRecord["Capacity"] = addCapacityTxtBox.Value;
                dm.dtChal.Rows.Add(newRecord);
                dm.UpdateChallenge();
                MessageBox.Show("Challenge added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields(addPanel);
            }
        }

        // cancel/addPanel button
        private void addCancel_Click(object sender, EventArgs e) {
            enableButtons();
            addPanel.Enabled = false;
            addPanel.Visible = false;
        }

        // save updatePanel button with validation
        private void updateSave_Click(object sender, EventArgs e) {
            DataRow updateRecord = dm.dtChal.Rows[cm.Position];

            if (updateNameTxtBox.Text == "")
            {
                MessageBox.Show("Please fill all the required fields!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                updateRecord["ChallengeName"] = updateNameTxtBox.Text;
                updateRecord["StartTime"] = updateStartTime.Text;
                updateRecord["Capacity"] = updateCapacityTxtBox.Value;
                cm.EndCurrentEdit();
                dm.UpdateChallenge();
                MessageBox.Show("Challenge updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // cancel updatePanel button
        private void updateCancel_Click(object sender, EventArgs e) {
            enableButtons();
            updatePanel.Enabled = false;
            updatePanel.Visible = false;
        }

        // listen for challenge selected index change
        private void challengeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if cm is not null then get current position and record and populate the Event Name field
            if (cm != null)
            {
                DataRow currentRecord = dm.dtChal.Rows[cm.Position];
                DataRow[] eventRecord = dm.dtEvent.Select("EventID = " + currentRecord["EventID"].ToString());
                eventNameTxtBox.Text = eventRecord[0]["EventName"].ToString();
            }
            // if cm is null then get the first challenge's eventID and populate the event name field
            // like this, it will always be populated
            else
            {
                DataRow[] chalRecord = dm.dtChal.Select("", "ChallengeID");
                DataRow[] eventRecord = dm.dtEvent.Select("EventID = " + chalRecord[0]["EventID"].ToString(), "EventID");
                eventNameTxtBox.Text = eventRecord[0]["EventName"].ToString();
            }
        }

        // next and prev buttons
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (cm.Position > 0)
                --cm.Position;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (cm.Position < cm.Count - 1)
                ++cm.Position;
        }

        // helper functions
        private void disableExcept(RoundButton btn) {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                if (button != btn) {
                    button.Enabled = false;
                    button.BackColor = Color.FromArgb(175, 196, 222);
                }
            }

            challengeList.Enabled = false;
        }

        private void enableButtons() {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                button.Enabled = true;
                if (mm.darkModeBool)
                    button.BackColor = mm.darkModeBtnBackColor;
                else
                    button.BackColor = Color.FromArgb(113, 167, 232);
            }

            challengeList.Enabled = true;
        }

        private void clearFields(Panel panel)
        {
            foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                tb.Text = "";

            addStatusComboBox.SelectedItem = null;

            addCapacityTxtBox.Value = 2;
        }

        // binding listBox and fields
        private void BindControls()
        {
            idTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.ChallengeID");
            nameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.ChallengeName");
            eventIDTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.EventID");
            startTimeTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.StartTime");
            statusTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.Status");
            capacityTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Challenge.Capacity");

            challengeList.DataSource = dm.dsNZESL;
            challengeList.DisplayMember = "Challenge";
            challengeList.ValueMember = "Challenge.ChallengeID";
            cm = (CurrencyManager)BindingContext[dm.dsNZESL, "Challenge"];
        }
    }
}
