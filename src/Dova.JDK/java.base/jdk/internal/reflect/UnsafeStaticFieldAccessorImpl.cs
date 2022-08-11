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

[JniSignatureAttribute("Ljdk/internal/reflect/UnsafeStaticFieldAccessorImpl;", "abstract")]
public partial class UnsafeStaticFieldAccessorImpl
	: Dova.JDK.jdk.@internal.reflect.UnsafeFieldAccessorImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnsafeStaticFieldAccessorImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/UnsafeStaticFieldAccessorImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnsafeStaticFieldAccessorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)V", "")]
	public UnsafeStaticFieldAccessorImpl(Dova.JDK.java.lang.reflect.Field arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/UnsafeStaticFieldAccessorImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
