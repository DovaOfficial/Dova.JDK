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

namespace Dova.JDK.java.util.spi;

[JniSignatureAttribute("Ljava/util/spi/ToolProvider;", "public abstract interface")]
public partial interface ToolProvider
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ToolProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/spi/ToolProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljava/io/PrintStream;Ljava/io/PrintStream;[Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(Ljava/io/PrintWriter;Ljava/io/PrintWriter;[Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findFirst", "(Ljava/lang/String;)Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;Ljava/io/PrintStream;[Ljava/lang/String;)I", "public transient")]
	int run(Dova.JDK.java.io.PrintStream arg0, Dova.JDK.java.io.PrintStream arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/PrintWriter;Ljava/io/PrintWriter;[Ljava/lang/String;)I", "public abstract transient")]
	int run(Dova.JDK.java.io.PrintWriter arg0, Dova.JDK.java.io.PrintWriter arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public static")]
	static Dova.JDK.java.util.Optional findFirst(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}
}
