using Datahandler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Usuario : PersonBase
    {
        public string password { get; protected set; }
        public Usuario(string name, string phone, string cpf, string password):base(name, cpf, phone)
        {
            this.password = password;
        }

    }
}
