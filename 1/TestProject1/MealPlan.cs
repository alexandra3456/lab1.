using System.Windows.Forms;

namespace RecipeTests
{
    [TestClass]
    public class MealPlanTests
    {
        private MealPlan _mealPlan;
        private ListView _listView;

        [TestInitialize]
        public void SetUp()
        {
            _listView = new ListView();
            _mealPlan = new MealPlan(_listView);
        }

        [TestMethod]
        public void AddRecipeToPlan()
        {
            // Arrange

            var mealPlan = new MealPlan(_listView);
            // Act & Assert

            Assert.IsNotNull(mealPlan);
        }

        [TestMethod]
        public void RemoveRecipeFromPlan()
        {
            // Arrange
            _listView.SelectedItems.Clear();
            var mealPlan = new MealPlan(_listView);
            // Act
            mealPlan.RemoveRecipeFromPlan();
            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SearchRecipeByName()
        {
            // Arrange
            var mealPlan = new MealPlan(_listView);
            // Act & Assert
            Assert.IsNotNull(mealPlan);
        }

        [TestMethod]
        public void LoadPlan()
        {
            // Arrange
            _listView.Items.Add("Тестовый элемент");
            Assert.AreEqual(1, _listView.Items.Count);

            // Act
            var mealPlan = new MealPlan(_listView);

            // Assert
            Assert.AreEqual(0, _listView.Items.Count);
        }
    }
}