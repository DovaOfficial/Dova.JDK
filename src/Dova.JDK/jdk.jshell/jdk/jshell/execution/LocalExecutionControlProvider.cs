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

namespace Dova.JDK.jdk.jshell.execution;

[JniSignatureAttribute("Ljdk/jshell/execution/LocalExecutionControlProvider;", "public")]
public partial class LocalExecutionControlProvider
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.jshell.spi.ExecutionControlProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LocalExecutionControlProvider()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/execution/LocalExecutionControlProvider;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LocalExecutionControlProvider", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "generate", "(Ljdk/jshell/spi/ExecutionEnv;Ljava/util/Map;)Ljdk/jshell/spi/ExecutionControl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "defaultParameters", "()Ljava/util/Map;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LocalExecutionControlProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LocalExecutionControlProvider() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/execution/LocalExecutionControlProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/spi/ExecutionEnv;Ljava/util/Map;)Ljdk/jshell/spi/ExecutionControl;", "public")]
	public Dova.JDK.jdk.jshell.spi.ExecutionControl generate(Dova.JDK.jdk.jshell.spi.ExecutionEnv arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.spi.ExecutionControl>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map defaultParameters()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}