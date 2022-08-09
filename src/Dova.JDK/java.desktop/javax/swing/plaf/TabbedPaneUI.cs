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

namespace Dova.JDK.javax.swing.plaf;

[JniSignatureAttribute("Ljavax/swing/plaf/TabbedPaneUI;", "public abstract")]
public partial class TabbedPaneUI
	: Dova.JDK.javax.swing.plaf.ComponentUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TabbedPaneUI()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/plaf/TabbedPaneUI;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TabbedPaneUI", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "tabForCoordinate", "(Ljavax/swing/JTabbedPane;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTabBounds", "(Ljavax/swing/JTabbedPane;I)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTabRunCount", "(Ljavax/swing/JTabbedPane;)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TabbedPaneUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public TabbedPaneUI() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/TabbedPaneUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JTabbedPane;II)I", "public abstract")]
	public int tabForCoordinate(Dova.JDK.javax.swing.JTabbedPane arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JTabbedPane;I)Ljava/awt/Rectangle;", "public abstract")]
	public Dova.JDK.java.awt.Rectangle getTabBounds(Dova.JDK.javax.swing.JTabbedPane arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTabbedPane;)I", "public abstract")]
	public int getTabRunCount(Dova.JDK.javax.swing.JTabbedPane arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}
}