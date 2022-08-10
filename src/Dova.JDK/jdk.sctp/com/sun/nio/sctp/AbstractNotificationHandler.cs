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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/AbstractNotificationHandler;", "public")]
public partial class AbstractNotificationHandler
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.nio.sctp.NotificationHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractNotificationHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/AbstractNotificationHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AbstractNotificationHandler", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/PeerAddressChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/SendFailedNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/ShutdownNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/AssociationChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleNotification", "(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractNotificationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AbstractNotificationHandler() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/AbstractNotificationHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/PeerAddressChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/SendFailedNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.SendFailedNotification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/ShutdownNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.ShutdownNotification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/AssociationChangeNotification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Notification;Ljava/lang/Object;)Lcom/sun/nio/sctp/HandlerResult;", "public")]
	public Dova.JDK.com.sun.nio.sctp.HandlerResult handleNotification(Dova.JDK.com.sun.nio.sctp.Notification arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.HandlerResult>(ret);
	}
}
