using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class EntradaRepository : IEntradaRepository
    {
        List<Entrada> listaEntradas;

        public EntradaRepository()
        {
            listaEntradas = new List<Entrada>();
        }

        public void Create(Entrada entrada)
        {
            Entrada entradaAux = buscaEntrada(entrada.id);

            //Si la receta ya existe en la BD
            if (entradaAux != null)
            {
                throw new EntradaYaExisteException();
            }
            else
            {
                listaEntradas.Add(entrada);
            }
        }

        public void Delete(long id)
        {
            Entrada entradaAux = buscaEntrada(id);

            if (entradaAux != null)
            {
                listaEntradas.Remove(entradaAux);
            }
            else
            {
                throw new EntradaNoExisteException();
            }
        }

        public void Update(Entrada entrada)
        {
            Entrada entradaAux = buscaEntrada(entrada.id);

            if (entradaAux != null)
            {
                listaEntradas.Remove(entradaAux);
                listaEntradas.Add(entrada);
            }
            else
            {
                throw new EntradaNoExisteException();
            }
        }

        public Entrada Read(long id)
        {
            Entrada entradaAux = buscaEntrada(id);

            if (entradaAux == null)
            {
                throw new EntradaNoExisteException();
            }

            return entradaAux;
        }

        public List<Entrada> ReadAll()
        {
            return this.listaEntradas;
        }

        private Entrada buscaEntrada(float id)
        {
            IList<Entrada> listaEntradas = ReadAll();
            Entrada entradaAux = null;

            bool bFound = false;
            int i = 0;
            while (!bFound && i < listaEntradas.Count())
            {
                if (listaEntradas.ElementAt(i).id == id)
                {
                    bFound = true;
                    entradaAux = listaEntradas.ElementAt(i);
                }
                i++;
            }
            return entradaAux;
        }
    }
}
