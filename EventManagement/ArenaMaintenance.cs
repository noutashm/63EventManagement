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
    public partial class ArenaMaintenance : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cm;

        public ArenaMaintenance(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            BindControls();
        }

        // handle dark mode on load
        private void ArenaMaintenance_Load(object sender, EventArgs e)
        {
            if (mm.darkModeBool)
                enableDarkMode();
            else
                disableDarkMode();
        }

        // helper functions for dark mode ~ explained more in another form
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

        // return button
        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        // show add panel and don't show add panel on the second function below
        private void addArenaBtn_Click(object sender, EventArgs e) {
            disableExcept(addArenaBtn);
            addPanel.Enabled = true;
            addPanel.Visible = true;
        }

        private void addCancel_Click(object sender, EventArgs e) {
            enableButtons();
            addPanel.Enabled = false;
            addPanel.Visible = false;
        }

        private void addSave_Click(object sender, EventArgs e) {
            DataRow newRecord = dm.dtArena.NewRow();

            // check if anyEmpty with helper function which takes an argument for panel and loops through that panel for text boxes and
            // checks if there's any empty fields, the function returns boolean/ check everything because everything is required in the db for Arena
            if (anyEmpty(addPanel)) {
                MessageBox.Show("All the fields are required!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // check if phone number field contains anything other than numbers and shows errr accordingly
            } else if (!int.TryParse(addNumTxtBox.Text, out int parsedValue)) {
                MessageBox.Show("Phone Number is number only field!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                newRecord["ArenaName"] = addNameTxtBox.Text;
                newRecord["StreetAddress"] = addAddrTxtBox.Text;
                newRecord["Suburb"] = addSubTxtBox.Text;
                newRecord["City"] = addCityTxtBox.Text;
                newRecord["PhoneNumber"] = parsedValue;
                dm.dtArena.Rows.Add(newRecord);
                MessageBox.Show("Arena added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dm.UpdateArena();
                clearFields(addPanel);
            }
        }

        // populate the fields and show updatePanel
        private void updateArenaBtn_Click(object sender, EventArgs e) {
            disableExcept(updateArenaBtn);

            DataRow currentRecord = dm.dtArena.Rows[cm.Position];
            updateNameTxtBox.Text = currentRecord["ArenaName"].ToString();
            updateAddrTxtBox.Text = currentRecord["StreetAddress"].ToString();
            updateSubTxtBox.Text = currentRecord["Suburb"].ToString();
            updateCityTxtBox.Text = currentRecord["City"].ToString();
            updateNumTxtBox.Text = currentRecord["PhoneNumber"].ToString();

            updatePanel.Enabled = true;
            updatePanel.Visible = true;
        }

        // update panel cancel button
        private void updateCancel_Click(object sender, EventArgs e) {
            enableButtons();
            updatePanel.Enabled = false;
            updatePanel.Visible = false;
        }

        // similar to add panel with validation and everything but for updating
        private void updateSave_Click(object sender, EventArgs e) {
            DataRow updateRecord = dm.dtArena.Rows[cm.Position];

            if (anyEmpty(updatePanel)) {
                MessageBox.Show("All the fields are required!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!int.TryParse(updateNumTxtBox.Text, out int parsedValue)) {
                MessageBox.Show("Phone Number is number only field!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                updateRecord["ArenaName"] = updateNameTxtBox.Text;
                updateRecord["StreetAddress"] = updateAddrTxtBox.Text;
                updateRecord["Suburb"] = updateSubTxtBox.Text;
                updateRecord["City"] = updateCityTxtBox.Text;
                updateRecord["PhoneNumber"] = parsedValue;
                cm.EndCurrentEdit();
                dm.UpdateArena();
                MessageBox.Show("Arena updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // next/prev buttons for listBox
        private void previousBtn_Click(object sender, EventArgs e) {
            if (cm.Position > 0)
                --cm.Position;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            if(cm.Position < cm.Count - 1)
                ++cm.Position;
        }

        // check if arena has any events and give error if it does
        private void deleteArenaBtn_Click(object sender, EventArgs e) {
            DataRow deleteRecord = dm.dtArena.Rows[cm.Position];
            DataRow[] eventRows = dm.dtEvent.Select("ArenaID = " + idTxtBox.Text);
            if (eventRows.Length != 0)
            {
                MessageBox.Show("You may only delete Arenas that have no events!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    deleteRecord.Delete();
                    dm.UpdateArena();
                    MessageBox.Show("Arena deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BindControls() {
            idTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.ArenaID");
            nameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.ArenaName");
            addrTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.StreetAddress");
            suburbTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.Suburb");
            cityTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.City");
            phoneTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Arena.PhoneNumber");
            
            arenaList.DataSource = dm.dsNZESL;
            arenaList.DisplayMember = "Arena";
            arenaList.ValueMember = "Arena.ArenaName";
            cm = (CurrencyManager)BindingContext[dm.dsNZESL, "Arena"];
        }

        // disableExcept takes btn as argument which will disable all the buttons in control except the particular button
        private void disableExcept(RoundButton btn) {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                if (button != btn) {
                    // disable them
                    button.Enabled = false;
                    // and change the color to look more disabled
                    button.BackColor = Color.FromArgb(175, 196, 222);
                }
            }
            arenaList.Enabled = false;
        }

        // enable buttons/loop through all the buttons and enable them/ also enable back to different color if dark mode enabled
        private void enableButtons() {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                button.Enabled = true;
                if (mm.darkModeBool)
                    button.BackColor = mm.darkModeBtnBackColor;
                else
                    button.BackColor = Color.FromArgb(113, 167, 232);
            }
            arenaList.Enabled = true;
        }

        // clear all the fields in a panel/ like for exampleif adding a record and clicking add, then clearing the fields would be nice
        private void clearFields(Panel panel)
        {
            foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                tb.Text = "";
        }

        // boolean returning functions checks if any of the textboxes in a panel is empty ~ true for yes/ false for no
        private bool anyEmpty(Panel panel) {
            foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                if (tb.Text == "")
                    return true;
            return false;
        }
    }
}
