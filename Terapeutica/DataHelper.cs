using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
    public class DataHelper
    {

        public static string CLIENTS_NAME = "name";
        public static string CLIENTS_BIRTHDAY = "birthday";
        public static string CLIENTS_GENDER = "gender";
        public static string CLIENTS_ID = "id";

        DataSet dataSet;

        DataTable tableClients;
        DataTable tableMedicactions;

        String filePath = "therapies.xml";

        public DataTable TableClients
        {
            get
            {
                return tableClients;
            }

            set
            {
                tableClients = value;
            }
        }
        public DataTable TableMedicactions
        {
            get
            {
                return tableMedicactions;
            }

            set
            {
                tableMedicactions = value;
            }
        }

        public DataHelper()
        {
            dataSet = new DataSet("therapies_dataset");

            TableClients = new DataTable("datatable_clients");
            TableClients.Columns.Add(CLIENTS_NAME);
            TableClients.Columns.Add(CLIENTS_BIRTHDAY);
            TableClients.Columns.Add(CLIENTS_GENDER);
            TableClients.Columns.Add(CLIENTS_ID);

            TableMedicactions = new DataTable("datatable_medications");
            TableMedicactions.Columns.Add("qtd");
            TableMedicactions.Columns.Add("posology");
            TableMedicactions.Columns.Add("client_id");
            TableMedicactions.Columns.Add("id");

            dataSet.Tables.Add(TableClients);
            dataSet.Tables.Add(TableMedicactions);

            load();
        }


        
        public void save()
        {
            dataSet.WriteXml(filePath);
        }

        public void load()
        {
            try
            {
                dataSet.ReadXml(filePath);
            }catch(FileNotFoundException e)
            {

            }
        }
    }
}
