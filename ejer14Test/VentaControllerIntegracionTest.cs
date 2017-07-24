using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Ejer14;

namespace ejer14Test
{
    [TestClass]
    public class VentaControllerIntegracionTest

    {
        private IVentaController ventaController;

        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IVentaRepository, VentaRepository>();
            unityContainer.RegisterType<IVentaService, VentaService>();
            unityContainer.RegisterType<IVentaConverter, VentaConverter>();
            unityContainer.RegisterType<IVentaController, VentaController >();

            ventaController = unityContainer.Resolve<IVentaController>();

        }

       
        [TestMethod]
        public void CreateMethod()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);
        }
    }
}
