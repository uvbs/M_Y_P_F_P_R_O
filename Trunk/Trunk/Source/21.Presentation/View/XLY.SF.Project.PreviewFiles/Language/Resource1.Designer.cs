﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XLY.SF.Project.PreviewFiles.Language {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XLY.SF.Project.PreviewFiles.Language.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;LanguageResource&gt;
        ///  &lt;FilePreviewLanguage&gt;
        ///    &lt;Preview&gt;预览&lt;/Preview&gt;
        ///    &lt;HEX&gt;16进制&lt;/HEX&gt;
        ///    &lt;Start&gt;开始&lt;/Start&gt;
        ///    &lt;Pause&gt;暂停&lt;/Pause&gt;
        ///    &lt;Stop&gt;停止&lt;/Stop&gt;
        ///  &lt;/FilePreviewLanguage&gt;
        ///&lt;/LanguageResource&gt;
        ///
        ///
        /// 的本地化字符串。
        /// </summary>
        internal static string Language_Cn {
            get {
                return ResourceManager.GetString("Language_Cn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;LanguageResource xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;FilePreviewLanguage&gt;
        ///    &lt;Preview&gt;Preview&lt;/Preview&gt;
        ///    &lt;HEX&gt;HEC&lt;/HEX&gt;
        ///    &lt;Start&gt;Start&lt;/Start&gt;
        ///    &lt;Pause&gt;Pause&lt;/Pause&gt;
        ///    &lt;Stop&gt;Stop&lt;/Stop&gt;
        ///  &lt;/FilePreviewLanguage&gt;
        ///&lt;/LanguageResource&gt;
        /// 的本地化字符串。
        /// </summary>
        internal static string Language_En {
            get {
                return ResourceManager.GetString("Language_En", resourceCulture);
            }
        }
    }
}