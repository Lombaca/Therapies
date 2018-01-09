using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Terapeutica
{
    public partial class Form1 : Form
    {

        //Modelo de dados

        //Modelo de dados
        DataHelper datahelper;

        public Form1()
        {
            InitializeComponent();
            datahelper = new DataHelper();
            dataGridViewClients.DataSource = datahelper.DataSet;
            dataGridViewClients.DataMember = DataHelper.DATATABLE_CLIENTS;
            dataGridViewClients.AutoGenerateColumns = true;
            dataGridViewClients.AutoResizeColumns();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client clientToAdd = new Client(
                textBoxName.Text,
                dateTimePickerBirthDate.Value,
                getCheckedGender());

            Client.addToDataBase(datahelper, clientToAdd);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int indexToRemove = dataGridViewClients.CurrentCell.RowIndex;// listBoxClientes.SelectedIndex;
            if (indexToRemove > -1)
            {
                //clients.RemoveAt(indexToRemove);
                Client.removeFromDataBase(datahelper, indexToRemove);
            }
            else
            {
                MessageBox.Show("Por favor seleccione um cliente!");
            }
        }

        GenderType getCheckedGender()
        {
            bool isMale = radioButtonMale.Checked;
            GenderType gender;
            if (isMale) gender = GenderType.male;
            else gender = GenderType.female;
            return gender;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            int index = dataGridViewClients.CurrentCell.RowIndex; // listBoxClientes.SelectedIndex;
            if (index > -1)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que quer Editar o cliente seleccionado?", 
                    "Atençao", 
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    Client clientToEdit = new Client(
                        textBoxName.Text,
                        dateTimePickerBirthDate.Value,
                        getCheckedGender());
                  
                    Client.editOnDataBase(datahelper, clientToEdit, index);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione um cliente!");
            }
        }

        private void listBoxClientes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridViewClients.CurrentCell.RowIndex;
            if (index > -1)
            {
                Client client = Client.readOnDataBase(datahelper, index);
                FormTerapies formTerapies = new FormTerapies(client);
                formTerapies.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "*";
            sv.DefaultExt = "csv";
            sv.ValidateNames = true;

            sv.Filter = "CSV File (.csv)|*.csv";
            ;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(sv.FileName);
                StreamWriter sw = new StreamWriter(sv.FileName);
                List <Client> clients=Client.getClientsList(datahelper);
                foreach (Client c in clients)
                {
                    Console.WriteLine(c.Id);
                    foreach (Medication m in Client.getMedications(datahelper, c.Id))
                    {
                        sw.WriteLine(c.Name + "; " + 
                            c.Birthday + "; " +
                            m.Name + "; " +
                            m.Posology + "; " +
                            m.Qtd + "; "
                            );
                    }
                }
                sw.Flush();
                sw.Close();

            }
        }
    }
}
