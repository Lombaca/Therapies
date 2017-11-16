using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
    class DataHelper
    {

        DataSet dataSet;
        DataTable tableClients;
        DataTable tableMedicactions;

        String filePath = "therapies.xml";

        public DataHelper()
        {
            dataSet = new DataSet("therapies_dataset");

            tableClients = new DataTable("datatable_clients");
            tableClients.Columns.Add("name");
            tableClients.Columns.Add("birthday");
            tableClients.Columns.Add("gender");
            tableClients.Columns.Add("id");

            tableMedicactions = new DataTable("datatable_medications");
            tableMedicactions.Columns.Add("qtd");
            tableMedicactions.Columns.Add("posology");
            tableMedicactions.Columns.Add("client_id");
            tableMedicactions.Columns.Add("id");

            dataSet.Tables.Add(tableClients);
            dataSet.Tables.Add(tableMedicactions);

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
            }catch(SecurityException e)
            {

            }
        }
    }
}
