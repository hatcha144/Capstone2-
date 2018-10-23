using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captstone2._0
{
    class Task
    {
        private string Name;
        private string Descrip;
        private string Date;
        private bool complete;

        public Task(string Name, string descrip, string Date, bool complete)
        {
            this.Name = Name;
            this.Descrip = descrip;
            this.Date = Date; 
            this.complete = completed;

        }

        public string memberName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string briefDescrip
        {
            get { return Descrip; }
            set { Descrip = value; }
        }
        public string dueDate
        {
            get { return Date; }
            set { Date = value; }
        }
        public bool completed
        {
            get { return complete; }
            set { complete = value; }
        }       
    }

}
