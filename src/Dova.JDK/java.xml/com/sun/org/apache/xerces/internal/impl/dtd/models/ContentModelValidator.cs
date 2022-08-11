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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.models;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/models/ContentModelValidator;", "public abstract interface")]
public partial interface ContentModelValidator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ContentModelValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dtd/models/ContentModelValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "([Lcom/sun/org/apache/xerces/internal/xni/QName;II)I"));
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xni/QName;II)I", "public abstract")]
	int validate(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}
}
