﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarsRover.Helper {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TextMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TextMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarsRover.Helper.TextMessages", typeof(TextMessages).Assembly);
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
        ///   Looks up a localized string similar to Please enter valid inputs for rover.
        /// </summary>
        internal static string ERR_0001 {
            get {
                return ResourceManager.GetString("ERR_0001", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter valid inputs for field.
        /// </summary>
        internal static string ERR_0002 {
            get {
                return ResourceManager.GetString("ERR_0002", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rover&apos;s initial position can not be greater than Field&apos;s boundaries.
        /// </summary>
        internal static string ERR_RANGE_OVERFLOW {
            get {
                return ResourceManager.GetString("ERR_RANGE_OVERFLOW", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the boundary coordinates of the Mars plateau.
        /// </summary>
        internal static string TXT_BOUNDARY {
            get {
                return ResourceManager.GetString("TXT_BOUNDARY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter initial coordinates for Rover [ID].
        /// </summary>
        internal static string TXT_INIT_COORDS {
            get {
                return ResourceManager.GetString("TXT_INIT_COORDS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter instruction set for Rover [ID].
        /// </summary>
        internal static string TXT_INST_SET {
            get {
                return ResourceManager.GetString("TXT_INST_SET", resourceCulture);
            }
        }
    }
}