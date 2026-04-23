using _1;

namespace RecipeTests
{
    [TestClass]
    public class BoundaryConditionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeCalories_IsNotAllowed()
        {
            // Act
            new Recipe("Тест", "Описание", new List<string>(), new List<string>(), -1);
        }

        [TestMethod]
        public void CaloriesZero_IsAllowedButMinimal()
        {
            // Arrange
            var recipe = new Recipe("Диетическое", "Описание", new List<string>(), new List<string>(), 0);

            // Act & Assert
            Assert.AreEqual(0, recipe.Calories);
        }

 


        [TestMethod]
        public void EmptyIngredients_IsAllowed()
        {
            // Arrange
            var recipe = new Recipe("Тест", "Описание", new List<string>(), new List<string>(), 100);

            // Act & Assert
            Assert.AreEqual(0, recipe.Ingredients.Count);
        }

        [TestMethod]
        public void EmptyInstructions_IsAllowed()
        {
            // Arrange
            var recipe = new Recipe("Тест", "Описание", new List<string>(), new List<string>(), 100);

            // Act & Assert
            Assert.AreEqual(0, recipe.Instructions.Count);
        }

        [TestMethod]
        public void CaloriesMaxValue_IsAllowed()
        {
            // Arrange & Act
            var recipe = new Recipe("Тест", "Описание", new List<string>(), new List<string>(), int.MaxValue);

            // Assert
            Assert.AreEqual(int.MaxValue, recipe.Calories);
        }

        [TestMethod]
        public void Ingredients_LargeList_StoredCorrectly()
        {
            // Arrange
            var ingredients = new List<string>();
            for (int i = 0; i < 50; i++) ingredients.Add($"Ингредиент {i}");

            // Act
            var recipe = new Recipe("Тест", "Описание", ingredients, new List<string>(), 100);

            // Assert
            Assert.AreEqual(50, recipe.Ingredients.Count);
        }

        [TestMethod]
        public void Instructions_LargeList_StoredCorrectly()
        {
            // Arrange
            var instructions = new List<string>();
            for (int i = 0; i < 20; i++) instructions.Add($"Шаг {i}");

            // Act
            var recipe = new Recipe("Тест", "Описание", new List<string>(), instructions, 100);

            // Assert
            Assert.AreEqual(20, recipe.Instructions.Count);
        }

        [TestMethod]
        public void RecipeWithSameName_CreatedTwice_BothAreIndependent()
        {
            // Arrange & Act
            var recipe1 = new Recipe("Борщ", "Первый", new List<string>(), new List<string>(), 300);
            var recipe2 = new Recipe("Борщ", "Второй", new List<string>(), new List<string>(), 400);

            // Assert
            Assert.AreNotSame(recipe1, recipe2);
            Assert.AreEqual(300, recipe1.Calories);
            Assert.AreEqual(400, recipe2.Calories);
        }
    }
}