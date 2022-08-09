/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.invoke;

[JniSignatureAttribute("Ljdk/internal/invoke/NativeEntryPoint;", "public")]
public partial class NativeEntryPoint
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeEntryPoint()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/invoke/NativeEntryPoint;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "shadowSpace", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "argMoves", "[J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "returnMoves", "[J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "needTransition", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "methodType", "Ljava/lang/invoke/MethodType;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NativeEntryPoint", "(I[J[JZLjava/lang/invoke/MethodType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "type", "()Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "make", "(Ljava/lang/String;Ljdk/internal/invoke/ABIDescriptorProxy;[Ljdk/internal/invoke/VMStorageProxy;[Ljdk/internal/invoke/VMStorageProxy;ZLjava/lang/invoke/MethodType;)Ljdk/internal/invoke/NativeEntryPoint;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "registerNatives", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "encodeVMStorages", "([Ljdk/internal/invoke/VMStorageProxy;)[J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "vmStorageToVMReg", "(II)J"));
	}

	[JniSignatureAttribute("I", "private final")]
	public int shadowSpace_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> argMoves_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> returnMoves_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool needTransition_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodType methodType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeEntryPoint(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I[J[JZLjava/lang/invoke/MethodType;Ljava/lang/String;)V", "private")]
	public NativeEntryPoint(int arg0, JavaArray<long> arg1, JavaArray<long> arg2, bool arg3, Dova.JDK.java.lang.invoke.MethodType arg4, Dova.JDK.java.lang.String arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/invoke/NativeEntryPoint;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/invoke/MethodType;", "public")]
	public Dova.JDK.java.lang.invoke.MethodType type()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/internal/invoke/ABIDescriptorProxy;[Ljdk/internal/invoke/VMStorageProxy;[Ljdk/internal/invoke/VMStorageProxy;ZLjava/lang/invoke/MethodType;)Ljdk/internal/invoke/NativeEntryPoint;", "public static")]
	public static Dova.JDK.jdk.@internal.invoke.NativeEntryPoint make(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.@internal.invoke.ABIDescriptorProxy arg1, JavaArray<Dova.JDK.jdk.@internal.invoke.VMStorageProxy> arg2, JavaArray<Dova.JDK.jdk.@internal.invoke.VMStorageProxy> arg3, bool arg4, Dova.JDK.java.lang.invoke.MethodType arg5)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.invoke.NativeEntryPoint>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void registerNatives()
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("([Ljdk/internal/invoke/VMStorageProxy;)[J", "private static")]
	public static JavaArray<long> encodeVMStorages(JavaArray<Dova.JDK.jdk.@internal.invoke.VMStorageProxy> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(II)J", "private static native")]
	public static long vmStorageToVMReg(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}
}
