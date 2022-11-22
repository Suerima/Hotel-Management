using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class PersonalInfoDAO
    {

        private static PersonalInfoDAO instance;
        public static PersonalInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PersonalInfoDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private PersonalInfoDAO() { }


        public int DeletePerson(string id)
        {
            try
            {
                string query = "USP_Delete_Person @PersonID "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {id});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdatePersonalInfo(PersonalInfo info)
        {
            try
            {
                string query = "USP_Update_PersonalInfo @PersonID , @Name , @Gender , @Dob , @Address , @Phone , @IDCard "; //
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] {info.PersonID, info.Name, info.Gender, info.Dob, info.Address, info.Phone, info.Idcard});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
