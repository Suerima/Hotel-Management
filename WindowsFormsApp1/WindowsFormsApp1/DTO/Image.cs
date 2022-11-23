using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Image
    {
        private string path;

        public string Path { get => path; set => path = value; }
        
        public Image() { }

        public Image(DataRow row)
        {
            this.Path = row["Path"].ToString();

        }
        public Image(string path)
        {
            this.Path = path;
        }
    }
}
