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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;", "public abstract")]
public partial class ReferenceType
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReferenceType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignmentCompatibleWith", "(Lcom/sun/org/apache/bcel/internal/generic/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstCommonSuperclass", "(Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;)Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCastableTo", "(Lcom/sun/org/apache/bcel/internal/generic/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firstCommonSuperclass", "(Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;)Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReferenceType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(BLjava/lang/String;)V", "protected")]
	public ReferenceType(byte arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "")]
	public ReferenceType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Type;)Z", "public")]
	public bool isAssignmentCompatibleWith(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;)Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType getFirstCommonSuperclass(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Type;)Z", "public")]
	public bool isCastableTo(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;)Lcom/sun/org/apache/bcel/internal/generic/ReferenceType;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType firstCommonSuperclass(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReferenceType>(ret);
	}
}
