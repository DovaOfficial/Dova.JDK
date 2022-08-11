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

namespace Dova.JDK.java.util.concurrent.atomic;

[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLongArray;", "public")]
public partial class AtomicLongArray
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AtomicLongArray()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/atomic/AtomicLongArray;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AA", "Ljava/lang/invoke/VarHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpaque", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOpaque", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcquire", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRelease", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndSet", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchange", "(IJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeAcquire", "(IJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareAndExchangeRelease", "(IJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetPlain", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSet", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetAcquire", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetRelease", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndSet", "(IJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAdd", "(IJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lazySet", "(IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weakCompareAndSetVolatile", "(IJJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndIncrement", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndDecrement", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "incrementAndGet", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrementAndGet", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAndGet", "(IJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndUpdate", "(ILjava/util/function/LongUnaryOperator;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAndGet", "(ILjava/util/function/LongUnaryOperator;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAndAccumulate", "(IJLjava/util/function/LongBinaryOperator;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulateAndGet", "(IJLjava/util/function/LongBinaryOperator;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPlain", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPlain", "(IJ)V"));
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

	[JniSignatureAttribute("Ljava/lang/invoke/VarHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.VarHandle AA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.VarHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> array_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AtomicLongArray(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public AtomicLongArray(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([J)V", "public")]
	public AtomicLongArray(JavaArray<long> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/concurrent/atomic/AtomicLongArray;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)J", "public final")]
	public long get(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IJ)V", "public final")]
	public void set(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long getOpaque(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IJ)V", "public final")]
	public void setOpaque(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long getAcquire(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IJ)V", "public final")]
	public void setRelease(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool compareAndSet(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)J", "public final")]
	public long compareAndExchange(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)J", "public final")]
	public long compareAndExchangeAcquire(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)J", "public final")]
	public long compareAndExchangeRelease(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool weakCompareAndSetPlain(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool weakCompareAndSet(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool weakCompareAndSetAcquire(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool weakCompareAndSetRelease(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJ)J", "public final")]
	public long getAndSet(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IJ)J", "public final")]
	public long getAndAdd(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IJ)V", "public final")]
	public void lazySet(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(IJJ)Z", "public final")]
	public bool weakCompareAndSetVolatile(int arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long getAndIncrement(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long getAndDecrement(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long incrementAndGet(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long decrementAndGet(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IJ)J", "public")]
	public long addAndGet(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/util/function/LongUnaryOperator;)J", "public final")]
	public long getAndUpdate(int arg0, Dova.JDK.java.util.function.LongUnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/util/function/LongUnaryOperator;)J", "public final")]
	public long updateAndGet(int arg0, Dova.JDK.java.util.function.LongUnaryOperator arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IJLjava/util/function/LongBinaryOperator;)J", "public final")]
	public long getAndAccumulate(int arg0, long arg1, Dova.JDK.java.util.function.LongBinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJLjava/util/function/LongBinaryOperator;)J", "public final")]
	public long accumulateAndGet(int arg0, long arg1, Dova.JDK.java.util.function.LongBinaryOperator arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public final")]
	public long getPlain(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IJ)V", "public final")]
	public void setPlain(int arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}
}
