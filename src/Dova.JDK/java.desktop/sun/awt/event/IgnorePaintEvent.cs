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

namespace Dova.JDK.sun.awt.@event;

[JniSignatureAttribute("Lsun/awt/event/IgnorePaintEvent;", "public")]
public partial class IgnorePaintEvent
	: Dova.JDK.java.awt.@event.PaintEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IgnorePaintEvent()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/event/IgnorePaintEvent;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "IgnorePaintEvent", "(Ljava/awt/Component;ILjava/awt/Rectangle;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IgnorePaintEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;ILjava/awt/Rectangle;)V", "public")]
	public IgnorePaintEvent(Dova.JDK.java.awt.Component arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/event/IgnorePaintEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}