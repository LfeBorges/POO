using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP
{
public class ValidadorUsuario
{
    public bool ValidarUsuario(string nome, Conta conta)
    {
        return conta.Titular == nome;
    }
}
}