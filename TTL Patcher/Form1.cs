using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTL_Patcher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void patchRegistry(int ttl)
        {
            RegistryKey saveKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", true);
            saveKey.SetValue("DefaultTTL", ttl);
            if (Convert.ToInt32(saveKey.GetValue("DefaultTTL")) == Convert.ToInt32(ttlBox.Text) + 1)
            {
                MessageBox.Show("Your TTL was changed successfully!\nReboot to apply changes!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show("Error occured!", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry) patchRegistry(ttl);
            }
        }

        private void ttlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' | Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void manualInputCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (manualInputCheck.Checked) ttlBox.ReadOnly = false;
            else ttlBox.ReadOnly = true;
        }

        private void selectOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectOS.SelectedIndex == 1) ttlBox.Text = "64";
            else ttlBox.Text = "64";
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            patchRegistry(Convert.ToInt32(ttlBox.Text) + 1);
        }
    }
}
