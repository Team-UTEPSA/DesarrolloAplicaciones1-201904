﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace verCanchas
{
    public partial class Form1 : Form
    {
        Canchas objcanchas = new Canchas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCanchas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objcanchas.listarCanchas();
        }
    }
}
