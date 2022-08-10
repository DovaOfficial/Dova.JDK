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

namespace Dova.JDK.javax.naming.ldap;

[JniSignatureAttribute("Ljavax/naming/ldap/UnsolicitedNotificationListener;", "public abstract interface")]
public partial interface UnsolicitedNotificationListener
	: IJavaObject
	, Dova.JDK.javax.naming.@event.NamingListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnsolicitedNotificationListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/ldap/UnsolicitedNotificationListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "notificationReceived", "(Ljavax/naming/ldap/UnsolicitedNotificationEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/naming/ldap/UnsolicitedNotificationEvent;)V", "public abstract")]
	void notificationReceived(Dova.JDK.javax.naming.ldap.UnsolicitedNotificationEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
