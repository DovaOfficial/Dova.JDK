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

namespace Dova.JDK.sun.reflect.generics.scope;

[JniSignatureAttribute("Lsun/reflect/generics/scope/Scope;", "public abstract interface")]
public partial interface Scope
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Scope()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/scope/Scope;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/reflect/TypeVariable;", "public abstract")]
	Dova.JDK.java.lang.reflect.TypeVariable lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
	}
}
