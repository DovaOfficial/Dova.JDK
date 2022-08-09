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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/HostnameVerifier;", "public abstract interface")]
public partial interface HostnameVerifier
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HostnameVerifier()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/net/ssl/HostnameVerifier;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", "public abstract")]
	bool verify(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.net.ssl.SSLSession arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}
}