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

namespace Dova.JDK.com.sun.tools.javac.comp;

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "public")]
public partial class Flow
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Flow()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "flowKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "make", "Lcom/sun/tools/javac/tree/TreeMaker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rs", "Lcom/sun/tools/javac/comp/Resolve;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrEnv", "Lcom/sun/tools/javac/comp/Env;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lint", "Lcom/sun/tools/javac/code/Lint;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowEffectivelyFinalInInnerClasses", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Flow;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breaksOutOf", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "aliveAfter", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeLambda", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/TreeMaker;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeLambdaThrownTypes", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/TreeMaker;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key flowKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeMaker;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeMaker make_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeMaker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Resolve;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Resolve rs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Resolve>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attrEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Lint;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Lint lint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Lint>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool allowEffectivelyFinalInInnerClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Flow(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Flow(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Flow;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.Flow instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Z", "public")]
	public bool breaksOutOf(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)Z", "public")]
	public bool aliveAfter(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/TreeMaker;Z)V", "public")]
	public void analyzeLambda(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/tree/TreeMaker;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List analyzeLambdaThrownTypes(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
	public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$AliveAnalyzer;", "")]
	public partial class AliveAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AliveAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$AliveAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alive", "Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Flow;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transitiveCovers", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanStat", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExhaustive", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanDef", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransitivelyCovered", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearPendingExits", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanStats", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleConstantCaseLabel", "(Ljava/util/Set;Lcom/sun/tools/javac/tree/JCTree$JCCaseLabel;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDead", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$Liveness;", "private")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness alive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AliveAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public AliveAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$AliveAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
		public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
		public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
		public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
		public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
		public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
		public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
		public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
		public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
		public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
		public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
		public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
		public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
		public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)V", "private")]
		public void transitiveCovers(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.java.util.Set arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void scanStat(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Ljava/util/Set;)Z", "private")]
		public bool isExhaustive(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.java.util.Set arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void scanDef(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Symbol;Ljava/util/Set;)Z", "private")]
		public bool isTransitivelyCovered(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2, Dova.JDK.java.util.Set arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "private")]
		public void clearPendingExits(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "")]
		public void scanStats(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Set;Lcom/sun/tools/javac/tree/JCTree$JCCaseLabel;)V", "private")]
		public void handleConstantCaseLabel(Dova.JDK.java.util.Set arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCaseLabel arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
		public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
		public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void markDead()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer;", "public")]
	public partial class AssignAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AssignAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inits", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uninits", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uninitsTry", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initsWhenTrue", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initsWhenFalse", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uninitsWhenTrue", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uninitsWhenFalse", "Lcom/sun/tools/javac/util/Bits;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vardecls", "[Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classDef", "Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstadr", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextadr", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnadr", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unrefdResources", "Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flowKind", "Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInitialConstructor", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Flow;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary", "(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssign", "(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditional", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageDef", "(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert", "(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trackable", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearPendingExits", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanExprs", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "referenced", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninit", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "letInit", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "letInit", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetBits", "([Lcom/sun/tools/javac/util/Bits;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanExpr", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newVar", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initParam", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanCond", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinalUninitializedStaticField", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinalUninitializedField", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSwitch", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVars", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Bits;Lcom/sun/tools/javac/util/Bits;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkInit", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/util/JCDiagnostic$Error;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkInit", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDead", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits inits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits uninits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits uninitsTry_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits initsWhenTrue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits initsWhenFalse_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits uninitsWhenTrue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Bits uninitsWhenFalse_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "protected")]
		public JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl> vardecls_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl classDef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int firstadr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int nextadr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int returnadr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$WriteableScope;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope unrefdResources_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowKind;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind flowKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int startPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isInitialConstructor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AssignAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "public")]
		public AssignAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Z)V", "")]
		public void split(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void merge()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public volatile")]
		public void scan(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V", "public")]
		public void visitBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V", "public")]
		public void visitBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V", "public")]
		public void visitAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
		public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "public")]
		public void visitConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V", "public")]
		public void visitAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotatedType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V", "public volatile")]
		public void visitPackageDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
		public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
		public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
		public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
		public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
		public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
		public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
		public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
		public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
		public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
		public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
		public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
		public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
		public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
		public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
		public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
		public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V", "public")]
		public void visitAssert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
		public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z", "protected")]
		public bool trackable(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "private")]
		public void clearPendingExits(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "")]
		public void scanExprs(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "")]
		public void referenced(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "")]
		public void uninit(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void letInit(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "")]
		public void letInit(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		}

		[JniSignatureAttribute("([Lcom/sun/tools/javac/util/Bits;)V", "private transient")]
		public void resetBits(JavaArray<Dova.JDK.com.sun.tools.javac.util.Bits> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void scanExpr(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "")]
		public void newVar(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "protected")]
		public void initParam(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void scanCond(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z", "")]
		public bool isFinalUninitializedStaticField(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z", "")]
		public bool isFinalUninitializedField(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Z)V", "private")]
		public void handleSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/Bits;Lcom/sun/tools/javac/util/Bits;)V", "private")]
		public void addVars(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.Bits arg1, Dova.JDK.com.sun.tools.javac.util.Bits arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Lcom/sun/tools/javac/util/JCDiagnostic$Error;)V", "")]
		public void checkInit(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg1, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Error arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "")]
		public void checkInit(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
		public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
		public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void markDead()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57]);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer$AssignPendingExit;", "public")]
		public partial class AssignPendingExit
			: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.PendingExit
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AssignPendingExit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer$AssignPendingExit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inits", "Lcom/sun/tools/javac/util/Bits;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uninits", "Lcom/sun/tools/javac/util/Bits;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exit_inits", "Lcom/sun/tools/javac/util/Bits;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exit_uninits", "Lcom/sun/tools/javac/util/Bits;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/Bits;Lcom/sun/tools/javac/util/Bits;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveJump", "()V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Bits inits_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Bits uninits_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Bits exit_inits_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Bits;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Bits exit_uninits_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Bits>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AssignPendingExit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/Bits;Lcom/sun/tools/javac/util/Bits;)V", "public")]
			public AssignPendingExit(Dova.JDK.com.sun.tools.javac.comp.Flow.AssignAnalyzer arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.util.Bits arg2, Dova.JDK.com.sun.tools.javac.util.Bits arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$AssignAnalyzer$AssignPendingExit;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void resolveJump()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer;", "")]
	public partial class FlowAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlowAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preciseRethrowTypes", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classDef", "Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thrown", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caught", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Flow;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorUncaught", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markThrown", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCaughtType", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExceptionOrThrowable", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleSwitch", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDead", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "")]
		public Dova.JDK.java.util.HashMap preciseRethrowTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl classDef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List thrown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List caught_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FlowAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public FlowAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
		public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
		public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
		public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
		public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
		public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
		public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
		public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
		public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
		public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
		public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
		public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
		public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
		public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void errorUncaught()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V", "")]
		public void markThrown(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "")]
		public void checkCaughtType(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "private")]
		public bool isExceptionOrThrowable(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "private")]
		public void handleSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
		public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
		public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "")]
		public void markDead()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer$ThrownPendingExit;", "")]
		public partial class ThrownPendingExit
			: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.PendingExit
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ThrownPendingExit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer$ThrownPendingExit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thrown", "Lcom/sun/tools/javac/code/Type;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
			public Dova.JDK.com.sun.tools.javac.code.Type thrown_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ThrownPendingExit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type;)V", "")]
			public ThrownPendingExit(Dova.JDK.com.sun.tools.javac.comp.Flow.FlowAnalyzer arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$FlowAnalyzer$ThrownPendingExit;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$CaptureAnalyzer;", "")]
	public partial class CaptureAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CaptureAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$CaptureAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentTree", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Flow;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssign", "(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "letInit", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkEffectivelyFinal", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportInnerClsNeedsFinalError", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportEffectivelyFinalError", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeTree", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDead", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree currentTree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CaptureAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public CaptureAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$CaptureAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V", "public")]
		public void visitGuardPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCGuardPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V", "public")]
		public void visitAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
		public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
		public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
		public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
		public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
		public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
		public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public void letInit(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "")]
		public void checkEffectivelyFinal(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;)V", "")]
		public void reportInnerClsNeedsFinalError(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;)V", "")]
		public void reportEffectivelyFinalError(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/TreeMaker;)V", "public")]
		public void analyzeTree(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "")]
		public void markDead()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$LambdaAliveAnalyzer;", "")]
	public partial class LambdaAliveAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.AliveAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LambdaAliveAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$LambdaAliveAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inLambda", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool inLambda_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LambdaAliveAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public LambdaAliveAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$LambdaAliveAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
		public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$LambdaAssignAnalyzer;", "")]
	public partial class LambdaAssignAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.AssignAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LambdaAssignAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$LambdaAssignAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosedSymbols", "Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inLambda", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;Lcom/sun/tools/javac/comp/Env;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trackable", "(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$WriteableScope;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope enclosedSymbols_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool inLambda_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LambdaAssignAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;Lcom/sun/tools/javac/comp/Env;)V", "")]
		public LambdaAssignAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$LambdaAssignAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$VarSymbol;)Z", "protected")]
		public bool trackable(Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$LambdaFlowAnalyzer;", "")]
	public partial class LambdaFlowAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.FlowAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LambdaFlowAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$LambdaFlowAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inferredThrownTypes", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inLambda", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Flow;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List inferredThrownTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool inLambda_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LambdaFlowAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public LambdaFlowAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$LambdaFlowAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$SnippetAliveAnalyzer;", "")]
	public partial class SnippetAliveAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.AliveAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SnippetAliveAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$SnippetAliveAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SnippetAliveAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "")]
		public SnippetAliveAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$SnippetAliveAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$SnippetBreakAnalyzer;", "")]
	public partial class SnippetBreakAnalyzer
		: Dova.JDK.com.sun.tools.javac.comp.Flow.AliveAnalyzer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SnippetBreakAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$SnippetBreakAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seenTrees", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "breaksOut", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Flow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breaksOut", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set seenTrees_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool breaksOut_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SnippetBreakAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow;)V", "public")]
		public SnippetBreakAnalyzer(Dova.JDK.com.sun.tools.javac.comp.Flow arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$SnippetBreakAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
		public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
		public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
		public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
		public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
		public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
		public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool breaksOut()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$Liveness;", "abstract static")]
	public partial class Liveness
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Liveness()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$Liveness;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIVE", "Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEAD", "Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECOVERY", "Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "or", "(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "or", "(Lcom/sun/tools/javac/comp/Flow$Liveness;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(Lcom/sun/tools/javac/comp/Flow$Liveness;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness ALIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness DEAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness RECOVERY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Flow$Liveness;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Liveness(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Liveness(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$Liveness;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness from(bool arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$Liveness;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>>(ret);
		}

		[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness or(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow$Liveness;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness or(Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow$Liveness;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness and(Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/comp/Flow$Liveness;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness and(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer;", "abstract static")]
	public partial class BaseAnalyzer
		: Dova.JDK.com.sun.tools.javac.tree.TreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BaseAnalyzer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingExits", "Lcom/sun/tools/javac/util/ListBuffer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageDef", "(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveContinues", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordExit", "(Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$PendingExit;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveJump", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveBreaks", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scanSyntheticBreak", "(Lcom/sun/tools/javac/tree/TreeMaker;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveYields", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/comp/Flow$Liveness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDead", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer pendingExits_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BaseAnalyzer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BaseAnalyzer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
		public void scan(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V", "public")]
		public void visitPackageDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness resolveContinues(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$PendingExit;)V", "")]
		public void recordExit(Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.PendingExit arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "private")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness resolveJump(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1, Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness resolveBreaks(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/TreeMaker;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public void scanSyntheticBreak(Dova.JDK.com.sun.tools.javac.tree.TreeMaker arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/ListBuffer;)Lcom/sun/tools/javac/comp/Flow$Liveness;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness resolveYields(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.util.ListBuffer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.Liveness>(ret);
		}

		[JniSignatureAttribute("()V", "abstract")]
		public void markDead()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$PendingExit;", "static")]
		public partial class PendingExit
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PendingExit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$PendingExit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/tools/javac/tree/JCTree;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveJump", "()V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree tree_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PendingExit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "")]
			public PendingExit(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$PendingExit;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "")]
			public void resolveJump()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "abstract static")]
		public partial class JumpKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static JumpKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAK", "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE", "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YIELD", "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeTag", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/tree/JCTree$Tag;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind BREAK_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind CONTINUE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind YIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "final")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag treeTag_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public JumpKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/tree/JCTree$Tag;)V", "private")]
			public JumpKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree;", "abstract")]
			public Dova.JDK.com.sun.tools.javac.tree.JCTree getTarget(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$BaseAnalyzer$JumpKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.BaseAnalyzer.JumpKind>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowKind;", "static final")]
	public partial class FlowKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlowKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Flow$FlowKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPECULATIVE_LOOP", "Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errKey", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isFinal", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinal", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Flow$FlowKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow$FlowKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind SPECULATIVE_LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String errKey_Property
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

		[JniSignatureAttribute("Z", "final")]
		public bool isFinal_Property
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

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Flow$FlowKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FlowKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Z)V", "private")]
		public FlowKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Flow$FlowKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$FlowKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Flow$FlowKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isFinal()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Flow$FlowKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Flow.FlowKind>>(ret);
		}
	}
}
