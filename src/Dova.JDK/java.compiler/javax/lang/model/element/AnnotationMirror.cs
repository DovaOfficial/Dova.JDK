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

namespace Dova.JDK.javax.lang.model.element;

[JniSignatureAttribute("Ljavax/lang/model/element/AnnotationMirror;", "public abstract interface")]
public partial interface AnnotationMirror
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationMirror()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/element/AnnotationMirror;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Ljavax/lang/model/type/DeclaredType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementValues", "()Ljava/util/Map;"));
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/DeclaredType;", "public abstract")]
	Dova.JDK.javax.lang.model.type.DeclaredType getAnnotationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.DeclaredType>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getElementValues()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
