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

[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl;", "abstract")]
public partial class MethodHandleImpl
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodHandleImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAKE_METHOD_HANDLE_INVOKE", "[Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAYS", "[Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_JVM_ARITY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_checkSpreadArgument", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_guardWithCatch", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_throwException", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_tryFinally", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_loop", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_profileBoolean", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_tableSwitch", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_LIMIT", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NFS", "[Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_cast", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_selectAlternative", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_countedLoopPred", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_countedLoopStep", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_initIterator", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_iteratePred", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_iterateNext", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_Array_newInstance", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_VarHandles_handleCheckedExceptions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_LIMIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HANDLES", "[Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "profile", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "profileBoolean", "(Z[I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCompileConstant", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwException", "(Ljava/lang/Throwable;)Lsun/invoke/empty/Empty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwException", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toArray", "(Ljava/util/List;)[Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(B)Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFunction", "(B)Ljava/lang/invoke/LambdaForm$NamedFunction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makePairwiseConvert", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makePairwiseConvert", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Z)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "varargsArray", "(I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "varargsArray", "(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeVarargsCollector", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeWrappedMember", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectAlternative", "(ZLjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guardWithCatch", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tryFinally", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tableSwitch", "(ILjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$CasesHolder;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loop", "([Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/invoke/MethodHandleImpl$LoopClauses;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeIntrinsic", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeIntrinsic", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeIntrinsic", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prepend", "([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstantHandle", "(I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeArrayElementAccessor", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeGuardWithTest", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeGuardWithCatch", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLoop", "(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeTryFinally", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeTableSwitch", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fakeMethodHandleInvoke", "(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fakeVarHandleInvoke", "(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bindCaller", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makePairwiseConvertByEditor", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeValueConversions", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;ZZ)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countNonNull", "([Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueConversion", "(Ljava/lang/Class;Ljava/lang/Class;ZZ)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeGuardWithTestForm", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeBlockInliningWrapper", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeGuardWithCatchForm", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboxResultHandle", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeCollector", "(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "assertCorrectArity", "(Ljava/lang/invoke/MethodHandle;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkSpreadArgument", "(Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeLoopForm", "(Ljava/lang/invoke/MethodType;[Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeTryFinallyForm", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeCollectorForm", "(Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeTableSwitchForm", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/BoundMethodHandle$SpeciesData;I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeConstantHandle", "(I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCachedHandle", "(ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countedLoopPredicate", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countedLoopStep", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIterator", "(Ljava/lang/Iterable;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iteratePredicate", "(Ljava/util/Iterator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iterateNext", "(Ljava/util/Iterator;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unmatchedArrayAccess", "(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/InternalError;"));
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "static")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> FAKE_METHOD_HANDLE_INVOKE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> ARRAYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_JVM_ARITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_checkSpreadArgument_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_guardWithCatch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_throwException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_tryFinally_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_loop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_profileBoolean_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_tableSwitch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte NF_LIMIT_Property
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

	[JniSignatureAttribute("[Ljava/lang/invoke/LambdaForm$NamedFunction;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction> NFS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MH_cast_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_selectAlternative_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_countedLoopPred_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_countedLoopStep_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_initIterator_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_iteratePred_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int MH_iterateNext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MH_Array_newInstance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MH_VarHandles_handleCheckedExceptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MH_LIMIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> HANDLES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodHandleImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public MethodHandleImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle profile(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Z[I)Z", "static")]
	public static bool profileBoolean(bool arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "static")]
	public static bool isCompileConstant(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Lsun/invoke/empty/Empty;", "static")]
	public static Dova.JDK.sun.invoke.empty.Empty throwException(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.invoke.empty.Empty>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle throwException(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)[Ljava/lang/invoke/MethodHandle;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> toArray(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
	}

	[JniSignatureAttribute("(B)Ljava/lang/invoke/LambdaForm$NamedFunction;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction getFunction(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
	}

	[JniSignatureAttribute("(B)Ljava/lang/invoke/LambdaForm$NamedFunction;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction createFunction(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makePairwiseConvert(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Z)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makePairwiseConvert(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle varargsArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle varargsArray(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeVarargsCollector(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeWrappedMember(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MemberName arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(ZLjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle selectAlternative(bool arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;", "static transient")]
	public static Dova.JDK.java.lang.Object guardWithCatch(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;[Ljava/lang/Object;)Ljava/lang/Object;", "static transient")]
	public static Dova.JDK.java.lang.Object tryFinally(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$CasesHolder;[Ljava/lang/Object;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object tableSwitch(int arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandleImpl.CasesHolder arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/invoke/MethodHandleImpl$LoopClauses;[Ljava/lang/Object;)Ljava/lang/Object;", "static transient")]
	public static Dova.JDK.java.lang.Object loop(JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.LoopClauses arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeIntrinsic(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeIntrinsic(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeIntrinsic(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)[Ljava/lang/Object;", "private static transient")]
	public static JavaArray<Dova.JDK.java.lang.Object> prepend(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle getConstantHandle(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeArrayElementAccessor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeGuardWithTest(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeGuardWithCatch(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeLoop(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeTryFinally(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeTableSwitch(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle fakeMethodHandleInvoke(Dova.JDK.java.lang.invoke.MemberName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle fakeVarHandleInvoke(Dova.JDK.java.lang.invoke.MemberName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle bindCaller(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "static")]
	public static void assertSame(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makePairwiseConvertByEditor(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;ZZ)[Ljava/lang/Object;", "static")]
	public static JavaArray<Dova.JDK.java.lang.Object> computeValueConversions(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)I", "private static")]
	public static int countNonNull(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;ZZ)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object valueConversion(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeGuardWithTestForm(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeBlockInliningWrapper(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeGuardWithCatchForm(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle unboxResultHandle(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeCollector(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I)Z", "private static")]
	public static bool assertCorrectArity(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)V", "static")]
	public static void checkSpreadArgument(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;[Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeLoopForm(Dova.JDK.java.lang.invoke.MethodType arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeTryFinallyForm(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/LambdaForm;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeCollectorForm(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/BoundMethodHandle$SpeciesData;I)Ljava/lang/invoke/LambdaForm;", "private static")]
	public static Dova.JDK.java.lang.invoke.LambdaForm makeTableSwitchForm(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeConstantHandle(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "private static synchronized")]
	public static Dova.JDK.java.lang.invoke.MethodHandle setCachedHandle(int arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(II)Z", "static")]
	public static bool countedLoopPredicate(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "static")]
	public static int countedLoopStep(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/Iterator;", "static")]
	public static Dova.JDK.java.util.Iterator initIterator(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Iterator;)Z", "static")]
	public static bool iteratePredicate(Dova.JDK.java.util.Iterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Iterator;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object iterateNext(Dova.JDK.java.util.Iterator arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/InternalError;", "static")]
	public static Dova.JDK.java.lang.InternalError unmatchedArrayAccess(Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.InternalError>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "static final")]
	public partial class ArrayAccess
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayAccess()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET", "Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SET", "Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LENGTH", "Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "objectAccessor", "(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cacheIndex", "(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intrinsic", "(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "opName", "(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess GET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess SET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayAccess(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ArrayAccess(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "public static")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle objectAccessor(Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)I", "static")]
		public static int cacheIndex(Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic intrinsic(Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/String;", "static")]
		public static Dova.JDK.java.lang.String opName(Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$ArrayAccessor;", "static final")]
	public partial class ArrayAccessor
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$ArrayAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETTER_INDEX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SETTER_INDEX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LENGTH_INDEX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEX_LIMIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPED_ACCESSORS", "Ljava/lang/ClassValue;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_ARRAY_GETTER", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_ARRAY_SETTER", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_ARRAY_LENGTH", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "name", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "type", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAccessor", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "correctType", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementI", "([II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementJ", "([JI)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementF", "([FI)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementD", "([DI)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementZ", "([ZI)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementB", "([BI)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementS", "([SI)S"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementC", "([CI)C"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getElementL", "([Ljava/lang/Object;I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementI", "([III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementJ", "([JIJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementF", "([FIF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementD", "([DID)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementZ", "([ZIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementB", "([BIB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementS", "([SIS)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementC", "([CIC)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setElementL", "([Ljava/lang/Object;ILjava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthI", "([I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthJ", "([J)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthF", "([F)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthD", "([D)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthZ", "([Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthB", "([B)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthS", "([S)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthC", "([C)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lengthL", "([Ljava/lang/Object;)I"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int GETTER_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SETTER_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int LENGTH_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int INDEX_LIMIT_Property
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

		[JniSignatureAttribute("Ljava/lang/ClassValue;", "static final")]
		public static Dova.JDK.java.lang.ClassValue TYPED_ACCESSORS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_ARRAY_GETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_ARRAY_SETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_ARRAY_LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ArrayAccessor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$ArrayAccessor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/String;", "static")]
		public static Dova.JDK.java.lang.String name(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodType;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodType type(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodHandle;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle getAccessor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandleImpl$ArrayAccess;)Ljava/lang/invoke/MethodType;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodType correctType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.ArrayAccess arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}

		[JniSignatureAttribute("([II)I", "static")]
		public static int getElementI(JavaArray<int> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([JI)J", "static")]
		public static long getElementJ(JavaArray<long> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([FI)F", "static")]
		public static float getElementF(JavaArray<float> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([DI)D", "static")]
		public static double getElementD(JavaArray<double> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([ZI)Z", "static")]
		public static bool getElementZ(JavaArray<bool> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([BI)B", "static")]
		public static byte getElementB(JavaArray<byte> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([SI)S", "static")]
		public static short getElementS(JavaArray<short> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([CI)C", "static")]
		public static char getElementC(JavaArray<char> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/Object;I)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object getElementL(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("([III)V", "static")]
		public static void setElementI(JavaArray<int> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([JIJ)V", "static")]
		public static void setElementJ(JavaArray<long> arg0, int arg1, long arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([FIF)V", "static")]
		public static void setElementF(JavaArray<float> arg0, int arg1, float arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([DID)V", "static")]
		public static void setElementD(JavaArray<double> arg0, int arg1, double arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([ZIZ)V", "static")]
		public static void setElementZ(JavaArray<bool> arg0, int arg1, bool arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([BIB)V", "static")]
		public static void setElementB(JavaArray<byte> arg0, int arg1, byte arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([SIS)V", "static")]
		public static void setElementS(JavaArray<short> arg0, int arg1, short arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([CIC)V", "static")]
		public static void setElementC(JavaArray<char> arg0, int arg1, char arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;ILjava/lang/Object;)V", "static")]
		public static void setElementL(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, Dova.JDK.java.lang.Object arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([I)I", "static")]
		public static int lengthI(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0);
			return ret;
		}

		[JniSignatureAttribute("([J)I", "static")]
		public static int lengthJ(JavaArray<long> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[23], arg0);
			return ret;
		}

		[JniSignatureAttribute("([F)I", "static")]
		public static int lengthF(JavaArray<float> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[24], arg0);
			return ret;
		}

		[JniSignatureAttribute("([D)I", "static")]
		public static int lengthD(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0);
			return ret;
		}

		[JniSignatureAttribute("([Z)I", "static")]
		public static int lengthZ(JavaArray<bool> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0);
			return ret;
		}

		[JniSignatureAttribute("([B)I", "static")]
		public static int lengthB(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27], arg0);
			return ret;
		}

		[JniSignatureAttribute("([S)I", "static")]
		public static int lengthS(JavaArray<short> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[28], arg0);
			return ret;
		}

		[JniSignatureAttribute("([C)I", "static")]
		public static int lengthC(JavaArray<char> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29], arg0);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)I", "static")]
		public static int lengthL(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "static final")]
	public partial class Intrinsic
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Intrinsic()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SELECT_ALTERNATIVE", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GUARD_WITH_CATCH", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRY_FINALLY", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_SWITCH", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOP", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_LOAD", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_STORE", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_LENGTH", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTITY", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic SELECT_ALTERNATIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic GUARD_WITH_CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic TRY_FINALLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic TABLE_SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic ARRAY_LOAD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic ARRAY_STORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic ARRAY_LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic IDENTITY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic ZERO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Intrinsic(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Intrinsic(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "public static")]
		public static Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$AsVarargsCollector;", "private static final")]
	public partial class AsVarargsCollector
		: Dova.JDK.java.lang.invoke.DelegatingMethodHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AsVarargsCollector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$AsVarargsCollector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arrayType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asCollectorCache", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewAsTypeChecks", "(Ljava/lang/invoke/MethodType;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeWithArguments", "([Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeUncached", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarargsCollector", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withVarargs", "(Z)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asFixedArity", "()Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVarargs", "(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodHandle target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class arrayType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle asCollectorCache_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AsVarargsCollector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)V", "")]
		public AsVarargsCollector(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)V", "")]
		public AsVarargsCollector(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.Class arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$AsVarargsCollector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Z)Z", "")]
		public bool viewAsTypeChecks(Dova.JDK.java.lang.invoke.MethodType arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public transient")]
		public Dova.JDK.java.lang.Object invokeWithArguments(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asTypeUncached(Dova.JDK.java.lang.invoke.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isVarargsCollector()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Z)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle withVarargs(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asFixedArity()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle setVarargs(Dova.JDK.java.lang.invoke.MemberName arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "protected")]
		public Dova.JDK.java.lang.invoke.MethodHandle getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Makers;", "private static final")]
	public partial class Makers
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Makers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$Makers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRODUCE_BLOCK_INLINING_FORM", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRODUCE_REINVOKER_FORM", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPED_COLLECTORS", "Ljava/lang/ClassValue;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "static final")]
		public static Dova.JDK.java.util.function.Function PRODUCE_BLOCK_INLINING_FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "static final")]
		public static Dova.JDK.java.util.function.Function PRODUCE_REINVOKER_FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassValue;", "static final")]
		public static Dova.JDK.java.lang.ClassValue TYPED_COLLECTORS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Makers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Makers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$Makers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$CountingWrapper;", "static")]
	public partial class CountingWrapper
		: Dova.JDK.java.lang.invoke.DelegatingMethodHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CountingWrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$CountingWrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "countingFormProducer", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonCountingFormProducer", "Ljava/util/function/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isCounting", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NF_maybeStopCounting", "Ljava/lang/invoke/LambdaForm$NamedFunction;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/LambdaForm;Ljava/util/function/Function;Ljava/util/function/Function;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeUncached", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "maybeStopCounting", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "countDown", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodHandle target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int count_Property
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

		[JniSignatureAttribute("Ljava/util/function/Function;", "private")]
		public Dova.JDK.java.util.function.Function countingFormProducer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Function;", "private")]
		public Dova.JDK.java.util.function.Function nonCountingFormProducer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool isCounting_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm$NamedFunction;", "static final")]
		public static Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction NF_maybeStopCounting_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm.NamedFunction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CountingWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/LambdaForm;Ljava/util/function/Function;Ljava/util/function/Function;I)V", "private")]
		public CountingWrapper(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.util.function.Function arg2, Dova.JDK.java.util.function.Function arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$CountingWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asTypeUncached(Dova.JDK.java.lang.invoke.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "protected")]
		public Dova.JDK.java.lang.invoke.MethodHandle getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "static")]
		public static void maybeStopCounting(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool countDown()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$BindCaller;", "private static")]
	public partial class BindCaller
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BindCaller()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$BindCaller;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKER_MT", "Ljava/lang/invoke/MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFLECT_INVOKER_MT", "Ljava/lang/invoke/MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CV_makeInjectedInvoker", "Ljava/lang/ClassValue;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MH_checkCallerClass", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INJECTED_INVOKER_TEMPLATE", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bindCaller", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reflectiveInvoker", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bindCallerWithInjectedInvoker", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prepareForInvoker", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "restoreToType", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkInjectedInvoker", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkCallerClass", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateInvokerTemplate", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeInjectedInvoker", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodType INVOKER_MT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodType REFLECT_INVOKER_MT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassValue;", "private static")]
		public static Dova.JDK.java.lang.ClassValue CV_makeInjectedInvoker_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassValue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandle MH_checkCallerClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "private static final")]
		public static JavaArray<byte> INJECTED_INVOKER_TEMPLATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
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
		public BindCaller(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public BindCaller() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$BindCaller;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle bindCaller(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle reflectiveInvoker(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle bindCallerWithInjectedInvoker(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle prepareForInvoker(Dova.JDK.java.lang.invoke.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodHandle restoreToType(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "private static")]
		public static bool checkInjectedInvoker(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static")]
		public static bool checkCallerClass(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[B", "private static")]
		public static JavaArray<byte> generateInvokerTemplate()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
		public static Dova.JDK.java.lang.Class makeInjectedInvoker(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$BindCaller$InjectedInvokerHolder;", "private static final")]
		public partial class InjectedInvokerHolder
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InjectedInvokerHolder()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$BindCaller$InjectedInvokerHolder;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invokerClass", "Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invoker", "Ljava/lang/invoke/MethodHandle;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reflectInvoker", "Ljava/lang/invoke/MethodHandle;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoker", "()Ljava/lang/invoke/MethodHandle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reflectInvoker", "()Ljava/lang/invoke/MethodHandle;"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
			public Dova.JDK.java.lang.Class invokerClass_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private")]
			public Dova.JDK.java.lang.invoke.MethodHandle invoker_Property
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

			[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private")]
			public Dova.JDK.java.lang.invoke.MethodHandle reflectInvoker_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InjectedInvokerHolder(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
			public InjectedInvokerHolder(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$BindCaller$InjectedInvokerHolder;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "private")]
			public Dova.JDK.java.lang.invoke.MethodHandle invoker()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "private")]
			public Dova.JDK.java.lang.invoke.MethodHandle reflectInvoker()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$WrappedMember;", "private static final")]
	public partial class WrappedMember
		: Dova.JDK.java.lang.invoke.DelegatingMethodHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedMember()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$WrappedMember;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "member", "Ljava/lang/invoke/MemberName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callerClass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInvokeSpecial", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MemberName;ZLjava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalMemberName", "()Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeUncached", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalCallerClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInvokeSpecial", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodHandle target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MemberName;", "private final")]
		public Dova.JDK.java.lang.invoke.MemberName member_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class callerClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isInvokeSpecial_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedMember(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MemberName;ZLjava/lang/Class;)V", "private")]
		public WrappedMember(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.java.lang.invoke.MemberName arg2, bool arg3, Dova.JDK.java.lang.Class arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$WrappedMember;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName internalMemberName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asTypeUncached(Dova.JDK.java.lang.invoke.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "")]
		public Dova.JDK.java.lang.Class internalCallerClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isInvokeSpecial()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "protected")]
		public Dova.JDK.java.lang.invoke.MethodHandle getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$IntrinsicMethodHandle;", "static final")]
	public partial class IntrinsicMethodHandle
		: Dova.JDK.java.lang.invoke.DelegatingMethodHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntrinsicMethodHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$IntrinsicMethodHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "intrinsicName", "Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "intrinsicData", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalProperties_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalProperties_1", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeUncached", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asCollector", "(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intrinsicName", "()Ljava/lang/invoke/MethodHandleImpl$Intrinsic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intrinsicData", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodHandle target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic intrinsicName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
		public Dova.JDK.java.lang.Object intrinsicData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntrinsicMethodHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;)V", "")]
		public IntrinsicMethodHandle(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandleImpl$Intrinsic;Ljava/lang/Object;)V", "")]
		public IntrinsicMethodHandle(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$IntrinsicMethodHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "volatile")]
		public Dova.JDK.java.lang.Object internalProperties_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String internalProperties_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asTypeUncached(Dova.JDK.java.lang.invoke.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle asCollector(Dova.JDK.java.lang.Class arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandleImpl$Intrinsic;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic intrinsicName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleImpl.Intrinsic>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object intrinsicData()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandle;", "protected")]
		public Dova.JDK.java.lang.invoke.MethodHandle getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$LoopClauses;", "static")]
	public partial class LoopClauses
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LoopClauses()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$LoopClauses;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clauses", "[[Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[Ljava/lang/invoke/MethodHandle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("[[Ljava/lang/invoke/MethodHandle;", "final")]
		public JavaArray<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>> clauses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LoopClauses(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([[Ljava/lang/invoke/MethodHandle;)V", "")]
		public LoopClauses(JavaArray<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$LoopClauses;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$CasesHolder;", "static")]
	public partial class CasesHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CasesHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$CasesHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cases", "[Ljava/lang/invoke/MethodHandle;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/invoke/MethodHandle;)V"));
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "final")]
		public JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> cases_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CasesHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/invoke/MethodHandle;)V", "public")]
		public CasesHolder(JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$CasesHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandleImpl$TableSwitchCacheKey;", "private static")]
	public partial class TableSwitchCacheKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TableSwitchCacheKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandleImpl$TableSwitchCacheKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "basicType", "Ljava/lang/invoke/MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfCases", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodType;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map CACHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private final")]
		public Dova.JDK.java.lang.invoke.MethodType basicType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int numberOfCases_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TableSwitchCacheKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;I)V", "public")]
		public TableSwitchCacheKey(Dova.JDK.java.lang.invoke.MethodType arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandleImpl$TableSwitchCacheKey;";
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
	}
}
