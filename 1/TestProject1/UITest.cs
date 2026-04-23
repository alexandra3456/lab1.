
namespace TestProject
{
    [TestClass]
    public class UITests
    {
        private MealPlanForm _mealPlanForm;

        [TestInitialize]
        public void SetUp()
        {
            _mealPlanForm = new MealPlanForm();
        }

        [TestMethod]
        public void ListView_IsVisibleAndEnabled()
        {
            // Assert
  
            Assert.IsTrue(_mealPlanForm.listView.Enabled);
        }

        [TestMethod]
        public void AddRecipeButton_IsVisibleAndEnabled()
        {
            // Assert
 
            Assert.IsTrue(_mealPlanForm.addRecipeButton.Enabled);
        }

        [TestMethod]
        public void RemoveRecipeButton_IsVisibleAndEnabled()
        {
            // Assert
 
            Assert.IsTrue(_mealPlanForm.removeRecipeButton.Enabled);
        }

        [TestMethod]
        public void SearchRecipeButton_IsVisibleAndEnabled()
        {
            // Assert
   
            Assert.IsTrue(_mealPlanForm.searchRecipeButton.Enabled);
        }

        [TestMethod]
        public void ListView_HasTwoColumns()
        {
            // Assert
            Assert.AreEqual(2, _mealPlanForm.listView.Columns.Count);
        }

        [TestMethod]
        public void ListView_FirstColumnHeader_IsDate()
        {
            // Assert
            Assert.AreEqual("Дата", _mealPlanForm.listView.Columns[0].Text);
        }

        [TestMethod]
        public void ListView_SecondColumnHeader_IsName()
        {
            // Assert
            Assert.AreEqual("Название", _mealPlanForm.listView.Columns[1].Text);
        }

        [TestMethod]
        public void ListView_InitiallyEmpty()
        {
            // Assert
            Assert.AreEqual(0, _mealPlanForm.listView.Items.Count);
        }


        [TestMethod]
        public void Form_HasCorrectTitle()
        {
            // Assert
            Assert.AreEqual("Планирование меню", _mealPlanForm.Text);
        }
    }
}