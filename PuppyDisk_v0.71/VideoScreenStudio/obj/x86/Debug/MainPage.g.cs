﻿#pragma checksum "D:\vc10\OpenScreenRecorder\PuppyDisk_v0.71\VideoScreenStudio\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "828BF0C7BB7C427C95ECB9ADCEC45325"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoScreenStudio
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
            case 2: // MainPage.xaml line 28
                {
                    this.TextReport = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 29
                {
                    this.canvas2d = (global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)(target);
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.canvas2d).Draw += this.onCanvasDraw;
                }
                break;
            case 4: // MainPage.xaml line 30
                {
                    this.TextOutput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 23
                {
                    this.Record = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Record).Click += this.Record_Click;
                }
                break;
            case 6: // MainPage.xaml line 24
                {
                    this.Stop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop).Click += this.Stop_Click;
                }
                break;
            case 7: // MainPage.xaml line 25
                {
                    this.UnpackFiles = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UnpackFiles).Click += this.UnpackFiles_Click;
                }
                break;
            case 8: // MainPage.xaml line 19
                {
                    this.Save = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Save).Click += this.Save_Click;
                }
                break;
            case 9: // MainPage.xaml line 20
                {
                    this.SaveFileTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // MainPage.xaml line 14
                {
                    this.Pick = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pick).Click += this.Pick_Click;
                }
                break;
            case 11: // MainPage.xaml line 16
                {
                    this.ScreenTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

