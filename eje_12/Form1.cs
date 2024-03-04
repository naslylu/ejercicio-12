using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbo_Paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paisSeleccionado = cbo_Paises.SelectedItem.ToString();

            // Verificar la información del país seleccionado
            switch (paisSeleccionado)
            {
                case "Estados Unidos":
                    txt_Continente.Text = "América del Norte";
                    txt_Capital.Text = "Washington D.C.";
                    txt_Presidente.Text = "Joe Biden";
                    txt_Gobierno.Text = "República Federal Presidencialista";
                    txt_Poblacion.Text = "331 millones";
                    txt_Idioma.Text = "Inglés";
                    txt_Moneda.Text = "Dólar estadounidense";
                    txt_Religion.Text = "Cristianismo";
                    break;

                case "Canada":
                    txt_Continente.Text = "América del Norte";
                    txt_Capital.Text = "Ottawa";
                    txt_Presidente.Text = "Justin Trudeau";
                    txt_Gobierno.Text = "Monarquía Parlamentaria";
                    txt_Poblacion.Text = "38 millones";
                    txt_Idioma.Text = "Inglés, Francés";
                    txt_Moneda.Text = "Dólar canadiense";
                    txt_Religion.Text = "Cristianismo";
                    break;

                case "Mexico":
                    txt_Continente.Text = "América del Norte";
                    txt_Capital.Text = "Ciudad de México";
                    txt_Presidente.Text = "Andrés Manuel López Obrador";
                    txt_Gobierno.Text = "República Federal Presidencialista";
                    txt_Poblacion.Text = "126 millones";
                    txt_Idioma.Text = "Español";
                    txt_Moneda.Text = "Peso mexicano";
                    txt_Religion.Text = "Catolicismo";
                    break;

                case "España":
                    txt_Continente.Text = "Europa";
                    txt_Capital.Text = "Madrid";
                    txt_Presidente.Text = "Pedro Sánchez";
                    txt_Gobierno.Text = "Monarquía Parlamentaria";
                    txt_Poblacion.Text = "47 millones";
                    txt_Idioma.Text = "Español";
                    txt_Moneda.Text = "Euro";
                    txt_Religion.Text = "Catolicismo";
                    break;

                case "Francia":
                    txt_Continente.Text = "Europa";
                    txt_Capital.Text = "París";
                    txt_Presidente.Text = "Emmanuel Macron";
                    txt_Gobierno.Text = "República Semipresidencialista";
                    txt_Poblacion.Text = "67 millones";
                    txt_Idioma.Text = "Francés";
                    txt_Moneda.Text = "Euro";
                    txt_Religion.Text = "Cristianismo";
                    break;

                case "Republica Dominicana":
                    txt_Continente.Text = "América del Norte";
                    txt_Capital.Text = "Santo Domingo";
                    txt_Presidente.Text = "Luis Abinader";
                    txt_Gobierno.Text = "PRM (Partido Revolucionario Moderno)";
                    txt_Poblacion.Text = "Alrededor de 10.8 millones de habitantes";
                    txt_Idioma.Text = "Español Latinoamericano";
                    txt_Moneda.Text = "DOP (Pesos Dominicanos)";
                    txt_Religion.Text = "Predomina la Católica";
                    break;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Continente.Clear();
            txt_Capital.Clear();
            txt_Presidente.Clear();
            txt_Gobierno.Clear();
            txt_Poblacion.Clear();
            txt_Idioma.Clear();
            txt_Moneda.Clear();
            txt_Religion.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
