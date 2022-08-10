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

namespace Dova.JDK.javax.print.@event;

[JniSignatureAttribute("Ljavax/print/event/PrintServiceAttributeListener;", "public abstract interface")]
public partial interface PrintServiceAttributeListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintServiceAttributeListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/event/PrintServiceAttributeListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "attributeUpdate", "(Ljavax/print/event/PrintServiceAttributeEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintServiceAttributeEvent;)V", "public abstract")]
	void attributeUpdate(Dova.JDK.javax.print.@event.PrintServiceAttributeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
