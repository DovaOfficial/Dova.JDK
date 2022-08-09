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

namespace Dova.JDK.org.w3c.dom.css;

[JniSignatureAttribute("Lorg/w3c/dom/css/CSSStyleSheet;", "public abstract interface")]
public partial interface CSSStyleSheet
	: IJavaObject
	, Dova.JDK.org.w3c.dom.stylesheets.StyleSheet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CSSStyleSheet()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/w3c/dom/css/CSSStyleSheet;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCssRules", "()Lorg/w3c/dom/css/CSSRuleList;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOwnerRule", "()Lorg/w3c/dom/css/CSSRule;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "insertRule", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "deleteRule", "(I)V"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSRuleList;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSRuleList getCssRules()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSRuleList>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSRule;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSRule getOwnerRule()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSRule>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "public abstract")]
	int insertRule(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	void deleteRule(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}