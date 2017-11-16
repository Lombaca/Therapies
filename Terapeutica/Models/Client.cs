using System;
using System.Collections.Generic;
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
        int id;
        GenderType gender;
        List<Medication> medications;

        public Client(string name, DateTime birthday, GenderType gender)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
        }

        public static void addClientToDataBase()
        {

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
