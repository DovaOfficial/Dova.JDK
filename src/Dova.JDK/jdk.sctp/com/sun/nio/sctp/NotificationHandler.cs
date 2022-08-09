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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/nio/sctp/NotificationHandler;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public abstract")]
	Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.Notification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}
}