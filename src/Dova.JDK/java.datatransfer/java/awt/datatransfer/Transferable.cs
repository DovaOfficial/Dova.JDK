/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt.datatransfer;

[JniSignatureAttribute("Ljava/awt/datatransfer/Transferable;", "public abstract interface")]
public partial interface Transferable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Transferable()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/datatransfer/Transferable;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTransferDataFlavors", "()[Ljava/awt/datatransfer/DataFlavor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isDataFlavorSupported", "(Ljava/awt/datatransfer/DataFlavor;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTransferData", "(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("()[Ljava/awt/datatransfer/DataFlavor;", "public abstract")]
	JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor> getTransferDataFlavors()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.datatransfer.DataFlavor>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Z", "public abstract")]
	bool isDataFlavorSupported(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/datatransfer/DataFlavor;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getTransferData(Dova.JDK.java.awt.datatransfer.DataFlavor arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}