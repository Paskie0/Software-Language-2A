namespace Opdracht_6B;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        CreateButtons();
    }
    private void CreateButtons()
    {
        Size buttonSize = new Size(ClientSize.Width / 3, ClientSize.Height / 3);

        Point[] positions = new Point[]
        {
                new Point(0, 0),
                new Point(ClientSize.Width - 600, 0),
                new Point(ClientSize.Width - 300, 0),
                new Point(0, ClientSize.Height - 600),
                new Point(ClientSize.Width - 600, ClientSize.Height - 600),
                new Point(ClientSize.Width - 300, ClientSize.Height - 600),
                new Point(0, ClientSize.Height - 300),
                new Point(ClientSize.Width - 600, ClientSize.Height - 300),
                new Point(ClientSize.Width - 300, ClientSize.Height - 300)
        };

        foreach (var position in positions)
        {
            Button button = CreateReusableButton("X", buttonSize, position, centerButton);

            this.Controls.Add(button);
        }
    }

    private Button CreateReusableButton(string text, Size size, Point location, EventHandler eventHandler)
    {
        Button button = new Button
        {
            Text = text,
            Size = size,
            Location = location,
            UseVisualStyleBackColor = true
        };

        button.Click += eventHandler;

        return button;
    }

    private void centerButton(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (button.Text == "X")
        {
            button.Text = "O";
            return;
        }
        else
        {
            button.Text = "X";
        }
    }
}


