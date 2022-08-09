/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/FieldActivator;", "public abstract interface")]
public partial interface FieldActivator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldActivator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/identity/FieldActivator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "startValueScopeFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "activateField", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "endValueScopeFor", "(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public abstract")]
	void startValueScopeFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/Field;I)Lcom/sun/org/apache/xerces/internal/impl/xs/identity/XPathMatcher;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher activateField(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.Field arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.XPathMatcher>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/identity/IdentityConstraint;I)V", "public abstract")]
	void endValueScopeFor(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.identity.IdentityConstraint arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}
}