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

namespace Dova.JDK.java.nio.channels;

[JniSignatureAttribute("Ljava/nio/channels/GatheringByteChannel;", "public abstract interface")]
public partial interface GatheringByteChannel
	: IJavaObject
	, Dova.JDK.java.nio.channels.WritableByteChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GatheringByteChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/GatheringByteChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;II)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "([Ljava/nio/ByteBuffer;)J"));
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;II)J", "public abstract")]
	long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;)J", "public abstract")]
	long write(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}
}
