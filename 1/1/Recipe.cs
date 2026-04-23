using System;
using System.Collections.Generic;
using System.Windows.Forms;
public class Recipe
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Instructions { get; set; }
    public int Calories { get; set; }
    public Recipe(string name, string description, List<string> ingredients, List<string>
    instructions, int calories)
    {
        // Валидация
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Название рецепта не может быть пустым", nameof(name));
        }

        if (calories < 0)
        {
            throw new ArgumentException("Калории не могут быть отрицательными", nameof(calories));
        }

        Name = name;
        Description = description;
        Ingredients = ingredients;
        Instructions = instructions;
        Calories = calories;
    }
    public override string ToString()
    {
        return Name;
    }
}