﻿#pragma checksum "..\..\..\Views\ChooseGamePlay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D6644736F594FF6F21E7BD44167C85B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameUI.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GameUI.Views {
    
    
    /// <summary>
    /// ChooseGamePlay
    /// </summary>
    public partial class ChooseGamePlay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button onePlayer;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock playerVsComputerText;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button twoPlayer;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button twoPlayerb;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock twoPlayersTextBox;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border startButtonBorder;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\ChooseGamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startGame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameUI;component/views/choosegameplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ChooseGamePlay.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.onePlayer = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\ChooseGamePlay.xaml"
            this.onePlayer.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\Views\ChooseGamePlay.xaml"
            this.onePlayer.MouseEnter += new System.Windows.Input.MouseEventHandler(this.onePlayer_MouseEnter);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\Views\ChooseGamePlay.xaml"
            this.onePlayer.MouseLeave += new System.Windows.Input.MouseEventHandler(this.onePlayer_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.playerVsComputerText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.twoPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayer.MouseEnter += new System.Windows.Input.MouseEventHandler(this.twoPlayer_MouseEnter);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayer.Click += new System.Windows.RoutedEventHandler(this.twoPlayer_Click);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayer.MouseLeave += new System.Windows.Input.MouseEventHandler(this.twoPlayer_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.twoPlayerb = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayerb.MouseEnter += new System.Windows.Input.MouseEventHandler(this.twoPlayerb_MouseEnter);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayerb.Click += new System.Windows.RoutedEventHandler(this.twoPlayer_Click);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\Views\ChooseGamePlay.xaml"
            this.twoPlayerb.MouseLeave += new System.Windows.Input.MouseEventHandler(this.twoPlayerb_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.twoPlayersTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.startButtonBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.startGame = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\Views\ChooseGamePlay.xaml"
            this.startGame.Click += new System.Windows.RoutedEventHandler(this.startGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

