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

namespace Dova.JDK.sun.security.jgss;

[JniSignatureAttribute("Lsun/security/jgss/GSSToken;", "public abstract")]
public partial class GSSToken
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GSSToken()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/GSSToken;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeInt", "(ILjava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeInt", "(I[BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readInt", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readInt", "(Ljava/io/InputStream;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readFully", "(Ljava/io/InputStream;[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readFully", "(Ljava/io/InputStream;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHexBytes", "([B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHexBytes", "([BI)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHexBytes", "([BII)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeLittleEndian", "(I[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeLittleEndian", "(I[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readBigEndian", "([BII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeBigEndian", "(I[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeBigEndian", "(I[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readLittleEndian", "([BII)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GSSToken(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public GSSToken() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/GSSToken;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static final")]
	public static void debug(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(ILjava/io/OutputStream;)V", "public static final")]
	public static void writeInt(int arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(I[BI)I", "public static final")]
	public static int writeInt(int arg0, JavaArray<byte> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "public static final")]
	public static int readInt(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)I", "public static final")]
	public static int readInt(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;[BII)V", "public static final")]
	public static void readFully(Dova.JDK.java.io.InputStream arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;[B)V", "public static final")]
	public static void readFully(Dova.JDK.java.io.InputStream arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String getHexBytes(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BI)Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String getHexBytes(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BII)Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String getHexBytes(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I[BI)V", "public static final")]
	public static void writeLittleEndian(int arg0, JavaArray<byte> arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I[B)V", "public static final")]
	public static void writeLittleEndian(int arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("([BII)I", "public static final")]
	public static int readBigEndian(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I[B)V", "public static final")]
	public static void writeBigEndian(int arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(I[BI)V", "public static final")]
	public static void writeBigEndian(int arg0, JavaArray<byte> arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BII)I", "public static final")]
	public static int readLittleEndian(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}
}
