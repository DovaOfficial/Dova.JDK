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

namespace Dova.JDK.jdk.jshell.tool;

[JniSignatureAttribute("Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract interface")]
public partial interface JavaShellToolBuilder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaShellToolBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/tool/JavaShellToolBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "run", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "start", "([Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "builder", "()Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "locale", "(Ljava/util/Locale;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "out", "(Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "out", "(Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "err", "(Ljava/io/PrintStream;Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "err", "(Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "in", "(Ljava/io/InputStream;Ljava/io/InputStream;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "env", "(Ljava/util/Map;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "interactiveTerminal", "(Z)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "persistence", "(Ljava/util/prefs/Preferences;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "persistence", "(Ljava/util/Map;)Ljdk/jshell/tool/JavaShellToolBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "promptCapture", "(Z)Ljdk/jshell/tool/JavaShellToolBuilder;"));
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public abstract transient")]
	void run(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)I", "public transient")]
	int start(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jshell/tool/JavaShellToolBuilder;", "public static")]
	static Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder builder()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder locale(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder @out(Dova.JDK.java.io.PrintStream arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;Ljava/io/PrintStream;Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder @out(Dova.JDK.java.io.PrintStream arg0, Dova.JDK.java.io.PrintStream arg1, Dova.JDK.java.io.PrintStream arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder err(Dova.JDK.java.io.PrintStream arg0, Dova.JDK.java.io.PrintStream arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintStream;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder err(Dova.JDK.java.io.PrintStream arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/InputStream;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder @in(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.InputStream arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder env(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/jshell/tool/JavaShellToolBuilder;", "public")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder interactiveTerminal(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/prefs/Preferences;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder persistence(Dova.JDK.java.util.prefs.Preferences arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder persistence(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/jshell/tool/JavaShellToolBuilder;", "public abstract")]
	Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder promptCapture(bool arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.tool.JavaShellToolBuilder>(ret);
	}
}
