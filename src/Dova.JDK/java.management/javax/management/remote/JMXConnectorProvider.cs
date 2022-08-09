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

namespace Dova.JDK.javax.management.remote;

[JniSignatureAttribute("Ljavax/management/remote/JMXConnectorProvider;", "public abstract interface")]
public partial interface JMXConnectorProvider
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JMXConnectorProvider()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/management/remote/JMXConnectorProvider;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newJMXConnector", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/JMXConnector;"));
	}

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/JMXConnector;", "public abstract")]
	Dova.JDK.javax.management.remote.JMXConnector newJMXConnector(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXConnector>(ret);
	}
}