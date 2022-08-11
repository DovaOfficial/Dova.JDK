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

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "public")]
public partial class ArgumentAttr
	: Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArgumentAttr()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "methodAttrKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferredAttr", "Lcom/sun/tools/javac/comp/DeferredAttr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attr", "Lcom/sun/tools/javac/comp/Attr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Lcom/sun/tools/javac/comp/Env;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Lcom/sun/tools/javac/code/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentTypeCache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/ArgumentAttr;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setResult", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSpeculative", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSpeculative", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processArg", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processArg", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/function/Function;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditional", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParens", "(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalCacheContext", "()Lcom/sun/tools/javac/comp/ArgumentAttr$LocalCacheContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribArg", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTree", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key methodAttrKey_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/DeferredAttr;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.DeferredAttr deferredAttr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.DeferredAttr>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "private final")]
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr attr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "private")]
	public Dova.JDK.com.sun.tools.javac.comp.Env env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type result_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map argumentTypeCache_Property
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
	public ArgumentAttr(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public ArgumentAttr(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/ArgumentAttr;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Type;)V", "")]
	public void setResult(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkSpeculative(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type checkSpeculative(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/function/Supplier;)V", "")]
	public void processArg(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/function/Function;)V", "")]
	public void processArg(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.function.Function arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
	public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "public")]
	public void visitConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V", "public")]
	public void visitParens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
	public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
	public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
	public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/comp/ArgumentAttr$LocalCacheContext;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.LocalCacheContext withLocalCacheContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.LocalCacheContext>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type attribArg(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
	public void visitTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
	public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$LocalCacheContext;", "")]
	public partial class LocalCacheContext
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalCacheContext()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$LocalCacheContext;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevCache", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leave", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map prevCache_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalCacheContext(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;)V", "public")]
		public LocalCacheContext(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$LocalCacheContext;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void leave()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$UniquePos;", "")]
	public partial class UniquePos
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UniquePos()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$UniquePos;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Lcom/sun/tools/javac/util/DiagnosticSource;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "")]
		public int pos_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/DiagnosticSource;", "")]
		public Dova.JDK.com.sun.tools.javac.util.DiagnosticSource source_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.DiagnosticSource>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UniquePos(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree;)V", "")]
		public UniquePos(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$UniquePos;";
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "abstract")]
	public partial class ArgumentType
		: Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgumentType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "speculativeTree", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "speculativeTypes", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "speculativeTree", "(Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "speculativeType", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionPhase;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "")]
		public Dova.JDK.java.lang.Object speculativeTree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map speculativeTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgumentType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/Map;)V", "public")]
		public ArgumentType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Type complete(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/tree/JCTree;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree speculativeTree(Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionPhase;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type speculativeType(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.comp.Resolve.MethodResolutionPhase arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedConstructorType;", "")]
	public partial class ResolvedConstructorType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ResolvedMemberType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResolvedConstructorType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedConstructorType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resultInfo", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ResolvedConstructorType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public ResolvedConstructorType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Ljava/util/Map;)V", "public")]
		public ResolvedConstructorType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedConstructorType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type methodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo resultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMethodType;", "")]
	public partial class ResolvedMethodType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ResolvedMemberType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResolvedMethodType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMethodType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resultInfo", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ResolvedMethodType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public ResolvedMethodType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Ljava/util/Map;)V", "public")]
		public ResolvedMethodType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMethodType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type methodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo resultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ExplicitLambdaType;", "")]
	public partial class ExplicitLambdaType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExplicitLambdaType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ExplicitLambdaType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argtypes", "Ljava/util/Optional;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnExpressions", "Ljava/util/Optional;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnExpressions", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkReturnInStatementLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argtypes", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkLambdaCompatible", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional argtypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional returnExpressions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExplicitLambdaType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "")]
		public ExplicitLambdaType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCLambda;Ljava/util/Map;)V", "")]
		public ExplicitLambdaType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ExplicitLambdaType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type getReturnType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List returnExpressions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)V", "")]
		public void checkReturnInStatementLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List argtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;)V", "private")]
		public void checkLambdaCompatible(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$SwitchExpressionType;", "")]
	public partial class SwitchExpressionType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SwitchExpressionType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$SwitchExpressionType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yieldExpressions", "Ljava/util/Optional;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "yieldExpressions", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional yieldExpressions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SwitchExpressionType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "")]
		public SwitchExpressionType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;Ljava/util/Map;)V", "")]
		public SwitchExpressionType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$SwitchExpressionType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List yieldExpressions()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ConditionalType;", "")]
	public partial class ConditionalType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConditionalType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ConditionalType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCConditional;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConditionalType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "")]
		public ConditionalType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCConditional;Ljava/util/Map;)V", "")]
		public ConditionalType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ConditionalType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ParensType;", "")]
	public partial class ParensType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParensType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ParensType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/ArgumentAttr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCParens;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCParens;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCParens;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParensType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCParens;)V", "")]
		public ParensType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCParens;Ljava/util/Map;)V", "")]
		public ParensType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ParensType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParens;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/ArgumentAttr$ArgumentType;", "volatile")]
		public Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType dup(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.comp.Env arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMemberType;", "abstract")]
	public partial class ResolvedMemberType
		: Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr.ArgumentType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResolvedMemberType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMemberType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodType", "()Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "overloadCheck", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resultInfo", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ResolvedMemberType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/ArgumentAttr;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Ljava/util/Map;)V", "public")]
		public ResolvedMemberType(Dova.JDK.com.sun.tools.javac.comp.ArgumentAttr arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.comp.Env arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/ArgumentAttr$ResolvedMemberType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Type;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Type methodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type overloadCheck(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/comp/Attr$ResultInfo;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo resultInfo(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo>(ret);
		}
	}
}
