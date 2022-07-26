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

namespace Dova.JDK.com.sun.jndi.dns;

[JniSignatureAttribute("Lcom/sun/jndi/dns/Resolver;", "")]
public partial class Resolver
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Resolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/dns/Resolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dnsClient", "Lcom/sun/jndi/dns/DnsClient;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retries", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "query", "(Lcom/sun/jndi/dns/DnsName;IIZZ)Lcom/sun/jndi/dns/ResourceRecords;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findNameServers", "(Lcom/sun/jndi/dns/DnsName;Z)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findZoneName", "(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/DnsName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "queryZone", "(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/ResourceRecords;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSoa", "(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/ResourceRecord;"));
	}

	[JniSignatureAttribute("Lcom/sun/jndi/dns/DnsClient;", "private")]
	public Dova.JDK.com.sun.jndi.dns.DnsClient dnsClient_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.DnsClient>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int timeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int retries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Resolver(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Ljava/lang/String;II)V", "")]
	public Resolver(JavaArray<Dova.JDK.java.lang.String> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/dns/Resolver;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;IIZZ)Lcom/sun/jndi/dns/ResourceRecords;", "")]
	public Dova.JDK.com.sun.jndi.dns.ResourceRecords query(Dova.JDK.com.sun.jndi.dns.DnsName arg0, int arg1, int arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.ResourceRecords>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;Z)[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> findNameServers(Dova.JDK.com.sun.jndi.dns.DnsName arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/DnsName;", "")]
	public Dova.JDK.com.sun.jndi.dns.DnsName findZoneName(Dova.JDK.com.sun.jndi.dns.DnsName arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.DnsName>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/ResourceRecords;", "")]
	public Dova.JDK.com.sun.jndi.dns.ResourceRecords queryZone(Dova.JDK.com.sun.jndi.dns.DnsName arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.ResourceRecords>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;IZ)Lcom/sun/jndi/dns/ResourceRecord;", "")]
	public Dova.JDK.com.sun.jndi.dns.ResourceRecord findSoa(Dova.JDK.com.sun.jndi.dns.DnsName arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.ResourceRecord>(ret);
	}
}
