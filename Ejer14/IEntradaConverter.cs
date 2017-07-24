using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public interface IEntradaConverter
    {
        EntradaDTO EntitytoDTO(Entrada entrada);
        Entrada DTOToEntity(EntradaDTO entradaDTO);
    }
}
