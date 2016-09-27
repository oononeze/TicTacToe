using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for GameShell.xaml
    /// </summary>
    public partial class GameShell : Window
    {
        public GameShell()
        {
            InitializeComponent();

            DoubleAnimation logoFontAnimation = new DoubleAnimation();
            logoFontAnimation.By = 30;
            logoFontAnimation.Duration = TimeSpan.FromSeconds(2);
            logo.BeginAnimation(TextBox.FontSizeProperty, logoFontAnimation);
        }
    }
}
