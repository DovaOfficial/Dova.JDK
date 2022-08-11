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

[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter;", "public")]
public partial class RichDiagnosticFormatter
	: Dova.JDK.com.sun.tools.javac.util.ForwardingDiagnosticFormatter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RichDiagnosticFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Lcom/sun/tools/javac/util/JavacMessages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameSimplifier", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$ClassNameSimplifier;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printer", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "whereClauses", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePreprocessor", "Lcom/sun/tools/javac/code/Types$UnaryVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbolPreprocessor", "Lcom/sun/tools/javac/code/Types$DefaultSymbolVisitor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatMessage", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatMessage", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unique", "(Lcom/sun/tools/javac/code/Type$TypeVar;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRichPrinter", "()Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWhereClauses", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preprocessArgument", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preprocessType", "(Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preprocessSymbol", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preprocessDiagnostic", "(Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRichPrinter", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_0", "()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_1", "()Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "final")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JavacMessages;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.JavacMessages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JavacMessages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$ClassNameSimplifier;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.ClassNameSimplifier nameSimplifier_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.ClassNameSimplifier>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichPrinter printer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichPrinter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map whereClauses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$UnaryVisitor;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor typePreprocessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.UnaryVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$DefaultSymbolVisitor;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Types.DefaultSymbolVisitor symbolPreprocessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.DefaultSymbolVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RichDiagnosticFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public RichDiagnosticFormatter(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;)I", "private")]
	public int indexOf(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String format(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String formatMessage(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatMessage(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;)Z", "private")]
	public bool unique(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichPrinter getRichPrinter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichPrinter>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List getWhereClauses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void preprocessArgument(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)V", "protected")]
	public void preprocessType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "protected")]
	public void preprocessSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)V", "protected")]
	public void preprocessDiagnostic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;)V", "protected")]
	public void setRichPrinter(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichPrinter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;", "public volatile")]
	public Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration getConfiguration_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration getConfiguration_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;", "protected")]
	public partial class RichPrinter
		: Dova.JDK.com.sun.tools.javac.code.Printer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RichPrinter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "className", "(Lcom/sun/tools/javac/code/Type$ClassType;ZLjava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVar", "(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCapturedType", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassSymbol", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassSymbol", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodSymbol", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodSymbol", "(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capturedVarId", "(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localize", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RichPrinter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter;)V", "protected")]
		public RichPrinter(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichPrinter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;ZLjava/util/Locale;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String className(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, bool arg1, Dova.JDK.java.util.Locale arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$TypeVar;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeVar(Dova.JDK.com.sun.tools.javac.code.Type.TypeVar arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitCapturedType(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitClassSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String visitMethodSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitMethodSymbol(Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$CapturedType;Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String capturedVarId(Dova.JDK.com.sun.tools.javac.code.Type.CapturedType arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "public transient")]
		public Dova.JDK.java.lang.String localize(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "static final")]
	public partial class WhereClauseKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WhereClauseKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEVAR", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERSECTION", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind TYPEVAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind CAPTURED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind INTERSECTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WhereClauseKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public WhereClauseKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String key()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$WhereClauseKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.WhereClauseKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration;", "public static")]
	public partial class RichConfiguration
		: Dova.JDK.com.sun.tools.javac.util.ForwardingDiagnosticFormatter.ForwardingConfiguration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RichConfiguration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "features", "Ljava/util/EnumSet;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Options;Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enable", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disable", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableFeatures", "()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "protected")]
		public Dova.JDK.java.util.EnumSet features_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RichConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter;)V", "public")]
		public RichConfiguration(Dova.JDK.com.sun.tools.javac.util.Options arg0, Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)V", "public")]
		public void enable(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)Z", "public")]
		public bool isEnabled(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;)V", "public")]
		public void disable(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public")]
		public JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature> getAvailableFeatures()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static final")]
		public partial class RichFormatterFeature
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RichFormatterFeature()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHERE_CLAUSES", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE_NAMES", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNIQUE_TYPEVAR_NAMES", "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature WHERE_CLAUSES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature SIMPLE_NAMES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature UNIQUE_TYPEVAR_NAMES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RichFormatterFeature(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public RichFormatterFeature(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/RichDiagnosticFormatter$RichConfiguration$RichFormatterFeature;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter.RichConfiguration.RichFormatterFeature>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$ClassNameSimplifier;", "protected")]
	public partial class ClassNameSimplifier
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassNameSimplifier()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/RichDiagnosticFormatter$ClassNameSimplifier;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameClashes", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/RichDiagnosticFormatter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "simplify", "(Lcom/sun/tools/javac/code/Symbol;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUsage", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map nameClashes_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassNameSimplifier(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/RichDiagnosticFormatter;)V", "protected")]
		public ClassNameSimplifier(Dova.JDK.com.sun.tools.javac.util.RichDiagnosticFormatter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/RichDiagnosticFormatter$ClassNameSimplifier;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String simplify(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "protected")]
		public void addUsage(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
