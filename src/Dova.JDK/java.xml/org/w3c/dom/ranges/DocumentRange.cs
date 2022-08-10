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

namespace Dova.JDK.org.w3c.dom.ranges;

[JniSignatureAttribute("Lorg/w3c/dom/ranges/DocumentRange;", "public abstract interface")]
public partial interface DocumentRange
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentRange()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/ranges/DocumentRange;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createRange", "()Lorg/w3c/dom/ranges/Range;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ranges/Range;", "public abstract")]
	Dova.JDK.org.w3c.dom.ranges.Range createRange()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ranges.Range>(ret);
	}
}
