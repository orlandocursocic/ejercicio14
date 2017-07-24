using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio14;
using Microsoft.Practices.Unity;

namespace ejercicio14Test
{
    [TestClass]
    public class EntradaControllerIntegracionTests
    {
        private IEntradaController entradaController;
        private IUnityContainer unityContainer;

        [TestInitialize]
        public void TestInit()
        {
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();
            unityContainer.RegisterType<IEntradaController, EntradaController>();

            entradaController = unityContainer.Resolve<IEntradaController>();
        }

        [TestMethod]
        public void CreateMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.id = 1;
            entradaController.Create(entradaDTO);
            entradaController.Delete(1);
        }

        [TestMethod]
        public void ReadMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.id = 1;
            entradaController.Create(entradaDTO);
            entradaController.Read(1);
        }

        [TestMethod]
        public void ReadAllMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.id = 1;
            EntradaDTO entradaDTO2 = new EntradaDTO();
            entradaDTO.id = 2;
            entradaController.Create(entradaDTO);
            entradaController.Create(entradaDTO2);

            Assert.AreEqual(2, entradaController.ReadAll().Count);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaDTO.id = 1;
            entradaController.Create(entradaDTO);

            entradaController.Update(entradaDTO);
        }
    }
}
