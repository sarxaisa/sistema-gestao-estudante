﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudante
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirEstudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormInserirEstudantes inserirEstudantes = new FormInserirEstudantes();
            inserirEstudantes.Show(this);
        }
    }
}
