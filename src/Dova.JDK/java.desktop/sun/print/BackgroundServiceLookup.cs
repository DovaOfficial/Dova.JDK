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

namespace Dova.JDK.sun.print;

[JniSignatureAttribute("Lsun/print/BackgroundServiceLookup;", "public abstract interface")]
public partial interface BackgroundServiceLookup
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BackgroundServiceLookup()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/BackgroundServiceLookup;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServicesInbackground", "(Lsun/print/BackgroundLookupListener;)V"));
	}

	[JniSignatureAttribute("(Lsun/print/BackgroundLookupListener;)V", "public abstract")]
	void getServicesInbackground(Dova.JDK.sun.print.BackgroundLookupListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
