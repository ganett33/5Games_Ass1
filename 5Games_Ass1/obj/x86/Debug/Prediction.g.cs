#pragma checksum "E:\Ours\Jongbo\LV6 IT\SoftwareDevelopment(LV6)\SoftwareDev(Lv6)\Semester1\COMP.6215 - Graphical User Interface Programming\Assignmnet\Final\5Games_Ass1\5Games_Ass1\Prediction.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F3D5E882CD58CF419385DC1172946CCF0F31BA9055E6FC5D256B57E429143CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _5Games_Ass1
{
    partial class Prediction : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Prediction.xaml line 12
                {
                    this.bg_movie = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Prediction.xaml line 48
                {
                    this.Teller = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Prediction.xaml line 50
                {
                    this.ButtonPrediction = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonPrediction).Click += this.ButtonPrediction_Click;
                }
                break;
            case 5: // Prediction.xaml line 56
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 6: // Prediction.xaml line 57
                {
                    this.Effect1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // Prediction.xaml line 58
                {
                    this.Effect = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // Prediction.xaml line 63
                {
                    this.TextBlockPrediction = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Prediction.xaml line 64
                {
                    this.txt_Welcome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

