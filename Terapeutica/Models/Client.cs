using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
    public enum GenderType { male, female };

    public class Client
    {
        
        String name;
        DateTime birthday;
        long id;
        GenderType gender;
        List<Medication> medications;

        public Client(string name, DateTime birthday, GenderType gender)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.id = Utils.CurrentTimeMillis();
        }

        public Client(string name, DateTime birthday, GenderType gender, long id)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.id = id;
        }


        //CRUD

        //Create
        public static void addToDataBase(DataHelper datahelper, Client client)
        {
            DataRow datarow = datahelper.TableClients.NewRow();

            datarow[DataHelper.CLIENTS_NAME] = client.Name;
            datarow[DataHelper.CLIENTS_BIRTHDAY] = client.Birthday;
            datarow[DataHelper.CLIENTS_GENDER] = client.Gender;
            datarow[DataHelper.CLIENTS_ID] = client.Id;

            datahelper.TableClients.Rows.Add(datarow);
            datahelper.save();
        }

        //Read
        public static Client readOnDataBase(DataHelper datahelper, int index)
        {
            Client client;

            DataRow datarow = datahelper.TableClients.Rows[index];

            client = new Client(
                 (String)datarow[DataHelper.CLIENTS_NAME],
                 DateTime.Parse((String)datarow[DataHelper.CLIENTS_BIRTHDAY]),
                 parseGender((String)datarow[DataHelper.CLIENTS_GENDER]),
                 long.Parse((String)datarow[DataHelper.CLIENTS_ID]));

            return client;

        }

        //Update
        public static void editOnDataBase(DataHelper datahelper, Client client, int index)
        {
            DataRow datarow = datahelper.TableClients.Rows[index];

            datarow[DataHelper.CLIENTS_NAME] = client.Name;
            datarow[DataHelper.CLIENTS_BIRTHDAY] = client.Birthday;
            datarow[DataHelper.CLIENTS_GENDER] = client.Gender;
            datarow[DataHelper.CLIENTS_ID] = client.Id;

            datahelper.save();
        }

        //Delete
        public static void removeFromDataBase(DataHelper datahelper, int indexToRemove)
        {
            datahelper.TableClients.Rows.RemoveAt(indexToRemove);
            datahelper.save();
        }

        public static List<Client> getClientsList(DataHelper datahelper) {

            List<Client> clients = new List<Client>();

            foreach(DataRow dataRow in datahelper.TableClients.Rows){

                String name = (String)dataRow[DataHelper.CLIENTS_NAME];
                DateTime birthday = DateTime.Parse((String)dataRow[DataHelper.CLIENTS_BIRTHDAY]);
                GenderType gender = parseGender((String)dataRow[DataHelper.CLIENTS_GENDER]);
                long id=   long.Parse((String)dataRow[DataHelper.CLIENTS_ID]);

                clients.Add(new Client(name, DateTime.Now, gender, id));
            }

            return clients;
        }

        public static List<Medication> getMedications(DataHelper datahelper, long id)
        {
            List<Medication> medications = new List<Medication>();
            DataView dataView = datahelper.DataSet.Tables[DataHelper.DATATABLE_TERAPIES].DefaultView;

            dataView.RowFilter = string.Format("{0} = '{1}'", DataHelper.MEDICATIONS_CLIENT_ID, id);
            foreach(DataRowView drv in dataView)
            {
                DataRow row = drv.Row;
                string name = (string)row[DataHelper.MEDICATIONS_NAME];
                float qtd = float.Parse((string)row[DataHelper.MEDICATIONS_QTD]);
                string posology = (string)row[DataHelper.MEDICATIONS_POSOLOGY];
                long clientId = long.Parse((string)row[DataHelper.MEDICATIONS_CLIENT_ID]);
                Medication med = new Medication(name, 1, posology, clientId);
                medications.Add(med);
            }
            return medications;
                 
        }

        public static GenderType parseGender(String strGender)
        {
            if (strGender.CompareTo("male") == 0) {
                return GenderType.male;
            } else {
                return GenderType.female;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }
        }

        public GenderType Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public List<Medication> Medications
        {
            get
            {
                return medications;
            }

            set
            {
                medications = value;
            }
        }
    }
}
