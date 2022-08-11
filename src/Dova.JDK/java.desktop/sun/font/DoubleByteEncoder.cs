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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/DoubleByteEncoder;", "public abstract")]
public partial class DoubleByteEncoder
	: Dova.JDK.java.nio.charset.CharsetEncoder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DoubleByteEncoder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/DoubleByteEncoder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index1", "[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index2", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sgp", "Lsun/nio/cs/Surrogate$Parser;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;[S[Ljava/lang/String;[BFF)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;[S[Ljava/lang/String;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;[S[Ljava/lang/String;FF)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/charset/Charset;[S[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canEncode", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeArrayLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeBufferLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeSurrogate", "(CC)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeDouble", "(C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeSingle", "(C)I"));
	}

	[JniSignatureAttribute("[S", "private")]
	public JavaArray<short> index1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> index2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/nio/cs/Surrogate$Parser;", "private final")]
	public Dova.JDK.sun.nio.cs.Surrogate.Parser sgp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.cs.Surrogate.Parser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DoubleByteEncoder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;[S[Ljava/lang/String;[BFF)V", "protected")]
	public DoubleByteEncoder(Dova.JDK.java.nio.charset.Charset arg0, JavaArray<short> arg1, JavaArray<Dova.JDK.java.lang.String> arg2, JavaArray<byte> arg3, float arg4, float arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;[S[Ljava/lang/String;[B)V", "protected")]
	public DoubleByteEncoder(Dova.JDK.java.nio.charset.Charset arg0, JavaArray<short> arg1, JavaArray<Dova.JDK.java.lang.String> arg2, JavaArray<byte> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;[S[Ljava/lang/String;FF)V", "protected")]
	public DoubleByteEncoder(Dova.JDK.java.nio.charset.Charset arg0, JavaArray<short> arg1, JavaArray<Dova.JDK.java.lang.String> arg2, float arg3, float arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;[S[Ljava/lang/String;)V", "protected")]
	public DoubleByteEncoder(Dova.JDK.java.nio.charset.Charset arg0, JavaArray<short> arg1, JavaArray<Dova.JDK.java.lang.String> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/DoubleByteEncoder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(C)Z", "public")]
	public bool canEncode(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
	public Dova.JDK.java.nio.charset.CoderResult encodeArrayLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "private")]
	public Dova.JDK.java.nio.charset.CoderResult encodeBufferLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", "protected")]
	public Dova.JDK.java.nio.charset.CoderResult encodeLoop(Dova.JDK.java.nio.CharBuffer arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.CoderResult>(ret);
	}

	[JniSignatureAttribute("(CC)[B", "protected")]
	public JavaArray<byte> encodeSurrogate(char arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(C)I", "protected")]
	public int encodeDouble(char arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)I", "protected")]
	public int encodeSingle(char arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}
}
