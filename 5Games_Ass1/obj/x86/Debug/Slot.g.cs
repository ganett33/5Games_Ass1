#pragma checksum "E:\Ours\Jongbo\LV6 IT\SoftwareDevelopment(LV6)\SoftwareDev(Lv6)\Semester1\COMP.6215 - Graphical User Interface Programming\Assignmnet\Final\5Games_Ass1\5Games_Ass1\Slot.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED12AFBBC844E6FECA3DD4AD5F14EDCB3B85C170D8ECD125B0D29076416E9391"
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
    partial class Slot : 
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
            case 2: // Slot.xaml line 58
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Slot.xaml line 61
                {
                    this.bg_blend = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 4: // Slot.xaml line 68
                {
                    this.img_SlotMachine = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // Slot.xaml line 75
                {
                    this.textBlockDollars = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Slot.xaml line 78
                {
                    this.buttonAddCash = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonAddCash).Click += this.buttonAddCash_Click;
                }
                break;
            case 7: // Slot.xaml line 83
                {
                    this.buttonPlay = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonPlay).Click += this.buttonPlay_Click;
                }
                break;
            case 8: // Slot.xaml line 90
                {
                    this.imageWheel1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageWheel1).Tapped += this.imageWheel1_Tapped;
                }
                break;
            case 9: // Slot.xaml line 95
                {
                    this.imageWheel2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageWheel2).Tapped += this.imageWheel2_Tapped;
                }
                break;
            case 10: // Slot.xaml line 100
                {
                    this.imageWheel3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageWheel3).Tapped += this.imageWheel3_Tapped;
                }
                break;
            case 11: // Slot.xaml line 107
                {
                    this.imageWinLose = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12: // Slot.xaml line 108
                {
                    this.imagerightdeco = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13: // Slot.xaml line 113
                {
                    this.rec_DecoTop = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 14: // Slot.xaml line 118
                {
                    this.richTxt_Intro = (global::Windows.UI.Xaml.Controls.RichTextBlock)(target);
                }
                break;
            case 15: // Slot.xaml line 163
                {
                    this.GameOver = (global::Windows.UI.Xaml.Controls.Image)(target);
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

