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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaUtilResourceBundleAccess;", "public abstract interface")]
public partial interface JavaUtilResourceBundleAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaUtilResourceBundleAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaUtilResourceBundleAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "(Ljava/util/ResourceBundle;)Ljava/util/ResourceBundle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setName", "(Ljava/util/ResourceBundle;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/ResourceBundle;Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParent", "(Ljava/util/ResourceBundle;Ljava/util/ResourceBundle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/Module;)Ljava/util/ResourceBundle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newResourceBundle", "(Ljava/lang/Class;)Ljava/util/ResourceBundle;"));
	}

	[JniSignatureAttribute("(Ljava/util/ResourceBundle;)Ljava/util/ResourceBundle;", "public abstract")]
	Dova.JDK.java.util.ResourceBundle getParent(Dova.JDK.java.util.ResourceBundle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/ResourceBundle;Ljava/lang/String;)V", "public abstract")]
	void setName(Dova.JDK.java.util.ResourceBundle arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/ResourceBundle;Ljava/util/Locale;)V", "public abstract")]
	void setLocale(Dova.JDK.java.util.ResourceBundle arg0, Dova.JDK.java.util.Locale arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/ResourceBundle;Ljava/util/ResourceBundle;)V", "public abstract")]
	void setParent(Dova.JDK.java.util.ResourceBundle arg0, Dova.JDK.java.util.ResourceBundle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/Module;)Ljava/util/ResourceBundle;", "public abstract")]
	Dova.JDK.java.util.ResourceBundle getBundle(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.lang.Module arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/ResourceBundle;", "public abstract")]
	Dova.JDK.java.util.ResourceBundle newResourceBundle(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
	}
}
