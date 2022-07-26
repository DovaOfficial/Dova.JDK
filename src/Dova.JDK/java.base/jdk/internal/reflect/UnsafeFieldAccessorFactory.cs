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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/UnsafeFieldAccessorFactory;", "")]
public partial class UnsafeFieldAccessorFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnsafeFieldAccessorFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/UnsafeFieldAccessorFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFieldAccessor", "(Ljava/lang/reflect/Field;Z)Ljdk/internal/reflect/FieldAccessor;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnsafeFieldAccessorFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public UnsafeFieldAccessorFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/UnsafeFieldAccessorFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Z)Ljdk/internal/reflect/FieldAccessor;", "static")]
	public static Dova.JDK.jdk.@internal.reflect.FieldAccessor newFieldAccessor(Dova.JDK.java.lang.reflect.Field arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.FieldAccessor>(ret);
	}
}
