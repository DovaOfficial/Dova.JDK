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

namespace Dova.JDK.java.security.cert;

[JniSignatureAttribute("Ljava/security/cert/X509Extension;", "public abstract interface")]
public partial interface X509Extension
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X509Extension()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/cert/X509Extension;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExtensionValue", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCriticalExtensionOIDs", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasUnsupportedCriticalExtension", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public abstract")]
	JavaArray<byte> getExtensionValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getCriticalExtensionOIDs()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool hasUnsupportedCriticalExtension()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getNonCriticalExtensionOIDs()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}