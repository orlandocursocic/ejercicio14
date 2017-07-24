using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio14;
using Microsoft.Practices.Unity;

namespace ejercicio14Test
{
    [TestClass]
    public class VentaControllerIntegracionTest
    {

        private IVentaController ventaController;
        private IUnityContainer unityContainer;

        [TestInitialize]
        public void TestInit()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IVentaRepository, VentaRepository>();
            unityContainer.RegisterType<IVentaService, VentaService>();
            unityContainer.RegisterType<IVentaConverter, VentaConverter>();
            unityContainer.RegisterType<IVentaController, VentaController>();

            ventaController = unityContainer.Resolve<IVentaController>();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException),
            "Quiero que casque, no está implementado.")]
        public void CreateMethod()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaController.Create(ventaDTO);
        }
    }
}
