﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class INICIO : Form
    {
        private int idCateg;

        public INICIO(int id)
        {
            InitializeComponent();
            this.idCateg = id;
        }
    }
}
