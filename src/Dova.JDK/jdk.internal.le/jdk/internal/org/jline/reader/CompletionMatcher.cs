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

namespace Dova.JDK.jdk.@internal.org.jline.reader;

[JniSignatureAttribute("Ljdk/internal/org/jline/reader/CompletionMatcher;", "public abstract interface")]
public partial interface CompletionMatcher
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompletionMatcher()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/reader/CompletionMatcher;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "matches", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compile", "(Ljava/util/Map;ZLjdk/internal/org/jline/reader/CompletingParsedLine;ZILjava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "exactMatch", "()Ljdk/internal/org/jline/reader/Candidate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCommonPrefix", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List matches(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;ZLjdk/internal/org/jline/reader/CompletingParsedLine;ZILjava/lang/String;)V", "public abstract")]
	void compile(Dova.JDK.java.util.Map arg0, bool arg1, Dova.JDK.jdk.@internal.org.jline.reader.CompletingParsedLine arg2, bool arg3, int arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/Candidate;", "public abstract")]
	Dova.JDK.jdk.@internal.org.jline.reader.Candidate exactMatch()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Candidate>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getCommonPrefix()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}