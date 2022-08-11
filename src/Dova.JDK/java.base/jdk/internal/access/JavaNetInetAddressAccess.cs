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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaNetInetAddressAccess;", "public abstract interface")]
public partial interface JavaNetInetAddressAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaNetInetAddressAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaNetInetAddressAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addressValue", "(Ljava/net/Inet4Address;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addressBytes", "(Ljava/net/Inet6Address;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalHostName", "(Ljava/net/InetAddress;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(Ljava/net/Inet4Address;)I", "public abstract")]
	int addressValue(Dova.JDK.java.net.Inet4Address arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/net/Inet6Address;)[B", "public abstract")]
	JavaArray<byte> addressBytes(Dova.JDK.java.net.Inet6Address arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getOriginalHostName(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
