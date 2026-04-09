public partial class MealPlanForm : Form
{
    private MealPlan mealPlan;
    private ListView listView;
    private Button addRecipeButton;
    private Button removeRecipeButton;
    private Button searchRecipeButton;
    public MealPlanForm()
    {
        this.Text = "Планирование меню";
        this.Width = 500;
        this.Height = 400;
        CreateControls();
        mealPlan = new MealPlan(listView);
    }
    private void CreateControls()
    {
        listView = new ListView
        {
            Location = new System.Drawing.Point(10, 10),
            Size = new System.Drawing.Size(380, 280),
            View = View.Details,
            FullRowSelect = true
        };
        listView.Columns.Add("Дата", 100);
        listView.Columns.Add("Название", 270);
        addRecipeButton = new Button
        {
            Location = new System.Drawing.Point(10, 300),
            Text = "Добавить рецепт",
            Size = new System.Drawing.Size(100, 25)
        };
        addRecipeButton.Click += (sender, e) => mealPlan.AddRecipeToPlan();
        removeRecipeButton = new Button
        {
            Location = new System.Drawing.Point(120, 300),
            Text = "Удалить рецепт",
            Size = new System.Drawing.Size(100, 25)
        };
        removeRecipeButton.Click += (sender, e) => mealPlan.RemoveRecipeFromPlan();
        searchRecipeButton = new Button
        {
            Location = new System.Drawing.Point(230, 300),
            Text = "Поиск рецепта",
            Size = new System.Drawing.Size(100, 25)
        };
        searchRecipeButton.Click += (sender, e) => mealPlan.SearchRecipeByName();
        this.Controls.Add(listView);
        this.Controls.Add(addRecipeButton);
        this.Controls.Add(removeRecipeButton);
        this.Controls.Add(searchRecipeButton);
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }
}