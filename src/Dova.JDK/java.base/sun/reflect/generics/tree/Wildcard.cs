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

[JniSignatureAttribute("Lsun/reflect/generics/tree/Wildcard;", "public")]
public partial class Wildcard
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.reflect.generics.tree.TypeArgument
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Wildcard()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/tree/Wildcard;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upperBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowerBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "emptyBounds", "[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/Wildcard;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()[Lsun/reflect/generics/tree/FieldTypeSignature;"));
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> upperBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private final")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> lowerBounds_Property
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

	[JniSignatureAttribute("[Lsun/reflect/generics/tree/FieldTypeSignature;", "private static final")]
	public static JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> emptyBounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Wildcard(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)V", "private")]
	public Wildcard(JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/reflect/generics/tree/Wildcard;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Lsun/reflect/generics/tree/FieldTypeSignature;[Lsun/reflect/generics/tree/FieldTypeSignature;)Lsun/reflect/generics/tree/Wildcard;", "public static")]
	public static Dova.JDK.sun.reflect.generics.tree.Wildcard make(JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg0, JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.reflect.generics.tree.Wildcard>(ret);
	}

	[JniSignatureAttribute("(Lsun/reflect/generics/visitor/TypeTreeVisitor;)V", "public")]
	public void accept(Dova.JDK.sun.reflect.generics.visitor.TypeTreeVisitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getUpperBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}

	[JniSignatureAttribute("()[Lsun/reflect/generics/tree/FieldTypeSignature;", "public")]
	public JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature> getLowerBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.reflect.generics.tree.FieldTypeSignature>>(ret);
	}
}
