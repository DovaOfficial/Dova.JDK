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

namespace Dova.JDK.sun.reflect.generics.visitor;

[JniSignatureAttribute("Lsun/reflect/generics/visitor/Visitor;", "public abstract interface")]
public partial interface Visitor
	: IJavaObject
	, Dova.JDK.sun.reflect.generics.visitor.TypeTreeVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Visitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/visitor/Visitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClassSignature", "(Lsun/reflect/generics/tree/ClassSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitMethodTypeSignature", "(Lsun/reflect/generics/tree/MethodTypeSignature;)V"));
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ClassSignature;)V", "public abstract")]
	void visitClassSignature(Dova.JDK.sun.reflect.generics.tree.ClassSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/MethodTypeSignature;)V", "public abstract")]
	void visitMethodTypeSignature(Dova.JDK.sun.reflect.generics.tree.MethodTypeSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
