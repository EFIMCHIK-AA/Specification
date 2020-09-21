using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Client
{
    public class Model
    {
        private string Name;
        private string Description;

        public DateTime DateCreate { get; set; }
        public int get_Id { get; set; }
        public string get_Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string get_Description
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
