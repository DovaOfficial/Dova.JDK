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

namespace Dova.JDK.javax.print.@event;

[JniSignatureAttribute("Ljavax/print/event/PrintJobAttributeListener;", "public abstract interface")]
public partial interface PrintJobAttributeListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintJobAttributeListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/event/PrintJobAttributeListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attributeUpdate", "(Ljavax/print/event/PrintJobAttributeEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobAttributeEvent;)V", "public abstract")]
	void attributeUpdate(Dova.JDK.javax.print.@event.PrintJobAttributeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
