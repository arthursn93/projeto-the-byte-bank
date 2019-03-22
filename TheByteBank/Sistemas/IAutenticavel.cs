using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheByteBank.Funcionarios;

namespace TheByteBank.Sistemas
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);       
    }
}
