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

namespace Dova.JDK.java.nio;

[JniSignatureAttribute("Ljava/nio/BufferMismatch;", "final")]
public partial class BufferMismatch
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferMismatch()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/nio/BufferMismatch;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SCOPED_MEMORY_ACCESS", "Ljdk/internal/misc/ScopedMemoryAccess;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BufferMismatch", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/FloatBuffer;ILjava/nio/FloatBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/LongBuffer;ILjava/nio/LongBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/DoubleBuffer;ILjava/nio/DoubleBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/IntBuffer;ILjava/nio/IntBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mismatch", "(Ljava/nio/CharBuffer;ILjava/nio/CharBuffer;II)I"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/ScopedMemoryAccess;", "static final")]
	public static Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess SCOPED_MEMORY_ACCESS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.ScopedMemoryAccess>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferMismatch(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public BufferMismatch() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/BufferMismatch;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/FloatBuffer;ILjava/nio/FloatBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.FloatBuffer arg0, int arg1, Dova.JDK.java.nio.FloatBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/LongBuffer;ILjava/nio/LongBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.LongBuffer arg0, int arg1, Dova.JDK.java.nio.LongBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/DoubleBuffer;ILjava/nio/DoubleBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.DoubleBuffer arg0, int arg1, Dova.JDK.java.nio.DoubleBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/IntBuffer;ILjava/nio/IntBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.IntBuffer arg0, int arg1, Dova.JDK.java.nio.IntBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.ByteBuffer arg0, int arg1, Dova.JDK.java.nio.ByteBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ShortBuffer;ILjava/nio/ShortBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.ShortBuffer arg0, int arg1, Dova.JDK.java.nio.ShortBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/CharBuffer;ILjava/nio/CharBuffer;II)I", "static")]
	public static int mismatch(Dova.JDK.java.nio.CharBuffer arg0, int arg1, Dova.JDK.java.nio.CharBuffer arg2, int arg3, int arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}
}
