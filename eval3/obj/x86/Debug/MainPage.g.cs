﻿#pragma checksum "C:\Users\amine\source\repos\eval3\eval3\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7650DFF98EE18B157C8546374CD932F8AF335ECD75665441FB626C8537E17652"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eval3
{
    partial class MainPage : 
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
            case 2: // MainPage.xaml line 13
                {
                    this.label = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 28
                {
                    this.supprimer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.supprimer).Click += this.supprimer_Click;
                }
                break;
            case 4: // MainPage.xaml line 29
                {
                    this.ajouter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ajouter).Click += this.ajouter_Click;
                }
                break;
            case 5: // MainPage.xaml line 30
                {
                    this.nouveau = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.nouveau).Click += this.nouveau_Click;
                }
                break;
            case 6: // MainPage.xaml line 31
                {
                    this.premier = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.premier).Click += this.premier_Click;
                }
                break;
            case 7: // MainPage.xaml line 32
                {
                    this.precedent = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.precedent).Click += this.precedent_Click;
                }
                break;
            case 8: // MainPage.xaml line 33
                {
                    this.suivant = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.suivant).Click += this.suivant_Click;
                }
                break;
            case 9: // MainPage.xaml line 34
                {
                    this.dernier = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.dernier).Click += this.dernier_Click;
                }
                break;
            case 10: // MainPage.xaml line 35
                {
                    this.titre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainPage.xaml line 16
                {
                    this.prenom = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 18
                {
                    this.nom = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // MainPage.xaml line 20
                {
                    this.sexe = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // MainPage.xaml line 22
                {
                    this.date_naissance = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // MainPage.xaml line 24
                {
                    this.numero_passeport = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // MainPage.xaml line 26
                {
                    this.echeance_passeport = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

