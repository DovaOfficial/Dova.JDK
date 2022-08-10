/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/naming/ldap/InitialLdapContext;", "public")]
public partial class InitialLdapContext
	: Dova.JDK.javax.naming.directory.InitialDirContext
	, Dova.JDK.javax.naming.ldap.LdapContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InitialLdapContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/ldap/InitialLdapContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BIND_CONTROLS_PROPERTY", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InitialLdapContext", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InitialLdapContext", "(Ljava/util/Hashtable;[Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newInstance", "([Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/LdapContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extendedOperation", "(Ljavax/naming/ldap/ExtendedRequest;)Ljavax/naming/ldap/ExtendedResponse;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reconnect", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConnectControls", "()[Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setRequestControls", "([Ljavax/naming/ldap/Control;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRequestControls", "()[Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResponseControls", "()[Ljavax/naming/ldap/Control;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultLdapInitCtx", "()Ljavax/naming/ldap/LdapContext;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String BIND_CONTROLS_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InitialLdapContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public InitialLdapContext() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;[Ljavax/naming/ldap/Control;)V", "public")]
	public InitialLdapContext(Dova.JDK.java.util.Hashtable arg0, JavaArray<Dova.JDK.javax.naming.ldap.Control> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/naming/ldap/InitialLdapContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)Ljavax/naming/ldap/LdapContext;", "public")]
	public Dova.JDK.javax.naming.ldap.LdapContext newInstance(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.LdapContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/ldap/ExtendedRequest;)Ljavax/naming/ldap/ExtendedResponse;", "public")]
	public Dova.JDK.javax.naming.ldap.ExtendedResponse extendedOperation(Dova.JDK.javax.naming.ldap.ExtendedRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.ExtendedResponse>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "public")]
	public void reconnect(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public")]
	public JavaArray<Dova.JDK.javax.naming.ldap.Control> getConnectControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/naming/ldap/Control;)V", "public")]
	public void setRequestControls(JavaArray<Dova.JDK.javax.naming.ldap.Control> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public")]
	public JavaArray<Dova.JDK.javax.naming.ldap.Control> getRequestControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/naming/ldap/Control;", "public")]
	public JavaArray<Dova.JDK.javax.naming.ldap.Control> getResponseControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.naming.ldap.Control>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/naming/ldap/LdapContext;", "private")]
	public Dova.JDK.javax.naming.ldap.LdapContext getDefaultLdapInitCtx()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.ldap.LdapContext>(ret);
	}
}
