using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;
namespace BMIUnitTests;

[TestClass]
public sealed class Test1
{
      [DataTestMethod]
        // Underweight example: ~16.31
        [DataRow(7, 0, 5, 5, BMICategory.Underweight)]
        // Normal example: ~23.30
        [DataRow(10, 0, 5, 5, BMICategory.Normal)]
        // Overweight example: ~25.63
        [DataRow(11, 0, 5, 5, BMICategory.Overweight)]
        // Obese example: ~34.95
        [DataRow(15, 0, 5, 5, BMICategory.Obese)]
        public void TestMethod1(int weightStones,int weightPounds,int heightFeet,int heightInches,BMICategory expectedCategory)
        {
            var model = new BMI
            {
                WeightStones = weightStones,
                WeightPounds = weightPounds,
                HeightFeet = heightFeet,
                HeightInches = heightInches
            };

            var category = model.BMICategory;

            Assert.AreEqual(expectedCategory, category);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // 10 stone, 0 pounds, 5 ft 5 in
            var model = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 5
            };

            double bmi = model.BMIValue;

            // Expected ≈ 23.30 
            Assert.AreEqual(23.30, bmi, 0.05,
                "BMI calculation is not within the expected tolerance.");
        }
}
