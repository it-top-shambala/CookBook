using System.Windows;
using System.Windows.Controls;

namespace CookBook.App.Components.InputComponent;

public partial class InputComponent : UserControl
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

    public static readonly DependencyProperty LabelNameProperty = DependencyProperty.Register(nameof(LabelName), typeof(string), typeof(InputComponent), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    public static readonly DependencyProperty LabelValueProperty = DependencyProperty.Register(nameof(LabelValue), typeof(string), typeof(InputComponent), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public InputComponent()
    {
        InitializeComponent();
    }
}

