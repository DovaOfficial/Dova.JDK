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

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "public")]
public partial class Infer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Infer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "inferKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rs", "Lcom/sun/tools/javac/comp/Resolve;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowGraphInference", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dependenciesFolder", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingGraphs", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "anyPoly", "Lcom/sun/tools/javac/code/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fromTypeVarFun", "Lcom/sun/tools/javac/code/Types$TypeMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "legacyEngine", "Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "graphEngine", "Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_INCORPORATION_STEPS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "incorporationCache", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "emptyContext", "Lcom/sun/tools/javac/comp/InferenceContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "roots", "(Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/comp/Infer$InferenceException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Infer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSuper", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiateMethod", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/util/List;ZZLcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;Lcom/sun/tools/javac/util/Warner;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiatePolymorphicSignatureInstance", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiateAsUninferredVars", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/InferenceContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doIncorporation", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dumpGraphsIfNeeded", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldPropagate", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/InferenceContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateReturnConstraints", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needsEagerInstantiation", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/InferenceContext;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateReferenceToTargetConstraint", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commonSuperWithDiffParameterization", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterizedSupers", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportBoundError", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportBoundError", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundFragment", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doIncorporationOp", "(Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportInstError", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiateFunctionalInterface", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/code/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "incorporationEngine", "()Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key inferKey_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Resolve;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Resolve rs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Resolve>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "")]
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "")]
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool allowGraphInference_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String dependenciesFolder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List pendingGraphs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.code.Type anyPoly_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types$TypeMapping;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping fromTypeVarFun_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types.TypeMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine legacyEngine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine graphEngine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_INCORPORATION_STEPS_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map incorporationCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/InferenceContext;", "final")]
	public Dova.JDK.com.sun.tools.javac.comp.InferenceContext emptyContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.InferenceContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Infer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Infer(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/DeferredAttr$DeferredAttrContext;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List roots(Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg0, Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredAttrContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Lcom/sun/tools/javac/comp/Infer$InferenceException;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceException error(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceException>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/Infer;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.Infer instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type asSuper(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/util/List;ZZLcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;Lcom/sun/tools/javac/util/Warner;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type instantiateMethod(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg2, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg3, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, bool arg6, bool arg7, Dova.JDK.com.sun.tools.javac.comp.Resolve.MethodResolutionContext arg8, Dova.JDK.com.sun.tools.javac.util.Warner arg9)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type instantiatePolymorphicSignatureInstance(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg1, Dova.JDK.com.sun.tools.javac.comp.Resolve.MethodResolutionContext arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/InferenceContext;)V", "")]
	public void instantiateAsUninferredVars(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
	public void doIncorporation(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionContext;)V", "private")]
	public void dumpGraphsIfNeeded(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.comp.Resolve.MethodResolutionContext arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/InferenceContext;)Z", "private")]
	public bool shouldPropagate(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Type generateReturnConstraints(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg1, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg2, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/InferenceContext;)Z", "private")]
	public bool needsEagerInstantiation(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/comp/Attr$ResultInfo;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.Type generateReferenceToTargetConstraint(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg3, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "private")]
	public bool commonSuperWithDiffParameterization(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getParameterizedSupers(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
	public void reportBoundError(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
	public void reportBoundError(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/JCDiagnostic$Fragment;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment getBoundFragment(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Fragment>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "")]
	public bool doIncorporationOp(Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.util.Warner arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
	public void reportInstError(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/comp/Check$CheckContext;)Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type instantiateFunctionalInterface(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.comp.Check.CheckContext arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;", "")]
	public Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine incorporationEngine()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.AbstractIncorporationEngine>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;", "abstract")]
	public partial class AbstractIncorporationEngine
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.UndetVarListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractIncorporationEngine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIncorporationActions", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "varInstantiated", "(Lcom/sun/tools/javac/code/Type$UndetVar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "varBoundChanged", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractIncorporationEngine(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;)V", "")]
		public AbstractIncorporationEngine(Dova.JDK.com.sun.tools.javac.comp.Infer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$AbstractIncorporationEngine;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)Lcom/sun/tools/javac/util/List;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.util.List getIncorporationActions(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)V", "public")]
		public void varInstantiated(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type;Z)V", "public")]
		public void varBoundChanged(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceException;", "public static")]
	public partial class InferenceException
		: Dova.JDK.com.sun.tools.javac.comp.Resolve.InapplicableMethodException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InferenceException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$InferenceException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDiagnostic", "()Lcom/sun/tools/javac/util/JCDiagnostic;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "transient")]
		public Dova.JDK.com.sun.tools.javac.util.List messages_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InferenceException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public InferenceException() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$InferenceException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/JCDiagnostic;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic getDiagnostic()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$PartiallyInferredMethodType;", "public")]
	public partial class PartiallyInferredMethodType
		: Dova.JDK.com.sun.tools.javac.code.Type.MethodType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PartiallyInferredMethodType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$PartiallyInferredMethodType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inferenceContext", "Lcom/sun/tools/javac/comp/InferenceContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Lcom/sun/tools/javac/comp/Env;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warn", "Lcom/sun/tools/javac/util/Warner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPartial", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/InferenceContext;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.InferenceContext inferenceContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.InferenceContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Env env_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Warner;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Warner warn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Warner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PartiallyInferredMethodType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$MethodType;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/util/Warner;)V", "public")]
		public PartiallyInferredMethodType(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg1, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg2, Dova.JDK.com.sun.tools.javac.comp.Env arg3, Dova.JDK.com.sun.tools.javac.util.Warner arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$PartiallyInferredMethodType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Attr$ResultInfo;)Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type check(Dova.JDK.com.sun.tools.javac.comp.Attr.ResultInfo arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPartial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "static final")]
	public partial class LegacyInferenceSteps
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LegacyInferenceSteps()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ_LOWER", "Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ_UPPER", "Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "steps", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/EnumSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps EQ_LOWER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps EQ_UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
		public Dova.JDK.java.util.EnumSet steps_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LegacyInferenceSteps(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/EnumSet;)V", "private")]
		public LegacyInferenceSteps(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.EnumSet arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$LegacyInferenceSteps;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.LegacyInferenceSteps>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$ImplicitArgType;", "")]
	public partial class ImplicitArgType
		: Dova.JDK.com.sun.tools.javac.comp.DeferredAttr.DeferredTypeMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplicitArgType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$ImplicitArgType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionPhase;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_0", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType_1", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_0", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType_1", "(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImplicitArgType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/comp/Resolve$MethodResolutionPhase;)V", "public")]
		public ImplicitArgType(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.comp.Resolve.MethodResolutionPhase arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$ImplicitArgType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Void;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitClassType_0(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$ClassType;Ljava/lang/Object;)Lcom/sun/tools/javac/code/Type;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Type visitClassType_1(Dova.JDK.com.sun.tools.javac.code.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public abstract")]
	public partial class IncorporationAction
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IncorporationAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$IncorporationAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uv", "Lcom/sun/tools/javac/code/Type$UndetVar;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "t", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameType", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubtype", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar uv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type t_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IncorporationAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;)V", "")]
		public IncorporationAction(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$IncorporationAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "abstract")]
		public void apply(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)Z", "")]
		public bool isSameType(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;)Z", "")]
		public bool isSubtype(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOp;", "")]
	public partial class IncorporationBinaryOp
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IncorporationBinaryOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opKind", "Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "op1", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "op2", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/util/Warner;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind opKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type op1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type op2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IncorporationBinaryOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;)V", "")]
		public IncorporationBinaryOp(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Warner;)Z", "")]
		public bool apply(Dova.JDK.com.sun.tools.javac.util.Warner arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "abstract static")]
	public partial class IncorporationBinaryOpKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IncorporationBinaryOpKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_SUBTYPE", "Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_SAME_TYPE", "Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;Lcom/sun/tools/javac/code/Types;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind IS_SUBTYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind IS_SAME_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IncorporationBinaryOpKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public IncorporationBinaryOpKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/util/Warner;Lcom/sun/tools/javac/code/Types;)Z", "abstract")]
		public bool apply(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2, Dova.JDK.com.sun.tools.javac.code.Types arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$IncorporationBinaryOpKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationBinaryOpKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$FreeTypeListener;", "abstract static interface")]
	public partial interface FreeTypeListener
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FreeTypeListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$FreeTypeListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typesInferred", "(Lcom/sun/tools/javac/comp/InferenceContext;)V"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;)V", "public abstract")]
		void typesInferred(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver;", "")]
	public partial class GraphSolver
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GraphSolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphSolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inferenceContext", "Lcom/sun/tools/javac/comp/InferenceContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "warn", "Lcom/sun/tools/javac/util/Warner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "solve", "(Lcom/sun/tools/javac/comp/Infer$GraphStrategy;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/InferenceContext;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.InferenceContext inferenceContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.InferenceContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Warner;", "")]
		public Dova.JDK.com.sun.tools.javac.util.Warner warn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Warner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GraphSolver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
		public GraphSolver(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1, Dova.JDK.com.sun.tools.javac.util.Warner arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$GraphSolver;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphStrategy;)V", "")]
		public void solve(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphStrategy arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;", "")]
		public partial class InferenceGraph
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InferenceGraph()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nodes", "Ljava/util/ArrayList;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/comp/Infer$GraphSolver;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findNode", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDot", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initNodes", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifyUpdate", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteNode", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V"));
			}

			[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
			public Dova.JDK.java.util.ArrayList nodes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver;", "final")]
			public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InferenceGraph(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver;)V", "")]
			public InferenceGraph(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;", "public")]
			public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node findNode(Dova.JDK.com.sun.tools.javac.code.Type arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "")]
			public Dova.JDK.java.lang.String toDot()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void initNodes()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V", "")]
			public void notifyUpdate(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0, Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V", "public")]
			public void deleteNode(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;", "")]
			public partial class Node
				: Dova.JDK.com.sun.tools.javac.util.GraphUtils.TarjanNode
				, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DottableNode
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Node()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deps", "Ljava/util/Set;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$2", "Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;Lcom/sun/tools/javac/code/Type;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closure", "()Ljava/util/Set;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllDependencies", "()Ljava/lang/Iterable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedDependencyKinds", "()[Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDependenciesByKind", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Collection;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nodeAttributes", "()Ljava/util/Properties;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDependency", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dependencyAttributes", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dependencyAttributes", "(Lcom/sun/tools/javac/util/GraphUtils$DottableNode;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "graphChanged", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWith", "(Lcom/sun/tools/javac/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closureInternal", "(Ljava/util/Set;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDependencies", "(Ljava/util/Set;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDependency", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)Z"));
				}

				[JniSignatureAttribute("Ljava/util/Set;", "")]
				public Dova.JDK.java.util.Set deps_Property
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

				[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;", "final")]
				public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph this2_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Node(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;Lcom/sun/tools/javac/code/Type;)V", "")]
				public Node(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
				public Dova.JDK.java.util.Set closure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}

				[JniSignatureAttribute("()Z", "protected")]
				public bool isLeaf()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
				public Dova.JDK.java.lang.Iterable getAllDependencies()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
				}

				[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;", "public")]
				public JavaArray<Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind> getSupportedDependencyKinds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind>>(ret);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Collection;", "public")]
				public Dova.JDK.java.util.Collection getDependenciesByKind(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Properties;", "public")]
				public Dova.JDK.java.util.Properties nodeAttributes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V", "protected")]
				public void addDependency(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;", "public")]
				public Dova.JDK.java.util.Properties dependencyAttributes(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DottableNode;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;", "public volatile")]
				public Dova.JDK.java.util.Properties dependencyAttributes(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DottableNode arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)V", "private")]
				public void graphChanged(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0, Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "protected")]
				public void mergeWith(Dova.JDK.com.sun.tools.javac.util.List arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/Set;)V", "private")]
				public void closureInternal(Dova.JDK.java.util.Set arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/Set;)V", "protected")]
				public void addDependencies(Dova.JDK.java.util.Set arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				}

				[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)Z", "protected")]
				public bool removeDependency(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
					return ret;
				}
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "static final")]
	public partial class DependencyKind
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DependencyKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$DependencyKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOUND", "Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STUCK", "Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dotStyle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Infer$DependencyKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind BOUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind STUCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String dotStyle_Property
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

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DependencyKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public DependencyKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$DependencyKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$DependencyKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.DependencyKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "static final")]
	public partial class GraphInferenceSteps
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GraphInferenceSteps()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ_LOWER", "Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ_LOWER_THROWS_UPPER_CAPTURED", "Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "steps", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/EnumSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps EQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps EQ_LOWER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps EQ_LOWER_THROWS_UPPER_CAPTURED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "final")]
		public Dova.JDK.java.util.EnumSet steps_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GraphInferenceSteps(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/EnumSet;)V", "private")]
		public GraphInferenceSteps(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.EnumSet arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$GraphInferenceSteps;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphInferenceSteps>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "abstract static")]
	public partial class InferenceStep
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InferenceStep()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$InferenceStep;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWER", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPER", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPER_LEGACY", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTURED", "Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ib", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/comp/Infer$InferenceStep;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "solve", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filterBounds", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep EQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep LOWER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep THROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep UPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep UPPER_LEGACY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep CAPTURED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound ib_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InferenceStep(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "private")]
		public InferenceStep(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$InferenceStep;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/comp/Infer$InferenceStep;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.comp.Infer.InferenceStep>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Z", "public")]
		public bool accepts(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/code/Type;", "abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Type solve(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List filterBounds(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$BestLeafSolver;", "abstract")]
	public partial class BestLeafSolver
		: Dova.JDK.com.sun.tools.javac.comp.Infer.LeafSolver
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BestLeafSolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$BestLeafSolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varsToSolve", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeCache", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noPath", "Lcom/sun/tools/javac/util/Pair;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeTreeToLeafs", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)Lcom/sun/tools/javac/util/Pair;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pickNode", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List varsToSolve_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map treeCache_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Pair;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Pair noPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BestLeafSolver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/util/List;)V", "")]
		public BestLeafSolver(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$BestLeafSolver;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;)Lcom/sun/tools/javac/util/Pair;", "")]
		public Dova.JDK.com.sun.tools.javac.util.Pair computeTreeToLeafs(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node pickNode(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$LeafSolver;", "abstract")]
	public partial class LeafSolver
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.comp.Infer.GraphStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LeafSolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$LeafSolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pickNode", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LeafSolver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;)V", "")]
		public LeafSolver(Dova.JDK.com.sun.tools.javac.comp.Infer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$LeafSolver;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node pickNode(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphStrategy;", "abstract static interface")]
	public partial interface GraphStrategy
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GraphStrategy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphStrategy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "done", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pickNode", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool done()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph$Node;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node pickNode(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph.Node>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphStrategy$NodeNotFoundException;", "public static")]
		public partial class NodeNotFoundException
			: Dova.JDK.java.lang.RuntimeException
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NodeNotFoundException()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$GraphStrategy$NodeNotFoundException;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "graph", "Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)V"));
			}

			[JniSignatureAttribute("J", "private static final")]
			public static long serialVersionUID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;", "transient")]
			public Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph graph_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NodeNotFoundException(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer$GraphSolver$InferenceGraph;)V", "public")]
			public NodeNotFoundException(Dova.JDK.com.sun.tools.javac.comp.Infer.GraphSolver.InferenceGraph arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$GraphStrategy$NodeNotFoundException;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$BoundFilter;", "protected static")]
	public partial class BoundFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.function.Predicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BoundFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$BoundFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inferenceContext", "Lcom/sun/tools/javac/comp/InferenceContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/InferenceContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Lcom/sun/tools/javac/code/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/InferenceContext;", "")]
		public Dova.JDK.com.sun.tools.javac.comp.InferenceContext inferenceContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.InferenceContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BoundFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;)V", "public")]
		public BoundFilter(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$BoundFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Z", "public")]
		public bool test(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool test(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$PropagateBounds;", "")]
	public partial class PropagateBounds
		: Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropagateBounds()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$PropagateBounds;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ib", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forward", "()Ljava/util/EnumSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "backwards", "()Ljava/util/EnumSet;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound ib_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PropagateBounds(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "public")]
		public PropagateBounds(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$PropagateBounds;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
		public void apply(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet forward()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet backwards()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$CheckUpperBounds;", "")]
	public partial class CheckUpperBounds
		: Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckUpperBounds()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$CheckUpperBounds;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckUpperBounds(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;)V", "public")]
		public CheckUpperBounds(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$CheckUpperBounds;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
		public void apply(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$SubstBounds;", "")]
	public partial class SubstBounds
		: Dova.JDK.com.sun.tools.javac.comp.Infer.CheckInst
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SubstBounds()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$SubstBounds;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCompatibleUpperBounds", "(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SubstBounds(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;)V", "")]
		public SubstBounds(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$SubstBounds;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
		public void apply(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/comp/InferenceContext;)V", "")]
		public void checkCompatibleUpperBounds(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0, Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$CheckInst;", "")]
	public partial class CheckInst
		: Dova.JDK.com.sun.tools.javac.comp.Infer.CheckBounds
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckInst()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$CheckInst;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "to", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/util/EnumSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundsToCheck", "()Ljava/util/EnumSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet to_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckInst(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;[Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "transient")]
		public CheckInst(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg2, JavaArray<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Ljava/util/EnumSet;)V", "")]
		public CheckInst(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.java.util.EnumSet arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$CheckInst;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet boundsToCheck()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
		public void report(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$EqCheckLegacy;", "")]
	public partial class EqCheckLegacy
		: Dova.JDK.com.sun.tools.javac.comp.Infer.CheckBounds
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EqCheckLegacy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$EqCheckLegacy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundsToCheck", "()Ljava/util/EnumSet;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EqCheckLegacy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
		public EqCheckLegacy(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$EqCheckLegacy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet boundsToCheck()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer$CheckBounds;", "")]
	public partial class CheckBounds
		: Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckBounds()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/comp/Infer$CheckBounds;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeFunc", "Ljava/util/function/BiFunction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optFilter", "Ljava/util/function/BiPredicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/comp/Infer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Ljava/util/function/BiFunction;Ljava/util/function/BiPredicate;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dup", "(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkBound", "(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/Warner;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundsToCheck", "()Ljava/util/EnumSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;", "")]
		public Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound from_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BiFunction;", "")]
		public Dova.JDK.java.util.function.BiFunction typeFunc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/BiPredicate;", "")]
		public Dova.JDK.java.util.function.BiPredicate optFilter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiPredicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Infer;", "final")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckBounds(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
		public CheckBounds(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Infer;Lcom/sun/tools/javac/code/Type$UndetVar;Lcom/sun/tools/javac/code/Type;Ljava/util/function/BiFunction;Ljava/util/function/BiPredicate;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
		public CheckBounds(Dova.JDK.com.sun.tools.javac.comp.Infer arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg1, Dova.JDK.com.sun.tools.javac.code.Type arg2, Dova.JDK.java.util.function.BiFunction arg3, Dova.JDK.java.util.function.BiPredicate arg4, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/Infer$CheckBounds;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/InferenceContext;Lcom/sun/tools/javac/util/Warner;)V", "")]
		public void apply(Dova.JDK.com.sun.tools.javac.comp.InferenceContext arg0, Dova.JDK.com.sun.tools.javac.util.Warner arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar;)Lcom/sun/tools/javac/comp/Infer$IncorporationAction;", "public")]
		public Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction dup(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Infer.IncorporationAction>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/util/Warner;)Z", "")]
		public bool checkBound(Dova.JDK.com.sun.tools.javac.code.Type arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg2, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg3, Dova.JDK.com.sun.tools.javac.util.Warner arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/EnumSet;", "")]
		public Dova.JDK.java.util.EnumSet boundsToCheck()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;Lcom/sun/tools/javac/code/Type$UndetVar$InferenceBound;)V", "")]
		public void report(Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg0, Dova.JDK.com.sun.tools.javac.code.Type.UndetVar.InferenceBound arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}
	}
}
