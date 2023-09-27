using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_model
{
    public class clsAnimaisClientes
    {
        private int cliid;
        private int aniid;

        public int CliId
        {
            get { return cliid; }
            set { cliid = value; }
        }

        public int AniId
        {
            get { return aniid; }
            set { aniid = value; }
        }
    }
}
