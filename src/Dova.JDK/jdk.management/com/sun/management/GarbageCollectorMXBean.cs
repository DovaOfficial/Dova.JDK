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

namespace Dova.JDK.com.sun.management;

[JniSignatureAttribute("Lcom/sun/management/GarbageCollectorMXBean;", "public abstract interface")]
public partial interface GarbageCollectorMXBean
	: IJavaObject
	, Dova.JDK.java.lang.management.GarbageCollectorMXBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GarbageCollectorMXBean()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/management/GarbageCollectorMXBean;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLastGcInfo", "()Lcom/sun/management/GcInfo;"));
	}

	[JniSignatureAttribute("()Lcom/sun/management/GcInfo;", "public abstract")]
	Dova.JDK.com.sun.management.GcInfo getLastGcInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.management.GcInfo>(ret);
	}
}
