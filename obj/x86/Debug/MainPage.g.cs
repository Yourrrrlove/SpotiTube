﻿#pragma checksum "C:\Users\mariu\Desktop\projs\Spotitube\Spotitube\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CB128B38EABC9E3B7DCF932B79EF257"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 29
                {
                    this.maximizeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.maximizeButton).Click += this.MaximizeMinimizeButton_Click;
                }
                break;
            case 3: // MainPage.xaml line 31
                {
                    this.navbar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 65
                {
                    this.mainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // MainPage.xaml line 87
                {
                    this.Main = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 6: // MainPage.xaml line 136
                {
                    this.SearchBar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.SearchBar).KeyUp += this.SearchBar_KeyUp;
                }
                break;
            case 7: // MainPage.xaml line 138
                {
                    this.randomButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.randomButton).Click += this.RandomButton_Click;
                }
                break;
            case 8: // MainPage.xaml line 139
                {
                    this.loopButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.loopButton).Click += this.LoopButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 140
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.LeftButton_Click;
                }
                break;
            case 10: // MainPage.xaml line 141
                {
                    this.PlayButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PlayButton).Click += this.PlayButton_Click;
                }
                break;
            case 11: // MainPage.xaml line 142
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.RightButton_Click;
                }
                break;
            case 12: // MainPage.xaml line 144
                {
                    this.VolumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.VolumeSlider).ValueChanged += this.VolumeSlider_Changed;
                }
                break;
            case 13: // MainPage.xaml line 145
                {
                    this.TimeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 14: // MainPage.xaml line 146
                {
                    this.CurrentTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // MainPage.xaml line 147
                {
                    this.CurrentDuration = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // MainPage.xaml line 88
                {
                    this.MainViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 17: // MainPage.xaml line 89
                {
                    this.MainListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.MainListView).RightTapped += this.MainListView_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.MainListView).ItemClick += this.onItemClicked;
                }
                break;
            case 18: // MainPage.xaml line 92
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element18 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element18).Click += this.DeleteSongButton_Click;
                }
                break;
            case 20: // MainPage.xaml line 111
                {
                    global::Windows.UI.Xaml.Controls.Grid element20 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element20).DoubleTapped += this.Grid_DoubleTapped;
                    ((global::Windows.UI.Xaml.Controls.Grid)element20).DragStarting += this.Grid_DragStarting;
                }
                break;
            case 21: // MainPage.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.Button element21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element21).Click += this.AddPlaylistButton_Click;
                }
                break;
            case 22: // MainPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.Button element22 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element22).Click += this.MaximizeMinimizeButton_Click;
                }
                break;
            case 23: // MainPage.xaml line 46
                {
                    this.PlaylistList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.PlaylistList).RightTapped += this.StackPanel_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.PlaylistList).ItemClick += this.PlaylistList_ItemClick;
                }
                break;
            case 24: // MainPage.xaml line 49
                {
                    this.EditButton = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.EditButton).Click += this.EditButton_Click;
                }
                break;
            case 25: // MainPage.xaml line 50
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element25 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element25).Click += this.DeleteButton_Click;
                }
                break;
            case 26: // MainPage.xaml line 55
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element26 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element26).Drop += this.StackPanel_Drop;
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element26).DragEnter += this.StackPanel_DragEnter;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

