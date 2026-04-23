

//namespace _1
//{
public partial class MealPlanForm : Form
{

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public AutoScaleMode AutoScaleMode { get; private set; }
    public Size ClientSize { get; private set; }
    public string Text { get; private set; }

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        listView1 = new ListView();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(192, 255, 192);
        button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        button1.Location = new Point(37, 331);
        button1.Name = "button1";
        button1.Size = new Size(95, 51);
        button1.TabIndex = 0;
        button1.Text = "Добавить рецепт";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(192, 255, 255);
        button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        button2.Location = new Point(162, 331);
        button2.Name = "button2";
        button2.Size = new Size(91, 51);
        button2.TabIndex = 1;
        button2.Text = "Поиск";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(255, 192, 192);
        button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        button3.Location = new Point(281, 331);
        button3.Name = "button3";
        button3.Size = new Size(91, 51);
        button3.TabIndex = 2;
        button3.Text = "Удалить рецепт";
        button3.UseVisualStyleBackColor = false;
        // 
        // listView1
        // 
        listView1.Location = new Point(22, 24);
        listView1.Name = "listView1";
        listView1.Size = new Size(365, 291);
        listView1.TabIndex = 3;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // MealPlanForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(192, 192, 255);
        ClientSize = new Size(418, 394);
        Controls.Add(listView1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "MealPlanForm";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private ListView listView1;
}
//}
