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

namespace Dova.JDK.com.sun.jmx.mbeanserver;

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/JmxMBeanServerBuilder;", "public")]
public partial class JmxMBeanServerBuilder
	: Dova.JDK.javax.management.MBeanServerBuilder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JmxMBeanServerBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/JmxMBeanServerBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JmxMBeanServerBuilder", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newMBeanServerDelegate", "()Ljavax/management/MBeanServerDelegate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newMBeanServer", "(Ljava/lang/String;Ljavax/management/MBeanServer;Ljavax/management/MBeanServerDelegate;)Ljavax/management/MBeanServer;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JmxMBeanServerBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JmxMBeanServerBuilder() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/JmxMBeanServerBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/management/MBeanServerDelegate;", "public")]
	public Dova.JDK.javax.management.MBeanServerDelegate newMBeanServerDelegate()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerDelegate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/MBeanServer;Ljavax/management/MBeanServerDelegate;)Ljavax/management/MBeanServer;", "public")]
	public Dova.JDK.javax.management.MBeanServer newMBeanServer(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.MBeanServer arg1, Dova.JDK.javax.management.MBeanServerDelegate arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}
}
