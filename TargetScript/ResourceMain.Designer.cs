﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetScript {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceMain {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceMain() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TargetScript.ResourceMain", typeof(ResourceMain).Assembly);
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
        ///   Looks up a localized string similar to (?i:(?s:(?&lt;loop&gt;\{(?&lt;type&gt;(Condition|Continue|Loop|SetConfig))(?&lt;side&gt;(Start|End)){0,1}\((?&lt;params&gt;.*?)\)\}))).
        /// </summary>
        internal static string ActionNodeLineLoopPattern {
            get {
                return ResourceManager.GetString("ActionNodeLineLoopPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ((?&lt;content&gt;\[.*?\]))|((?&lt;content&gt;\{.*?\})).
        /// </summary>
        internal static string ActionNodeResolveVariablePattern {
            get {
                return ResourceManager.GetString("ActionNodeResolveVariablePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;keyword&gt;\[(?&lt;content&gt;[^\]]+)\])|(AND|OR|NOT|XOR)|(?&lt;content&gt;[a-z]+[0-9a-z-_\.]*)).
        /// </summary>
        internal static string AttributeKeywordPattern {
            get {
                return ResourceManager.GetString("AttributeKeywordPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;command&gt;\{(?&lt;name&gt;[a-z]+[0-9a-z-_]*)\((?&lt;params&gt;[^\{\}\[\]\(\)]*)\)\})).
        /// </summary>
        internal static string CommandEvalPattern {
            get {
                return ResourceManager.GetString("CommandEvalPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;command&gt;\{(?&lt;name&gt;IIF)\((?&lt;params&gt;.*?)\)\})).
        /// </summary>
        internal static string CommandSpecialPattern {
            get {
                return ResourceManager.GetString("CommandSpecialPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (c) 2018, 2019. Daniel Patterson, MCSD (danielanywhere).
        /// </summary>
        internal static string Copyright {
            get {
                return ResourceManager.GetString("Copyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;el&gt;\{\{(?=\{*))(?&lt;content&gt;[a-z]+[0-9a-z-_]*){0,1}(?&lt;er&gt;(?&lt;=\}*)\}\})).
        /// </summary>
        internal static string ExpressionEscapeCPattern {
            get {
                return ResourceManager.GetString("ExpressionEscapeCPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^~${content}~^.
        /// </summary>
        internal static string ExpressionEscapeCReplacement {
            get {
                return ResourceManager.GetString("ExpressionEscapeCReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;el&gt;\^\~)(?&lt;content&gt;[a-z]+[0-9a-z-_]*){0,1}(?&lt;er&gt;\~\^)).
        /// </summary>
        internal static string ExpressionEscapeDPattern {
            get {
                return ResourceManager.GetString("ExpressionEscapeDPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{${content}}}.
        /// </summary>
        internal static string ExpressionEscapeDReplacement {
            get {
                return ResourceManager.GetString("ExpressionEscapeDReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;el&gt;\[\[(?=\[*))(?&lt;content&gt;[a-z]+[0-9a-z-_\:]*){0,1}(?&lt;er&gt;(?&lt;=\]*)\]\])).
        /// </summary>
        internal static string ExpressionEscapeSPattern {
            get {
                return ResourceManager.GetString("ExpressionEscapeSPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^|${content}|^.
        /// </summary>
        internal static string ExpressionEscapeSReplacement {
            get {
                return ResourceManager.GetString("ExpressionEscapeSReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;el&gt;\^\|)(?&lt;content&gt;[a-z]+[0-9a-z-_\:]*){0,1}(?&lt;er&gt;\|\^)).
        /// </summary>
        internal static string ExpressionEscapeTPattern {
            get {
                return ResourceManager.GetString("ExpressionEscapeTPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[${content}]].
        /// </summary>
        internal static string ExpressionEscapeTReplacement {
            get {
                return ResourceManager.GetString("ExpressionEscapeTReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;key&gt;\[[^\]]+\])|(?&lt;key&gt;\{[^\}]+\})|(?&lt;key&gt;\&quot;.*(?&lt;!\\)\&quot;)|(AND|OR|NOT|XOR)|(?&lt;key&gt;\w+).
        /// </summary>
        internal static string ExpressionEvalStringPattern {
            get {
                return ResourceManager.GetString("ExpressionEvalStringPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;command&gt;\{(?&lt;name&gt;[a-z]+[0-9a-z-_]*)(\((?&lt;params&gt;.*?)\)){0,1}\})).
        /// </summary>
        internal static string ExpressionKeywordCommandPattern {
            get {
                return ResourceManager.GetString("ExpressionKeywordCommandPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:\{(?&lt;name&gt;[a-z]+[0-9a-z-_]*)\}).
        /// </summary>
        internal static string ExpressionKeywordConfigPattern {
            get {
                return ResourceManager.GetString("ExpressionKeywordConfigPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:\[(?&lt;name&gt;[a-z]+[0-9a-z-_\:]*)\]).
        /// </summary>
        internal static string ExpressionKeywordMetadataPattern {
            get {
                return ResourceManager.GetString("ExpressionKeywordMetadataPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(\{|\[)(?&lt;name&gt;[a-z]+[0-9a-z-_]*)).
        /// </summary>
        internal static string ExpressionKeywordNamePattern {
            get {
                return ResourceManager.GetString("ExpressionKeywordNamePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;operator&gt;AND|OR|NOT|XOR)).
        /// </summary>
        internal static string ExpressionOperatorPattern {
            get {
                return ResourceManager.GetString("ExpressionOperatorPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \((?&lt;tag&gt;\@(?&lt;index&gt;\d+)\#(?&lt;id&gt;\d+))\).
        /// </summary>
        internal static string ExpressionParameterPattern {
            get {
                return ResourceManager.GetString("ExpressionParameterPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;placeholder&gt;\@(?&lt;index&gt;\d+)\#(?&lt;id&gt;\d+)).
        /// </summary>
        internal static string ExpressionPlaceholderPattern {
            get {
                return ResourceManager.GetString("ExpressionPlaceholderPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:^(?&lt;word&gt;[a-z]+[0-9a-z-_]*)$).
        /// </summary>
        internal static string ExpressionSingleWord {
            get {
                return ResourceManager.GetString("ExpressionSingleWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?&lt;tag&gt;\@(?&lt;index&gt;\d+)\#(?&lt;id&gt;\d+))$.
        /// </summary>
        internal static string ExpressionTagOnlyPattern {
            get {
                return ResourceManager.GetString("ExpressionTagOnlyPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;tag&gt;\@(?&lt;index&gt;\d+)\#(?&lt;id&gt;\d+)).
        /// </summary>
        internal static string ExpressionTagPattern {
            get {
                return ResourceManager.GetString("ExpressionTagPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;word&gt;[a-z]+[0-9a-z]*)).
        /// </summary>
        internal static string ExpressionWordPattern {
            get {
                return ResourceManager.GetString("ExpressionWordPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;content&gt;\&quot;.*?(?&lt;!\\)\&quot;).
        /// </summary>
        internal static string InnerQuotesOnlyPattern {
            get {
                return ResourceManager.GetString("InnerQuotesOnlyPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;content&gt;\{[^\{\[\(\&quot;\}]+\})|(?&lt;content&gt;\[[^\{\[\(\&quot;\]]+\])|(?&lt;content&gt;\&quot;.*?(?&lt;!\\)\&quot;)|(AND|OR|NOT|XOR)|(?&lt;content&gt;\w+)).
        /// </summary>
        internal static string InnerVariablesAllPattern {
            get {
                return ResourceManager.GetString("InnerVariablesAllPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;content&gt;(?&lt;!\{)\{[a-z]+[0-9a-z-_]*\}(?!\}))|(?&lt;content&gt;(?&lt;!\[)\[[a-z]+[0-9a-z-_\:]*\](?!\]))|(AND|OR|NOT|XOR)|(?&lt;!(\{|\[)[0-9a-z-_]*)(?&lt;content&gt;[a-z]+[a-z0-9-_]*)(?![a-z0-9-_]*\s*\()(?![0-9a-z-_]*(\]|\}))).
        /// </summary>
        internal static string InnerVariablesNoQuotePattern {
            get {
                return ResourceManager.GetString("InnerVariablesNoQuotePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;content&gt;\{[^\{\[\(\&quot;\}]+\})|(?&lt;content&gt;\[[^\{\[\(\&quot;\]]+\]).
        /// </summary>
        internal static string InnerVariablesOnlyPattern {
            get {
                return ResourceManager.GetString("InnerVariablesOnlyPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;keyword&gt;\{(?&lt;content&gt;[a-z]+[0-9a-z-_]*)\})).
        /// </summary>
        internal static string JsonTemplateCKeywordPattern {
            get {
                return ResourceManager.GetString("JsonTemplateCKeywordPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{${content}}}.
        /// </summary>
        internal static string JsonTemplateCKeywordReplacement {
            get {
                return ResourceManager.GetString("JsonTemplateCKeywordReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;keyword&gt;\[(?&lt;content&gt;[a-z]+[0-9a-z-_]*)\])).
        /// </summary>
        internal static string JsonTemplateSKeywordPattern {
            get {
                return ResourceManager.GetString("JsonTemplateSKeywordPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[${content}]].
        /// </summary>
        internal static string JsonTemplateSKeywordReplacement {
            get {
                return ResourceManager.GetString("JsonTemplateSKeywordReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?s:(?&lt;object&gt;\{\s*\&quot;TypeName\&quot;\s*\:\s*\&quot;(?&lt;type&gt;[^\&quot;]+)\&quot;.*?((?=,\s*\{\s*\&quot;TypeName\&quot;\s*\:)|(?=\s*\]\s*$))))).
        /// </summary>
        internal static string JsonTemplateSplitPattern {
            get {
                return ResourceManager.GetString("JsonTemplateSplitPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;content&gt;\{(?&lt;command&gt;(inc|dec)indent)\s*\(\s*\)\s*\})).
        /// </summary>
        internal static string PostProcessingIncDecPattern {
            get {
                return ResourceManager.GetString("PostProcessingIncDecPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;content&gt;\{(?&lt;command&gt;tab)\s*\(\s*(?&lt;params&gt;\d+)\s*\)\s*\})).
        /// </summary>
        internal static string PostProcessingTabPattern {
            get {
                return ResourceManager.GetString("PostProcessingTabPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:\{(?&lt;variable&gt;\{.*?\})\}|\[(?&lt;variable&gt;\[.*?\])\]).
        /// </summary>
        internal static string PostProcessingUnescapeBracePattern {
            get {
                return ResourceManager.GetString("PostProcessingUnescapeBracePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ${variable}.
        /// </summary>
        internal static string PostProcessingUnescapeBraceReplacement {
            get {
                return ResourceManager.GetString("PostProcessingUnescapeBraceReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Convert easy-to-read, easy-to-maintain JSON declarations to finished code.
        ///
        ///Syntax:
        ///TargetScript {/project:{Filename}|/createtemplate:{Filename}}
        ///  [/mode:{ModeName}][/output:{Filename}]
        ///  [/projectPath:{WorkingPath}]
        ///  [/tabChar:{T|S}][/tabCount:{Integer}]
        ///  [/verbose]
        ///  [/wait]
        ///  [/?]
        ///
        ///  createtemplate - Open a text-based source file and convert it to template.
        ///  Filename       - Name of the project, source, or output file to open or save.
        ///  mode           - Set the operating mode.
        ///  ModeNam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Syntax {
            get {
                return ResourceManager.GetString("Syntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;content&gt;\{(?&lt;command&gt;\w+)\s*\(\s*(?&lt;params&gt;[^\{\[\(\&quot;\)]+)\s*\)\s*\}).
        /// </summary>
        internal static string ToolsCommandsPattern {
            get {
                return ResourceManager.GetString("ToolsCommandsPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;char&gt;[\!\@\#\$\%\^\&amp;\*\(\)\+\=\\\|\{\}\[\]\?\&quot;\&lt;\&gt;\.]).
        /// </summary>
        internal static string ToolsEscapePattern {
            get {
                return ResourceManager.GetString("ToolsEscapePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \${char}.
        /// </summary>
        internal static string ToolsEscapeReplacement {
            get {
                return ResourceManager.GetString("ToolsEscapeReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:(?&lt;subject&gt;[^\s]+)\s+IN\s*\((?&lt;params&gt;.*?)\)).
        /// </summary>
        internal static string ToolsReduceCommandInPattern {
            get {
                return ResourceManager.GetString("ToolsReduceCommandInPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?i:\s*(?&lt;param&gt;[^,]+)\s*(,|$)).
        /// </summary>
        internal static string ToolsReduceCommandParamPattern {
            get {
                return ResourceManager.GetString("ToolsReduceCommandParamPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^\s*(\[(?&lt;content&gt;.*)\])|(\{(?&lt;content&gt;.*)\})|(\((?&lt;content&gt;.*)\))|(\&quot;(?&lt;content&gt;.*)\&quot;)\s*$.
        /// </summary>
        internal static string ToolsStripBracesPattern {
            get {
                return ResourceManager.GetString("ToolsStripBracesPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ${content}.
        /// </summary>
        internal static string ToolsStripBracesReplacement {
            get {
                return ResourceManager.GetString("ToolsStripBracesReplacement", resourceCulture);
            }
        }
    }
}
