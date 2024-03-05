using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Gato;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);

        // First Row
        this.FindControl<Button>("Start");
    }

    private void Start_OnClick(object? sender, RoutedEventArgs e)
    {
        var secondWindow = new Game();
        secondWindow.Show();
    }

    private void Btn2_OnClick(object? sender, RoutedEventArgs e)
    {
        var thirdWindow = new AutoGame();
        thirdWindow.Show();
    }
}