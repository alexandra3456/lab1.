
namespace TestProject
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void Constructor_WhenValidData_SetsNameCorrectly()
        {
            // Arrange & Act
            var recipe = new Recipe("Блины", "Описание", new List<string>(), new List<string>(), 250);

            // Assert
            Assert.AreEqual("Блины", recipe.Name);
        }

        [TestMethod]
        public void Constructor_WhenValidData_SetsCaloriesCorrectly()
        {
            // Arrange & Act
            var recipe = new Recipe("Блины", "Описание", new List<string>(), new List<string>(), 250);

            // Assert
            Assert.AreEqual(250, recipe.Calories);
        }

        [TestMethod]
        public void Constructor_WhenValidData_SetsDescriptionCorrectly()
        {
            // Arrange & Act
            var recipe = new Recipe("Блины", "Вкусные блины", new List<string>(), new List<string>(), 250);

            // Assert
            Assert.AreEqual("Вкусные блины", recipe.Description);
        }

        [TestMethod]
        public void Constructor_WhenValidData_SetsIngredientsCorrectly()
        {
            // Arrange
            var ingredients = new List<string> { "Мука", "Яйца", "Молоко" };

            // Act
            var recipe = new Recipe("Блины", "Описание", ingredients, new List<string>(), 250);

            // Assert
            Assert.AreEqual(3, recipe.Ingredients.Count);
        }

        [TestMethod]
        public void Constructor_WhenValidData_SetsInstructionsCorrectly()
        {
            // Arrange
            var instructions = new List<string> { "Смешать", "Выпечь" };

            // Act
            var recipe = new Recipe("Блины", "Описание", new List<string>(), instructions, 250);

            // Assert
            Assert.AreEqual(2, recipe.Instructions.Count);
        }

        [TestMethod]
        public void ToString_ReturnsRecipeName()
        {
            // Arrange
            var recipe = new Recipe("Борщ", "Классический", new List<string>(), new List<string>(), 300);

            // Act
            var result = recipe.ToString();

            // Assert
            Assert.AreEqual("Борщ", result);
        }

        [TestMethod]
        public void Name_CanBeChanged()
        {
            // Arrange
            var recipe = new Recipe("Старое", "Описание", new List<string>(), new List<string>(), 100);

            // Act
            recipe.Name = "Новое";

            // Assert
            Assert.AreEqual("Новое", recipe.Name);
        }

        [TestMethod]
        public void Calories_CanBeChanged()
        {
            // Arrange
            var recipe = new Recipe("Тест", "Описание", new List<string>(), new List<string>(), 100);

            // Act
            recipe.Calories = 500;

            // Assert
            Assert.AreEqual(500, recipe.Calories);
        }

        [TestMethod]
        public void Description_CanBeChanged()
        {
            // Arrange
            var recipe = new Recipe("Тест", "Старое описание", new List<string>(), new List<string>(), 100);

            // Act
            recipe.Description = "Новое описание";

            // Assert
            Assert.AreEqual("Новое описание", recipe.Description);
        }

        [TestMethod]
        public void Ingredients_CanBeChanged()
        {
            // Arrange
            var recipe = new Recipe("Тест", "Описание", new List<string>(), new List<string>(), 100);

            // Act
            recipe.Ingredients = new List<string> { "Соль", "Перец" };

            // Assert
            Assert.AreEqual(2, recipe.Ingredients.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WhenCaloriesIsNegative_ThrowsArgumentException()
        {
            // Act
            new Recipe("Тест", "Описание", new List<string>(), new List<string>(), -10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WhenNameIsEmpty_ThrowsArgumentException()
        {
            // Act
            new Recipe("", "Описание", new List<string>(), new List<string>(), 100);
        }
    }
}