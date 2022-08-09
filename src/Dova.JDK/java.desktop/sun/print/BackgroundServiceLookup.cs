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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/print/BackgroundServiceLookup;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getServicesInbackground", "(Lsun/print/BackgroundLookupListener;)V"));
	}

	[JniSignatureAttribute("(Lsun/print/BackgroundLookupListener;)V", "public abstract")]
	void getServicesInbackground(Dova.JDK.sun.print.BackgroundLookupListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
