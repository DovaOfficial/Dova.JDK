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

namespace Dova.JDK.javax.tools;

[JniSignatureAttribute("Ljavax/tools/JavaCompiler;", "public abstract interface")]
public partial interface JavaCompiler
	: IJavaObject
	, Dova.JDK.javax.tools.Tool
	, Dova.JDK.javax.tools.OptionChecker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaCompiler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/JavaCompiler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardFileManager", "(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTask", "(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/JavaCompiler$CompilationTask;"));
	}

	[JniSignatureAttribute("(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;", "public abstract")]
	Dova.JDK.javax.tools.StandardJavaFileManager getStandardFileManager(Dova.JDK.javax.tools.DiagnosticListener arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.nio.charset.Charset arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Iterable;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/JavaCompiler$CompilationTask;", "public abstract")]
	Dova.JDK.javax.tools.JavaCompiler.CompilationTask getTask(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.tools.JavaFileManager arg1, Dova.JDK.javax.tools.DiagnosticListener arg2, Dova.JDK.java.lang.Iterable arg3, Dova.JDK.java.lang.Iterable arg4, Dova.JDK.java.lang.Iterable arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaCompiler.CompilationTask>(ret);
	}

	[JniSignatureAttribute("Ljavax/tools/JavaCompiler$CompilationTask;", "public abstract static interface")]
	public partial interface CompilationTask
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Callable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompilationTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/JavaCompiler$CompilationTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModules", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProcessors", "(Ljava/lang/Iterable;)V"));
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public abstract")]
		void addModules(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)V", "public abstract")]
		void setLocale(Dova.JDK.java.util.Locale arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Boolean;", "public abstract")]
		Dova.JDK.java.lang.Boolean call_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		Dova.JDK.java.lang.Object call_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public abstract")]
		void setProcessors(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}
}
