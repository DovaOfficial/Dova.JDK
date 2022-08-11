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

namespace Dova.JDK.sun.reflect.generics.tree;

[JniSignatureAttribute("Lsun/reflect/generics/tree/FormalTypeParameter;", "public")]
public partial class FormalTypeParameter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.tree.TypeTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FormalTypeParameter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/tree/FormalTypeParameter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/FormalTypeParameter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> bounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FormalTypeParameter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)V", "private")]
	public FormalTypeParameter(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/tree/FormalTypeParameter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/FormalTypeParameter;", "public static")]
	public static Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter make(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.FormalTypeParameter>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V", "public")]
	public void accept(Dova.JDK.sun.reflect.generics.visitor.TypeTreeVisitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
