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

namespace Dova.JDK.com.sun.jndi.ldap;

[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapSearchEnumeration;", "final")]
public partial class LdapSearchEnumeration
	: Dova.JDK.com.sun.jndi.ldap.AbstractLdapNamingEnumeration
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LdapSearchEnumeration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/ldap/LdapSearchEnumeration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startName", "Ljavax/naming/Name;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "searchArgs", "Lcom/sun/jndi/ldap/LdapCtx$SearchArgs;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acc", "Ljava/security/AccessControlContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jndi/ldap/LdapCtx;Lcom/sun/jndi/ldap/LdapResult;Ljava/lang/String;Lcom/sun/jndi/ldap/LdapCtx$SearchArgs;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Lcom/sun/jndi/ldap/AbstractLdapNamingEnumeration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createItem_0", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;Ljava/util/Vector;)Ljavax/naming/NameClassPair;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createItem_1", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;Ljava/util/Vector;)Ljavax/naming/directory/SearchResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferredResults", "(Lcom/sun/jndi/ldap/LdapReferralContext;)Lcom/sun/jndi/ldap/AbstractLdapNamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendUnprocessedReferrals", "(Lcom/sun/jndi/ldap/LdapReferralException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartName", "(Ljavax/naming/Name;)V"));
	}

	[JniSignatureAttribute("Ljavax/naming/Name;", "private")]
	public Dova.JDK.javax.naming.Name startName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Name>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jndi/ldap/LdapCtx$SearchArgs;", "private")]
	public Dova.JDK.com.sun.jndi.ldap.LdapCtx.SearchArgs searchArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.LdapCtx.SearchArgs>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private final")]
	public Dova.JDK.java.security.AccessControlContext acc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LdapSearchEnumeration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapCtx;Lcom/sun/jndi/ldap/LdapResult;Ljava/lang/String;Lcom/sun/jndi/ldap/LdapCtx$SearchArgs;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "")]
	public LdapSearchEnumeration(Dova.JDK.com.sun.jndi.ldap.LdapCtx arg0, Dova.JDK.com.sun.jndi.ldap.LdapResult arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.jndi.ldap.LdapCtx.SearchArgs arg3, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/ldap/LdapSearchEnumeration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/AbstractLdapNamingEnumeration;)V", "protected")]
	public void update(Dova.JDK.com.sun.jndi.ldap.AbstractLdapNamingEnumeration arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;Ljava/util/Vector;)Ljavax/naming/NameClassPair;", "protected volatile")]
	public Dova.JDK.javax.naming.NameClassPair createItem_0(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1, Dova.JDK.java.util.Vector arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NameClassPair>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;Ljava/util/Vector;)Ljavax/naming/directory/SearchResult;", "protected")]
	public Dova.JDK.javax.naming.directory.SearchResult createItem_1(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1, Dova.JDK.java.util.Vector arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapReferralContext;)Lcom/sun/jndi/ldap/AbstractLdapNamingEnumeration;", "protected")]
	public Dova.JDK.com.sun.jndi.ldap.AbstractLdapNamingEnumeration getReferredResults(Dova.JDK.com.sun.jndi.ldap.LdapReferralContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.ldap.AbstractLdapNamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jndi/ldap/LdapReferralException;)V", "public")]
	public void appendUnprocessedReferrals(Dova.JDK.com.sun.jndi.ldap.LdapReferralException arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)V", "")]
	public void setStartName(Dova.JDK.javax.naming.Name arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
