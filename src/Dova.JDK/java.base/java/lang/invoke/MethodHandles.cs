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

[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles;", "public")]
public partial class MethodHandles
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodHandles()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandles;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPL_NAMES", "Ljava/lang/invoke/MemberName$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTITY_MHS", "[Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO_MHS", "[Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "throwException", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles$Lookup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "()Ljava/lang/invoke/MethodHandles$Lookup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classData", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classData", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "empty", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "constant", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identity", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "spreadInvoker", "(Ljava/lang/invoke/MethodType;I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayLength", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "varHandleInvoker", "(Ljava/lang/invoke/VarHandle$AccessMode;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "publicLookup", "()Ljava/lang/invoke/MethodHandles$Lookup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tryFinally", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tableSwitch", "(Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loop", "([[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zero", "(Lsun/invoke/util/Wrapper;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exactInvoker", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "foldArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "foldArguments", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCachedMethodHandle", "([Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoker", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reflectAs", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "basicInvoker", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "explicitCastArgumentsChecks", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "permuteArgumentChecks", "([ILjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findFirstDupOrDrop", "([II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeIdentity", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArguments", "(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeZero", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertArgumentsChecks", "(Ljava/lang/invoke/MethodHandle;II)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertArgumentPrimitive", "(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "copyTypes", "([Ljava/lang/Object;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArguments0", "(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArgumentChecks", "(Ljava/lang/invoke/MethodType;ILjava/util/List;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArgumentsToMatch", "(Ljava/lang/invoke/MethodHandle;ILjava/util/List;IZ)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropArgumentsToMatch", "(Ljava/lang/invoke/MethodHandle;ILjava/util/List;I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterArgumentsCheckArity", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterRepeatedArgument", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterArgument", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterArgumentChecks", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectArgumentsChecks", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterReturnValueChecks", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "foldArgumentChecks", "(ILjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "misMatchedTypes", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/RuntimeException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "argumentsWithCombiner", "(ZLjava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "argumentsWithCombinerChecks", "(IZLjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;[I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loopChecks0", "([[Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loopChecks1a", "(ILjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "buildCommonSuffix", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loopChecks1b", "(Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loopChecks1cd", "(Ljava/util/List;Ljava/util/List;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loopChecks2", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "identityOrVoid", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fillParameterTypes", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixArities", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longestParameterList", "(Ljava/util/stream/Stream;I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "longestParameterList", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "whileLoopChecks", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countedLoop", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countedLoop", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countedLoopChecks", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iteratedLoopChecks", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "swapArguments", "(Ljava/lang/invoke/MethodHandle;II)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "permuteArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tryFinallyChecks", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "tableSwitchChecks", "(Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "privateLookupIn", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandles$Lookup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "classDataAt", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayConstructor", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayElementGetter", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayElementSetter", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arrayElementVarHandle", "(Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "byteArrayViewVarHandle", "(Ljava/lang/Class;Ljava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "byteBufferViewVarHandle", "(Ljava/lang/Class;Ljava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "varHandleExactInvoker", "(Ljava/lang/invoke/VarHandle$AccessMode;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "explicitCastArguments", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dropReturn", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterArguments", "(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectArguments", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterReturnValue", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "collectReturnValue", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "filterArgumentsWithCombiner", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "foldArgumentsWithCombiner", "(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "guardWithTest", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "catchException", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "whileLoop", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doWhileLoop", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "iteratedLoop", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MemberName$Factory;", "static final")]
	public static Dova.JDK.java.lang.invoke.MemberName.Factory IMPL_NAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> IDENTITY_MHS_Property
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

	[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> ZERO_MHS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
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
	public MethodHandles(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public MethodHandles() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandles;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle throwException(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles$Lookup;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup lookup(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandles$Lookup;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup lookup()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object classData(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object classData(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle empty(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle constant(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle identity(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;I)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle spreadInvoker(Dova.JDK.java.lang.invoke.MethodType arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle arrayLength(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessMode;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle varHandleInvoker(Dova.JDK.java.lang.invoke.VarHandle.AccessMode arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MethodHandles$Lookup;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup publicLookup()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle tryFinally(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle tableSwitch(Dova.JDK.java.lang.invoke.MethodHandle arg0, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("([[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle loop(JavaArray<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle zero(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Lsun/invoke/util/Wrapper;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle zero(Dova.JDK.sun.invoke.util.Wrapper arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle exactInvoker(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle foldArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle foldArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "private static synchronized")]
	public static Dova.JDK.java.lang.invoke.MethodHandle setCachedMethodHandle(JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle invoker(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/reflect/Member;", "public static")]
	public static Dova.JDK.java.lang.Object reflectAs(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle basicInvoker(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)V", "private static")]
	public static void explicitCastArgumentsChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("([ILjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)Z", "static")]
	public static bool permuteArgumentChecks(JavaArray<int> arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([II)I", "private static")]
	public static int findFirstDupOrDrop(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle insertArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeIdentity(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeZero(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;II)[Ljava/lang/Class;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.Class> insertArgumentsChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/Class;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle insertArgumentPrimitive(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List copyTypes(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/util/List;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropArguments0(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;ILjava/util/List;)I", "private static")]
	public static int dropArgumentChecks(Dova.JDK.java.lang.invoke.MethodType arg0, int arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/util/List;IZ)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropArgumentsToMatch(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.util.List arg2, int arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/util/List;I)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropArgumentsToMatch(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.util.List arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void filterArgumentsCheckArity(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle filterRepeatedArgument(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle filterArgument(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)V", "private static")]
	public static void filterArgumentChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodType;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodType collectArgumentsChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)V", "private static")]
	public static void filterReturnValueChecks(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class foldArgumentChecks(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/RuntimeException;", "static")]
	public static Dova.JDK.java.lang.RuntimeException misMatchedTypes(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.RuntimeException>(ret);
	}

	[JniSignatureAttribute("(ZLjava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;", "private static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle argumentsWithCombiner(bool arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, int arg2, Dova.JDK.java.lang.invoke.MethodHandle arg3, JavaArray<int> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(IZLjava/lang/invoke/MethodType;Ljava/lang/invoke/MethodType;[I)Ljava/lang/Class;", "private static transient")]
	public static Dova.JDK.java.lang.Class argumentsWithCombinerChecks(int arg0, bool arg1, Dova.JDK.java.lang.invoke.MethodType arg2, Dova.JDK.java.lang.invoke.MethodType arg3, JavaArray<int> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("([[Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void loopChecks0(JavaArray<JavaArray<Dova.JDK.java.lang.invoke.MethodHandle>> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void loopChecks1a(int arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;I)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List buildCommonSuffix(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)V", "private static")]
	public static void loopChecks1b(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/lang/Class;)V", "private static")]
	public static void loopChecks1cd(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "private static")]
	public static void loopChecks2(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle identityOrVoid(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List fillParameterTypes(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List fixArities(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/stream/Stream;I)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List longestParameterList(Dova.JDK.java.util.stream.Stream arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List longestParameterList(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void whileLoopChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle countedLoop(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle countedLoop(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, Dova.JDK.java.lang.invoke.MethodHandle arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void countedLoopChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, Dova.JDK.java.lang.invoke.MethodHandle arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class iteratedLoopChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;II)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle swapArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle permuteArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "private static")]
	public static void tryFinallyChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodType;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodType tableSwitchChecks(Dova.JDK.java.lang.invoke.MethodHandle arg0, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandles$Lookup;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup privateLookupIn(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/Class;I)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object classDataAt(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle arrayConstructor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle arrayElementGetter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle arrayElementSetter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.VarHandle arrayElementVarHandle(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.VarHandle byteArrayViewVarHandle(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.nio.ByteOrder arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/nio/ByteOrder;)Ljava/lang/invoke/VarHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.VarHandle byteBufferViewVarHandle(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.nio.ByteOrder arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessMode;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle varHandleExactInvoker(Dova.JDK.java.lang.invoke.VarHandle.AccessMode arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle explicitCastArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle dropReturn(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;I[Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle filterArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle collectArguments(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle filterReturnValue(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle collectReturnValue(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;", "static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle filterArgumentsWithCombiner(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;ILjava/lang/invoke/MethodHandle;[I)Ljava/lang/invoke/MethodHandle;", "static transient")]
	public static Dova.JDK.java.lang.invoke.MethodHandle foldArgumentsWithCombiner(Dova.JDK.java.lang.invoke.MethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle guardWithTest(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle catchException(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle whileLoop(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle doWhileLoop(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "public static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle iteratedLoop(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[90], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup;", "public static final")]
	public partial class Lookup
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Lookup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandles$Lookup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prevLookupClass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTECTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNCONDITIONAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ORIGINAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_MODES", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULL_POWER_MODES", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUSTED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedProtectionDomain", "Ljava/security/ProtectionDomain;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPL_LOOKUP", "Ljava/lang/invoke/MethodHandles$Lookup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC_LOOKUP", "Ljava/lang/invoke/MethodHandles$Lookup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOKASIDE_TABLE", "Ljava/util/concurrent/ConcurrentHashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "linkMethodHandleConstant", "(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "([B)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccess", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOrNull", "(BLjava/lang/invoke/MemberName;)Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOrNull", "(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOrFail", "(BLjava/lang/invoke/MemberName;)Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOrFail", "(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOrFail", "(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MemberName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureInitialized", "(Ljava/lang/Class;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revealDirect", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandleInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeAccessException", "(Ljava/lang/Class;)Ljava/lang/IllegalAccessException;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousLookupClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findVirtual", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findStatic", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflect", "(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupModes", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newLookup", "(Ljava/lang/Class;Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkUnprivilegedlookupClass", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClassAccessible", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureDefineClassPermission", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeClassDefiner", "([B)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFullPrivilegeAccess", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeHiddenClassDefiner", "(Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;Ljava/util/Set;Z)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeHiddenClassDefiner", "(Ljava/lang/String;[BLjava/util/Set;)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeHiddenClassDefiner", "([BLjava/util/Set;Z)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeHiddenClassDefiner", "([B)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBoundCallerLookup", "(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectMethod", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findVirtualForMH", "(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findVirtualForVH", "(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectConstructor", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessClass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSecurityManager", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSecurityManager", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSpecialCaller", "(Ljava/lang/Class;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectField", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldVarHandle", "(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectMethodNoRestrictInvokeSpecial", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectForMH", "(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectForVH", "(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectMethodNoSecurityManager", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectConstructorNoSecurityManager", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectField", "(Ljava/lang/reflect/Field;Z)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectFieldNoSecurityManager", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldVarHandleNoSecurityManager", "(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSymbolicClass", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupClassOrNull", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethodName", "(BLjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixmods", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessFailedMessage", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectMethodCommon", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;ZZLjava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethod", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restrictProtectedReceiver", "(Ljava/lang/invoke/MemberName;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restrictReceiver", "(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/DirectMethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maybeBindCaller", "(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectFieldCommon", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkField", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldVarHandleCommon", "(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectConstructorCommon", "(Ljava/lang/Class;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectMethodForConstant", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canBeCached", "(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropLookupMode", "(I)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineHiddenClass", "([BZ[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineHiddenClassWithClassData", "([BLjava/lang/Object;Z[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;)Ljava/lang/invoke/MethodHandles$Lookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupClassProtectionDomain", "()Ljava/security/ProtectionDomain;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findConstructor", "(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSpecial", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findGetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findVarHandle", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findStaticGetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findStaticSetter", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findStaticVarHandle", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectSpecial", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectConstructor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectGetter", "(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectSetter", "(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unreflectVarHandle", "(Ljava/lang/reflect/Field;)Ljava/lang/invoke/VarHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasPrivateAccess", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class prevLookupClass_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int PUBLIC_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int PRIVATE_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int PROTECTED_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int PACKAGE_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int MODULE_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int UNCONDITIONAL_Property
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

		[JniSignatureAttribute("I", "public static final")]
		public static int ORIGINAL_Property
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
		public static int ALL_MODES_Property
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
		public static int FULL_POWER_MODES_Property
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
		public static int TRUSTED_Property
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

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private volatile")]
		public Dova.JDK.java.security.ProtectionDomain cachedProtectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup IMPL_LOOKUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup;", "static final")]
		public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup PUBLIC_LOOKUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentHashMap;", "static")]
		public static Dova.JDK.java.util.concurrent.ConcurrentHashMap LOOKASIDE_TABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentHashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Lookup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;I)V", "private")]
		public Lookup(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
		public Lookup(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandles$Lookup;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle linkMethodHandleConstant(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Object arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class defineClass(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandles$Lookup;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup @in(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V", "")]
		public void checkAccess(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(BLjava/lang/invoke/MemberName;)Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName resolveOrNull(byte arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName resolveOrNull(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.invoke.MethodType arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/invoke/MemberName;)Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName resolveOrFail(byte arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName resolveOrFail(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.invoke.MethodType arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MemberName;", "")]
		public Dova.JDK.java.lang.invoke.MemberName resolveOrFail(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Class arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class ensureInitialized(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandleInfo;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandleInfo revealDirect(Dova.JDK.java.lang.invoke.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandleInfo>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/IllegalAccessException;", "private")]
		public Dova.JDK.java.lang.IllegalAccessException makeAccessException(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.IllegalAccessException>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class lookupClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class previousLookupClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findVirtual(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findStatic(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflect(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int lookupModes()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;I)Ljava/lang/invoke/MethodHandles$Lookup;", "private static")]
		public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup newLookup(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
		public static void checkUnprivilegedlookupClass(Dova.JDK.java.lang.Class arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "")]
		public bool isClassAccessible(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void ensureDefineClassPermission()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
		}

		[JniSignatureAttribute("([B)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner makeClassDefiner(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasFullPrivilegeAccess()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;Ljava/util/Set;Z)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner makeHiddenClassDefiner(Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile arg0, Dova.JDK.java.util.Set arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[BLjava/util/Set;)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner makeHiddenClassDefiner(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1, Dova.JDK.java.util.Set arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner>(ret);
		}

		[JniSignatureAttribute("([BLjava/util/Set;Z)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner makeHiddenClassDefiner(JavaArray<byte> arg0, Dova.JDK.java.util.Set arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner>(ret);
		}

		[JniSignatureAttribute("([B)Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner makeHiddenClassDefiner(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassDefiner>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandles$Lookup;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup findBoundCallerLookup(Dova.JDK.java.lang.invoke.MemberName arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectMethod(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle findVirtualForMH(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle findVirtualForVH(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectConstructor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class accessClass(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)V", "")]
		public void checkSecurityManager(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
		public void checkSecurityManager(Dova.JDK.java.lang.Class arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)V", "private")]
		public void checkSpecialCaller(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectField(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/VarHandle;", "private")]
		public Dova.JDK.java.lang.invoke.VarHandle getFieldVarHandle(byte arg0, byte arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.invoke.MemberName arg3, Dova.JDK.java.lang.invoke.MemberName arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectMethodNoRestrictInvokeSpecial(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectForMH(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectForVH(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectMethodNoSecurityManager(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectConstructorNoSecurityManager(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;Z)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectField(Dova.JDK.java.lang.reflect.Field arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectFieldNoSecurityManager(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/VarHandle;", "private")]
		public Dova.JDK.java.lang.invoke.VarHandle getFieldVarHandleNoSecurityManager(byte arg0, byte arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.invoke.MemberName arg3, Dova.JDK.java.lang.invoke.MemberName arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
		public void checkSymbolicClass(Dova.JDK.java.lang.Class arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "private")]
		public Dova.JDK.java.lang.Class lookupClassOrNull()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/String;)V", "")]
		public void checkMethodName(byte arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		}

		[JniSignatureAttribute("(I)I", "private static")]
		public static int fixmods(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[52], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String accessFailedMessage(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;ZZLjava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectMethodCommon(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2, bool arg3, bool arg4, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V", "")]
		public void checkMethod(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;)Z", "private")]
		public bool restrictProtectedReceiver(Dova.JDK.java.lang.invoke.MemberName arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/DirectMethodHandle;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle restrictReceiver(Dova.JDK.java.lang.invoke.MemberName arg0, Dova.JDK.java.lang.invoke.DirectMethodHandle arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle maybeBindCaller(Dova.JDK.java.lang.invoke.MemberName arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectFieldCommon(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)V", "")]
		public void checkField(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(BBLjava/lang/Class;Ljava/lang/invoke/MemberName;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/VarHandle;", "private")]
		public Dova.JDK.java.lang.invoke.VarHandle getFieldVarHandleCommon(byte arg0, byte arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.invoke.MemberName arg3, Dova.JDK.java.lang.invoke.MemberName arg4, bool arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MemberName;Z)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectConstructorCommon(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MemberName arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Ljava/lang/invoke/MethodHandle;", "private")]
		public Dova.JDK.java.lang.invoke.MethodHandle getDirectMethodForConstant(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(BLjava/lang/Class;Ljava/lang/invoke/MemberName;)Z", "private")]
		public bool canBeCached(byte arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.invoke.MemberName arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/invoke/MethodHandles$Lookup;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup dropLookupMode(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("([BZ[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;)Ljava/lang/invoke/MethodHandles$Lookup;", "public transient")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup defineHiddenClass(JavaArray<byte> arg0, bool arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("([BLjava/lang/Object;Z[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;)Ljava/lang/invoke/MethodHandles$Lookup;", "public transient")]
		public Dova.JDK.java.lang.invoke.MethodHandles.Lookup defineHiddenClassWithClassData(JavaArray<byte> arg0, Dova.JDK.java.lang.Object arg1, bool arg2, JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}

		[JniSignatureAttribute("()Ljava/security/ProtectionDomain;", "private")]
		public Dova.JDK.java.security.ProtectionDomain lookupClassProtectionDomain()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findConstructor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/invoke/MethodType;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findSpecial(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.invoke.MethodType arg2, Dova.JDK.java.lang.Class arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findGetter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findSetter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandle findVarHandle(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findStaticGetter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle findStaticSetter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/invoke/VarHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandle findStaticVarHandle(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle bind(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectSpecial(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectConstructor(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectGetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/invoke/MethodHandle;", "public")]
		public Dova.JDK.java.lang.invoke.MethodHandle unreflectSetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/invoke/VarHandle;", "public")]
		public Dova.JDK.java.lang.invoke.VarHandle unreflectVarHandle(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasPrivateAccess()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[83]);
			return ret;
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;", "static")]
		public partial class ClassDefiner
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassDefiner()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookup", "Ljava/lang/invoke/MethodHandles$Lookup;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytes", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFlags", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "className", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(ZLjava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Z)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClassAsLookup", "(ZLjava/lang/Object;)Ljava/lang/invoke/MethodHandles$Lookup;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClassAsLookup", "(Z)Ljava/lang/invoke/MethodHandles$Lookup;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestmate", "()Z"));
			}

			[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup;", "private final")]
			public Dova.JDK.java.lang.invoke.MethodHandles.Lookup lookup_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String name_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> bytes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int classFlags_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
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
			public ClassDefiner(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;I)V", "private")]
			public ClassDefiner(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0, Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandles$Lookup$ClassDefiner;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "")]
			public Dova.JDK.java.lang.String className()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(ZLjava/lang/Object;)Ljava/lang/Class;", "")]
			public Dova.JDK.java.lang.Class defineClass(bool arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Z)Ljava/lang/Class;", "")]
			public Dova.JDK.java.lang.Class defineClass(bool arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(ZLjava/lang/Object;)Ljava/lang/invoke/MethodHandles$Lookup;", "")]
			public Dova.JDK.java.lang.invoke.MethodHandles.Lookup defineClassAsLookup(bool arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
			}

			[JniSignatureAttribute("(Z)Ljava/lang/invoke/MethodHandles$Lookup;", "")]
			public Dova.JDK.java.lang.invoke.MethodHandles.Lookup defineClassAsLookup(bool arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
			}

			[JniSignatureAttribute("()Z", "private")]
			public bool isNestmate()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;", "static")]
		public partial class ClassFile
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassFile()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessFlags", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytes", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I[B)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "([BLjava/lang/String;)Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readInt", "([BI)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstanceNoCheck", "(Ljava/lang/String;[B)Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readUnsignedShort", "([BI)I"));
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

			[JniSignatureAttribute("I", "final")]
			public int accessFlags_Property
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

			[JniSignatureAttribute("[B", "final")]
			public JavaArray<byte> bytes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassFile(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I[B)V", "")]
			public ClassFile(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<byte> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([BLjava/lang/String;)Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;", "static")]
			public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile newInstance(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile>(ret);
			}

			[JniSignatureAttribute("([BI)I", "private static")]
			public static int readInt(JavaArray<byte> arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/String;[B)Ljava/lang/invoke/MethodHandles$Lookup$ClassFile;", "static")]
			public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile newInstanceNoCheck(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassFile>(ret);
			}

			[JniSignatureAttribute("([BI)I", "private static")]
			public static int readUnsignedShort(JavaArray<byte> arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "public static final")]
		public partial class ClassOption
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassOption()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NESTMATE", "Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRONG", "Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flag", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "optionsToFlag", "(Ljava/util/Set;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;"));
			}

			[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "public static final")]
			public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption NESTMATE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "public static final")]
			public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption STRONG_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int flag_Property
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

			[JniSignatureAttribute("[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "private static final")]
			public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassOption(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
			public ClassOption(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "public static")]
			public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "public static")]
			public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Set;)I", "static")]
			public static int optionsToFlag(Dova.JDK.java.util.Set arg0)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("()[Ljava/lang/invoke/MethodHandles$Lookup$ClassOption;", "private static")]
			public static JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.MethodHandles.Lookup.ClassOption>>(ret);
			}
		}
	}
}
