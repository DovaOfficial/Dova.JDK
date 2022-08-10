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

namespace Dova.JDK.sun.java2d;

[JniSignatureAttribute("Lsun/java2d/BackBufferCapsProvider;", "public abstract interface")]
public partial interface BackBufferCapsProvider
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BackBufferCapsProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/BackBufferCapsProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBackBufferCaps", "()Ljava/awt/BufferCapabilities;"));
	}

	[JniSignatureAttribute("()Ljava/awt/BufferCapabilities;", "public abstract")]
	Dova.JDK.java.awt.BufferCapabilities getBackBufferCaps()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.BufferCapabilities>(ret);
	}
}
