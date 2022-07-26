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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer;", "")]
public partial class CompletenessAnalyzer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompletenessAnalyzer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scannerFactory", "Lcom/sun/tools/javac/parser/ScannerFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proc", "Ljdk/jshell/JShell;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XEXPR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDECL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSTMT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XEXPR1o", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDECL1o", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSTMT1o", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XEXPR1", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDECL1", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSTMT1", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XANY1", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XTERM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSTART", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XERRO", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XBRACESNEEDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMODIFIER", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/JShell;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "error", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Ljava/lang/String;)Ljdk/jshell/CompletenessAnalyzer$CaInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "die", "()V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ScannerFactory;", "private final")]
	public Dova.JDK.com.sun.tools.javac.parser.ScannerFactory scannerFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ScannerFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/JShell;", "private final")]
	public Dova.JDK.jdk.jshell.JShell proc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.JShell>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XEXPR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XDECL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XSTMT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XEXPR1o_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XDECL1o_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XSTMT1o_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XEXPR1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XDECL1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XSTMT1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XANY1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XTERM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XSTART_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XERRO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XBRACESNEEDED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int XMODIFIER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompletenessAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/JShell;)V", "")]
	public CompletenessAnalyzer(Dova.JDK.jdk.jshell.JShell arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "private static")]
	public static Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness error()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jshell/CompletenessAnalyzer$CaInfo;", "")]
	public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CaInfo scan(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CaInfo>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void die()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CaLog;", "private static")]
	public partial class CaLog
		: Dova.JDK.com.sun.tools.javac.util.Log
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CaLog()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$CaLog;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;Ljava/io/PrintWriter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(ILjava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(ILcom/sun/tools/javac/util/JCDiagnostic$Error;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLog", "(Lcom/sun/tools/javac/util/Context;)Ljdk/jshell/CompletenessAnalyzer$CaLog;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CaLog(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;Ljava/io/PrintWriter;)V", "private")]
		public CaLog(Dova.JDK.com.sun.tools.javac.util.Context arg0, Dova.JDK.java.io.PrintWriter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$CaLog;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void error(int arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public transient")]
		public void error(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/util/JCDiagnostic$Error;)V", "public")]
		public void error(int arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)V", "public")]
		public void report(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Ljdk/jshell/CompletenessAnalyzer$CaLog;", "private static")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.CaLog createLog(Dova.JDK.com.sun.tools.javac.util.Context arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CaLog>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$Parser;", "private static")]
	public partial class Parser
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Parser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$Parser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchedFactory", "Ljava/util/function/Supplier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parseFactory", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljdk/jshell/CompletenessAnalyzer$Matched;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Ljdk/jshell/CompletenessAnalyzer$CT;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkResult", "Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/function/Supplier;Lcom/sun/tools/javac/util/Names;Ljava/util/function/Function;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextToken", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endPos", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseUnit", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetInput", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldAbort", "(Ljdk/jshell/SourceCodeAnalysis$Completeness;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldAbort", "(Ljdk/jshell/CompletenessAnalyzer$TK;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseExpressionOptionalSemi", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSimpleStatement", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseDeclaration", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disambiguateDeclarationVsExpression", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseExpressionStatement", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disambiguateStatementVsExpression", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseExpression", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastly", "(Ljdk/jshell/CompletenessAnalyzer$TK;)Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "optionalFinalSemi", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseStatement", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
		}

		[JniSignatureAttribute("Ljava/util/function/Supplier;", "private final")]
		public Dova.JDK.java.util.function.Supplier matchedFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
		public Dova.JDK.java.util.function.Function parseFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$Matched;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.Matched @in_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.Matched>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CT;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT token_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysis$Completeness;", "private")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness checkResult_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
		public Dova.JDK.com.sun.tools.javac.util.Names names_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Parser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/function/Supplier;Lcom/sun/tools/javac/util/Names;Ljava/util/function/Function;)V", "")]
		public Parser(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.com.sun.tools.javac.util.Names arg1, Dova.JDK.java.util.function.Function arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$Parser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "final")]
		public void nextToken()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int endPos()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseUnit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()V", "final")]
		public void resetInput()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljdk/jshell/SourceCodeAnalysis$Completeness;)Z", "")]
		public bool shouldAbort(Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;)Z", "")]
		public bool shouldAbort(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseExpressionOptionalSemi()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseSimpleStatement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseDeclaration()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness disambiguateDeclarationVsExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseExpressionStatement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness disambiguateStatementVsExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;)Ljdk/jshell/SourceCodeAnalysis$Completeness;", "")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness lastly(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness optionalFinalSemi()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness parseStatement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CaInfo;", "static")]
	public partial class CaInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CaInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$CaInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unitEndPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/SourceCodeAnalysis$Completeness;I)V"));
		}

		[JniSignatureAttribute("I", "final")]
		public int unitEndPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysis$Completeness;", "final")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness status_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CaInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/SourceCodeAnalysis$Completeness;I)V", "")]
		public CaInfo(Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$CaInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$SyntaxException;", "private static")]
	public partial class SyntaxException
		: Dova.JDK.java.lang.RuntimeException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SyntaxException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$SyntaxException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SyntaxException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SyntaxException() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$SyntaxException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$Matched;", "private static")]
	public partial class Matched
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Matched()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$Matched;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scanner", "Lcom/sun/tools/javac/parser/Scanner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Lcom/sun/tools/javac/parser/Tokens$Token;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevCT", "Ljdk/jshell/CompletenessAnalyzer$CT;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentCT", "Ljdk/jshell/CompletenessAnalyzer$CT;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Ljava/util/Deque;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Scanner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljdk/jshell/CompletenessAnalyzer$CT;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Ljdk/jshell/CompletenessAnalyzer$CT;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "db", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "advance", "()Lcom/sun/tools/javac/parser/Tokens$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextCT", "()Ljdk/jshell/CompletenessAnalyzer$CT;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Scanner;", "private final")]
		public Dova.JDK.com.sun.tools.javac.parser.Scanner scanner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Scanner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token;", "private")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Token current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CT;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT prevCT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CT;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT currentCT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Deque;", "private final")]
		public Dova.JDK.java.util.Deque stack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Deque>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Matched(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Scanner;)V", "")]
		public Matched(Dova.JDK.com.sun.tools.javac.parser.Scanner arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$Matched;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/jshell/CompletenessAnalyzer$CT;", "public")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Ljdk/jshell/CompletenessAnalyzer$CT;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT match(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private transient")]
		public void db(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/parser/Tokens$Token;", "private")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Token advance()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/CompletenessAnalyzer$CT;", "private")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT nextCT()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.CT>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$CT;", "private static")]
	public partial class CT
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CT()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$CT;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tok", "Lcom/sun/tools/javac/parser/Tokens$Token;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$Token;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$Token;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/CompletenessAnalyzer$TK;I)V"));
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public final")]
		public Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public final")]
		public int endPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String message_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token;", "public final")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Token tok_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CT(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$Token;Ljava/lang/String;)V", "private")]
		public CT(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.Token arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$Token;)V", "private")]
		public CT(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;I)V", "private")]
		public CT(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$CT;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "static final")]
	public partial class TK
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TK()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/CompletenessAnalyzer$TK;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOF", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTIFIER", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDERSCORE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONKEYS_AT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPORT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEMI", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONST", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUSTOM", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLEMENTS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSTRACT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRICTFP", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTECTED", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSIENT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOLATILE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMA", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMP", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTLT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTGT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUES", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STAR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASSERT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAK", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CATCH", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DO", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELSE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINALLY", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWITCH", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNCHRONIZED", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROW", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRY", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHILE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTLITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONGLITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOATLITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLELITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARLITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRINGLITERAL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALSE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THIS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUSPLUS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBSUB", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARROW", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLCOL", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LPAREN", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RPAREN", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LBRACE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RBRACE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LBRACKET", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RBRACKET", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELLIPSIS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BANG", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TILDE", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLON", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BANGEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMPAMP", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BARBAR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUB", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLASH", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CARET", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERCENT", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUSEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STAREQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLASHEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMPEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAREQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CARETEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERCENTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTLTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTGTEQ", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNMATCHED", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARENS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACKETS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRACES", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOTSTAR", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLCOLNEW", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOTCLASS", "Ljdk/jshell/CompletenessAnalyzer$TK;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tokenKindToTKMap", "Ljava/util/EnumMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokenKind", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "belongs", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueOp", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mapping", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/jshell/CompletenessAnalyzer$TK;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$TokenKind;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$TokenKind;IZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/jshell/CompletenessAnalyzer$TK;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/jshell/CompletenessAnalyzer$TK;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isError", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/jshell/CompletenessAnalyzer$TK;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tokenKindToTK", "(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Ljdk/jshell/CompletenessAnalyzer$TK;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStart", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOkToTerminate", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeclaration", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBracesNeeded", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModifier", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpression", "()Z"));
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK EOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ERROR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK IDENTIFIER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK UNDERSCORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK MONKEYS_AT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK IMPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SEMI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CONST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GOTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CUSTOM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ENUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK IMPLEMENTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK THROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK INT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK VOID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ABSTRACT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FINAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK NATIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK STRICTFP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PRIVATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PROTECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK TRANSIENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK EXTENDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK COMMA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK AMP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LTLT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GTGT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GTGTGT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK QUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DOT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK STAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ASSERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BREAK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CONTINUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ELSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FINALLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK IF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK RETURN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SYNCHRONIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK THROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK TRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK WHILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK INTLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LONGLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FLOATLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DOUBLELITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CHARLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK STRINGLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK TRUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK FALSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK NULL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK THIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PLUSPLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SUBSUB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK INSTANCEOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK NEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SUPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ARROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK COLCOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LPAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK RPAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LBRACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK RBRACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LBRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK RBRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK ELLIPSIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK EQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BANG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK TILDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK COLON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK EQEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BANGEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK AMPAMP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BARBAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SUB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SLASH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CARET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PERCENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PLUSEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SUBEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK STAREQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK SLASHEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK AMPEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BAREQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK CARETEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PERCENTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK LTLTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GTGTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK GTGTGTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK UNMATCHED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK PARENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BRACKETS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK BRACES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DOTSTAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK COLCOLNEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer$TK;", "public static final")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK DOTCLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumMap;", "static final")]
		public static Dova.JDK.java.util.EnumMap tokenKindToTKMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "final")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind tokenKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[122], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int belongs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[123]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[123], value);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool valueOp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[124]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[124], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "")]
		public Dova.JDK.java.util.function.Function mapping_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[125], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/jshell/CompletenessAnalyzer$TK;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TK(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$TokenKind;I)V", "private")]
		public TK(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$TokenKind;IZ)V", "private")]
		public TK(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg2, int arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public TK(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/CompletenessAnalyzer$TK;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/jshell/CompletenessAnalyzer$TK;", "public static")]
		public static JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jshell/CompletenessAnalyzer$TK;", "public static")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isError()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/jshell/CompletenessAnalyzer$TK;", "private static")]
		public static JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jshell/CompletenessAnalyzer$TK;Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Ljdk/jshell/CompletenessAnalyzer$TK;", "private static")]
		public static Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK tokenKindToTK(Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK arg0, Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer.TK>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isStart()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isOkToTerminate()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isDeclaration()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isBracesNeeded()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isModifier()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isExpression()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}
	}
}
