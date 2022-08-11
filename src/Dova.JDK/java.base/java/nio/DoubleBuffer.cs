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

[JniSignatureAttribute("Ljava/nio/DoubleBuffer;", "public abstract")]
public partial class DoubleBuffer
	: Dova.JDK.java.nio.Buffer
	, Dova.JDK.java.lang.Comparable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoubleBuffer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/DoubleBuffer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_BASE_OFFSET", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hb", "[D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isReadOnly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([DJILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII[DILjdk/internal/access/foreign/MemorySegmentProxy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "base", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I[D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "([D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "([DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(ILjava/nio/DoubleBuffer;II)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(I[D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(ID)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/nio/DoubleBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrap", "([D)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrap", "([DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "position_0", "(I)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "position_1", "(I)Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit_0", "(I)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit_1", "(I)Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirect", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArray", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "array_0", "()[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "array_1", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arrayOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mark_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flip_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flip_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rewind_0", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rewind_1", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "(II)Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "(II)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_0", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "slice_1", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_0", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duplicate_1", "()Ljava/nio/Buffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mismatch", "(Ljava/nio/DoubleBuffer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "allocate", "(I)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArray", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBuffer", "(ILjava/nio/DoubleBuffer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putArray", "(I[DII)Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compact", "()Ljava/nio/DoubleBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "order", "()Ljava/nio/ByteOrder;"));
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

	[JniSignatureAttribute("[D", "final")]
	public JavaArray<double> hb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int offset_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool isReadOnly_Property
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
	public DoubleBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([DJILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public DoubleBuffer(JavaArray<double> arg0, long arg1, int arg2, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(IIIILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public DoubleBuffer(int arg0, int arg1, int arg2, int arg3, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(IIII[DILjdk/internal/access/foreign/MemorySegmentProxy;)V", "")]
	public DoubleBuffer(int arg0, int arg1, int arg2, int arg3, JavaArray<double> arg4, int arg5, Dova.JDK.jdk.@internal.access.foreign.MemorySegmentProxy arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/DoubleBuffer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object @base()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double get()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(I[D)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(int arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I)D", "public abstract")]
	public double get(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("([D)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer get(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer put(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(Dova.JDK.java.nio.DoubleBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(D)Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer put(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/DoubleBuffer;II)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, Dova.JDK.java.nio.DoubleBuffer arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I[D)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(ID)Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer put(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/nio/DoubleBuffer;", "public")]
	public Dova.JDK.java.nio.DoubleBuffer put(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/DoubleBuffer;)I", "public")]
	public int compareTo(Dova.JDK.java.nio.DoubleBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)I", "private static")]
	public static int compare(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer clear_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer clear_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([D)Ljava/nio/DoubleBuffer;", "public static")]
	public static Dova.JDK.java.nio.DoubleBuffer wrap(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("([DII)Ljava/nio/DoubleBuffer;", "public static")]
	public static Dova.JDK.java.nio.DoubleBuffer wrap(JavaArray<double> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer position_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer position_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer limit_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer limit_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isDirect()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool hasArray()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()[D", "public final")]
	public JavaArray<double> array_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object array_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int arrayOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer mark_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer mark_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer reset_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer reset_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer flip_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer flip_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer rewind_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public final")]
	public Dova.JDK.java.nio.DoubleBuffer rewind_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer slice_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer slice_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer slice_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer duplicate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/Buffer;", "public volatile")]
	public Dova.JDK.java.nio.Buffer duplicate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.Buffer>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/DoubleBuffer;)I", "public")]
	public int mismatch(Dova.JDK.java.nio.DoubleBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/nio/DoubleBuffer;", "public static")]
	public static Dova.JDK.java.nio.DoubleBuffer allocate(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "private")]
	public Dova.JDK.java.nio.DoubleBuffer getArray(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("(ILjava/nio/DoubleBuffer;II)V", "")]
	public void putBuffer(int arg0, Dova.JDK.java.nio.DoubleBuffer arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I[DII)Ljava/nio/DoubleBuffer;", "private")]
	public Dova.JDK.java.nio.DoubleBuffer putArray(int arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer asReadOnlyBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/DoubleBuffer;", "public abstract")]
	public Dova.JDK.java.nio.DoubleBuffer compact()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.DoubleBuffer>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/ByteOrder;", "public abstract")]
	public Dova.JDK.java.nio.ByteOrder order()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteOrder>(ret);
	}
}
