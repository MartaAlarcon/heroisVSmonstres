using BattleFunction;
using HeroisVSMonstres;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestA�adirValoresPersonalizados_DentroDelRango()
        {
            // Arrange
            int life = 3000;
            int min = 3000;
            int max = 3750;

            // Act
            bool result = V2.A�adirValoresPersonalizados(life, max, min);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestA�adirValoresPersonalizados_FueraDelRango()
        {
            // Arrange
            int life = 150;
            int min = 3000;
            int max = 3750;

            // Act
            bool result = V2.A�adirValoresPersonalizados(life, max, min);

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
        public void TestEscogerDificultad_EnElL�miteInferior()
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
        public void TestEscogerDificultad_EnElL�miteSuperior()
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
    }
}