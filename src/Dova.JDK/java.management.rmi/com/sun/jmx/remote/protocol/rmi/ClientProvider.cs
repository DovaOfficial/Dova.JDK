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

[JniSignatureAttribute("Lcom/sun/jmx/remote/protocol/rmi/ClientProvider;", "public")]
public partial class ClientProvider
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.management.remote.JMXConnectorProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClientProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/protocol/rmi/ClientProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newJMXConnector", "(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/JMXConnector;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClientProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ClientProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/protocol/rmi/ClientProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/remote/JMXServiceURL;Ljava/util/Map;)Ljavax/management/remote/JMXConnector;", "public")]
	public Dova.JDK.javax.management.remote.JMXConnector newJMXConnector(Dova.JDK.javax.management.remote.JMXServiceURL arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.remote.JMXConnector>(ret);
	}
}
