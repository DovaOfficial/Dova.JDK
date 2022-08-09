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

namespace Dova.JDK.java.awt.@event;

[JniSignatureAttribute("Ljava/awt/event/KeyAdapter;", "public abstract")]
public partial class KeyAdapter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.@event.KeyListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyAdapter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/event/KeyAdapter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "KeyAdapter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "keyTyped", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "keyPressed", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "keyReleased", "(Ljava/awt/event/KeyEvent;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public KeyAdapter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/event/KeyAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyTyped(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyPressed(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void keyReleased(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
