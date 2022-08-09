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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/nio/channels/ByteChannel;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
