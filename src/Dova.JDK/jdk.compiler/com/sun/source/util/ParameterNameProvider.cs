/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/ParameterNameProvider;", "public abstract interface")]
public partial interface ParameterNameProvider
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParameterNameProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/ParameterNameProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterName", "(Ljavax/lang/model/element/VariableElement;)Ljava/lang/CharSequence;"));
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Ljava/lang/CharSequence;", "public abstract")]
	Dova.JDK.java.lang.CharSequence getParameterName(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}
}
