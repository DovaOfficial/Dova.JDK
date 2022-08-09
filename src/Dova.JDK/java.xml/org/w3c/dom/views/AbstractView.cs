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

namespace Dova.JDK.org.w3c.dom.views;

[JniSignatureAttribute("Lorg/w3c/dom/views/AbstractView;", "public abstract interface")]
public partial interface AbstractView
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractView()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/w3c/dom/views/AbstractView;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDocument", "()Lorg/w3c/dom/views/DocumentView;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/views/DocumentView;", "public abstract")]
	Dova.JDK.org.w3c.dom.views.DocumentView getDocument()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.views.DocumentView>(ret);
	}
}
