using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public interface IEntradaService
    {
        void Create(Entrada entrada);
        void Delete(long id);
        Entrada Read(long id);
        List<Entrada> ReadAll();
        void Update(Entrada entrada);
    }
}
