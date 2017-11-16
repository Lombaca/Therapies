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

        public static List<Client> getClientsList(DataHelper datahelper) {

            List<Client> clients = new List<Client>();

            foreach(DataRow dataRow in datahelper.TableClients.Rows){

                String name = (String)dataRow[DataHelper.CLIENTS_NAME];
                //DateTime birthday = (DateTime)dataRow[DataHelper.CLIENTS_BIRTHDAY];
                //GenderType gender= (GenderType)dataRow[DataHelper.CLIENTS_GENDER];

                clients.Add(new Client(name, DateTime.Now, GenderType.male));
            }

            return clients;
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
