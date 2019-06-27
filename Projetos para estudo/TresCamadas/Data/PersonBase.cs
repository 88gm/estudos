using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datahandler
{
    public abstract class PersonBase : IPerson
    {
        public PersonBase(string name, string cpf, string phone)
        {
            this.name = name;
            this.cpf = cpf;
            this.phone = phone;
        }
        public PersonBase () { }

        protected string name, cpf, phone;    

        public void setName(string name) { this.name = name; }
        public void setCpf (string cpf) { this.cpf = cpf; }
        public void setPhone(string phone) { this.phone = phone; }

        public void save()
        {
            System.Console.Write("Gravado com sucesso!");
        }
    }
}
