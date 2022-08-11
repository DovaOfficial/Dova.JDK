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

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/NotificationEmitter;", "public abstract interface")]
public partial interface NotificationEmitter
	: IJavaObject
	, Dova.JDK.javax.management.NotificationBroadcaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NotificationEmitter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/NotificationEmitter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationListener", "(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;Ljavax/management/NotificationFilter;Ljava/lang/Object;)V", "public abstract")]
	void removeNotificationListener(Dova.JDK.javax.management.NotificationListener arg0, Dova.JDK.javax.management.NotificationFilter arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}
