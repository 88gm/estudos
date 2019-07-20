using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datahandler
{
    public abstract class PersonBase : IPerson
    {
        public string Name { get; protected set; }
        public string Cpf {  get; protected set; }
        public string Phone { get; protected set; }

        public PersonBase(string name, string cpf, string phone)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Phone = phone;
        }

        public void save()
        {
            System.Console.Write("Gravado com sucesso!");
        }
    }
}
