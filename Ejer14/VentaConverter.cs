using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public class VentaConverter : IVentaConverter
    {
        public Venta DTOToEntity(VentaDTO ventaDTO)
        {
            Venta resultado = new Venta();
            resultado.Id = ventaDTO.Id;
            return resultado;
        }

        public VentaDTO EntitytoDTO(Venta venta)
        {
            VentaDTO resultado = new VentaDTO();
            resultado.Id = venta.Id;
            return resultado;
        }
    }
}
