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

[JniSignatureAttribute("Lsun/security/krb5/KrbTgsReq;", "public")]
public partial class KrbTgsReq
	: Dova.JDK.sun.security.krb5.KrbKdcReq
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KrbTgsReq()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KrbTgsReq;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "princName", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientAlias", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "servName", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverAlias", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tgsReqMessg", "Lsun/security/krb5/internal/TGSReq;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "additionalCreds", "Lsun/security/krb5/Credentials;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useSubkey", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tgsReqKey", "Lsun/security/krb5/EncryptionKey;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;[Lsun/security/krb5/internal/PAData;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMessage", "()Lsun/security/krb5/internal/TGSReq;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encoding", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createRequest", "(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/internal/TGSReq;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdditionalCreds", "()Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "usedSubkey", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendAndGetCreds", "()Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClientAlias", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerAlias", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCtime", "()Lsun/security/krb5/internal/KerberosTime;"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName princName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName clientAlias_Property
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

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName servName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private")]
	public Dova.JDK.sun.security.krb5.PrincipalName serverAlias_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/TGSReq;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.TGSReq tgsReqMessg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.TGSReq>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime ctime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/Credentials;", "private")]
	public Dova.JDK.sun.security.krb5.Credentials additionalCreds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool useSubkey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/EncryptionKey;", "")]
	public Dova.JDK.sun.security.krb5.EncryptionKey tgsReqKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KrbTgsReq(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;[Lsun/security/krb5/internal/PAData;)V", "private")]
	public KrbTgsReq(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.PrincipalName arg4, Dova.JDK.sun.security.krb5.PrincipalName arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg7, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg8, JavaArray<int> arg9, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg10, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg11, Dova.JDK.sun.security.krb5.Credentials arg12, Dova.JDK.sun.security.krb5.EncryptionKey arg13, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg14) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;)V", "")]
	public KrbTgsReq(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, JavaArray<int> arg7, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg8, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg9, Dova.JDK.sun.security.krb5.Credentials arg10, Dova.JDK.sun.security.krb5.EncryptionKey arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/Credentials;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/Credentials;[Lsun/security/krb5/internal/PAData;)V", "public")]
	public KrbTgsReq(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.Credentials arg1, Dova.JDK.sun.security.krb5.PrincipalName arg2, Dova.JDK.sun.security.krb5.PrincipalName arg3, Dova.JDK.sun.security.krb5.PrincipalName arg4, Dova.JDK.sun.security.krb5.PrincipalName arg5, Dova.JDK.sun.security.krb5.Credentials arg6, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KrbTgsReq;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/krb5/internal/TGSReq;", "")]
	public Dova.JDK.sun.security.krb5.@internal.TGSReq getMessage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.TGSReq>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void debug(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[B", "public volatile")]
	public JavaArray<byte> encoding()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCOptions;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;[ILsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/Credentials;Lsun/security/krb5/EncryptionKey;[Lsun/security/krb5/internal/PAData;)Lsun/security/krb5/internal/TGSReq;", "private")]
	public Dova.JDK.sun.security.krb5.@internal.TGSReq createRequest(Dova.JDK.sun.security.krb5.@internal.KDCOptions arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1, Dova.JDK.sun.security.krb5.EncryptionKey arg2, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg3, Dova.JDK.sun.security.krb5.PrincipalName arg4, Dova.JDK.sun.security.krb5.PrincipalName arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg7, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg8, JavaArray<int> arg9, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg10, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg11, Dova.JDK.sun.security.krb5.Credentials arg12, Dova.JDK.sun.security.krb5.EncryptionKey arg13, JavaArray<Dova.JDK.sun.security.krb5.@internal.PAData> arg14)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.TGSReq>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "")]
	public Dova.JDK.sun.security.krb5.Credentials getAdditionalCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool usedSubkey()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.Credentials sendAndGetCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "")]
	public Dova.JDK.sun.security.krb5.PrincipalName getClientAlias()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "")]
	public Dova.JDK.sun.security.krb5.PrincipalName getServerAlias()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getCtime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}
}
