﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MISA.CukCuk.Core.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MISA.CukCuk.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Mã khách hàng đã tồn tại trên hệ thống!..
        /// </summary>
        internal static string Customer_Code_Exists_msg {
            get {
                return ResourceManager.GetString("Customer_Code_Exists_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã khách hàng không được phép để trống!..
        /// </summary>
        internal static string Customer_Code_Null_msg {
            get {
                return ResourceManager.GetString("Customer_Code_Null_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID khách hàng không được phép để trống!..
        /// </summary>
        internal static string CustomerId_Null_msg {
            get {
                return ResourceManager.GetString("CustomerId_Null_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email đã tồn tại trên hệ thống!..
        /// </summary>
        internal static string Email_Exists_msg {
            get {
                return ResourceManager.GetString("Email_Exists_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email chưa đúng định dạng!..
        /// </summary>
        internal static string Email_Invalid_msg {
            get {
                return ResourceManager.GetString("Email_Invalid_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 001.
        /// </summary>
        internal static string MISACode {
            get {
                return ResourceManager.GetString("MISACode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại đã tồn tại trên hệ thống!..
        /// </summary>
        internal static string PhoneNumber_Exists_msg {
            get {
                return ResourceManager.GetString("PhoneNumber_Exists_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại chưa đúng định dạng!..
        /// </summary>
        internal static string PhoneNumber_Invalid_msg {
            get {
                return ResourceManager.GetString("PhoneNumber_Invalid_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Có lỗi xảy ra vui lòng liên hệ MISA!..
        /// </summary>
        internal static string User_msg {
            get {
                return ResourceManager.GetString("User_msg", resourceCulture);
            }
        }
    }
}
