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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/KrbAsRep;", "")]
public partial class KrbAsRep
	: Dova.JDK.sun.security.krb5.KrbKdcRep
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbAsRep()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbAsRep;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rep", "Lsun/security/krb5/internal/ASRep;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "creds", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "DEBUG", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decrypt", "(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPA", "()[Lsun/security/krb5/internal/PAData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decryptUsingKeyTab", "(Ljavax/security/auth/kerberos/KeyTab;Lsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decryptUsingPassword", "([CLsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCCreds", "()Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreds", "()Lsun/security/krb5/Credentials;"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ASRep;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.ASRep rep_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ASRep>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials creds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbAsRep(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "")]
	public KrbAsRep(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbAsRep;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V", "private")]
	public void decrypt(Dova.JDK.sun.security.krb5.EncryptionKey arg0, Dova.JDK.sun.security.krb5.KrbAsReq arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/PAData;", "")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> getPA()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KeyTab;Lsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V", "")]
	public void decryptUsingKeyTab(Dova.JDK.javax.security.auth.kerberos.KeyTab arg0, Dova.JDK.sun.security.krb5.KrbAsReq arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([CLsun/security/krb5/KrbAsReq;Lsun/security/krb5/PrincipalName;)V", "")]
	public void decryptUsingPassword(JavaArray<char> arg0, Dova.JDK.sun.security.krb5.KrbAsReq arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/Credentials;", "")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "")]
	public Dova.JDK.sun.security.krb5.Credentials getCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}
}
