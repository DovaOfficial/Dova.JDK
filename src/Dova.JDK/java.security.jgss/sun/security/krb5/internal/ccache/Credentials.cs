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

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/Credentials;", "public")]
public partial class Credentials
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Credentials()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/Credentials;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sname", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lsun/security/krb5/EncryptionKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authtime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "starttime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endtime", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "renewTill", "Lsun/security/krb5/internal/KerberosTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caddr", "Lsun/security/krb5/internal/HostAddresses;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "authorizationData", "Lsun/security/krb5/internal/AuthorizationData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isEncInSKey", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "Lsun/security/krb5/internal/TicketFlags;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ticket", "Lsun/security/krb5/internal/Ticket;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secondTicket", "Lsun/security/krb5/internal/Ticket;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/internal/Ticket;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCRep;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/internal/AuthorizationData;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;ZLsun/security/krb5/internal/TicketFlags;Lsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/internal/Ticket;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServicePrincipal", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuthTime", "()Lsun/security/krb5/internal/KerberosTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartTime", "()Lsun/security/krb5/internal/KerberosTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndTime", "()Lsun/security/krb5/internal/KerberosTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenewTill", "()Lsun/security/krb5/internal/KerberosTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTicket", "()Lsun/security/krb5/internal/Ticket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTicketFlags", "()Lsun/security/krb5/internal/TicketFlags;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServicePrincipal2", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClientPrincipal", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKrbCreds", "()Lsun/security/krb5/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTktEType", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTktEType2", "()I"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "")]
	public Dova.JDK.sun.security.krb5.PrincipalName cname_Property
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

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "")]
	public Dova.JDK.sun.security.krb5.PrincipalName sname_Property
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

	[JniSignatureAttribute("Lsun/security/krb5/EncryptionKey;", "")]
	public Dova.JDK.sun.security.krb5.EncryptionKey key_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime authtime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime starttime_Property
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

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime endtime_Property
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

	[JniSignatureAttribute("Lsun/security/krb5/internal/KerberosTime;", "")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime renewTill_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/HostAddresses;", "")]
	public Dova.JDK.sun.security.krb5.@internal.HostAddresses caddr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.HostAddresses>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/AuthorizationData;", "")]
	public Dova.JDK.sun.security.krb5.@internal.AuthorizationData authorizationData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.AuthorizationData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool isEncInSKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/TicketFlags;", "")]
	public Dova.JDK.sun.security.krb5.@internal.TicketFlags flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.TicketFlags>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/Ticket;", "")]
	public Dova.JDK.sun.security.krb5.@internal.Ticket ticket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.Ticket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/Ticket;", "")]
	public Dova.JDK.sun.security.krb5.@internal.Ticket secondTicket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.Ticket>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Credentials(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/internal/Ticket;)V", "public")]
	public Credentials(Dova.JDK.sun.security.krb5.@internal.KDCRep arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCRep;)V", "public")]
	public Credentials(Dova.JDK.sun.security.krb5.@internal.KDCRep arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/KDCRep;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/internal/AuthorizationData;Z)V", "public")]
	public Credentials(Dova.JDK.sun.security.krb5.@internal.KDCRep arg0, Dova.JDK.sun.security.krb5.@internal.Ticket arg1, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Lsun/security/krb5/PrincipalName;Lsun/security/krb5/EncryptionKey;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;Lsun/security/krb5/internal/KerberosTime;ZLsun/security/krb5/internal/TicketFlags;Lsun/security/krb5/internal/HostAddresses;Lsun/security/krb5/internal/AuthorizationData;Lsun/security/krb5/internal/Ticket;Lsun/security/krb5/internal/Ticket;)V", "public")]
	public Credentials(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1, Dova.JDK.sun.security.krb5.EncryptionKey arg2, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg3, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg4, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg5, Dova.JDK.sun.security.krb5.@internal.KerberosTime arg6, bool arg7, Dova.JDK.sun.security.krb5.@internal.TicketFlags arg8, Dova.JDK.sun.security.krb5.@internal.HostAddresses arg9, Dova.JDK.sun.security.krb5.@internal.AuthorizationData arg10, Dova.JDK.sun.security.krb5.@internal.Ticket arg11, Dova.JDK.sun.security.krb5.@internal.Ticket arg12) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/Credentials;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/krb5/EncryptionKey;", "public")]
	public Dova.JDK.sun.security.krb5.EncryptionKey getKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.EncryptionKey>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName getServicePrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getAuthTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getStartTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getEndTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/KerberosTime;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.KerberosTime getRenewTill()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.KerberosTime>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/Ticket;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.Ticket getTicket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.Ticket>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/TicketFlags;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.TicketFlags getTicketFlags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.TicketFlags>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName getServicePrincipal2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName getClientPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.Credentials setKrbCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTktEType()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTktEType2()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}
}
