using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clModel
{
    public class clAnimaisModel
    {

        private int _aniid;
        private string _nome;
        private string _apelido;
        private DateTime _datanasc;
        private string _obs;
        private int _espid;

        public int Id
        {
            get { return _aniid; }
            set { _aniid = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
        }

        public DateTime DataNasc
        {
            get { return _datanasc; }
            set { _datanasc = value; }
        }

        public string Obs
        {
            get { return _obs; }
            set { _obs = value; }
        }
        public int EspID
        {
            get { return _espid; }
            set { _espid = value; }
        }
    }
}