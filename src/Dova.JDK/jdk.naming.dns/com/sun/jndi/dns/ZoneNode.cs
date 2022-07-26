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

[JniSignatureAttribute("Lcom/sun/jndi/dns/ZoneNode;", "")]
public partial class ZoneNode
	: Dova.JDK.com.sun.jndi.dns.NameNode
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZoneNode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/dns/ZoneNode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentsRef", "Ljava/lang/ref/SoftReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serialNumber", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expiration", "Ljava/util/Date;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContents", "()Lcom/sun/jndi/dns/NameNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMinimumTtl", "(Lcom/sun/jndi/dns/ResourceRecord;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpiration", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpired", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSerialNumber", "(Lcom/sun/jndi/dns/ResourceRecord;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeepestPopulated", "(Lcom/sun/jndi/dns/DnsName;)Lcom/sun/jndi/dns/ZoneNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "depopulate", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPopulated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populate", "(Lcom/sun/jndi/dns/DnsName;Lcom/sun/jndi/dns/ResourceRecords;)Lcom/sun/jndi/dns/NameNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareSerialNumberTo", "(Lcom/sun/jndi/dns/ResourceRecord;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newNameNode", "(Ljava/lang/String;)Lcom/sun/jndi/dns/NameNode;"));
	}

	[JniSignatureAttribute("Ljava/lang/ref/SoftReference;", "private")]
	public Dova.JDK.java.lang.@ref.SoftReference contentsRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.SoftReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long serialNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Date;", "private")]
	public Dova.JDK.java.util.Date expiration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZoneNode(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public ZoneNode(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/dns/ZoneNode;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/jndi/dns/NameNode;", "synchronized")]
	public Dova.JDK.com.sun.jndi.dns.NameNode getContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.NameNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/ResourceRecord;)J", "private static")]
	public static long getMinimumTtl(Dova.JDK.com.sun.jndi.dns.ResourceRecord arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void setExpiration(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Z", "synchronized")]
	public bool isExpired()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/ResourceRecord;)J", "private static")]
	public static long getSerialNumber(Dova.JDK.com.sun.jndi.dns.ResourceRecord arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;)Lcom/sun/jndi/dns/ZoneNode;", "")]
	public Dova.JDK.com.sun.jndi.dns.ZoneNode getDeepestPopulated(Dova.JDK.com.sun.jndi.dns.DnsName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.ZoneNode>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void depopulate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Z", "synchronized")]
	public bool isPopulated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/DnsName;Lcom/sun/jndi/dns/ResourceRecords;)Lcom/sun/jndi/dns/NameNode;", "")]
	public Dova.JDK.com.sun.jndi.dns.NameNode populate(Dova.JDK.com.sun.jndi.dns.DnsName arg0, Dova.JDK.com.sun.jndi.dns.ResourceRecords arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.NameNode>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/dns/ResourceRecord;)I", "")]
	public int compareSerialNumberTo(Dova.JDK.com.sun.jndi.dns.ResourceRecord arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jndi/dns/NameNode;", "protected")]
	public Dova.JDK.com.sun.jndi.dns.NameNode newNameNode(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.dns.NameNode>(ret);
	}
}
