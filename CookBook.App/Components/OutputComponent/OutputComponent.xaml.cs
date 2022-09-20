using System.Windows;
using System.Windows.Controls;

namespace CookBook.App.Components.OutputComponent;

public partial class OutputComponent : UserControl
{
    public string LabelName
    {
        get => GetValue(LabelNameProperty).ToString();
        set => SetValue(LabelNameProperty, value);
    }

    public string LabelValue
    {
        get => GetValue(LabelValueProperty).ToString();
        set => SetValue(LabelValueProperty, value);
    }


    public static readonly DependencyProperty LabelNameProperty =
        DependencyProperty.Register(nameof(LabelName), typeof(string), typeof(OutputComponent));

    public static readonly DependencyProperty LabelValueProperty =
        DependencyProperty.Register(nameof(LabelValue), typeof(string), typeof(OutputComponent));

    public OutputComponent()
    {
        InitializeComponent();
    }
}
