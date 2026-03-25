using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Equipo2WF_JJUT_RERC
{
    public partial class Form2 : Form
    {
        private List<string[]> datosEmpleados;
        public Form2(List<string[]> ListaDelForm1)
        {
            InitializeComponent();

            datosEmpleados = ListaDelForm1;
            datosEmpleados = datosEmpleados.OrderBy(x => x[1]).ToList();
            foreach (string[] a in datosEmpleados)
            {
               label1.Text += a[0] + "\n" + a[1] + "\n" + a[2] + "\n" +  a[3] + "\n" + a[4] + "\n" + a[5] + "\n" + a[6] + "\n" + a[7] + "\n" + a[8] + "\n" + "\n";
            }
        }
    }
}
