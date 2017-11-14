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

        List<Medication> medications=new List<Medication>();

        public FormTerapies(Client client)
        {
            this.clientToEdit = client;
            InitializeComponent();
            this.Text = client.Name;
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
                textBoxPosology.Text
                );
            medications.Add(med);
            updateForm();
        }


        void updateForm()
        {
            listBoxMedications.Items.Clear();
            foreach (Medication med in medications)
            {

                String posologyStr = String.Format("{0} - {1} - {2}", med.Qtd, med.Name, med.Posology);
                listBoxMedications.Items.Add(posologyStr);
            }
        }

    }
}
