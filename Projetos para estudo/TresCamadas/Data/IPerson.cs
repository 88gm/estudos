using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datahandler
{
    public interface IPerson
    {
        void setName(string name);
        void setCpf(string cpf);
        void setPhone(string phone);
        void save();
    }
}
