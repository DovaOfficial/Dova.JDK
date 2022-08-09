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

[JniSignatureAttribute("Lorg/w3c/dom/css/RGBColor;", "public abstract interface")]
public partial interface RGBColor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RGBColor()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/w3c/dom/css/RGBColor;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRed", "()Lorg/w3c/dom/css/CSSPrimitiveValue;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getGreen", "()Lorg/w3c/dom/css/CSSPrimitiveValue;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBlue", "()Lorg/w3c/dom/css/CSSPrimitiveValue;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSPrimitiveValue;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue getRed()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSPrimitiveValue;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue getGreen()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/css/CSSPrimitiveValue;", "public abstract")]
	Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue getBlue()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.css.CSSPrimitiveValue>(ret);
	}
}
