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

namespace Dova.JDK.org.w3c.dom.css;

[JniSignatureAttribute("Lorg/w3c/dom/css/CSSMediaRule;", "public abstract interface")]
public partial interface CSSMediaRule
	: IJavaObject
	, Dova.JDK.org.w3c.dom.css.CSSRule
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CSSMediaRule()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/css/CSSMediaRule;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCssRules", "()Lorg/w3c/dom/css/CSSRuleList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertRule", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteRule", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMedia", "()Lorg/w3c/dom/stylesheets/MediaList;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSRuleList;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSRuleList getCssRules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSRuleList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public abstract")]
	int insertRule(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void deleteRule(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/stylesheets/MediaList;", "public abstract")]
	Dova.JDK.org.w3c.dom.stylesheets.MediaList getMedia()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.stylesheets.MediaList>(ret);
	}
}
