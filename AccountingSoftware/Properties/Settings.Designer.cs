﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSoftware.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int sel_img_index {
            get {
                return ((int)(this["sel_img_index"]));
            }
            set {
                this["sel_img_index"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Test Software Company")]
        public string sett_companyName {
            get {
                return ((string)(this["sett_companyName"]));
            }
            set {
                this["sett_companyName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Jahed")]
        public string sett_manager {
            get {
                return ((string)(this["sett_manager"]));
            }
            set {
                this["sett_manager"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123(558)")]
        public string sett_landLine {
            get {
                return ((string)(this["sett_landLine"]));
            }
            set {
                this["sett_landLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+93729908940")]
        public string sett_cellNumber {
            get {
                return ((string)(this["sett_cellNumber"]));
            }
            set {
                this["sett_cellNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Afghanistan, Herat")]
        public string sett_address {
            get {
                return ((string)(this["sett_address"]));
            }
            set {
                this["sett_address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("test.com")]
        public string sett_webSite {
            get {
                return ((string)(this["sett_webSite"]));
            }
            set {
                this["sett_webSite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6.6")]
        public decimal sett_salesTax {
            get {
                return ((decimal)(this["sett_salesTax"]));
            }
            set {
                this["sett_salesTax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal sett_billTax {
            get {
                return ((decimal)(this["sett_billTax"]));
            }
            set {
                this["sett_billTax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Admin")]
        public string login_user_name {
            get {
                return ((string)(this["login_user_name"]));
            }
            set {
                this["login_user_name"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=JAHED\\JAHEDSQL;Initial Catalog=Accounting;Integrated Security=True;Tr" +
            "ustServerCertificate=True")]
        public string default_connection_string {
            get {
                return ((string)(this["default_connection_string"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=JAHED\\JAHEDSQL;Initial Catalog=Accounting;Integrated Security=True;Tr" +
            "ustServerCertificate=True")]
        public string main_connection_string {
            get {
                return ((string)(this["main_connection_string"]));
            }
            set {
                this["main_connection_string"] = value;
            }
        }
    }
}
