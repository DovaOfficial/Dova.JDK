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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm;", "")]
public partial class LambdaForm
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LambdaForm()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forceInline", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "customized", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "[Ljava/lang/invoke/LambdaForm$Name;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Ljava/lang/invoke/LambdaForm$Kind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vmentry", "Ljava/lang/invoke/MemberName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCompiled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformCache", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID_RESULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAST_RESULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LF_FAILED", "Ljdk/internal/perf/PerfCounter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPILE_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationCounter", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNED_ARGUMENT_LIMIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNED_ARGUMENTS", "[[Ljava/lang/invoke/LambdaForm$Name;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPL_NAMES", "Ljava/lang/invoke/MemberName$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LF_identity", "[Ljava/lang/invoke/LambdaForm;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LF_zero", "[Ljava/lang/invoke/LambdaForm;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_identity", "[Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_zero", "[Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "createFormsLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_NAME_COUNTERS", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_NAMES", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRACE_INTERPRETER", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Kind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;ZLjava/lang/invoke/LambdaForm$Kind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;IZLjava/lang/invoke/MethodHandle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;ILjava/lang/invoke/LambdaForm$Kind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;IZLjava/lang/invoke/MethodHandle;Ljava/lang/invoke/LambdaForm$Kind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I[Ljava/lang/invoke/LambdaForm$Name;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType", "()Ljava/lang/invoke/LambdaForm$BasicType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/invoke/LambdaForm;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/lang/invoke/LambdaForm$Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity", "(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType", "(I)Ljava/lang/invoke/LambdaForm$BasicType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameter", "(I)Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodType", "()Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arguments", "(ILjava/lang/invoke/MethodType;)[Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileToBytecode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "debugNames", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "associateWithDebugName", "(Ljava/lang/invoke/LambdaForm;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uncustomize", "()Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editor", "()Ljava/lang/invoke/LambdaFormEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "customize", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namesOK", "(I[Ljava/lang/invoke/LambdaForm$Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arity", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixResult", "(I[Ljava/lang/invoke/LambdaForm$Name;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buildEmptyNames", "(ILjava/lang/invoke/MethodType;Z)[Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nameRefsAreLegal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "basicTypeSignature", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicTypeSignature", "(Ljava/lang/invoke/MethodType;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidSignature", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "constantZero", "(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateDebugName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "internArgument", "(Ljava/lang/invoke/LambdaForm$Name;)Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastUseIndex", "(Ljava/lang/invoke/LambdaForm$Name;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMatchingIdiom", "(ILjava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forceInterpretation", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "traceInterpreter", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "traceInterpreter", "(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "failedCompilationCounter", "()Ljdk/internal/perf/PerfCounter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "signatureArity", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueMatches", "(Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Class;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkInt", "(Ljava/lang/Class;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkRef", "(Ljava/lang/Class;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interpretWithArgumentsTracing", "([Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkInvocationCounter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arityCheck", "([Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interpretName", "(Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resultCheck", "([Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "argumentTypesMatch", "(Ljava/lang/String;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lambdaName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useCount", "(Ljava/lang/invoke/LambdaForm$Name;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "argument", "(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFormsFor", "(Ljava/lang/invoke/LambdaForm$BasicType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buildNames", "([Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Name;)[Ljava/lang/invoke/LambdaForm$Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterConstraint", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expressionCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelectAlternative", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGuardWithCatch", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTryFinally", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTableSwitch", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoop", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interpretWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "shortenSignature", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identityForm", "(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zeroForm", "(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_I", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_J", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_F", "(F)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_D", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_L", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_V", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_I", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_J", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_F", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_D", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_L", "()Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("I", "final")]
	public int arity_Property
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

	[JniSignatureAttribute("I", "final")]
	public int result_Property
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

	[JniSignatureAttribute("Z", "final")]
	public bool forceInline_Property
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

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "final")]
	public Dova.JDK.java.lang.invoke.MethodHandle customized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$Name;", "final")]
	public JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "final")]
	public Dova.JDK.java.lang.invoke.LambdaForm.Kind kind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MemberName;", "")]
	public Dova.JDK.java.lang.invoke.MemberName vmentry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isCompiled_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "volatile")]
	public Dova.JDK.java.lang.Object transformCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int VOID_RESULT_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int LAST_RESULT_Property
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

	[JniSignatureAttribute("Ljdk/internal/perf/PerfCounter;", "private static")]
	public static Dova.JDK.jdk.@internal.perf.PerfCounter LF_FAILED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.perf.PerfCounter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int COMPILE_THRESHOLD_Property
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

	[JniSignatureAttribute("I", "private")]
	public int invocationCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int INTERNED_ARGUMENT_LIMIT_Property
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

	[JniSignatureAttribute("[[Ljava/lang/invoke/LambdaForm$Name;", "private static final")]
	public static JavaArray<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>> INTERNED_ARGUMENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MemberName$Factory;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MemberName.Factory IMPL_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm> LF_identity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm> LF_zero_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$NamedFunction;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction> NF_identity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$NamedFunction;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction> NF_zero_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object createFormsLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap DEBUG_NAME_COUNTERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap DEBUG_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool TRACE_INTERPRETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LambdaForm(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Kind;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, Dova.JDK.java.lang.invoke.LambdaForm.Kind arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;ZLjava/lang/invoke/LambdaForm$Kind;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, bool arg2, Dova.JDK.java.lang.invoke.LambdaForm.Kind arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)V", "private")]
	public LambdaForm(Dova.JDK.java.lang.invoke.MethodType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;I)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;IZLjava/lang/invoke/MethodHandle;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, int arg2, bool arg3, Dova.JDK.java.lang.invoke.MethodHandle arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;ILjava/lang/invoke/LambdaForm$Kind;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, int arg2, Dova.JDK.java.lang.invoke.LambdaForm.Kind arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;IZLjava/lang/invoke/MethodHandle;Ljava/lang/invoke/LambdaForm$Kind;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, int arg2, bool arg3, Dova.JDK.java.lang.invoke.MethodHandle arg4, Dova.JDK.java.lang.invoke.LambdaForm.Kind arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;)V", "")]
	public LambdaForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/invoke/LambdaForm$BasicType;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm.BasicType returnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.invoke.LambdaForm arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)Z", "")]
	public bool contains(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$NamedFunction;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction identity(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm$BasicType;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm.BasicType parameterType(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm$Name;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm.Name parameter(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MethodType;", "")]
	public Dova.JDK.java.lang.invoke.MethodType methodType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;)[Ljava/lang/invoke/LambdaForm$Name;", "static")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arguments(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void compileToBytecode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool debugNames()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;Ljava/lang/String;)V", "static")]
	public static void associateWithDebugName(Dova.JDK.java.lang.invoke.LambdaForm arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm uncustomize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void prepare()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/LambdaFormEditor;", "")]
	public Dova.JDK.java.lang.invoke.LambdaFormEditor editor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm customize(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;)Z", "private static")]
	public static bool namesOK(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int arity()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$Name;)I", "private static")]
	public static int fixResult(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int normalize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;Z)[Ljava/lang/invoke/LambdaForm$Name;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> buildEmptyNames(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool nameRefsAreLegal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String basicTypeSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String basicTypeSignature(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool isValidSignature(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$NamedFunction;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction constantZero(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String generateDebugName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)Ljava/lang/invoke/LambdaForm$Name;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.Name internArgument(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)I", "")]
	public int lastUseIndex(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;I)Z", "private")]
	public bool isMatchingIdiom(int arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool forceInterpretation()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "static")]
	public static void traceInterpreter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)V", "static transient")]
	public static void traceInterpreter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljdk/internal/perf/PerfCounter;", "private static")]
	public static Dova.JDK.jdk.@internal.perf.PerfCounter failedCompilationCounter()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.perf.PerfCounter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "static")]
	public static int signatureArity(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Class;Ljava/lang/Object;)Z", "private static")]
	public static bool valueMatches(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Z", "private static")]
	public static bool checkInt(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Z", "private static")]
	public static bool checkRef(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "transient")]
	public Dova.JDK.java.lang.Object interpretWithArgumentsTracing(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkInvocationCounter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Z", "private")]
	public bool arityCheck(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object interpretName(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Object;)Z", "private")]
	public bool resultCheck(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Z", "private static")]
	public static bool argumentTypesMatch(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String lambdaName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)I", "")]
	public int useCount(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm$Name;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.Name argument(int arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)V", "private static")]
	public static void createFormsFor(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Name;)[Ljava/lang/invoke/LambdaForm$Name;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> buildNames(JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, Dova.JDK.java.lang.invoke.LambdaForm.Name arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name>>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object parameterConstraint(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int expressionCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isSelectAlternative(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isGuardWithCatch(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isTryFinally(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isTableSwitch(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isLoop(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "transient")]
	public Dova.JDK.java.lang.Object interpretWithArguments(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String shortenSignature(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm identityForm(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm zeroForm(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(I)I", "private static")]
	public static int identity_I(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long identity_J(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return ret;
	}

	[JniSignatureAttribute("(F)F", "private static")]
	public static float identity_F(float arg0)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "private static")]
	public static double identity_D(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[66], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object identity_L(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void identity_V()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[68]);
	}

	[JniSignatureAttribute("()I", "private static")]
	public static int zero_I()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("()J", "private static")]
	public static long zero_J()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[70]);
		return ret;
	}

	[JniSignatureAttribute("()F", "private static")]
	public static float zero_F()
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[71]);
		return ret;
	}

	[JniSignatureAttribute("()D", "private static")]
	public static double zero_D()
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[72]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object zero_L()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "static final")]
	public partial class Kind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Kind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERIC", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTITY", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOUND_REINVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REINVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELEGATE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXACT_LINKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXACT_INVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERIC_LINKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERIC_INVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINK_TO_TARGET_METHOD", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINK_TO_CALL_SITE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_VIRTUAL", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_SPECIAL", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_SPECIAL_IFC", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_STATIC", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_NEW_INVOKE_SPECIAL", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_INTERFACE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_INVOKE_STATIC_INIT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_REFERENCE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_REFERENCE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_REFERENCE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_REFERENCE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_INT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_INT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_INT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_INT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_BOOLEAN", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_BOOLEAN", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_BOOLEAN_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_BOOLEAN_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_BYTE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_BYTE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_BYTE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_BYTE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_CHAR", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_CHAR", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_CHAR_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_CHAR_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_SHORT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_SHORT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_SHORT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_SHORT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_LONG", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_LONG", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_LONG_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_LONG_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_FLOAT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_FLOAT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_FLOAT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_FLOAT_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_DOUBLE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_DOUBLE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_DOUBLE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_DOUBLE_VOLATILE", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRY_FINALLY", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_SWITCH", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLLECT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLLECTOR", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONVERT", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPREAD", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOP", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GUARD", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GUARD_WITH_CATCH", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARHANDLE_EXACT_INVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARHANDLE_INVOKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARHANDLE_LINKER", "Ljava/lang/invoke/LambdaForm$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultLambdaName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodName", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/invoke/LambdaForm$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/invoke/LambdaForm$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/invoke/LambdaForm$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/invoke/LambdaForm$Kind;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GENERIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind ZERO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind IDENTITY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind BOUND_REINVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind REINVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DELEGATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind EXACT_LINKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind EXACT_INVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GENERIC_LINKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GENERIC_INVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind LINK_TO_TARGET_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind LINK_TO_CALL_SITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_VIRTUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_SPECIAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_SPECIAL_IFC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_NEW_INVOKE_SPECIAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind DIRECT_INVOKE_STATIC_INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_REFERENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_REFERENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_REFERENCE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_REFERENCE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_INT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_INT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_INT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_INT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_BOOLEAN_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_BOOLEAN_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_BYTE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_BYTE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_CHAR_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_CHAR_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_SHORT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_SHORT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_LONG_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_LONG_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_FLOAT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_FLOAT_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GET_DOUBLE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind PUT_DOUBLE_VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind TRY_FINALLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind TABLE_SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind COLLECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind COLLECTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind CONVERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind SPREAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GUARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind GUARD_WITH_CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind VARHANDLE_EXACT_INVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind VARHANDLE_INVOKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Kind;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind VARHANDLE_LINKER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String defaultLambdaName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String methodName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/invoke/LambdaForm$Kind;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/LambdaForm$Kind;", "public static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Kind>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/invoke/LambdaForm$Kind;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Kind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Name;", "static final")]
	public partial class Name
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Name()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$Name;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "function", "Ljava/lang/invoke/LambdaForm$NamedFunction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constraint", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/invoke/LambdaForm$BasicType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/LambdaForm$BasicType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/invoke/LambdaForm$BasicType;Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodType;[Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MemberName;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "index", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "()Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/invoke/LambdaForm$Name;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refersTo", "(Ljava/lang/Class;Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newIndex", "(I)Ljava/lang/invoke/LambdaForm$Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParam", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initIndex", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneWithIndex", "(I)Ljava/lang/invoke/LambdaForm$Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceNames", "([Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/invoke/LambdaForm$Name;II)Ljava/lang/invoke/LambdaForm$Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internArguments", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInvokeBasic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastUseIndex", "(Ljava/lang/invoke/LambdaForm$Name;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConstantZero", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exprString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useCount", "(Ljava/lang/invoke/LambdaForm$Name;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withConstraint", "(Ljava/lang/Object;)Ljava/lang/invoke/LambdaForm$Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLinkerMethodInvoke", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typesMatch", "(Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typesMatch", "(Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeChar", "()C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceName", "(Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Name;)Ljava/lang/invoke/LambdaForm$Name;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "final")]
		public Dova.JDK.java.lang.invoke.LambdaForm.BasicType type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("S", "")]
		public short index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$NamedFunction;", "final")]
		public Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction function_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object constraint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "final")]
		public JavaArray<Dova.JDK.java.lang.Object> arguments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Name(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)V", "transient")]
		public Name(Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/invoke/LambdaForm$BasicType;)V", "")]
		public Name(int arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)V", "")]
		public Name(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/invoke/LambdaForm$BasicType;Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)V", "private")]
		public Name(int arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1, Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction arg2, JavaArray<Dova.JDK.java.lang.Object> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/Object;)V", "private")]
		public Name(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)V", "transient")]
		public Name(Dova.JDK.java.lang.invoke.MethodHandle arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;[Ljava/lang/Object;)V", "transient")]
		public Name(Dova.JDK.java.lang.invoke.MethodType arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;[Ljava/lang/Object;)V", "transient")]
		public Name(Dova.JDK.java.lang.invoke.MemberName arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm$Name;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int index()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/LambdaForm$BasicType;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.BasicType type()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Z", "")]
		public bool refersTo(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String debugString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm$Name;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.Name newIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isParam()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "")]
		public bool initIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm$Name;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.Name cloneWithIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/invoke/LambdaForm$Name;[Ljava/lang/invoke/LambdaForm$Name;II)Ljava/lang/invoke/LambdaForm$Name;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.Name replaceNames(JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void internArguments()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isInvokeBasic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)I", "")]
		public int lastUseIndex(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isConstantZero()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String paramString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String exprString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;)I", "")]
		public int useCount(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/invoke/LambdaForm$Name;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.Name withConstraint(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isLinkerMethodInvoke()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Object;)Z", "private static")]
		public static bool typesMatch(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$NamedFunction;[Ljava/lang/Object;)Z", "private transient")]
		public bool typesMatch(Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()C", "")]
		public char typeChar()
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[24]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$Name;Ljava/lang/invoke/LambdaForm$Name;)Ljava/lang/invoke/LambdaForm$Name;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.Name replaceName(Dova.JDK.java.lang.invoke.LambdaForm.Name arg0, Dova.JDK.java.lang.invoke.LambdaForm.Name arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.Name>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "static final")]
	public partial class BasicType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$BasicType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "J_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "V_TYPE", "Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_TYPES", "[Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARG_TYPES", "[Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARG_TYPE_LIMIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_LIMIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "L_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "J_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "V_TYPE_NUM", "B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btChar", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btClass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btWrapper", "Lsun/invoke/util/Wrapper;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/invoke/LambdaForm$BasicType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ICLjava/lang/Class;Lsun/invoke/util/Wrapper;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicType", "(C)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicType", "(B)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicType", "(Ljava/lang/Class;)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicType", "(Lsun/invoke/util/Wrapper;)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicTypeChar", "(Ljava/lang/Class;)C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "basicTypeChar", "()C"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isArgBasicTypeChar", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isBasicTypeChar", "(C)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "basicTypeClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "basicTypeSlots", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "basicTypeWrapper", "()Lsun/invoke/util/Wrapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkBasicType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicTypeOrds", "([Ljava/lang/invoke/LambdaForm$BasicType;)[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicTypesOrd", "([Ljava/lang/Class;)[B"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType L_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType I_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType J_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType F_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType D_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$BasicType;", "public static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType V_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$BasicType;", "static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> ALL_TYPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$BasicType;", "static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> ARG_TYPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int ARG_TYPE_LIMIT_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int TYPE_LIMIT_Property
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

		[JniSignatureAttribute("B", "static final")]
		public static byte L_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte I_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte J_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte F_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte D_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("B", "static final")]
		public static byte V_TYPE_NUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("C", "final")]
		public char btChar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "final")]
		public Dova.JDK.java.lang.Class btClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/invoke/util/Wrapper;", "final")]
		public Dova.JDK.sun.invoke.util.Wrapper btWrapper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.invoke.util.Wrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$BasicType;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ICLjava/lang/Class;Lsun/invoke/util/Wrapper;)V", "private")]
		public BasicType(Dova.JDK.java.lang.String arg0, int arg1, char arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.sun.invoke.util.Wrapper arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm$BasicType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/invoke/LambdaForm$BasicType;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>>(ret);
		}

		[JniSignatureAttribute("(C)Ljava/lang/invoke/LambdaForm$BasicType;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType basicType(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(B)Ljava/lang/invoke/LambdaForm$BasicType;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType basicType(byte arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/LambdaForm$BasicType;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType basicType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Lsun/invoke/util/Wrapper;)Ljava/lang/invoke/LambdaForm$BasicType;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType basicType(Dova.JDK.sun.invoke.util.Wrapper arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/LambdaForm$BasicType;", "public static")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.BasicType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)C", "static")]
		public static char basicTypeChar(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()C", "")]
		public char basicTypeChar()
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isArgBasicTypeChar(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(C)Z", "static")]
		public static bool isBasicTypeChar(char arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Ljava/lang/invoke/LambdaForm$BasicType;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class basicTypeClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int basicTypeSlots()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/invoke/util/Wrapper;", "")]
		public Dova.JDK.sun.invoke.util.Wrapper basicTypeWrapper()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.invoke.util.Wrapper>(ret);
		}

		[JniSignatureAttribute("()Z", "private static")]
		public static bool checkBasicType()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/invoke/LambdaForm$BasicType;)[I", "static")]
		public static JavaArray<int> basicTypeOrds(JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)[B", "static")]
		public static JavaArray<byte> basicTypesOrd(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$NamedFunction;", "static")]
	public partial class NamedFunction
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedFunction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$NamedFunction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "member", "Ljava/lang/invoke/MemberName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolvedHandle", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invoker", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKER_METHOD_TYPE", "Ljava/lang/invoke/MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MemberName;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType", "()Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterType", "(I)Ljava/lang/invoke/LambdaForm$BasicType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "member", "()Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodType", "()Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intrinsicName", "()Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intrinsicData", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arity", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isInvokeBasic", "(Ljava/lang/invoke/MemberName;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConstantZero", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIdentity", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoker", "()Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "memberDeclaringClassOrNull", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolvedHandle", "()Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeWithArgumentsTracing", "([Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeInvoker", "(Ljava/lang/invoke/MethodTypeForm;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMemberIsConsistent", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MemberName;", "final")]
		public Dova.JDK.java.lang.invoke.MemberName member_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle resolvedHandle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle invoker_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodType INVOKER_METHOD_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedFunction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)V", "")]
		public NamedFunction(Dova.JDK.java.lang.invoke.MethodHandle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "")]
		public NamedFunction(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)V", "")]
		public NamedFunction(Dova.JDK.java.lang.invoke.MemberName arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)V", "")]
		public NamedFunction(Dova.JDK.java.lang.invoke.MethodType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandle;)V", "")]
		public NamedFunction(Dova.JDK.java.lang.invoke.MemberName arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm$NamedFunction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/invoke/LambdaForm$BasicType;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.BasicType returnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()V", "synchronized")]
		public void resolve()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm$BasicType;", "")]
		public Dova.JDK.java.lang.invoke.LambdaForm.BasicType parameterType(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.BasicType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName member()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodType;", "")]
		public Dova.JDK.java.lang.invoke.MethodType methodType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "transient")]
		public Dova.JDK.java.lang.Object invokeWithArguments(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic intrinsicName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object intrinsicData()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int arity()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Z", "private static")]
		public static bool isInvokeBasic(Dova.JDK.java.lang.invoke.MemberName arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isConstantZero()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isIdentity()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle invoker()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class memberDeclaringClassOrNull()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle resolvedHandle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object invokeWithArgumentsTracing(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodTypeForm;)Ljava/lang/invoke/MethodHandle;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle computeInvoker(Dova.JDK.java.lang.invoke.MethodTypeForm arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool assertMemberIsConsistent()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Holder;", "final")]
	public partial class Holder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Holder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$Holder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_I", "(Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_J", "(Ljava/lang/Object;J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_F", "(Ljava/lang/Object;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_D", "(Ljava/lang/Object;D)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_L", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity_V", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_I", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_J", "(Ljava/lang/Object;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_F", "(Ljava/lang/Object;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_D", "(Ljava/lang/Object;)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero_L", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Holder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaForm$Holder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;I)I", "static")]
		public static int identity_I(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;J)J", "static")]
		public static long identity_J(Dova.JDK.java.lang.Object arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;F)F", "static")]
		public static float identity_F(Dova.JDK.java.lang.Object arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;D)D", "static")]
		public static double identity_D(Dova.JDK.java.lang.Object arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object identity_L(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "static")]
		public static void identity_V(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "static")]
		public static int zero_I(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)J", "static")]
		public static long zero_J(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)F", "static")]
		public static float zero_F(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)D", "static")]
		public static double zero_D(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object zero_L(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$Compiled;", "abstract static interface")]
	public partial interface Compiled
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Compiled()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaForm$Compiled;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
