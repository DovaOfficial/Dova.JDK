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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "public abstract interface")]
public partial interface DatatypeValidator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DatatypeValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)V", "public abstract")]
	void validate(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
