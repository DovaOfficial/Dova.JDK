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

namespace Dova.JDK.java.beans.beancontext;

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContext;", "public abstract interface")]
public partial interface BeanContext
	: IJavaObject
	, Dova.JDK.java.beans.beancontext.BeanContextChild
	, Dova.JDK.java.util.Collection
	, Dova.JDK.java.beans.DesignMode
	, Dova.JDK.java.beans.Visibility
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "globalHierarchyLock", "Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResource", "(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiateChild", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBeanContextMembershipListener", "(Ljava/beans/beancontext/BeanContextMembershipListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeBeanContextMembershipListener", "(Ljava/beans/beancontext/BeanContextMembershipListener;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "public static final")]
	public static Dova.JDK.java.lang.Object globalHierarchyLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/io/InputStream;", "public abstract")]
	Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.beancontext.BeanContextChild arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/beancontext/BeanContextChild;)Ljava/net/URL;", "public abstract")]
	Dova.JDK.java.net.URL getResource(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.beancontext.BeanContextChild arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object instantiateChild(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextMembershipListener;)V", "public abstract")]
	void addBeanContextMembershipListener(Dova.JDK.java.beans.beancontext.BeanContextMembershipListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextMembershipListener;)V", "public abstract")]
	void removeBeanContextMembershipListener(Dova.JDK.java.beans.beancontext.BeanContextMembershipListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
