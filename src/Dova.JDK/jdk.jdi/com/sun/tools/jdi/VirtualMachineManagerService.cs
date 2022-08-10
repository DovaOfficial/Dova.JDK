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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/VirtualMachineManagerService;", "public abstract interface")]
public partial interface VirtualMachineManagerService
	: IJavaObject
	, Dova.JDK.com.sun.jdi.VirtualMachineManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VirtualMachineManagerService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/VirtualMachineManagerService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addConnector", "(Lcom/sun/jdi/connect/Connector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDefaultConnector", "(Lcom/sun/jdi/connect/LaunchingConnector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeConnector", "(Lcom/sun/jdi/connect/Connector;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/Connector;)V", "public abstract")]
	void addConnector(Dova.JDK.com.sun.jdi.connect.Connector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/LaunchingConnector;)V", "public abstract")]
	void setDefaultConnector(Dova.JDK.com.sun.jdi.connect.LaunchingConnector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/Connector;)V", "public abstract")]
	void removeConnector(Dova.JDK.com.sun.jdi.connect.Connector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
