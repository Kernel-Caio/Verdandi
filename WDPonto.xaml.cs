﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Verdandi
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        List<Registros> listaRegistros = new List<Registros>();

        public Menu()
        {
            Registros registro = new Registros();

            InitializeComponent();
            txb_matricula.Focus();

            for (int i = 0; i < 4; i++)
            {
                listaRegistros.Add(registro.Insere("1", "Caio Oliveira de Paula", "07:45:00"));
                listaRegistros.Add(registro.Insere("1", "Caio Oliveira de Paula", "11:00:00"));
            }

            dg_registros.ItemsSource = listaRegistros;
        }

        private void dg_registros_AutoGeneratedColumns(object sender, System.EventArgs e)
        {
            dg_registros.Columns[0].Width = new DataGridLength(0.2, DataGridLengthUnitType.Star);
            dg_registros.Columns[1].Width = new DataGridLength(1.4, DataGridLengthUnitType.Star);
            dg_registros.Columns[2].Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

    public class Registros
    {
        public string? id { get; set; }
        public string? nome { get; set; }
        public string? hora { get; set; }

        public Registros() { }

        public Registros Insere(string id, string nome, string hora)
        {
            Registros registro = new Registros();
            registro.id = id;
            registro.nome = nome;
            registro.hora = hora;

            return registro;
        }
    }
}
