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


    public readonly DependencyProperty LabelNameProperty;
    public readonly DependencyProperty LabelValueProperty;
    public OutputComponent()
    {
        LabelNameProperty = DependencyProperty.Register(nameof(LabelName), typeof(string), typeof(OutputComponent));
        LabelValueProperty = DependencyProperty.Register(nameof(LabelValue), typeof(string), typeof(OutputComponent));
        InitializeComponent();
    }
}

