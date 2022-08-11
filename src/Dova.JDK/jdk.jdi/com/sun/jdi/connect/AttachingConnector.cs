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

namespace Dova.JDK.com.sun.jdi.connect;

[JniSignatureAttribute("Lcom/sun/jdi/connect/AttachingConnector;", "public abstract interface")]
public partial interface AttachingConnector
	: IJavaObject
	, Dova.JDK.com.sun.jdi.connect.Connector
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttachingConnector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/connect/AttachingConnector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attach", "(Ljava/util/Map;)Lcom/sun/jdi/VirtualMachine;"));
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Lcom/sun/jdi/VirtualMachine;", "public abstract")]
	Dova.JDK.com.sun.jdi.VirtualMachine attach(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}
}
