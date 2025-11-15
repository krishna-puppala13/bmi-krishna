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
            // Arrange
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
}
