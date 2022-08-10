/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.javadoc.@internal.api;

[JniSignatureAttribute("Ljdk/javadoc/internal/api/JavadocTool;", "public")]
public partial class JavadocTool
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.tools.DocumentationTool
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavadocTool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/api/JavadocTool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "JavadocTool", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;[Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourceVersions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSupportedOption", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStandardFileManager", "(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTask", "(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/DocumentationTool$DocumentationTask;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTask", "(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;Lcom/sun/tools/javac/util/Context;)Ljavax/tools/DocumentationTool$DocumentationTask;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavadocTool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JavadocTool() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/api/JavadocTool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/io/OutputStream;[Ljava/lang/String;)I", "public transient")]
	public int run(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.java.io.OutputStream arg2, JavaArray<Dova.JDK.java.lang.String> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getSourceVersions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int isSupportedOption(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;", "public")]
	public Dova.JDK.javax.tools.StandardJavaFileManager getStandardFileManager(Dova.JDK.javax.tools.DiagnosticListener arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.nio.charset.Charset arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/DocumentationTool$DocumentationTask;", "public")]
	public Dova.JDK.javax.tools.DocumentationTool.DocumentationTask getTask(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.tools.JavaFileManager arg1, Dova.JDK.javax.tools.DiagnosticListener arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.Iterable arg4, Dova.JDK.java.lang.Iterable arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.DocumentationTask>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;Lcom/sun/tools/javac/util/Context;)Ljavax/tools/DocumentationTool$DocumentationTask;", "public")]
	public Dova.JDK.javax.tools.DocumentationTool.DocumentationTask getTask(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.tools.JavaFileManager arg1, Dova.JDK.javax.tools.DiagnosticListener arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.Iterable arg4, Dova.JDK.java.lang.Iterable arg5, Dova.JDK.com.sun.tools.javac.util.Context arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.DocumentationTask>(ret);
	}
}
