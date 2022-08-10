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

namespace Dova.JDK.jdk.dynalink;

[JniSignatureAttribute("Ljdk/dynalink/Operation;", "public abstract interface")]
public partial interface Operation
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Operation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/Operation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "named", "(Ljava/lang/Object;)Ljdk/dynalink/NamedOperation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withNamespaces", "([Ljdk/dynalink/Namespace;)Ljdk/dynalink/NamespaceOperation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withNamespace", "(Ljdk/dynalink/Namespace;)Ljdk/dynalink/NamespaceOperation;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/dynalink/NamedOperation;", "public")]
	Dova.JDK.jdk.dynalink.NamedOperation named(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.NamedOperation>(ret);
	}

	[JniSignatureAttribute("([Ljdk/dynalink/Namespace;)Ljdk/dynalink/NamespaceOperation;", "public transient")]
	Dova.JDK.jdk.dynalink.NamespaceOperation withNamespaces(JavaArray<Dova.JDK.jdk.dynalink.Namespace> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.NamespaceOperation>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/Namespace;)Ljdk/dynalink/NamespaceOperation;", "public")]
	Dova.JDK.jdk.dynalink.NamespaceOperation withNamespace(Dova.JDK.jdk.dynalink.Namespace arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.NamespaceOperation>(ret);
	}
}
