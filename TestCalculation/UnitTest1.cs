using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace TestCalculation
{
    [TestClass]
    public class TestCalculation
    {
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int productType = 5;
            int materialType = 1;
            int count = 10;
            float width = 10;
            float length = 5;

            int expected = -1;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            int productType = 1;
            int materialType = 5;
            int count = 10;
            float width = 10;
            float length = 5;

            int expected = -1;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_CorrentCountQuantityForProduct()
        {
            int productType = 1;
            int materialType = 2;
            int count = 10;
            float width = 10;
            float length = 5;

            int expected = 551;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ExistentMaterialTypeAndProductType()
        {
            int productType = 1;
            int materialType = 1;
            int count = 10;
            float width = 10;
            float length = 5;

            int expected = -1;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_CountQuantityForProductNotNull()
        {
            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 0;
            float length = 0;

            Calculation calculationClass = new Calculation();

            int actual = calculationClass.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(actual);
        }
    }
}
