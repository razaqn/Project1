﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btmember_Click(object sender, EventArgs e)
        {
            FormMember fmb = new FormMember();
            fmb.Show();
            this.Hide();
        }

        private void btbook_Click(object sender, EventArgs e)
        {
            FormBook fbk = new FormBook();
            fbk.Show();
            this.Hide();
        }

        private void bttransaction_Click(object sender, EventArgs e)
        {
            FormTransaction fts = new FormTransaction();
            fts.Show();
            this.Hide();
        }

        private void btemployee_Click(object sender, EventArgs e)
        {
            FormEmployee fem = new FormEmployee();
            fem.Show();
            this.Hide();
        }
    }
}
