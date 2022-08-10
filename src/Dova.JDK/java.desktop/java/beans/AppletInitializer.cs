/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.beans;

[JniSignatureAttribute("Ljava/beans/AppletInitializer;", "public abstract interface")]
public partial interface AppletInitializer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AppletInitializer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/AppletInitializer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "initialize", "(Ljava/applet/Applet;Ljava/beans/beancontext/BeanContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activate", "(Ljava/applet/Applet;)V"));
	}

	[JniSignatureAttribute("(Ljava/applet/Applet;Ljava/beans/beancontext/BeanContext;)V", "public abstract")]
	void initialize(Dova.JDK.java.applet.Applet arg0, Dova.JDK.java.beans.beancontext.BeanContext arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/applet/Applet;)V", "public abstract")]
	void activate(Dova.JDK.java.applet.Applet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
