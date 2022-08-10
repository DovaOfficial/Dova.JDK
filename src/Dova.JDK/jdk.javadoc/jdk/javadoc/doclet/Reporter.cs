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

namespace Dova.JDK.jdk.javadoc.doclet;

[JniSignatureAttribute("Ljdk/javadoc/doclet/Reporter;", "public abstract interface")]
public partial interface Reporter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Reporter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/doclet/Reporter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/tools/Diagnostic$Kind;Ljavax/tools/FileObject;IIILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/tools/Diagnostic$Kind;Lcom/sun/source/util/DocTreePath;IIILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/tools/Diagnostic$Kind;Ljavax/lang/model/element/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/tools/Diagnostic$Kind;Lcom/sun/source/util/DocTreePath;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDiagnosticWriter", "()Ljava/io/PrintWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStandardWriter", "()Ljava/io/PrintWriter;"));
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljavax/tools/FileObject;IIILjava/lang/String;)V", "public")]
	void print(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.javax.tools.FileObject arg1, int arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Lcom/sun/source/util/DocTreePath;IIILjava/lang/String;)V", "public")]
	void print(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.com.sun.source.util.DocTreePath arg1, int arg2, int arg3, int arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljavax/lang/model/element/Element;Ljava/lang/String;)V", "public abstract")]
	void print(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Lcom/sun/source/util/DocTreePath;Ljava/lang/String;)V", "public abstract")]
	void print(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.com.sun.source.util.DocTreePath arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/String;)V", "public abstract")]
	void print(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/io/PrintWriter;", "public")]
	Dova.JDK.java.io.PrintWriter getDiagnosticWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/PrintWriter;", "public")]
	Dova.JDK.java.io.PrintWriter getStandardWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
	}
}
