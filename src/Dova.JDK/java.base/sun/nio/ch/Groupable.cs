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

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/Groupable;", "abstract interface")]
public partial interface Groupable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Groupable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/Groupable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Lsun/nio/ch/AsynchronousChannelGroupImpl;"));
	}

	[JniSignatureAttribute("()Lsun/nio/ch/AsynchronousChannelGroupImpl;", "public abstract")]
	Dova.JDK.sun.nio.ch.AsynchronousChannelGroupImpl group()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.AsynchronousChannelGroupImpl>(ret);
	}
}
