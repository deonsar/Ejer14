﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer14
{
    public class VentaController : IVentaController
    {
        private IVentaService ventaService;
        private IVentaConverter ventaConverter;

        public VentaController(IVentaService _ventaService,  IVentaConverter _ventaConvertet)
        {
            this.ventaService = _ventaService;
            this.ventaConverter = _ventaConvertet;
        }

        public void Create(VentaDTO ventaDTO)
        {
            Venta venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Create(venta);
        }

        public void Delete(long id)
        {
            ventaService.Delete(id);
        }

        public VentaDTO Read(long id)
        {
            Venta venta = ventaService.Read(id);
            VentaDTO ventaDTO = ventaConverter.EntitytoDTO(venta);
            return ventaDTO;
        }

        public IList<VentaDTO> ReadAll()
        {
            IList<VentaDTO> listaResultado = new List<VentaDTO>();
            IList<Venta> listaVenta = ventaService.ReadAll();

            foreach (Venta v in listaVenta)
            {
                VentaDTO ventaDTO = ventaConverter.EntitytoDTO(v);
                listaResultado.Add(ventaDTO);
            }
            return listaResultado;
        }

        public void Update(VentaDTO ventaDTO)
        {
            Venta venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Update(venta);
        }
    }
}
