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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/Notification;", "public abstract interface")]
public partial interface Notification
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Notification()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/Notification;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "association", "()Lcom/sun/nio/sctp/Association;"));
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/Association;", "public abstract")]
	Dova.JDK.com.sun.nio.sctp.Association association()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}
}
