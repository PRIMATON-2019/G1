using G1.Clases;
using G1.Clases.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace G1.Tests

{
    [TestClass]
    public class TestListaObjetos
    {
        ListaObjetos lo = new ListaObjetos();
        [TestMethod]
        public void TestListaObjetos_Agregar()
        {
            //Arrange = Planteo
            Alumnos alumnos = new Alumnos();
            alumnos.Id = 1;
            //Act = Prueba - Se llama al metodo a ser testeado.
            bool res = lo.Agregar(alumnos);

            //Assert = Afirmacion
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestListaObjetos_Copiar()
        {
            //Arrange = Planteo
            Alumnos alumno1 = new Alumnos();
            Alumnos alumno2 = new Alumnos();
            Alumnos alumno3 = new Alumnos();

            Alumnos[] origen = {alumno1,alumno2,alumno3};
            Alumnos[] Destino = origen;
            

            //Act = Prueba - Se llama al metodo a ser testeado.
            Alumnos[] destino = lo.Copiar(origen, Destino);

            Alumnos[] origen1 = { alumno1, alumno2, alumno3, alumno1};
            origen = origen1;

            //Assert = Afirmacion
            Assert.AreEqual(destino, origen);
        }
    }
}
