﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квест
{
    public partial class PDA : Form
    {
        public PDA()
        {
            InitializeComponent();
        }

        private void PDA_Load(object sender, EventArgs e)
        {

        }

        private void OpenMaps_Click(object sender, EventArgs e)
        {
            FormPdaMaps form2 = new FormPdaMaps();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            FormStatistica form2 = new FormStatistica();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
