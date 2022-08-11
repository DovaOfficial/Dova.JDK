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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/DatagramSocketImplFactory;", "public abstract interface")]
public partial interface DatagramSocketImplFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DatagramSocketImplFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/DatagramSocketImplFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;"));
	}

	[JniSignatureAttribute("()Ljava/net/DatagramSocketImpl;", "public abstract")]
	Dova.JDK.java.net.DatagramSocketImpl createDatagramSocketImpl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.DatagramSocketImpl>(ret);
	}
}
