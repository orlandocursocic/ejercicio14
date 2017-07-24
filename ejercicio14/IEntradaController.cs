using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public interface IEntradaController
    {
        void Create(EntradaDTO entrada);
        void Delete(long id);
        EntradaDTO Read(long id);
        List<EntradaDTO> ReadAll();
        void Update(EntradaDTO entrada);
    }
}
