using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clModel
{
    public class clClientesModel
    {
        private int _cliid;
        private string _nome;
        private decimal _cpf;
        private string _email;
        private DateTime _datacadastro;


        public int Id
        {
            get { return _cliid; }
            set { _cliid = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public decimal Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime Datacadastro
        {
            get { return _datacadastro; }
            set { _datacadastro = value; }
        }
    }
}