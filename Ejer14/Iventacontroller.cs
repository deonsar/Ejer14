using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public interface IVentaController
    {
        void Create(VentaDTO ventaDTO);

        VentaDTO Read(long id);
        //VentaDTO Read(VentaDTO ventaDTO) ;   

        IList<VentaDTO> ReadAll();

        void Update(VentaDTO ventaDTO);

        void Delete(long id);
            
        
    }
}
