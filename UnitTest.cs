using BattleFunction;
using HeroisVSMonstres;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAñadirValoresPersonalizados_DentroDelRango()
        {
            // Arrange
            int life = 3000;
            int min = 3000;
            int max = 3750;

            // Act
            bool result = V2.AñadirValoresPersonalizados(life, max, min);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAñadirValoresPersonalizados_FueraDelRango()
        {
            // Arrange
            int life = 150;
            int min = 3000;
            int max = 3750;

            // Act
            bool result = V2.AñadirValoresPersonalizados(life, max, min);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestEscogerDificultad_DentroDelRango()
        {
            // Arrange
            int level = 2;
            int levelOne = 1;
            int levelFour = 4;

            // Act
            bool result = V2.EscogerDificultad(level, levelOne, levelFour);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEscogerDificultad_FueraDelRango()
        {
            // Arrange
            int level = 5;
            int levelOne = 1;
            int levelFour = 4;

            // Act
            bool result = V2.EscogerDificultad(level, levelOne, levelFour);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestEscogerDificultad_EnElLímiteInferior()
        {
            // Arrange
            int level = 1;
            int levelOne = 1;
            int levelFour = 4;

            // Act
            bool result = V2.EscogerDificultad(level, levelOne, levelFour);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEscogerDificultad_EnElLímiteSuperior()
        {
            // Arrange
            int level = 4;
            int levelOne = 1;
            int levelFour = 4;

            // Act
            bool result = V2.EscogerDificultad(level, levelOne, levelFour);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MostrarValores_MostrarValoresCorrectos()
        {
            // Arrange
            int vida = 1500;
            int ataque = 200;
            int reduccion = 25;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                V2.MostrarValores(vida, ataque, reduccion);

                // Assert
                string expectedOutput = $"Vida: {vida}\r\nAtaque: {ataque}\r\nReducción: {reduccion}\r\n";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }

        }
        public void IntroducirNombrePersonajes_RetornarEntradaDelUsuario()
        {
            // Arrange
            string input = "Nombre1 Nombre2 Nombre3 Nombre4";

            // Act
            string result = V2.IntroducirNombrePersonajes();

            // Assert
            Assert.AreEqual(input, result);
        }
    }
}
