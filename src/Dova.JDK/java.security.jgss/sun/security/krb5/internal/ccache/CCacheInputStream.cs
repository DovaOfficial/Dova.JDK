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

namespace Dova.JDK.sun.security.krb5.@internal.ccache;

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/CCacheInputStream;", "public")]
public partial class CCacheInputStream
	: Dova.JDK.sun.security.krb5.@internal.util.KrbDataInputStream
	, Dova.JDK.sun.security.krb5.@internal.ccache.FileCCacheConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CCacheInputStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/CCacheInputStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readKey", "(I)Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRealm", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readPrincipal", "(I)Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTimes", "()[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readskey", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFlags", "()[Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAddr", "()[Lsun/security/krb5/internal/HostAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAuth", "()[Lsun/security/krb5/internal/AuthorizationDataEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readData", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTag", "()Lsun/security/krb5/internal/ccache/Tag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readCred", "(I)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool DEBUG_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CCacheInputStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public CCacheInputStream(Dova.JDK.java.io.InputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/CCacheInputStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lsun/security/krb5/EncryptionKey;", "")]
	public Dova.JDK.sun.security.krb5.EncryptionKey readKey(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isRealm(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName readPrincipal(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()[J", "")]
	public JavaArray<long> readTimes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool readskey()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()[Z", "")]
	public JavaArray<bool> readFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/HostAddress;", "")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.HostAddress> readAddr()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.HostAddress>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/AuthorizationDataEntry;", "")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.AuthorizationDataEntry> readAuth()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.AuthorizationDataEntry>>(ret);
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> readData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/Tag;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Tag readTag()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Tag>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object readCred(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
