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

namespace Dova.JDK.javax.imageio.spi;

[JniSignatureAttribute("Ljavax/imageio/spi/RegisterableService;", "public abstract interface")]
public partial interface RegisterableService
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RegisterableService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/spi/RegisterableService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onRegistration", "(Ljavax/imageio/spi/ServiceRegistry;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "onDeregistration", "(Ljavax/imageio/spi/ServiceRegistry;Ljava/lang/Class;)V"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/spi/ServiceRegistry;Ljava/lang/Class;)V", "public abstract")]
	void onRegistration(Dova.JDK.javax.imageio.spi.ServiceRegistry arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/spi/ServiceRegistry;Ljava/lang/Class;)V", "public abstract")]
	void onDeregistration(Dova.JDK.javax.imageio.spi.ServiceRegistry arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
