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
    public partial class CompetitorMaintenance : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cm;

        // adding arguments for DataModule and MainMenu to be able to use dark mode and manipulate db centerly
        public CompetitorMaintenance(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            BindControls();
        }

        // check for dark mode form onload
        private void CompetitorMaintenance_Load(object sender, EventArgs e)
        {
            if (mm.darkModeBool)
                enableDarkMode();
            else
                disableDarkMode();
        }

        // dark mode helper functions - self explanitory - changing backcolor/forecolor
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

        // when clicking add competitor show addPanel and disable buttons with disableExcept helper function
        private void addCompetitorBtn_Click(object sender, EventArgs e) {
            disableExcept(addCompetitorBtn);
            addPanel.Enabled = true;
            addPanel.Visible = true;
        }

        // event lister for updating competitor
        private void updateCompetitorBtn_Click(object sender, EventArgs e) {
            // disable buttons
            disableExcept(updateCompetitorBtn);

            // populate fields with currently selected record
            DataRow currentRecord = dm.dtComp.Rows[cm.Position];
            updateUsernameTxtBox.Text = currentRecord["UserName"].ToString();
            updatefirstNameTxtBox.Text = currentRecord["FirstName"].ToString();
            updateLastNameTxtBox.Text = currentRecord["LastName"].ToString();

            // light handling for 'Gelding' hehehe
            if (currentRecord["Gender"].ToString() == "Gelding")
            {
                currentRecord["Gender"] = "Other";
            }
            updateGenderComboBox.SelectedItem = currentRecord["Gender"].ToString();
            updateDatePicker.Text = currentRecord["DateOfBirth"].ToString();
            updateEmailTxtBox.Text = currentRecord["EmailAddress"].ToString();

            // make updatePanel visible
            updatePanel.Enabled = true;
            updatePanel.Visible = true;
        }

        // delete competitor event handler function
        private void deleteCompetitorBtn_Click(object sender, EventArgs e) {
            // get selected record
            DataRow deleteRecord = dm.dtComp.Rows[cm.Position];

            // get entry records by competitorID to see if the current competitor has any entry recor
            DataRow[] entryRows = dm.dtEntry.Select("CompetitorID = " + idTxtBox.Text);
            
            // if competitor has entry record show error
            if (entryRows.Length != 0)
            {
                MessageBox.Show("You may only delete competitors that have no entries!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // else ask for confirmation
            } else
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                // if confirmed delete record
                if (d == DialogResult.Yes)
                {
                    deleteRecord.Delete();
                    dm.UpdateCompetitor();

                    // show delete message box
                    MessageBox.Show("Competitor deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // close competitor form on returnBtn click
        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        // when user fills in addPanel and clicks on save competitor button event handler
        private void addSave_Click(object sender, EventArgs e) {
            // Initialize new row
            DataRow newRecord = dm.dtComp.NewRow();

            // validation if they are empty then show error message box
            if (addUsernameTxtBox.Text == "" || addGenderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the Required Fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // else save and show confirmation message box
                newRecord["UserName"] = addUsernameTxtBox.Text;
                newRecord["FirstName"] = addfirstNameTxtBox.Text;
                newRecord["LastName"] = addLastNameTxtBox.Text;
                newRecord["Gender"] = addGenderComboBox.SelectedItem;
                newRecord["DateOfBirth"] = addDatePicker.Value;
                newRecord["EmailAddress"] = addEmailTxtBox.Text;
                dm.dtComp.Rows.Add(newRecord);
                dm.UpdateCompetitor();
                MessageBox.Show("Competitor added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields(addPanel);
            }
        }

        // if clicking on cancel rather than save competitor
        private void addCancel_Click(object sender, EventArgs e) {
            enableButtons();
            addPanel.Enabled = false;
            addPanel.Visible = false;
        }

        // when userfills in updatePanel and clicks on update competitor button event handler
        private void updateSave_Click(object sender, EventArgs e) {
            DataRow updateRecord = dm.dtComp.Rows[cm.Position];

            // validation ~ save as above
            if (updateUsernameTxtBox.Text == "" || updateGenderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the Required Fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                updateRecord["UserName"] = updateUsernameTxtBox.Text;
                updateRecord["FirstName"] = updatefirstNameTxtBox.Text;
                updateRecord["LastName"] = updateLastNameTxtBox.Text;
                updateRecord["Gender"] = updateGenderComboBox.SelectedItem;
                updateRecord["DateOfBirth"] = updateDatePicker.Value;
                updateRecord["EmailAddress"] = updateEmailTxtBox.Text;
                cm.EndCurrentEdit();
                dm.UpdateCompetitor();
                MessageBox.Show("Competitor updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        // same as addCancel
        private void updateCancel_Click(object sender, EventArgs e) {
            enableButtons();
            updatePanel.Enabled = false;
            updatePanel.Visible = false;
        }

        // helper functions explained in the other forms
        private void disableExcept(RoundButton btn) {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                if (button != btn) {
                    button.Enabled = false;
                    button.BackColor = Color.FromArgb(175, 196, 222);
                }
            }

            competitorList.Enabled = false;
        }

        private void enableButtons() {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                button.Enabled = true;
                if (mm.darkModeBool)
                    button.BackColor = mm.darkModeBtnBackColor;
                else
                    button.BackColor = Color.FromArgb(113, 167, 232);
            }

            competitorList.Enabled = true;
        }

        // helper function ~ to clear after adding a competitor
        private void clearFields(Panel panel)
        {
            foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                tb.Text = "";

            foreach (ComboBox cb in panel.Controls.OfType<ComboBox>())
                cb.SelectedItem = null;
        }

        // bind records to textboxes/controls and listBox
        private void BindControls()
        {
            idTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.CompetitorID");
            usernameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.UserName");
            firstNameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.FirstName");
            lastNameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.LastName");
            genderTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.Gender");
            dateTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.DateOfBirth");
            emailTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Competitor.EmailAddress");

            competitorList.DataSource = dm.dsNZESL;
            competitorList.DisplayMember = "Competitor";
            competitorList.ValueMember = "Competitor.UserName";
            cm = (CurrencyManager)BindingContext[dm.dsNZESL, "Competitor"];
        }

        // prev and next button to increment/decrement currency manager to browse through list of competitors
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
    }
}
