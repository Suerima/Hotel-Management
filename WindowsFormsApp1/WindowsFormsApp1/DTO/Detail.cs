using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Detail
    {
        private string detailID;
        private string details;


        public Detail() { }

        public string DetailID { get => detailID; set => detailID = value; }
        public string Details { get => details; set => details = value; }
        public Detail(DataRow row)
        {
            this.DetailID = row["DetailID"].ToString();
            this.Details = row["Detail"].ToString();
        }

        public Detail(string detailID, string details)
        {
            DetailID = detailID;
            Details = details;
        }
    }
}
