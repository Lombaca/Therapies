using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terapeutica
{
    public class Medication
    {
        String name;
        float qtd;
        String posology;
        long id;
        long clientId;
        
        public Medication(string name, float qtd, string posology, long clientId)
        {
            this.name = name;
            this.qtd = qtd;
            this.posology = posology;
            this.clientId = clientId;
            this.id = Utils.CurrentTimeMillis();
        }


        //Create
        public static void addToDataBase(DataHelper datahelper, Medication medication)
        {
            DataRow datarow = datahelper.TableMedicactions.NewRow();
            datarow[DataHelper.MEDICATIONS_NAME] = medication.name;
            datarow[DataHelper.MEDICATIONS_QTD      ] = medication.Qtd;
            datarow[DataHelper.MEDICATIONS_POSOLOGY ] = medication.Posology;
            datarow[DataHelper.MEDICATIONS_CLIENT_ID] = medication.ClientId;
            datarow[DataHelper.MEDICATIONS_ID       ] = medication.Id;

            datahelper.TableMedicactions.Rows.Add(datarow);
            datahelper.save();
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

        public float Qtd
        {
            get
            {
                return qtd;
            }

            set
            {
                qtd = value;
            }
        }

        public string Posology
        {
            get
            {
                return posology;
            }

            set
            {
                posology = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public long ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }
    }
}
