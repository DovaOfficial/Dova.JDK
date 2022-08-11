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

namespace Dova.JDK.jdk.jfr.@internal.dcmd;

[JniSignatureAttribute("Ljdk/jfr/internal/dcmd/DCmdStart;", "final")]
public partial class DCmdStart
	: Dova.JDK.jdk.jfr.@internal.dcmd.AbstractDCmd
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DCmdStart()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/dcmd/DCmdStart;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(Ljdk/jfr/internal/dcmd/ArgumentParser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printHelp", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgumentInfos", "()[Ljdk/jfr/internal/dcmd/Argument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureExtended", "([Ljava/lang/String;Ljdk/jfr/internal/dcmd/ArgumentParser;)Ljava/util/LinkedHashMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureStandard", "([Ljava/lang/String;)Ljava/util/LinkedHashMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeWithForcedInstrumentation", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasJDKEvents", "(Ljava/util/Map;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DCmdStart(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public DCmdStart() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/dcmd/DCmdStart;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/dcmd/ArgumentParser;)V", "public")]
	public void execute(Dova.JDK.jdk.jfr.@internal.dcmd.ArgumentParser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> printHelp()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/jfr/internal/dcmd/Argument;", "public")]
	public JavaArray<Dova.JDK.jdk.jfr.@internal.dcmd.Argument> getArgumentInfos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.jfr.@internal.dcmd.Argument>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;Ljdk/jfr/internal/dcmd/ArgumentParser;)Ljava/util/LinkedHashMap;", "private")]
	public Dova.JDK.java.util.LinkedHashMap configureExtended(JavaArray<Dova.JDK.java.lang.String> arg0, Dova.JDK.jdk.jfr.@internal.dcmd.ArgumentParser arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/LinkedHashMap;", "private")]
	public Dova.JDK.java.util.LinkedHashMap configureStandard(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "private")]
	public void initializeWithForcedInstrumentation(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Z", "private")]
	public bool hasJDKEvents(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}
}
