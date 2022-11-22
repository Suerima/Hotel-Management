using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class PersonalInfoBUS
    {
        private static PersonalInfoBUS instance;
        public static PersonalInfoBUS Instance
        {

            get
            {
                if (instance == null)
                    instance = new PersonalInfoBUS();
                return PersonalInfoBUS.instance;
            }
            private set { instance = value; }
        }
        private PersonalInfoBUS() { }

        public int UpdatePersonalInfo(PersonalInfo info)
        {
            return PersonalInfoDAO.Instance.UpdatePersonalInfo(info);
        }

        public int DeletePerson(string id)
        {
            return PersonalInfoDAO.Instance.DeletePerson(id);
        }
    }
}
