using System;
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
    public partial class Form1 : Form
    {

        //Modelo de dados
        List<Client> clients = new List<Client>();

        DataHelper datahelper;

        public Form1()
        {
            InitializeComponent();
            datahelper = new DataHelper();
            clients = Client.getClientsList(datahelper);
            updateForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client clientToAdd = new Client(
                textBoxName.Text,
                dateTimePickerBirthDate.Value,
                getCheckedGender());

            clients.Add(clientToAdd);

            Client.addToDataBase(datahelper, clientToAdd);

            updateForm();
        }

        void updateForm() {
            listBoxClientes.Items.Clear();
            foreach (Client client in clients){
                listBoxClientes.Items.Add(client.Name);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int indexToRemove = listBoxClientes.SelectedIndex;
            if (indexToRemove > -1)
            {
                clients.RemoveAt(indexToRemove);
                updateForm();
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

            int index;
            index = listBoxClientes.SelectedIndex;
            if (index > -1)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que quer Editar o cliente seleccionado?", 
                    "Atençao", 
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Client clientToedit = clients[index];
                    clientToedit.Name = textBoxName.Text;
                    clientToedit.Birthday = dateTimePickerBirthDate.Value;
                    clientToedit.Gender = getCheckedGender();
                    updateForm();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione um cliente!");
            }
        }

        private void listBoxClientes_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listBoxClientes.SelectedIndex;
            if (index > -1)
            {
                FormTerapies formTerapies = new FormTerapies(clients[index]);
                formTerapies.Show();
            }
        }
    }
}
