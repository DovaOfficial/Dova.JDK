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

[JniSignatureAttribute("Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;", "final")]
public partial class MemoryAccessVarHandleShortHelper
	: Dova.JDK.java.lang.invoke.MemoryAccessVarHandleBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemoryAccessVarHandleShortHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCOPED_MEMORY_ACCESS", "Ljdk/internal/misc/ScopedMemoryAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VM_ALIGN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORM", "Ljava/lang/invoke/VarForm;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZJJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "offset", "(ZLjdk/internal/access/foreign/MemorySegmentProxy;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "set", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessModeTypeUncached", "(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setVolatile", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setOpaque", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAcquire", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRelease", "(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeExactBehavior_1", "()Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_0", "()Ljava/lang/invoke/VarHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokeBehavior_1", "()Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convEndian", "(ZS)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkAddress", "(Ljava/lang/Object;JJZ)Ljdk/internal/access/foreign/MemorySegmentProxy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "offsetNoVMAlignCheck", "(ZLjdk/internal/access/foreign/MemorySegmentProxy;JJ)J"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool BE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess;", "static final")]
	public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess SCOPED_MEMORY_ACCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int VM_ALIGN_Property
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

	[JniSignatureAttribute("Ljava/lang/invoke/VarForm;", "static final")]
	public static Dova.JDK.java.lang.invoke.VarForm FORM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarForm>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MemoryAccessVarHandleShortHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZZJJZ)V", "")]
	public MemoryAccessVarHandleShortHelper(bool arg0, bool arg1, long arg2, long arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S", "static")]
	public static short get(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(ZLjdk/internal/access/foreign/MemorySegmentProxy;JJ)J", "static")]
	public static long offset(bool arg0, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V", "static")]
	public static void set(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle$AccessType;)Ljava/lang/invoke/MethodType;", "final")]
	public Dova.JDK.java.lang.invoke.MethodType accessModeTypeUncached(Dova.JDK.java.lang.invoke.VarHandle.AccessType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S", "static")]
	public static short getVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V", "static")]
	public static void setVolatile(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S", "static")]
	public static short getOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V", "static")]
	public static void setOpaque(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;J)S", "static")]
	public static short getAcquire(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/VarHandle;Ljava/lang/Object;JS)V", "static")]
	public static void setRelease(Dova.JDK.java.lang.invoke.VarHandle arg0, Dova.JDK.java.lang.Object arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
	public Dova.JDK.java.lang.invoke.VarHandle withInvokeExactBehavior_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;", "public")]
	public Dova.JDK.java.lang.invoke.MemoryAccessVarHandleShortHelper withInvokeExactBehavior_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemoryAccessVarHandleShortHelper>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/VarHandle;", "public volatile")]
	public Dova.JDK.java.lang.invoke.VarHandle withInvokeBehavior_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/MemoryAccessVarHandleShortHelper;", "public")]
	public Dova.JDK.java.lang.invoke.MemoryAccessVarHandleShortHelper withInvokeBehavior_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemoryAccessVarHandleShortHelper>(ret);
	}

	[JniSignatureAttribute("(ZS)S", "static")]
	public static short convEndian(bool arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;JJZ)Ljdk/internal/access/foreign/MemorySegmentProxy;", "static")]
	public static Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy checkAddress(Dova.JDK.java.lang.Object arg0, long arg1, long arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy>(ret);
	}

	[JniSignatureAttribute("(ZLjdk/internal/access/foreign/MemorySegmentProxy;JJ)J", "static")]
	public static long offsetNoVMAlignCheck(bool arg0, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return ret;
	}
}
