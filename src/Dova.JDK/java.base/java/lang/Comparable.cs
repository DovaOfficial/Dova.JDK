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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/Comparable;", "public abstract interface")]
public partial interface Comparable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Comparable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/Comparable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
	int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
