using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class EntradaConverter : IEntradaConverter
    {
        public Entrada DTOToEntity(EntradaDTO entradaDTO)
        {
            Entrada entrada = new Entrada();
            entrada.id = entradaDTO.id;
            return entrada;
            
        }

        public EntradaDTO EntityToDTO(Entrada entrada)
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.id = entrada.id;
            return entradaDTO;
        }
    }
}
