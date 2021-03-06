﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terapeutica
{
    public partial class FormTerapies : Form
    {
        Client clientToEdit;
        public Client ClientToEdit
        {
            get
            {
                return clientToEdit;
            }

            set
            {
                clientToEdit = value;
            }
        }
        //Modelo de dados
        DataHelper datahelper;

        public FormTerapies(Client client)
        {
            this.clientToEdit = client;
            InitializeComponent();
            this.Text = client.Name;

            datahelper = new DataHelper();

            DataView dataView = datahelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;
            dataView.RowFilter = string.Format("[{0}] = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, client.Id);
            dataGridViewTerapies.DataSource = dataView;
            dataGridViewTerapies.AutoGenerateColumns = true;
            dataGridViewTerapies.AutoResizeColumns();

        }

        public FormTerapies()
        {
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medication med = new Medication(
                textBoxMedName.Text,
                (float)numericUpDownQtd.Value,
                textBoxPosology.Text,
                clientToEdit.Id
                );

            Medication.addToDataBase(datahelper, med);
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
