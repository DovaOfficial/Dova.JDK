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

namespace Dova.JDK.jdk.jfr.@internal.dcmd;

[JniSignatureAttribute("Ljdk/jfr/internal/dcmd/DCmdConfigure;", "final")]
public partial class DCmdConfigure
	: Dova.JDK.jdk.jfr.@internal.dcmd.AbstractDCmd
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DCmdConfigure()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/dcmd/DCmdConfigure;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DCmdConfigure", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "execute", "(Ljdk/jfr/internal/dcmd/ArgumentParser;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "execute", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Boolean;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printHelp", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getArgumentInfos", "()[Ljdk/jfr/internal/dcmd/Argument;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printRepositoryPath", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printDumpPath", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printStackDepth", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printGlobalBufferCount", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printGlobalBufferSize", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printThreadBufferSize", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMemorySize", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printMaxChunkSize", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printSampleThreads", "()V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DCmdConfigure(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public DCmdConfigure() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/dcmd/DCmdConfigure;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/dcmd/ArgumentParser;)V", "protected")]
	public void execute(Dova.JDK.jdk.jfr.@internal.dcmd.ArgumentParser arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Boolean;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> execute(bool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Integer arg3, Dova.JDK.java.lang.Long arg4, Dova.JDK.java.lang.Long arg5, Dova.JDK.java.lang.Long arg6, Dova.JDK.java.lang.Long arg7, Dova.JDK.java.lang.Long arg8, Dova.JDK.java.lang.Boolean arg9)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> printHelp()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/jfr/internal/dcmd/Argument;", "public")]
	public JavaArray<Dova.JDK.jdk.jfr.@internal.dcmd.Argument> getArgumentInfos()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.dcmd.Argument>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printRepositoryPath()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printDumpPath()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printStackDepth()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printGlobalBufferCount()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printGlobalBufferSize()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printThreadBufferSize()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printMemorySize()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printMaxChunkSize()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void printSampleThreads()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}
}
