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

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/QueryExp;", "public abstract interface")]
public partial interface QueryExp
	: IJavaObject
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static QueryExp()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/QueryExp;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljavax/management/ObjectName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMBeanServer", "(Ljavax/management/MBeanServer;)V"));
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "public abstract")]
	bool apply(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "public abstract")]
	void setMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
