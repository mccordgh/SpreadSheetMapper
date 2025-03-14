using Avalonia.Controls;
using System;

namespace SpreadSheetMapper.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        FileAColumns.ItemsSource = Array.Empty<string>();
        FileBColumns.ItemsSource = Array.Empty<string>();
    }
}
