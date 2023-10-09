using _5E_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _5E_API.Service
{
    public interface I5eAPIService
    {
        Task<Spells> GetSpell(string name);
    }
}
