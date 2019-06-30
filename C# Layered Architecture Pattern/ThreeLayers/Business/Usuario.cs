using Datahandler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Usuario : PersonBase
    {
        public Usuario(string name, string phone, string cpf)
        {
            this.name = name;
            this.phone = phone;
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public Usuario() { }
    }
}
