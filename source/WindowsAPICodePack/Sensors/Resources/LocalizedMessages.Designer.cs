﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAPICodePack.Sensors.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAPICodePack.Sensors.Resources.LocalizedMessages", typeof(LocalizedMessages).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data field array cannot be null or empty..
        /// </summary>
        internal static string SensorEmptyData {
            get {
                return ResourceManager.GetString("SensorEmptyData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property keys array cannot be null or empty..
        /// </summary>
        internal static string SensorEmptyProperties {
            get {
                return ResourceManager.GetString("SensorEmptyProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sensor id=&apos;{0}&apos; type=&apos;{1}&apos; category=&apos;{2}&apos; name=&apos;{3}&apos;..
        /// </summary>
        internal static string SensorGetString {
            get {
                return ResourceManager.GetString("SensorGetString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sensors collection cannot be null or empty..
        /// </summary>
        internal static string SensorManagerEmptySensorsCollection {
            get {
                return ResourceManager.GetString("SensorManagerEmptySensorsCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sensor not initialized..
        /// </summary>
        internal static string SensorNotInitialized {
            get {
                return ResourceManager.GetString("SensorNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data contains a null value at index {0}..
        /// </summary>
        internal static string SensorNullValueAtIndex {
            get {
                return ResourceManager.GetString("SensorNullValueAtIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find property..
        /// </summary>
        internal static string SensorPropertyNotFound {
            get {
                return ResourceManager.GetString("SensorPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No sensors found. Are any sensor drivers installed?.
        /// </summary>
        internal static string SensorsNotFound {
            get {
                return ResourceManager.GetString("SensorsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get report from sensor..
        /// </summary>
        internal static string SensorUnableToGetReport {
            get {
                return ResourceManager.GetString("SensorUnableToGetReport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected pointer size..
        /// </summary>
        internal static string SensorUnexpectedPointerSize {
            get {
                return ResourceManager.GetString("SensorUnexpectedPointerSize", resourceCulture);
            }
        }
    }
}
