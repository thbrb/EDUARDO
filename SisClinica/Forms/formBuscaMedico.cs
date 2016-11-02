﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisClinica.Classes;

namespace SisClinica.Forms
{
    public partial class formBuscaMedico : Form
    {
        public formBuscaMedico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgMedicos.DataSource = new Medico().Pesquisar(txtBoxNome.Text);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
