using System.Collections.Generic;

namespace ejercicio14
{
    public interface IEntradaRepository
    {
        void Create(Entrada entrada);
        void Delete(long id);
        Entrada Read(long id);
        List<Entrada> ReadAll();
        void Update(Entrada entrada);
    }
}