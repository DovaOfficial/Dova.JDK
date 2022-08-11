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

namespace Dova.JDK.com.sun.jndi.toolkit.url;

[JniSignatureAttribute("Lcom/sun/jndi/toolkit/url/GenericURLDirContext;", "public abstract")]
public partial class GenericURLDirContext
	: Dova.JDK.com.sun.jndi.toolkit.url.GenericURLContext
	, Dova.JDK.javax.naming.directory.DirContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GenericURLDirContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/url/GenericURLDirContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Hashtable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebind", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/naming/Name;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljavax/naming/Name;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;)Ljavax/naming/directory/Attributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchema", "(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchema", "(Ljava/lang/String;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljava/lang/String;ILjavax/naming/directory/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifyAttributes", "(Ljava/lang/String;[Ljavax/naming/directory/ModificationItem;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSubcontext", "(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaClassDefinition", "(Ljava/lang/String;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSchemaClassDefinition", "(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContinuationDirContext", "(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GenericURLDirContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;)V", "protected")]
	public GenericURLDirContext(Dova.JDK.java.util.Hashtable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/url/GenericURLDirContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void rebind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void rebind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/Attributes;", "public")]
	public Dova.JDK.javax.naming.directory.Attributes getAttributes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.Attributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.javax.naming.directory.SearchControls arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/naming/directory/SearchControls;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.naming.directory.SearchControls arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;[Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", "public")]
	public Dova.JDK.javax.naming.NamingEnumeration search(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void bind(Dova.JDK.javax.naming.Name arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljavax/naming/directory/Attributes;)V", "public")]
	public void bind(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchema(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchema(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;ILjavax/naming/directory/Attributes;)V", "public")]
	public void modifyAttributes(Dova.JDK.javax.naming.Name arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjavax/naming/directory/Attributes;)V", "public")]
	public void modifyAttributes(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.javax.naming.directory.Attributes arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;[Ljavax/naming/directory/ModificationItem;)V", "public")]
	public void modifyAttributes(Dova.JDK.javax.naming.Name arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljavax/naming/directory/ModificationItem;)V", "public")]
	public void modifyAttributes(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.javax.naming.directory.ModificationItem> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext createSubcontext(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;Ljavax/naming/directory/Attributes;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext createSubcontext(Dova.JDK.javax.naming.Name arg0, Dova.JDK.javax.naming.directory.Attributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchemaClassDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;", "public")]
	public Dova.JDK.javax.naming.directory.DirContext getSchemaClassDefinition(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/naming/Name;)Ljavax/naming/directory/DirContext;", "protected")]
	public Dova.JDK.javax.naming.directory.DirContext getContinuationDirContext(Dova.JDK.javax.naming.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.DirContext>(ret);
	}
}
