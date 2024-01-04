using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedrunnersStats
{
    public partial class SettingsPage : Form
    {
        Controller controller;
        Settings newSettings;
        List<Form> activeForms;
        public SettingsPage(ref Controller controller, ref List<Form> activeForms)
        {
            InitializeComponent();
            this.controller = controller;
            newSettings = this.controller.settings.copy();
            itemCheckbox.Checked = newSettings.complexItems;
            playerCheckbox.Checked = newSettings.complexPlayers;
            loadingCheckBox.Checked = newSettings.foregroundLoading;
            dataLabel.Text = "Data Path:\n" + controller.settings.dataPath;
            dumpLabel.Text = "Dump Source:\n" + controller.settings.dumpSource;
            this.activeForms = activeForms;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.complexItems = itemCheckbox.Checked;
        }

        private void playerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.complexPlayers = playerCheckbox.Checked;
        }

        private void loadingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.foregroundLoading = loadingCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(controller.settings.complexItems != newSettings.complexItems || controller.settings.complexPlayers != newSettings.complexPlayers || controller.settings.foregroundLoading != newSettings.foregroundLoading)
            {
                foreach(Form form in activeForms)
                {
                    form.Close();
                }
            }
            controller.settings = newSettings.copy();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            itemCheckbox.Checked = controller.settings.complexItems;
            playerCheckbox.Checked = controller.settings.complexPlayers;
            loadingCheckBox.Checked = controller.settings.foregroundLoading;
            dataLabel.Text = "Data Path:\n" + controller.settings.dataPath;
            dumpLabel.Text = "Dump Source:\n" + controller.settings.dumpSource;
            newSettings.dataPath = controller.settings.dataPath;
            newSettings.dumpSource = controller.settings.dumpSource;
        }
    }
}
