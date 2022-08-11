/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.jshell.tool;

[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback;", "")]
public partial class Feedback
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Feedback()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Feedback;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_PATTERN", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUNCATION_FIELD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_SEPARATOR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR_VALUE_ADD_SELECTOR", "Ljdk/internal/jshell/tool/Selector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_TYPEKIND_SELECTOR", "Ljdk/internal/jshell/tool/Selector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Ljdk/internal/jshell/tool/Feedback$Mode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retainedCurrentMode", "Ljdk/internal/jshell/tool/Feedback$Mode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modeMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retainedMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFormat", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrompt", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContinuationPrompt", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modeCompletions", "()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modeCompletions", "(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldDisplayCommandFluff", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPre", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPost", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorPre", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorPost", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markModesReadOnly", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreEncodedModes", "(Ljdk/internal/jshell/tool/MessageHandler;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeedback", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;Ljava/util/function/Consumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncateVarValue", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTruncation", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMode", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;Ljava/util/function/Consumer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrompt", "(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern FIELD_PATTERN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String TRUNCATION_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String RECORD_SEPARATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector VAR_VALUE_ADD_SELECTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "private static final")]
	public static Dova.JDK.jdk.@internal.jshell.tool.Selector RECORD_TYPEKIND_SELECTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode retainedCurrentMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map modeMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map retainedMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Feedback(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Feedback() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Feedback;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg2, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.lang.String arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.util.List arg10)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg2, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved arg5, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.lang.String arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.lang.String arg10, Dova.JDK.java.util.List arg11)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "public")]
	public bool setFormat(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPrompt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getContinuationPrompt(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider modeCompletions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;)Ljdk/internal/jshell/tool/JShellTool$CompletionProvider;", "")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider modeCompletions(Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool.CompletionProvider>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool shouldDisplayCommandFluff()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPre()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPost()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getErrorPre()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getErrorPost()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void markModesReadOnly()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljava/lang/String;)Z", "public")]
	public bool restoreEncodedModes(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;Ljava/util/function/Consumer;)Z", "public")]
	public bool setFeedback(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String truncateVarValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "public")]
	public bool setTruncation(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;Ljava/util/function/Consumer;)Z", "public")]
	public bool setMode(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1, Dova.JDK.java.util.function.Consumer arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)Z", "public")]
	public bool setPrompt(Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg0, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback$Mode;", "private static")]
	public partial class Mode
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Mode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Feedback$Mode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commandFluff", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byField", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readOnly", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prompt", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "continuationPrompt", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Feedback$Mode;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Feedback$Mode$Setting;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrompt", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContinuationPrompt", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncateVarValue", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCommandFluff", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrompts", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncateValue", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool commandFluff_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map byField_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool readOnly_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String prompt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String continuationPrompt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Mode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Feedback$Mode;)V", "")]
		public Mode(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;)V", "private")]
		public Mode(Dova.JDK.java.lang.String arg0, bool arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public Mode(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Feedback$Mode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Feedback$Mode$Setting;)V", "private")]
		public void add(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode.Setting arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String encode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String format(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String format(Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg2, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.lang.String arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.util.List arg10)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector$FormatCase;Ljdk/internal/jshell/tool/Selector$FormatAction;Ljdk/internal/jshell/tool/Selector$FormatWhen;Ljdk/internal/jshell/tool/Selector$FormatResolve;Ljdk/internal/jshell/tool/Selector$FormatUnresolved;Ljdk/internal/jshell/tool/Selector$FormatErrors;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String format(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatCase arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatAction arg2, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatWhen arg3, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatResolve arg4, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatUnresolved arg5, Dova.JDK.jdk.@internal.jshell.tool.Selector.FormatErrors arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.lang.String arg8, Dova.JDK.java.lang.String arg9, Dova.JDK.java.lang.String arg10, Dova.JDK.java.util.List arg11)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)V", "")]
		public void set(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.jshell.tool.Selector arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getPrompt(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getContinuationPrompt(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String truncateVarValue(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Z)V", "")]
		public void setCommandFluff(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void setPrompts(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String truncateValue(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback$Mode$Setting;", "static")]
		public partial class Setting
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Setting()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Feedback$Mode$Setting;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "format", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selector", "Ljdk/internal/jshell/tool/Selector;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String format_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/Selector;", "final")]
			public Dova.JDK.jdk.@internal.jshell.tool.Selector selector_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Setting(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/jshell/tool/Selector;)V", "")]
			public Setting(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.jshell.tool.Selector arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Feedback$Mode$Setting;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback$Setter;", "private")]
	public partial class Setter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Setter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/Feedback$Setter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "at", "Ljdk/internal/jshell/tool/ArgTokenizer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messageHandler", "Ljdk/internal/jshell/tool/MessageHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valid", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/Feedback;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/Feedback;Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormat", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFormat", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hard", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluffmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOptionsAndRemainingInput", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fluff", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFluff", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hardmsg", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreEncodedModes", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFeedback", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTruncation", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMode", "(Ljava/util/function/Consumer;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodedModeIterator", "(Ljava/lang/String;)Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildMode", "(Ljava/util/Iterator;)Ljdk/internal/jshell/tool/Feedback$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showModeSettings", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showModeSettings", "(Ljdk/internal/jshell/tool/Feedback$Mode;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showPromptSettings", "(Ljdk/internal/jshell/tool/Feedback$Mode;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFormatSettings", "(Ljdk/internal/jshell/tool/Feedback$Mode;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showTruncationSettings", "(Ljdk/internal/jshell/tool/Feedback$Mode;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextMode", "()Ljdk/internal/jshell/tool/Feedback$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextFormat", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorat", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toIdentifier", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installFormat", "(Ljdk/internal/jshell/tool/Feedback$Mode;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFeedbackSetting", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFeedbackModes", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toModeIdentifier", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSelector", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextModeIdentifier", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStringLiteral", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchForMode", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/Feedback$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "searchForMode", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/jshell/tool/Feedback$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrompt", "()Z"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ArgTokenizer;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer at_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/MessageHandler;", "private final")]
		public Dova.JDK.jdk.@internal.jshell.tool.MessageHandler messageHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.MessageHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool valid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/Feedback;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.Feedback this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Setter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback;Ljdk/internal/jshell/tool/MessageHandler;Ljdk/internal/jshell/tool/ArgTokenizer;)V", "")]
		public Setter(Dova.JDK.jdk.@internal.jshell.tool.Feedback arg0, Dova.JDK.jdk.@internal.jshell.tool.MessageHandler arg1, Dova.JDK.jdk.@internal.jshell.tool.ArgTokenizer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/Feedback$Setter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String toFormat(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool setFormat()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void hard(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void fluffmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void checkOptionsAndRemainingInput()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void fluff(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool showFluff()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void hardmsg(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
		public bool restoreEncodedModes(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "")]
		public bool setFeedback(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool setTruncation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/function/Consumer;)Z", "")]
		public bool setMode(Dova.JDK.java.util.function.Consumer arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Iterator;", "")]
		public Dova.JDK.java.util.Iterator encodedModeIterator(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Iterator;)Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode buildMode(Dova.JDK.java.util.Iterator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void showModeSettings(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback$Mode;)V", "")]
		public void showModeSettings(Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback$Mode;)V", "")]
		public void showPromptSettings(Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback$Mode;Ljava/lang/String;)V", "")]
		public void showFormatSettings(Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback$Mode;)V", "")]
		public void showTruncationSettings(Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("()Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode nextMode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String nextFormat()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public void errorat(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String toIdentifier(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/Feedback$Mode;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void installFormat(Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()V", "")]
		public void showFeedbackSetting()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
		}

		[JniSignatureAttribute("()V", "")]
		public void showFeedbackModes()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String toModeIdentifier(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Selector;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Selector parseSelector(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Selector>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String nextModeIdentifier()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String toStringLiteral(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode searchForMode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/internal/jshell/tool/Feedback$Mode;", "private")]
		public Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode searchForMode(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.Feedback.Mode>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool setPrompt()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
			return ret;
		}
	}
}
