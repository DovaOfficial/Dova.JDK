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

[JniSignatureAttribute("Ljava/nio/channels/ByteChannel;", "public abstract interface")]
public partial interface ByteChannel
	: IJavaObject
	, Dova.JDK.java.nio.channels.ReadableByteChannel
	, Dova.JDK.java.nio.channels.WritableByteChannel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static ByteChannel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/channels/ByteChannel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
