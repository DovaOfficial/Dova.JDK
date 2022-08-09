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

namespace Dova.JDK.com.sun.security.jgss;

[JniSignatureAttribute("Lcom/sun/security/jgss/ExtendedGSSCredential;", "public abstract interface")]
public partial interface ExtendedGSSCredential
	: IJavaObject
	, Dova.JDK.org.ietf.jgss.GSSCredential
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedGSSCredential()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/security/jgss/ExtendedGSSCredential;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "impersonate", "(Lorg/ietf/jgss/GSSName;)Lorg/ietf/jgss/GSSCredential;"));
	}

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSName;)Lorg/ietf/jgss/GSSCredential;", "public abstract")]
	Dova.JDK.org.ietf.jgss.GSSCredential impersonate(Dova.JDK.org.ietf.jgss.GSSName arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.ietf.jgss.GSSCredential>(ret);
	}
}
