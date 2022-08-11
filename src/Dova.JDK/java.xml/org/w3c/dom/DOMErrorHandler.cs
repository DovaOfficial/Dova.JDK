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

namespace Dova.JDK.org.w3c.dom;

[JniSignatureAttribute("Lorg/w3c/dom/DOMErrorHandler;", "public abstract interface")]
public partial interface DOMErrorHandler
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMErrorHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/DOMErrorHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleError", "(Lorg/w3c/dom/DOMError;)Z"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMError;)Z", "public abstract")]
	bool handleError(Dova.JDK.org.w3c.dom.DOMError arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
