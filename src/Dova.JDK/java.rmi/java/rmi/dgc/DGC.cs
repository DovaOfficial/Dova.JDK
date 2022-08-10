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

namespace Dova.JDK.java.rmi.dgc;

[JniSignatureAttribute("Ljava/rmi/dgc/DGC;", "public abstract interface")]
public partial interface DGC
	: IJavaObject
	, Dova.JDK.java.rmi.Remote
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DGC()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/rmi/dgc/DGC;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clean", "([Ljava/rmi/server/ObjID;JLjava/rmi/dgc/VMID;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dirty", "([Ljava/rmi/server/ObjID;JLjava/rmi/dgc/Lease;)Ljava/rmi/dgc/Lease;"));
	}

	[JniSignatureAttribute("([Ljava/rmi/server/ObjID;JLjava/rmi/dgc/VMID;Z)V", "public abstract")]
	void clean(JavaArray<Dova.JDK.java.rmi.server.ObjID> arg0, long arg1, Dova.JDK.java.rmi.dgc.VMID arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/rmi/server/ObjID;JLjava/rmi/dgc/Lease;)Ljava/rmi/dgc/Lease;", "public abstract")]
	Dova.JDK.java.rmi.dgc.Lease dirty(JavaArray<Dova.JDK.java.rmi.server.ObjID> arg0, long arg1, Dova.JDK.java.rmi.dgc.Lease arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.dgc.Lease>(ret);
	}
}
