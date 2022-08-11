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

namespace Dova.JDK.com.sun.jdi.request;

[JniSignatureAttribute("Lcom/sun/jdi/request/ThreadDeathRequest;", "public abstract interface")]
public partial interface ThreadDeathRequest
	: IJavaObject
	, Dova.JDK.com.sun.jdi.request.EventRequest
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ThreadDeathRequest()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/request/ThreadDeathRequest;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addThreadFilter", "(Lcom/sun/jdi/ThreadReference;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;)V", "public abstract")]
	void addThreadFilter(Dova.JDK.com.sun.jdi.ThreadReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
