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

namespace Dova.JDK.com.sun.jmx.remote.protocol.rmi;

[JniSignatureAttribute("Lcom/sun/jmx/remote/protocol/rmi/ServerProvider;", "public")]
public partial class ServerProvider
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.management.remote.JMXConnectorServerProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServerProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/protocol/rmi/ServerProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newJMXConnectorServer", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/MBeanServer;)Ljavax/management/remote/JMXConnectorServer;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServerProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ServerProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/protocol/rmi/ServerProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;Ljavax/management/MBeanServer;)Ljavax/management/remote/JMXConnectorServer;", "public")]
	public Dova.JDK.javax.management.remote.JMXConnectorServer newJMXConnectorServer(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.javax.management.MBeanServer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXConnectorServer>(ret);
	}
}
