using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (productType != 1 && productType != 2 && productType != 3)
            {
                return -1;
            }

            if (materialType != 1 && materialType != 2)
            {
                return -1;
            }

            double[] coefficientProductType = new double[] { 1.1, 2.5, 8.43 }; 
            double[] percentDefectiveMaterialType = new double[] { 0.3, 0.12 }; 

            double qualityRawMaterial = count * coefficientProductType[productType-1] * width * length;

            double defectiveMaterial = qualityRawMaterial * percentDefectiveMaterialType[materialType-1] / 100;

            int totalMaterial = Convert.ToInt32(qualityRawMaterial + defectiveMaterial);

            return totalMaterial;
        }
    }
}
