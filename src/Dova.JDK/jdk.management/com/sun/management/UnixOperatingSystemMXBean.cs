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

namespace Dova.JDK.com.sun.management;

[JniSignatureAttribute("Lcom/sun/management/UnixOperatingSystemMXBean;", "public abstract interface")]
public partial interface UnixOperatingSystemMXBean
	: IJavaObject
	, Dova.JDK.com.sun.management.OperatingSystemMXBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixOperatingSystemMXBean()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/management/UnixOperatingSystemMXBean;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpenFileDescriptorCount", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxFileDescriptorCount", "()J"));
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getOpenFileDescriptorCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getMaxFileDescriptorCount()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}
}
