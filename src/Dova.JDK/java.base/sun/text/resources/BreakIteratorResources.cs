/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.text.resources;

[JniSignatureAttribute("Lsun/text/resources/BreakIteratorResources;", "public")]
public partial class BreakIteratorResources
	: Dova.JDK.sun.util.resources.BreakIteratorResourceBundle
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BreakIteratorResources()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/text/resources/BreakIteratorResources;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BreakIteratorResources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBreakIteratorInfo", "()Ljava/util/ResourceBundle;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BreakIteratorResources(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BreakIteratorResources() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/text/resources/BreakIteratorResources;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/ResourceBundle;", "protected")]
	public Dova.JDK.java.util.ResourceBundle getBreakIteratorInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
	}
}
