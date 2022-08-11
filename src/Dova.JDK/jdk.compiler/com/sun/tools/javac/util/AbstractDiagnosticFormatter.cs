/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.util;

[JniSignatureAttribute("Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter;", "public abstract")]
public partial class AbstractDiagnosticFormatter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractDiagnosticFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Lcom/sun/tools/javac/util/JavacMessages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "config", "Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allCaptured", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printer", "Lcom/sun/tools/javac/code/Printer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/JavacMessages;Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indent", "(Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatKind", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatKind", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRaw", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localize", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indentString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expr2String", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatIterable", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Iterable;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatArgument", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatDiagnostic", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatSourceLine", "(Lcom/sun/tools/javac/util/JCDiagnostic;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatLintCategory", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrinter", "()Lcom/sun/tools/javac/code/Printer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatSubdiagnostics", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displaySource", "(Ljavax/tools/Diagnostic;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displaySource", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatArguments", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrinter", "(Lcom/sun/tools/javac/code/Printer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatSubdiagnostic", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_0", "()Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_1", "()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatPosition", "(Ljavax/tools/Diagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatPosition", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatSource", "(Ljavax/tools/Diagnostic;ZLjava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatSource", "(Lcom/sun/tools/javac/util/JCDiagnostic;ZLjava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;)J"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JavacMessages;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.JavacMessages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JavacMessages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration config_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int depth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List allCaptured_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Printer;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Printer printer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Printer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractDiagnosticFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JavacMessages;Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;)V", "protected")]
	public AbstractDiagnosticFormatter(Dova.JDK.com.sun.tools.javac.util.JavacMessages arg0, Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String format(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String indent(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatKind(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String formatKind(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRaw()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "protected transient")]
	public Dova.JDK.java.lang.String localize(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String indentString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String expr2String(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Iterable;Ljava/util/Locale;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatIterable(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.Iterable arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/Object;Ljava/util/Locale;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatArgument(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "protected abstract")]
	public Dova.JDK.java.lang.String formatDiagnostic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;I)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatSourceLine(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatLintCategory(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Printer;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Printer getPrinter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Printer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List formatSubdiagnostics(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;)Z", "public volatile")]
	public bool displaySource(Dova.JDK.javax.tools.Diagnostic arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Z", "public")]
	public bool displaySource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/util/Collection;", "protected")]
	public Dova.JDK.java.util.Collection formatArguments(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Printer;)V", "public")]
	public void setPrinter(Dova.JDK.com.sun.tools.javac.code.Printer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatSubdiagnostic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration getConfiguration_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;", "public volatile")]
	public Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration getConfiguration_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String formatPosition(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatPosition(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;ZLjava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String formatSource(Dova.JDK.javax.tools.Diagnostic arg0, bool arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;ZLjava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatSource(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, bool arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;)J", "private")]
	public long getPosition(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;", "public static")]
	public partial class SimpleConfiguration
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleConfiguration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multilineLimits", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibleParts", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caretEnabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Set;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Options;Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMultilineLimit", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCaretEnabled", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisiblePart", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMultilineLimit", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCaretEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisible_0", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisible_1", "()Ljava/util/EnumSet;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected")]
		public Dova.JDK.java.util.Map multilineLimits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "protected")]
		public Dova.JDK.java.util.EnumSet visibleParts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool caretEnabled_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Set;)V", "public")]
		public SimpleConfiguration(Dova.JDK.java.util.Set arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;Ljava/util/Set;)V", "public")]
		public SimpleConfiguration(Dova.JDK.com.sun.tools.javac.util.Options arg0, Dova.JDK.java.util.Set arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Set;)V", "public")]
		public void setVisible(Dova.JDK.java.util.Set arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;)I", "public")]
		public int getMultilineLimit(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setCaretEnabled(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;Z)V", "public")]
		public void setVisiblePart(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;I)V", "public")]
		public void setMultilineLimit(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCaretEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public volatile")]
		public Dova.JDK.java.util.Set getVisible_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "public")]
		public Dova.JDK.java.util.EnumSet getVisible_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
	}
}
