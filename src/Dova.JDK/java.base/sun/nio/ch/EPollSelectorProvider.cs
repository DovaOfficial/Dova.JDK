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

[JniSignatureAttribute("Lsun/nio/ch/EPollSelectorProvider;", "public")]
public partial class EPollSelectorProvider
	: Dova.JDK.sun.nio.ch.SelectorProviderImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EPollSelectorProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/EPollSelectorProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inheritedChannel", "()Ljava/nio/channels/Channel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openSelector", "()Ljava/nio/channels/spi/AbstractSelector;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EPollSelectorProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EPollSelectorProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/EPollSelectorProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/nio/channels/Channel;", "public")]
	public Dova.JDK.java.nio.channels.Channel inheritedChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.Channel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/spi/AbstractSelector;", "public")]
	public Dova.JDK.java.nio.channels.spi.AbstractSelector openSelector()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.AbstractSelector>(ret);
	}
}
