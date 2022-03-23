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
    public partial class EventMaintenance : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cm;

        public EventMaintenance(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            BindControls();
        }

        // dark mode handling
        private void EventMaintenance_Load(object sender, EventArgs e)
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

        // close form
        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        // add event button/populate Arena with ArenaID list
        private void addEventBtn_Click(object sender, EventArgs e) {
            disableExcept(addEventBtn);

            if (addArenaIDComboBox.Items.Count == 0)
            {
                for (int i = 0; i < dm.dtArena.Rows.Count; i++)
                {
                    addArenaIDComboBox.Items.Add(dm.dtArena.Rows[i]["ArenaID"]);
                }
            }

            addPanel.Enabled = true;
            addPanel.Visible = true;
        }

        // event handler to populate arena name textbox based on selected arena ID
        private void addArenaIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do a check it's not null
            if (addArenaIDComboBox.SelectedItem != null)
            {
                // get arena id
                int arenaID = (int)addArenaIDComboBox.SelectedItem;
                // get arena recodr with the above arena id
                DataRow[] arenaRecord = dm.dtArena.Select("ArenaID = " + arenaID);
                // populate the retrived record's arena name into text box
                addArenaNameTxtBox.Text = arenaRecord[0]["ArenaName"].ToString();
            }
        }


        // handling update event
        private void updateEventBtn_Click(object sender, EventArgs e) {
            disableExcept(updateEventBtn);

            DataRow currentRecord = dm.dtEvent.Rows[cm.Position];
            DataRow[] arenaRecord = dm.dtArena.Select("ArenaID = " + currentRecord["ArenaID"].ToString());
            updateNameTxtBox.Text = currentRecord["EventName"].ToString();
            updateArenaIDTxtBox.Text = currentRecord["ArenaID"].ToString();
            updateArenaNameTxtBox.Text = arenaRecord[0]["ArenaName"].ToString();
            updateStatusComboBox.SelectedItem = currentRecord["Status"].ToString();
            updateCapcityNumBox.Value = (int) currentRecord["Capacity"];
            updateDatePicker.Value = (DateTime) currentRecord["EventDate"];

            updatePanel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void deleteEventBtn_Click(object sender, EventArgs e) {
            DataRow deleteRecord = dm.dtEvent.Rows[cm.Position];
            // check challenge records for any event id and show error if there are events with challenges
            DataRow[] chalRows = dm.dtChal.Select("EventID = " + idTxtBox.Text);
            if (chalRows.Length != 0)
                MessageBox.Show("You may only delete events that have no challenges!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    deleteRecord.Delete();
                    dm.UpdateEvent();
                    MessageBox.Show("Event deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addSave_Click(object sender, EventArgs e) {
            DataRow newRecord = dm.dtEvent.NewRow();

            // validation for adding and show message
            if (addNameTxtBox.Text == "" || addArenaIDComboBox.SelectedItem == null || addStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                newRecord["EventName"] = addNameTxtBox.Text;
                newRecord["ArenaID"] = addArenaIDComboBox.SelectedItem;
                newRecord["Status"] = addStatusComboBox.SelectedItem;
                newRecord["Capacity"] = addCapcityNumBox.Value;
                newRecord["EventDate"] = addDatePicker.Value;

                dm.dtEvent.Rows.Add(newRecord);
                dm.UpdateEvent();
                MessageBox.Show("Event added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields(addPanel);
            }
        }

        // cancel add panel/make it go invisible
        private void addCancel_Click(object sender, EventArgs e) {
            enableButtons();
            addPanel.Enabled = false;
            addPanel.Visible = false;
        }

        // similar to add save but more in tuned for this panel
        private void updateSave_Click(object sender, EventArgs e) {
            DataRow updateRecord = dm.dtEvent.Rows[cm.Position];

            if (updateNameTxtBox.Text == "" || updateStatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields!", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateRecord["EventName"] = updateNameTxtBox.Text;
                updateRecord["Status"] = updateStatusComboBox.SelectedItem;
                updateRecord["Capacity"] = updateCapcityNumBox.Value;
                updateRecord["EventDate"] = updateDatePicker.Value;
                cm.EndCurrentEdit();
                dm.UpdateEvent();
                MessageBox.Show("Event updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // similar to add cancel
        private void updateCancel_Click(object sender, EventArgs e) {
            enableButtons();
            updatePanel.Enabled = false;
            updatePanel.Visible = false;
        }

        // next/prev buttons
        private void previousBtn_Click(object sender, EventArgs e) {
            if (cm.Position > 0)
                --cm.Position;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            if (cm.Position < cm.Count - 1)
                ++cm.Position;
        }

        // event list box event listener
        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if currency manager is not null
            if (cm != null)
            {
                // get current record's arena id and use that to get current arena name and populate the field
                DataRow currentRecord = dm.dtEvent.Rows[cm.Position];
                DataRow[] arenaRecord = dm.dtArena.Select("ArenaID = " + currentRecord["ArenaID"].ToString());
                arenaNameTxtBox.Text = arenaRecord[0]["ArenaName"].ToString();
                // else, populate it with the first event's independen record
            } else
            {
                DataRow[] eventRecord = dm.dtEvent.Select("", "EventID");
                DataRow[] arenaRecord = dm.dtArena.Select("ArenaID = " + eventRecord[0]["ArenaID"].ToString(), "ArenaID");
                arenaNameTxtBox.Text = arenaRecord[0]["ArenaName"].ToString();
            }
        }

        // binding controls
        private void BindControls() {
            idTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.EventID");
            nameTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.EventName");
            arenaIDTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.ArenaID");
            statusTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.Status");
            capacityTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.Capacity");
            dateTxtBox.DataBindings.Add("Text", dm.dsNZESL, "Event.EventDate");

            eventList.DataSource = dm.dsNZESL;
            eventList.DisplayMember = "Event";
            eventList.ValueMember = "Event.EventName";
            cm = (CurrencyManager)BindingContext[dm.dsNZESL, "Event"];
        }

        // helper functions ~ explained more in other forms
        private void disableExcept(RoundButton btn) {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                if (button != btn) {
                    button.Enabled = false;
                    button.BackColor = Color.FromArgb(175, 196, 222);
                }
            }

            eventList.Enabled = false;
        }

        private void enableButtons() {
            foreach (RoundButton button in Controls.OfType<RoundButton>()) {
                button.Enabled = true;
                if (mm.darkModeBool)
                    button.BackColor = mm.darkModeBtnBackColor;
                else
                    button.BackColor = Color.FromArgb(113, 167, 232);
            }

            eventList.Enabled = true;
        }

        private void clearFields(Panel panel)
        {
            foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                tb.Text = "";

            foreach (ComboBox cb in panel.Controls.OfType<ComboBox>())
                cb.SelectedItem = null;

            addCapcityNumBox.Value = 101;
        }
    }
}
