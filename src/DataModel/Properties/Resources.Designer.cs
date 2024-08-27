﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUnique.OpenMU.DataModel.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MUnique.OpenMU.DataModel.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines, if the (sub-)servers should be automatically started then when server process starts. This setting applies only to the all-in-one server (MUnique.OpenMU.Startup)..
        /// </summary>
        public static string SystemConfiguration_AutoStart_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_AutoStart_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto Start.
        /// </summary>
        public static string SystemConfiguration_AutoStart_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_AutoStart_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines, if the all-in-one server (MUnique.OpenMU.Startup) automatically updates the database schema when the server process starts. In a distributed deployment, the user must start the update manually over the admin panel..
        /// </summary>
        public static string SystemConfiguration_AutoUpdateSchema_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_AutoUpdateSchema_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto Update Database Schema.
        /// </summary>
        public static string SystemConfiguration_AutoUpdateSchema_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_AutoUpdateSchema_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings apply system-wide. Keep in mind, they can be overwritten by start parameters and environment variables. Have a look at the Startup-Readme, if you want to know more about that..
        /// </summary>
        public static string SystemConfiguration_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines how the own ip address is determined. It&apos;s reported back to the game
        ///client in case it requests to connect to a selected game server (server selection
        ///screen) or the chat server (when starting a chat with the in-game messenger).
        ///This may be helpful, if the server is started in an environment where the public
        ///IP is not reachable from the outside (e.g. because you share your IPv4-Address
        ///or behind a firewall) and you want to use it within your computer or private network..
        /// </summary>
        public static string SystemConfiguration_IpResolver_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_IpResolver_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IP Resolving.
        /// </summary>
        public static string SystemConfiguration_IpResolver_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_IpResolver_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines the parameter for the IP resolving, when it&apos;s set to &apos;Custom&apos;.
        /// </summary>
        public static string SystemConfiguration_IpResolverParameter_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_IpResolverParameter_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom IP / Hostname.
        /// </summary>
        public static string SystemConfiguration_IpResolverParameter_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_IpResolverParameter_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Configuration.
        /// </summary>
        public static string SystemConfiguration_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines, if the user can enter commands in the console of the server process. This setting applies only to the all-in-one server (MUnique.OpenMU.Startup). It replaces the &apos;-deamon&apos; start parameter..
        /// </summary>
        public static string SystemConfiguration_ReadConsoleInput_Description {
            get {
                return ResourceManager.GetString("SystemConfiguration_ReadConsoleInput_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read console input.
        /// </summary>
        public static string SystemConfiguration_ReadConsoleInput_Name {
            get {
                return ResourceManager.GetString("SystemConfiguration_ReadConsoleInput_Name", resourceCulture);
            }
        }
    }
}
