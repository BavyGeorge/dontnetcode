﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.IO;

namespace Software_Engineering.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        public string GeneratePath()
        {
            System.IO.DirectoryInfo myDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            string parentDirectory = myDirectory.Parent.FullName;
            parentDirectory = parentDirectory.Substring(0, parentDirectory.Length - 9);
            parentDirectory = parentDirectory + "SoftwareEngineeringDatabase.mdf";
            string Firstpart = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=";
            string Lastpart = ";Integrated Security = True;Connect Timeout =30";
            string Fullpath = Firstpart + parentDirectory + Lastpart;
            return Fullpath;
        }

        [global::System.Configuration.ApplicationScopedSetting()]
        [global::System.Diagnostics.DebuggerNonUserCode()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1823382\Source\Repos\Software_Engineering _Assignment\Software Engineering\Software Engineering\SoftwareEngineeringDatabase.mdf;Integrated Security=True")]

        public string DatabaseCon
        {
            get
            {
                return ((string)(this["DatabaseCon"]));
            }
        }
    }
}
