using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace GameUI.Views
{
    /// <summary>
    /// Interaction logic for ChooseGamePlay.xaml
    /// </summary>
    public partial class ChooseGamePlay : UserControl
    {
        public ChooseGamePlay()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            startButtonBorder.Visibility = Visibility.Visible;
        }

        private void onePlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            playerVsComputerText.Text = "Player Vs Computer";
            playerVsComputerText.Foreground = Brushes.White;

        }

        private void onePlayer_MouseLeave(object sender, MouseEventArgs e)
        {
            playerVsComputerText.Text = null;
        }

        private void twoPlayer_MouseEnter(object sender, MouseEventArgs e)
        {
            twoPlayersTextBox.Text = "Player1 Vs Player2";
            Rotation3DAnimation r3DA = new Rotation3DAnimation();
            //r3DA.To =
            r3DA.Duration = TimeSpan.FromSeconds(5);
          //  twoPlayer.BeginAnimation(twoPlayer.r, r3DA);
        }

        private void twoPlayerb_MouseEnter(object sender, MouseEventArgs e)
        {
            twoPlayersTextBox.Text = "Player1 Vs Player2";
            Rotation3DAnimationUsingKeyFrames rkf = new Rotation3DAnimationUsingKeyFrames();            
        }

        private void twoPlayerb_MouseLeave(object sender, MouseEventArgs e)
        {
            twoPlayersTextBox.Text = null;
        }

        private void twoPlayer_MouseLeave(object sender, MouseEventArgs e)
        {
            twoPlayersTextBox.Text = null;
        }

        private void twoPlayer_Click(object sender, RoutedEventArgs e)
        {
            startButtonBorder.Visibility = Visibility.Visible;
        }

        private void startGame_Click(object sender, RoutedEventArgs e)
        {

        }


        //DoubleAnimation widthAnimation = new DoubleAnimation();
        //widthAnimation.From = 160;
        //widthAnimation.To = click.Width - 30;
        //widthAnimation.Duration = TimeSpan.FromSeconds(5);
        //click.BeginAnimation(Button.WidthProperty, widthAnimation);

    }
}
