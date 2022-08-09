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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/TerminalSink;", "abstract interface")]
public partial interface TerminalSink
	: IJavaObject
	, Dova.JDK.java.util.stream.Sink
	, Dova.JDK.java.util.function.Supplier
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static TerminalSink()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/util/stream/TerminalSink;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
