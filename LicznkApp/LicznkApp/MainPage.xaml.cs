namespace LicznkApp;

public partial class MainPage : ContentPage
{
    int counterNumber = 1;

    public MainPage()
    {
        InitializeComponent();
        AddCounter("Licznik 1");
    }

    void OnAddClicked(object sender, EventArgs e)
    {
        counterNumber++;
        AddCounter("Licznik " + counterNumber);
    }

    void AddCounter(string name)
    {
        int value = 0;

        var nameLabel = new Label { Text = name, FontAttributes = FontAttributes.Bold };
        var valueLabel = new Label { Text = value.ToString(), FontSize = 20, HorizontalOptions = LayoutOptions.Center };

        var plus = new Button { Text = "+", BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("#87CEFA") ,  };
        var minus = new Button { Text = "-", BackgroundColor = Microsoft.Maui.Graphics.Color.FromArgb("#87CEFA") };

        plus.Clicked += (s, e) => { value++; valueLabel.Text = value.ToString(); };
        minus.Clicked += (s, e) => { value--; valueLabel.Text = value.ToString(); };

        var stack = new HorizontalStackLayout
        {
            Children = { minus, valueLabel, plus }
        };

        var box = new VerticalStackLayout
        {
            Children = { nameLabel, stack },
            Margin = new Thickness(0, 10)
        };

        CounterLayout.Children.Add(box);
    }
}
