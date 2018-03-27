using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Interface
{
    interface iCountryRepository
    {
        void Salvar(Country country);
        Country Get(int id);
    }
}
