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

namespace Dova.JDK.sun.security.jgss.krb5;

[JniSignatureAttribute("Lsun/security/jgss/krb5/MicToken_v2;", "")]
public partial class MicToken_v2
	: Dova.JDK.sun.security.jgss.krb5.MessageToken_v2
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MicToken_v2()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/jgss/krb5/MicToken_v2;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5Context;Lorg/ietf/jgss/MessageProp;Ljava/io/InputStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5Context;Lorg/ietf/jgss/MessageProp;[BII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5Context;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/jgss/krb5/Krb5Context;[BIILorg/ietf/jgss/MessageProp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encode", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "([BII)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MicToken_v2(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5Context;Lorg/ietf/jgss/MessageProp;Ljava/io/InputStream;)V", "public")]
	public MicToken_v2(Dova.JDK.sun.security.jgss.krb5.Krb5Context arg0, Dova.JDK.org.ietf.jgss.MessageProp arg1, Dova.JDK.java.io.InputStream arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5Context;Lorg/ietf/jgss/MessageProp;[BII)V", "public")]
	public MicToken_v2(Dova.JDK.sun.security.jgss.krb5.Krb5Context arg0, Dova.JDK.org.ietf.jgss.MessageProp arg1, JavaArray<byte> arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5Context;Ljava/io/InputStream;Lorg/ietf/jgss/MessageProp;)V", "public")]
	public MicToken_v2(Dova.JDK.sun.security.jgss.krb5.Krb5Context arg0, Dova.JDK.java.io.InputStream arg1, Dova.JDK.org.ietf.jgss.MessageProp arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/security/jgss/krb5/Krb5Context;[BIILorg/ietf/jgss/MessageProp;)V", "public")]
	public MicToken_v2(Dova.JDK.sun.security.jgss.krb5.Krb5Context arg0, JavaArray<byte> arg1, int arg2, int arg3, Dova.JDK.org.ietf.jgss.MessageProp arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/jgss/krb5/MicToken_v2;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([BI)I", "public")]
	public int encode(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> encode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public void encode(Dova.JDK.java.io.OutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public void verify(Dova.JDK.java.io.InputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("([BII)V", "public")]
	public void verify(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}
}
