﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class StartForm : Form
    {
        public List<RadioButton> radioButtons;
        public StartForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>
            {
                radioButton1, radioButton2, radioButton3, radioButton4
            };
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
