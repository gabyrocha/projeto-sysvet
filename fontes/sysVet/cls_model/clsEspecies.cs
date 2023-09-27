using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_model
{
    public class clsEspecies
    {
        private int espid;
        private string espnome;

        public int Id
        {
            get { return espid; }
            set { espid = value; }
        }
        
        public string Nome
        {
            get { return espnome; } 
            set { espnome = value; }
        }
    }
}
