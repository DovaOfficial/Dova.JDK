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

namespace Dova.JDK.java.nio;

[JniSignatureAttribute("Ljava/nio/HeapDoubleBuffer;", "")]
public partial class HeapDoubleBuffer
	: Dova.JDK.java.nio.DoubleBuffer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HeapDoubleBuffer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/HeapDoubleBuffer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BASE_OFFSET", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_INDEX_SCALE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([DIIIIILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([DIILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "([DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(ID)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(ILjava/nio/DoubleBuffer;II)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirect", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReadOnly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "(II)Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "(II)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compact", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "order", "()Ljava/nio/ByteOrder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ix", "(I)I"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long ARRAY_BASE_OFFSET_Property
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

	[JniSignatureAttribute("J", "private static final")]
	public static long ARRAY_INDEX_SCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HeapDoubleBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([DIIIIILjdk/internal/access/foreign/MemorySegmentProxy;)V", "protected")]
	public HeapDoubleBuffer(JavaArray<double> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("([DIILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public HeapDoubleBuffer(JavaArray<double> arg0, int arg1, int arg2, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(IILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public HeapDoubleBuffer(int arg0, int arg1, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/HeapDoubleBuffer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)D", "public")]
	public double get(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double get()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(ID)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(Dova.JDK.java.nio.DoubleBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/DoubleBuffer;II)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, Dova.JDK.java.nio.DoubleBuffer arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDirect()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReadOnly()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer slice_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer slice_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer duplicate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer duplicate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer asReadOnlyBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer compact()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "public")]
	public Dova.JDK.java.nio.ByteOrder order()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}

	[JniSignatureAttribute("(I)I", "protected")]
	public int ix(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}
}
