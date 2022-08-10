/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lsun/reflect/generics/visitor/TypeTreeVisitor;", "public abstract interface")]
public partial interface TypeTreeVisitor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeTreeVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/visitor/TypeTreeVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResult", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFormalTypeParameter", "(Lsun/reflect/generics/tree/FormalTypeParameter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitSimpleClassTypeSignature", "(Lsun/reflect/generics/tree/SimpleClassTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitClassTypeSignature", "(Lsun/reflect/generics/tree/ClassTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBottomSignature", "(Lsun/reflect/generics/tree/BottomSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitArrayTypeSignature", "(Lsun/reflect/generics/tree/ArrayTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitTypeVariableSignature", "(Lsun/reflect/generics/tree/TypeVariableSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitVoidDescriptor", "(Lsun/reflect/generics/tree/VoidDescriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitWildcard", "(Lsun/reflect/generics/tree/Wildcard;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitByteSignature", "(Lsun/reflect/generics/tree/ByteSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitBooleanSignature", "(Lsun/reflect/generics/tree/BooleanSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitShortSignature", "(Lsun/reflect/generics/tree/ShortSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitCharSignature", "(Lsun/reflect/generics/tree/CharSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitIntSignature", "(Lsun/reflect/generics/tree/IntSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitLongSignature", "(Lsun/reflect/generics/tree/LongSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFloatSignature", "(Lsun/reflect/generics/tree/FloatSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDoubleSignature", "(Lsun/reflect/generics/tree/DoubleSignature;)V"));
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getResult()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/FormalTypeParameter;)V", "public abstract")]
	void visitFormalTypeParameter(Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/SimpleClassTypeSignature;)V", "public abstract")]
	void visitSimpleClassTypeSignature(Dova.JDK.sun.reflect.generics.tree.SimpleClassTypeSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ClassTypeSignature;)V", "public abstract")]
	void visitClassTypeSignature(Dova.JDK.sun.reflect.generics.tree.ClassTypeSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/BottomSignature;)V", "public abstract")]
	void visitBottomSignature(Dova.JDK.sun.reflect.generics.tree.BottomSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ArrayTypeSignature;)V", "public abstract")]
	void visitArrayTypeSignature(Dova.JDK.sun.reflect.generics.tree.ArrayTypeSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/TypeVariableSignature;)V", "public abstract")]
	void visitTypeVariableSignature(Dova.JDK.sun.reflect.generics.tree.TypeVariableSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/VoidDescriptor;)V", "public abstract")]
	void visitVoidDescriptor(Dova.JDK.sun.reflect.generics.tree.VoidDescriptor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/Wildcard;)V", "public abstract")]
	void visitWildcard(Dova.JDK.sun.reflect.generics.tree.Wildcard arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ByteSignature;)V", "public abstract")]
	void visitByteSignature(Dova.JDK.sun.reflect.generics.tree.ByteSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/BooleanSignature;)V", "public abstract")]
	void visitBooleanSignature(Dova.JDK.sun.reflect.generics.tree.BooleanSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/ShortSignature;)V", "public abstract")]
	void visitShortSignature(Dova.JDK.sun.reflect.generics.tree.ShortSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/CharSignature;)V", "public abstract")]
	void visitCharSignature(Dova.JDK.sun.reflect.generics.tree.CharSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/IntSignature;)V", "public abstract")]
	void visitIntSignature(Dova.JDK.sun.reflect.generics.tree.IntSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/LongSignature;)V", "public abstract")]
	void visitLongSignature(Dova.JDK.sun.reflect.generics.tree.LongSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/FloatSignature;)V", "public abstract")]
	void visitFloatSignature(Dova.JDK.sun.reflect.generics.tree.FloatSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/tree/DoubleSignature;)V", "public abstract")]
	void visitDoubleSignature(Dova.JDK.sun.reflect.generics.tree.DoubleSignature arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}
}
