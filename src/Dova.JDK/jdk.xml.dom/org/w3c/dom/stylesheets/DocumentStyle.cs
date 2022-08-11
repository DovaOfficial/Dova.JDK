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

namespace Dova.JDK.org.w3c.dom.stylesheets;

[JniSignatureAttribute("Lorg/w3c/dom/stylesheets/DocumentStyle;", "public abstract interface")]
public partial interface DocumentStyle
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentStyle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/stylesheets/DocumentStyle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyleSheets", "()Lorg/w3c/dom/stylesheets/StyleSheetList;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/stylesheets/StyleSheetList;", "public abstract")]
	Dova.JDK.org.w3c.dom.stylesheets.StyleSheetList getStyleSheets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.stylesheets.StyleSheetList>(ret);
	}
}
