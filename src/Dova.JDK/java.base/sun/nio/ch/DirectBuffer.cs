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

[JniSignatureAttribute("Lsun/nio/ch/DirectBuffer;", "public abstract interface")]
public partial interface DirectBuffer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DirectBuffer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/DirectBuffer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleaner", "()Ljdk/internal/ref/Cleaner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attachment", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "address", "()J"));
	}

	[JniSignatureAttribute("()Ljdk/internal/ref/Cleaner;", "public abstract")]
	Dova.JDK.jdk.@internal.@ref.Cleaner cleaner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.@ref.Cleaner>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object attachment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long address()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}
}
