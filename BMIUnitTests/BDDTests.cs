using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;   // This is the namespace from your BMI.cs file

namespace BMIUnitTests.Tests   // change if your test project uses a different namespace
{
    [TestClass]
    [TestCategory("BDD")]
    public class BmiBddTests
    {
        // Scenario: Underweight BMI
        // Given a very light person
        // When I calculate their BMI
        // Then the BMI category should be Underweight
        [TestMethod]
        public void BDDTest_1()
        {
            // Given
            var model = new BMI
            {
                WeightStones = 7,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 8
            };

            // When
            var bmiValue = model.BMIValue;
            var category = model.BMICategory;

            // Then
            Assert.IsTrue(bmiValue < 18.5, "BMI should be in underweight range.");
            Assert.AreEqual(BMICategory.Underweight, category);
        }

        // Scenario: Normal BMI
        // Given a person with healthy weight
        // When I calculate their BMI
        // Then the BMI category should be Normal
        [TestMethod]
        public void BDDTest_2()
        {
            // Given
            var model = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 6
            };

            // When
            var bmiValue = model.BMIValue;
            var category = model.BMICategory;

            // Then
            Assert.IsTrue(bmiValue >= 18.5 && bmiValue <= 24.9, "BMI should be in normal range.");
            Assert.AreEqual(BMICategory.Normal, category);
        }

        // Scenario: Overweight BMI
        // Given a person above normal weight
        // When I calculate their BMI
        // Then the BMI category should be Overweight
        [TestMethod]
        public void BDDTest_3()
        {
            // Given
            var model = new BMI
            {
                WeightStones = 13,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 6
            };

            // When
            var bmiValue = model.BMIValue;
            var category = model.BMICategory;

            // Then
            Assert.IsTrue(bmiValue > 24.9 && bmiValue <= 29.9, "BMI should be in overweight range.");
            Assert.AreEqual(BMICategory.Overweight, category);
        }

        // Scenario: Obese BMI
        // Given a person with very high weight
        // When I calculate their BMI
        // Then the BMI category should be Obese
        [TestMethod]
        public void BDDTest_4()
        {
            // Given
            var model = new BMI
            {
                WeightStones = 17,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 6
            };

            // When
            var bmiValue = model.BMIValue;
            var category = model.BMICategory;

            // Then
            Assert.IsTrue(bmiValue > 30, "BMI should be in obese range.");
            Assert.AreEqual(BMICategory.Obese, category);
        }
    }
}
