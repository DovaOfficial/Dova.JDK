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

[JniSignatureAttribute("Lcom/sun/nio/sctp/NotificationHandler;", "public abstract interface")]
public partial interface NotificationHandler
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NotificationHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/NotificationHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public abstract")]
	Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.Notification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}
}
