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

namespace Dova.JDK.sun.security.krb5.@internal;

[JniSignatureAttribute("Lsun/security/krb5/internal/Authenticator;", "public")]
public partial class Authenticator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Authenticator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/Authenticator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authenticator_vno", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cksum", "Lsun/security/krb5/Checksum;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cusec", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subKey", "Lsun/security/krb5/EncryptionKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seqNumber", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authorizationData", "Lsun/security/krb5/internal/AuthorizationData;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/DerValue;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;ILsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Ljava/lang/Integer;Lsun/security/krb5/internal/AuthorizationData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asn1Encode", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubKey", "()Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeqNumber", "()Ljava/lang/Integer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChecksum", "()Lsun/security/krb5/Checksum;"));
	}

	[JniSignatureAttribute("I", "public")]
	public int authenticator_vno_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName cname_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Checksum;", "")]
	public Dova.JDK.sun.security.krb5.Checksum cksum_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Checksum>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public")]
	public int cusec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime ctime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/EncryptionKey;", "")]
	public Dova.JDK.sun.security.krb5.EncryptionKey subKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "")]
	public Dova.JDK.java.lang.Integer seqNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/AuthorizationData;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.AuthorizationData authorizationData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.AuthorizationData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Authenticator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "public")]
	public Authenticator(Dova.JDK.sun.security.util.DerValue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public Authenticator(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Checksum;ILsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/EncryptionKey;Ljava/lang/Integer;Lsun/security/krb5/internal/AuthorizationData;)V", "public")]
	public Authenticator(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.sun.security.krb5.Checksum arg1, int arg2, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg3, Dova.JDK.sun.security.krb5.EncryptionKey arg4, Dova.JDK.java.lang.Integer arg5, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/Authenticator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "private")]
	public void init(Dova.JDK.sun.security.util.DerValue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> asn1Encode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/EncryptionKey;", "public final")]
	public Dova.JDK.sun.security.krb5.EncryptionKey getSubKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Integer;", "public final")]
	public Dova.JDK.java.lang.Integer getSeqNumber()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Checksum;", "public final")]
	public Dova.JDK.sun.security.krb5.Checksum getChecksum()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Checksum>(ret);
	}
}
