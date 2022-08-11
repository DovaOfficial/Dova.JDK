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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/RenderBuffer;", "public")]
public partial class RenderBuffer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RenderBuffer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/RenderBuffer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_BYTE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_SHORT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_INT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_FLOAT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_LONG", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZEOF_DOUBLE", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COPY_FROM_ARRAY_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseAddress", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endAddress", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "curAddress", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "capacity", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([S)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([I)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([B)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([J)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([F)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([SII)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([BII)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([JII)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([FII)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "([III)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByte", "(B)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShort", "(S)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(I)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(II)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(J)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFloat", "(F)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putDouble", "(D)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "position", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "position", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remaining", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capacity", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAddress", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skip", "(J)Lsun/java2d/pipe/RenderBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "allocate", "(I)Lsun/java2d/pipe/RenderBuffer;"));
	}

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_BYTE_Property
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

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_SHORT_Property
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

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_INT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("J", "protected static final")]
	public static long SIZEOF_DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int COPY_FROM_ARRAY_THRESHOLD_Property
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

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "protected final")]
	public Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "protected final")]
	public long baseAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "protected final")]
	public long endAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("J", "protected")]
	public long curAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "protected final")]
	public int capacity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RenderBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public RenderBuffer(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/RenderBuffer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([S)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([I)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([J)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([F)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([SII)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<short> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([BII)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([JII)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<long> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([FII)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<float> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("([III)Lsun/java2d/pipe/RenderBuffer;", "public")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer put(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(B)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putByte(byte arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(S)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putShort(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(II)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putInt(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(F)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putFloat(float arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(D)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer putDouble(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int position()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public final")]
	public void position(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int remaining()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int capacity()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public final")]
	public long getAddress()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(J)Lsun/java2d/pipe/RenderBuffer;", "public final")]
	public Dova.JDK.sun.java2d.pipe.RenderBuffer skip(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/java2d/pipe/RenderBuffer;", "public static")]
	public static Dova.JDK.sun.java2d.pipe.RenderBuffer allocate(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderBuffer>(ret);
	}
}
