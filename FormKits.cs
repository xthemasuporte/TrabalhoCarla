using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormKits : Form
    {
        public ArrayList listaKits;
        public FormKits()
        {
            InitializeComponent();
            listaKits = new ArrayList();

            listaKits.Add("015;Kit Semana Nobre;3.000 KG;Picado de carne,Bife,Contra File,Carne Muida");
            listaKits.Add("016;Kit Espetinho;2.000 KG;Espetinho de Frango,Espetinho de Kafta,Espetinho de Carne");
            listaKits.Add("017;Kit Tira gosto;1.500 KG;Picado de carne,Toicinho,Calabrtesa Fatiada");
            listaKits.Add("018;Kit Maromba;2.000 KG;Picado de carne,Bife,Almondega,Carne Muida");
            listaKits.Add("019;Kit Hamburguer 1;1.000 KG;Hamburguer Artesanal,Queijo,Bacon,Batata");
            listaKits.Add("020;Kit Hamburguer 2;1.500 KG;Hamburguer de Costela, Cheddar,Bacon,Picles");
            listaKits.Add("021;Kit Frango;4.000 KG;File de Frango,Coxa de Frango,Medalhao de Frango");
            listaKits.Add("022;Kit Semana 1;4.000 KG;Picado de carne,Bife,Salsicha,Frango a passarinho");
            listaKits.Add("023;Kit Semana 2;6.000 KG;Picado de carne,Bife,Apimentada,Rocambole");
            listaKits.Add("024;Kit Bovinao;6.000 KG;Milanesa,Empanado,Medalhao de Carne");
            listaKits.Add("025;Kit Maromba;2.000 KG;Picado de carne,File de Coxa,Peito de frango");
            listaKits.Add("026;Kit Churrasco;2.000 KG;Pao de Alho,Picanha,Fraldinha,Toscana");
            listaKits.Add("027;Kit Churrasco Nobre 1;3.000 KG;Picanha,Coxao duro,Maminha,Asinha de Frango");
            listaKits.Add("028;Kit Churrasco Nobre 2;4.000 KG;Picado de Frango,Toscana de Frango,Coxinha da Asa");


            foreach (String kits in listaKits)
            {
                string[] listaKits = kits.Split(';');
                dataGridView1.Rows.Add(listaKits);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKits_Load(object sender, EventArgs e)
        {


        }
    }
}
