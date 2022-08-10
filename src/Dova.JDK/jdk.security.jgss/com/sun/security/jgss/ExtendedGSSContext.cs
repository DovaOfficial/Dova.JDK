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

namespace Dova.JDK.com.sun.security.jgss;

[JniSignatureAttribute("Lcom/sun/security/jgss/ExtendedGSSContext;", "public abstract interface")]
public partial interface ExtendedGSSContext
	: IJavaObject
	, Dova.JDK.org.ietf.jgss.GSSContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedGSSContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/security/jgss/ExtendedGSSContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inquireSecContext", "(Lcom/sun/security/jgss/InquireType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDelegPolicyState", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "requestDelegPolicy", "(Z)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/security/jgss/InquireType;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object inquireSecContext(Dova.JDK.com.sun.security.jgss.InquireType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool getDelegPolicyState()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void requestDelegPolicy(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
