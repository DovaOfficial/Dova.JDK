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

[JniSignatureAttribute("Lsun/security/krb5/internal/EncKrbCredPart;", "public")]
public partial class EncKrbCredPart
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EncKrbCredPart()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/EncKrbCredPart;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ticketInfo", "[Lsun/security/krb5/internal/KrbCredInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeStamp", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonce", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "usec", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sAddress", "Lsun/security/krb5/internal/HostAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rAddress", "Lsun/security/krb5/internal/HostAddresses;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/util/DerValue;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/security/krb5/internal/KrbCredInfo;Lsun/security/krb5/internal/KerberosTime;Ljava/lang/Integer;Ljava/lang/Integer;Lsun/security/krb5/internal/HostAddress;Lsun/security/krb5/internal/HostAddresses;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/security/util/DerValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asn1Encode", "()[B"));
	}

	[JniSignatureAttribute("[Lsun/security/krb5/internal/KrbCredInfo;", "public")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.KrbCredInfo> ticketInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.KrbCredInfo>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime timeStamp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "private")]
	public Dova.JDK.java.lang.Integer nonce_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "private")]
	public Dova.JDK.java.lang.Integer usec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/HostAddress;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.HostAddress sAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.HostAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/HostAddresses;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.HostAddresses rAddress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.HostAddresses>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EncKrbCredPart(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/DerValue;)V", "public")]
	public EncKrbCredPart(Dova.JDK.sun.security.util.DerValue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public EncKrbCredPart(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("([Lsun/security/krb5/internal/KrbCredInfo;Lsun/security/krb5/internal/KerberosTime;Ljava/lang/Integer;Ljava/lang/Integer;Lsun/security/krb5/internal/HostAddress;Lsun/security/krb5/internal/HostAddresses;)V", "public")]
	public EncKrbCredPart(JavaArray<Dova.JDK.sun.security.krb5.@internal.KrbCredInfo> arg0, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg1, Dova.JDK.java.lang.Integer arg2, Dova.JDK.java.lang.Integer arg3, Dova.JDK.sun.security.krb5.@internal.HostAddress arg4, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/EncKrbCredPart;";
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
}
