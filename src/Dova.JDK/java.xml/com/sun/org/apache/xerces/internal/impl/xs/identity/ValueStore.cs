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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;", "public abstract interface")]
public partial interface ValueStore
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ValueStore()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/ValueStore;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reportError", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addValue", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public abstract")]
	void reportError(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;ZLjava/lang/Object;SLcom/sun/org/apache/xerces/internal/xs/ShortList;)V", "public abstract")]
	void addValue(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field arg0, bool arg1, Dova.JDK.java.lang.Object arg2, short arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}
}
