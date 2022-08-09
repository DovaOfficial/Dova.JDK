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

namespace Dova.JDK.com.sun.jmx.remote.@internal;

[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/NotificationBufferFilter;", "public abstract interface")]
public partial interface NotificationBufferFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NotificationBufferFilter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jmx/remote/internal/NotificationBufferFilter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "apply", "(Ljava/util/List;Ljavax/management/ObjectName;Ljavax/management/Notification;)V"));
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljavax/management/ObjectName;Ljavax/management/Notification;)V", "public abstract")]
	void apply(Dova.JDK.java.util.List arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.javax.management.Notification arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}
