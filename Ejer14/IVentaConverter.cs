using Ejer14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public interface IVentaConverter
    {
        VentaDTO EntitytoDTO(Venta venta);
        Venta DTOToEntity(VentaDTO ventaDTO);

        
    }
}
