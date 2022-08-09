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

[JniSignatureAttribute("Ljava/nio/channels/SelectableChannel;", "public abstract")]
public partial class SelectableChannel
	: Dova.JDK.java.nio.channels.spi.AbstractInterruptibleChannel
	, Dova.JDK.java.nio.channels.Channel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SelectableChannel()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/nio/channels/SelectableChannel;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SelectableChannel", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isRegistered", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "blockingLock", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isBlocking", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "validOps", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SelectableChannel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SelectableChannel() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/channels/SelectableChannel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isRegistered()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;", "public final")]
	public Dova.JDK.java.nio.channels.SelectionKey register(Dova.JDK.java.nio.channels.Selector arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SelectionKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;", "public abstract")]
	public Dova.JDK.java.nio.channels.SelectionKey register(Dova.JDK.java.nio.channels.Selector arg0, int arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SelectionKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/spi/SelectorProvider;", "public abstract")]
	public Dova.JDK.java.nio.channels.spi.SelectorProvider provider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.spi.SelectorProvider>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/nio/channels/SelectableChannel;", "public abstract")]
	public Dova.JDK.java.nio.channels.SelectableChannel configureBlocking(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SelectableChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object blockingLock()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isBlocking()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int validOps()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;", "public abstract")]
	public Dova.JDK.java.nio.channels.SelectionKey keyFor(Dova.JDK.java.nio.channels.Selector arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SelectionKey>(ret);
	}
}