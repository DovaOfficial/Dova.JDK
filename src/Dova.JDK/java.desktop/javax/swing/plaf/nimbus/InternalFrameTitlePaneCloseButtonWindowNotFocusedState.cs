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

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/InternalFrameTitlePaneCloseButtonWindowNotFocusedState;", "")]
public partial class InternalFrameTitlePaneCloseButtonWindowNotFocusedState
	: Dova.JDK.javax.swing.plaf.nimbus.State
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InternalFrameTitlePaneCloseButtonWindowNotFocusedState()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/plaf/nimbus/InternalFrameTitlePaneCloseButtonWindowNotFocusedState;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InternalFrameTitlePaneCloseButtonWindowNotFocusedState", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isInState", "(Ljavax/swing/JComponent;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InternalFrameTitlePaneCloseButtonWindowNotFocusedState(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public InternalFrameTitlePaneCloseButtonWindowNotFocusedState() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/InternalFrameTitlePaneCloseButtonWindowNotFocusedState;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Z", "protected")]
	public bool isInState(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
