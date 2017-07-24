using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class EntradaController : IEntradaController
    {
        private IEntradaService entradaService;
        private IEntradaConverter entradaConverter;

        public EntradaController(IEntradaService entradaService, IEntradaConverter entradaConverter)
        {
            this.entradaService = entradaService;
            this.entradaConverter = entradaConverter;
        }

        public void Create(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Create(entrada);
        }

        public void Delete(long id)
        {
            entradaService.Delete(id);
        }

        public EntradaDTO Read(long id)
        {
            EntradaDTO entradaDTO = entradaConverter.EntityToDTO(entradaService.Read(id));
            return entradaDTO;
        }

        public List<EntradaDTO> ReadAll()
        {
            List<EntradaDTO> listaResultado = new List<EntradaDTO>();

            IList<Entrada> listaEntrada = entradaService.ReadAll();

            foreach (Entrada e in listaEntrada)
            {
                EntradaDTO entradaDTO = entradaConverter.EntityToDTO(e);
                listaResultado.Add(entradaDTO);
            }

            return listaResultado;
        }

        public void Update(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Update(entrada);
        }
    }
}
