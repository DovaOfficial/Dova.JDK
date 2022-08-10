/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/LegacyLayoutFocusTraversalPolicy;", "final")]
public partial class LegacyLayoutFocusTraversalPolicy
	: Dova.JDK.javax.swing.LayoutFocusTraversalPolicy
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LegacyLayoutFocusTraversalPolicy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/LegacyLayoutFocusTraversalPolicy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LegacyLayoutFocusTraversalPolicy", "(Ljavax/swing/DefaultFocusManager;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LegacyLayoutFocusTraversalPolicy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/DefaultFocusManager;)V", "")]
	public LegacyLayoutFocusTraversalPolicy(Dova.JDK.javax.swing.DefaultFocusManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/LegacyLayoutFocusTraversalPolicy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
