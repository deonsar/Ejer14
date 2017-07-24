using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public interface IVentaService
    {

        void Create(Venta venta);

        Venta Read(long id);
        //VentaDTO Read(VentaDTO ventaDTO) ;   

        IList<Venta> ReadAll();

        void Update(Venta venta);

        void Delete(long id);
    }
}
