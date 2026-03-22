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
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Nivel";
            dataGridView1.Columns[2].Name = "Sueldo Bruto";
            dataGridView1.Columns[3].Name = "Exencion De Impuestos";
            dataGridView1.Columns[4].Name = "N° Semanas";
            dataGridView1.Columns[5].Name = "Sueldo Bruto Total";
            dataGridView1.Columns[6].Name = "Retencion De Impuestos";
            dataGridView1.Columns[7].Name = "Sueldo Neto A Cobrar";
            foreach (string[] i in datosEmpleados)
            {
                dataGridView1.Rows.Add(i[0], i[1], i[2], i[3], i[4], i[5], i[6],i[7]);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
