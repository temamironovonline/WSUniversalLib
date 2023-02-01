using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace TestCalculation
{
    [TestClass]
    public class TestCalculation
    {
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType() // Проверяет поведение метода, если будет указан несуществующий тип продукции
        {
            int productType = 5, materialType = 1, count = 10;
            float width = 10, length = 5;

            int expected = -1;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType() // Проверяет поведение метода, если будет указан несуществующий тип материала
        {
            int productType = 1, materialType = 5, count = 10;
            float width = 10, length = 5;

            int expected = -1;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(expected != actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_CurrentCountQuantityProduct() // Проверяет поведение метода, если все данные указаны верно
        {
            int productType = 1, materialType = 2, count = 10;
            float width = 10, length = 5;

            int expected = 551;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ResultHasIntType() // Возвращаемый тип данных должен быть int
        {
            int productType = 5, materialType = 1, count = 10;
            float width = 10, length = 5;

            Calculation calculationClass = new Calculation();

            Assert.IsInstanceOfType(calculationClass.GetQuantityForProduct(productType, materialType, count, width, length), typeof(int));
        }

        [TestMethod]
        public void GetQuantityForProduct_ResultIsNotDoubleType() // Возвращаемый тип данных не должен быть double
        {
            int productType = 5, materialType = 1, count = 10;
            float width = 10, length = 5;

            Calculation calculationClass = new Calculation();

            Assert.IsNotInstanceOfType(calculationClass.GetQuantityForProduct(productType, materialType, count, width, length), typeof(double));
        }

        [TestMethod]
        public void GetQuantityForProduct_ResultIsNotFloatType() // Возвращаемый тип данных не должен быть float
        {
            int productType = 5, materialType = 1, count = 10;
            float width = 10, length = 5;

            Calculation calculationClass = new Calculation();

            Assert.IsNotInstanceOfType(calculationClass.GetQuantityForProduct(productType, materialType, count, width, length), typeof(float));
        }

        [TestMethod]
        public void GetQuantityForProduct_CountQuantityForProductIsNotNull() // Проверяет, что возвращаемое значение != null
        {
            int productType = 1, materialType = 1, count = 0;
            float width = 0, length = 0;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(actual);
        }
    }
}
