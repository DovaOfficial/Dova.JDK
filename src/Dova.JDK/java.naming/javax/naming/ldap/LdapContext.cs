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

namespace Dova.JDK.javax.naming.ldap;

[JniSignatureAttribute("Ljavax/naming/ldap/LdapContext;", "public abstract interface")]
public partial interface LdapContext
	: IJavaObject
	, Dova.JDK.javax.naming.directory.DirContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LdapContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/ldap/LdapContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTROL_FACTORIES", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "([Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/LdapContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extendedOperation", "(Ljavax/naming/ldap/ExtendedRequest;)Ljavax/naming/ldap/ExtendedResponse;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reconnect", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnectControls", "()[Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRequestControls", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRequestControls", "()[Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResponseControls", "()[Ljavax/naming/ldap/Control;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CONTROL_FACTORIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/LdapContext;", "public abstract")]
	Dova.JDK.javax.naming.ldap.LdapContext newInstance(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.LdapContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/ldap/ExtendedRequest;)Ljavax/naming/ldap/ExtendedResponse;", "public abstract")]
	Dova.JDK.javax.naming.ldap.ExtendedResponse extendedOperation(Dova.JDK.javax.naming.ldap.ExtendedRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.ExtendedResponse>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "public abstract")]
	void reconnect(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public abstract")]
	JavaArray<Dova.JDK.javax.naming.ldap.Control> getConnectControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "public abstract")]
	void setRequestControls(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public abstract")]
	JavaArray<Dova.JDK.javax.naming.ldap.Control> getRequestControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public abstract")]
	JavaArray<Dova.JDK.javax.naming.ldap.Control> getResponseControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}
}
