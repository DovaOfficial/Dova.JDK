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

namespace Dova.JDK.javax.management.modelmbean;

[JniSignatureAttribute("Ljavax/management/modelmbean/ModelMBean;", "public abstract interface")]
public partial interface ModelMBean
	: IJavaObject
	, Dova.JDK.javax.management.DynamicMBean
	, Dova.JDK.javax.management.PersistentMBean
	, Dova.JDK.javax.management.modelmbean.ModelMBeanNotificationBroadcaster
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModelMBean()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/modelmbean/ModelMBean;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModelMBeanInfo", "(Ljavax/management/modelmbean/ModelMBeanInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setManagedResource", "(Ljava/lang/Object;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("(Ljavax/management/modelmbean/ModelMBeanInfo;)V", "public abstract")]
	void setModelMBeanInfo(Dova.JDK.javax.management.modelmbean.ModelMBeanInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "public abstract")]
	void setManagedResource(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
