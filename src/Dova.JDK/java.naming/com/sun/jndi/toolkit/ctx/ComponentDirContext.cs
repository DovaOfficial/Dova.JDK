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

namespace Dova.JDK.com.sun.jndi.toolkit.ctx;

[JniSignatureAttribute("Lcom/sun/jndi/toolkit/ctx/ComponentDirContext;", "public abstract")]
public partial class ComponentDirContext
	: Dova.JDK.com.sun.jndi.toolkit.ctx.PartialCompositeDirContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ComponentDirContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/ctx/ComponentDirContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getAttributes_nns", "(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_modifyAttributes_nns", "(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_modifyAttributes_nns", "(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_bind_nns", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_rebind_nns", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_createSubcontext_nns", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search_nns", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search_nns", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search_nns", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getSchema_nns", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getSchemaClassDefinition_nns", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_getAttributes", "(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_modifyAttributes", "(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_modifyAttributes", "(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_bind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_rebind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_createSubcontext", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_search", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_search", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_getSchema", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "p_getSchemaClassDefinition", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_bind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_rebind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_createSubcontext", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getAttributes", "(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_modifyAttributes", "(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_modifyAttributes", "(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_search", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getSchema", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "c_getSchemaClassDefinition", "(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ComponentDirContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public ComponentDirContext() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/ctx/ComponentDirContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;", "protected")]
	public Dova.JDK.javax.naming.directory.Attributes c_getAttributes_nns(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void c_modifyAttributes_nns(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void c_modifyAttributes_nns(Dova.JDK.javax.naming.Name arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void c_bind_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void c_rebind_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext c_createSubcontext_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext c_getSchema_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext c_getSchemaClassDefinition_nns(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;", "protected")]
	public Dova.JDK.javax.naming.directory.Attributes p_getAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void p_modifyAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void p_modifyAttributes(Dova.JDK.javax.naming.Name arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void p_bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected")]
	public void p_rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext p_createSubcontext(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration p_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration p_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected")]
	public Dova.JDK.javax.naming.NamingEnumeration p_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext p_getSchema(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext p_getSchemaClassDefinition(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected abstract")]
	public void c_bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected abstract")]
	public void c_rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected abstract")]
	public Dova.JDK.javax.naming.directory.DirContext c_createSubcontext(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/Attributes;", "protected abstract")]
	public Dova.JDK.javax.naming.directory.Attributes c_getAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected abstract")]
	public void c_modifyAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;Lcom/sun/jndi/toolkit/ctx/Continuation;)V", "protected abstract")]
	public void c_modifyAttributes(Dova.JDK.javax.naming.Name arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected abstract")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected abstract")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/NamingEnumeration;", "protected abstract")]
	public Dova.JDK.javax.naming.NamingEnumeration c_search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected abstract")]
	public Dova.JDK.javax.naming.directory.DirContext c_getSchema(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Lcom/sun/jndi/toolkit/ctx/Continuation;)Ljavax/naming/directory/DirContext;", "protected abstract")]
	public Dova.JDK.javax.naming.directory.DirContext c_getSchemaClassDefinition(Dova.JDK.javax.naming.Name arg0, Dova.JDK.com.sun.jndi.toolkit.ctx.Continuation arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}
}
