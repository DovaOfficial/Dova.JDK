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

namespace Dova.JDK.sun.nio;

[JniSignatureAttribute("Lsun/nio/ByteBuffered;", "public abstract interface")]
public partial interface ByteBuffered
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ByteBuffered()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ByteBuffered;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteBuffer", "()Ljava/nio/ByteBuffer;"));
	}

	[JniSignatureAttribute("()Ljava/nio/ByteBuffer;", "public abstract")]
	Dova.JDK.java.nio.ByteBuffer getByteBuffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}
}
