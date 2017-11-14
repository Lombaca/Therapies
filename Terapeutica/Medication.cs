using System;
using System.Collections.Generic;
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
        int id;

        public Medication(string name, float qtd, string posology)
        {
            this.name = name;
            this.qtd = qtd;
            this.posology = posology;
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

        public int Id
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
    }
}
