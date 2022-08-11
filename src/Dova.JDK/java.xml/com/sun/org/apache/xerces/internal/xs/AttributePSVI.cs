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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/AttributePSVI;", "public abstract interface")]
public partial interface AttributePSVI
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ItemPSVI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttributePSVI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xs/AttributePSVI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeDeclaration", "()Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration getAttributeDeclaration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration>(ret);
	}
}
