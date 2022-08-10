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

namespace Dova.JDK.com.sun.jndi.toolkit.dir;

[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/LazySearchEnumerationImpl;", "public final")]
public partial class LazySearchEnumerationImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.naming.NamingEnumeration
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LazySearchEnumerationImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/LazySearchEnumerationImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "candidates", "Ljavax/naming/NamingEnumeration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextMatch", "Ljavax/naming/directory/SearchResult;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cons", "Ljavax/naming/directory/SearchControls;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filter", "Lcom/sun/jndi/toolkit/dir/AttrFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "context", "Ljavax/naming/Context;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "env", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "useFactory", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LazySearchEnumerationImpl", "(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;Ljavax/naming/Context;Ljava/util/Hashtable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LazySearchEnumerationImpl", "(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;Ljavax/naming/Context;Ljava/util/Hashtable;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LazySearchEnumerationImpl", "(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next_0", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next_1", "()Ljavax/naming/directory/SearchResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasMoreElements", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextElement_0", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextElement_1", "()Ljavax/naming/directory/SearchResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasMore", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findNextMatch", "(Z)Ljavax/naming/directory/SearchResult;"));
	}

	[JniSignatureAttribute("Ljavax/naming/NamingEnumeration;", "private")]
	public Dova.JDK.javax.naming.NamingEnumeration candidates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.NamingEnumeration>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/naming/directory/SearchResult;", "private")]
	public Dova.JDK.javax.naming.directory.SearchResult nextMatch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchResult>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/naming/directory/SearchControls;", "private")]
	public Dova.JDK.javax.naming.directory.SearchControls cons_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchControls>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/AttrFilter;", "private")]
	public Dova.JDK.com.sun.jndi.toolkit.dir.AttrFilter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jndi.toolkit.dir.AttrFilter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/naming/Context;", "private")]
	public Dova.JDK.javax.naming.Context context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.Context>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private")]
	public Dova.JDK.java.util.Hashtable env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool useFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LazySearchEnumerationImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;Ljavax/naming/Context;Ljava/util/Hashtable;)V", "public")]
	public LazySearchEnumerationImpl(Dova.JDK.javax.naming.NamingEnumeration arg0, Dova.JDK.com.sun.jndi.toolkit.dir.AttrFilter arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.javax.naming.Context arg3, Dova.JDK.java.util.Hashtable arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;Ljavax/naming/Context;Ljava/util/Hashtable;Z)V", "public")]
	public LazySearchEnumerationImpl(Dova.JDK.javax.naming.NamingEnumeration arg0, Dova.JDK.com.sun.jndi.toolkit.dir.AttrFilter arg1, Dova.JDK.javax.naming.directory.SearchControls arg2, Dova.JDK.javax.naming.Context arg3, Dova.JDK.java.util.Hashtable arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljavax/naming/NamingEnumeration;Lcom/sun/jndi/toolkit/dir/AttrFilter;Ljavax/naming/directory/SearchControls;)V", "public")]
	public LazySearchEnumerationImpl(Dova.JDK.javax.naming.NamingEnumeration arg0, Dova.JDK.com.sun.jndi.toolkit.dir.AttrFilter arg1, Dova.JDK.javax.naming.directory.SearchControls arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jndi/toolkit/dir/LazySearchEnumerationImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object next_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/naming/directory/SearchResult;", "public")]
	public Dova.JDK.javax.naming.directory.SearchResult next_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchResult>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasMoreElements()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object nextElement_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/naming/directory/SearchResult;", "public")]
	public Dova.JDK.javax.naming.directory.SearchResult nextElement_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchResult>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasMore()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljavax/naming/directory/SearchResult;", "private")]
	public Dova.JDK.javax.naming.directory.SearchResult findNextMatch(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.naming.directory.SearchResult>(ret);
	}
}
