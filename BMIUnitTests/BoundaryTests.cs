using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace BMIUnitTests
{
    [TestClass]
    public class BmiCategoryBoundaryTests
    {
        private BMI MakeModel(int stones, int pounds, int feet, int inches)
        {
            return new BMI
            {
                WeightStones = stones,
                WeightPounds = pounds,
                HeightFeet = feet,
                HeightInches = inches
            };
        }

        [TestMethod]
        public void Category_Underweight_At_And_Below_18point4()
        {
            var m1 = MakeModel(7, 0, 6, 0);
            var m2 = MakeModel(6, 7, 6, 0);

            Assert.AreEqual(BMICategory.Underweight, m1.BMICategory);
            Assert.AreEqual(BMICategory.Underweight, m2.BMICategory);
        }

        [TestMethod]
        public void Category_Normal_Between_18point5_And_24point9()
        {
            var m1 = MakeModel(10, 0, 5, 8);
            var m2 = MakeModel(11, 0, 5, 10);

            Assert.AreEqual(BMICategory.Normal, m1.BMICategory);
            Assert.AreEqual(BMICategory.Normal, m2.BMICategory);
        }

        [TestMethod]
        public void Category_Overweight_Between_25_And_29point9()
        {
            var m1 = MakeModel(12, 0, 5, 6);
            var m2 = MakeModel(13, 0, 5, 6);

            Assert.AreEqual(BMICategory.Overweight, m1.BMICategory);
            Assert.AreEqual(BMICategory.Overweight, m2.BMICategory);
        }

        [TestMethod]
        public void Category_Obese_Above_30()
        {
            var m1 = MakeModel(15, 0, 5, 6);
            var m2 = MakeModel(18, 0, 5, 6);

            Assert.AreEqual(BMICategory.Obese, m1.BMICategory);
            Assert.AreEqual(BMICategory.Obese, m2.BMICategory);
        }
    }
}
