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

namespace Dova.JDK.java.awt.@event;

[JniSignatureAttribute("Ljava/awt/event/AWTEventListener;", "public abstract interface")]
public partial interface AWTEventListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AWTEventListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/event/AWTEventListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "eventDispatched", "(Ljava/awt/AWTEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "public abstract")]
	void eventDispatched(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}