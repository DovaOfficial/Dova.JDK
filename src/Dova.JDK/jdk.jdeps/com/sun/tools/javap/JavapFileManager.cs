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

namespace Dova.JDK.com.sun.tools.javap;

[JniSignatureAttribute("Lcom/sun/tools/javap/JavapFileManager;", "public")]
public partial class JavapFileManager
	: Dova.JDK.com.sun.tools.javac.file.JavacFileManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavapFileManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javap/JavapFileManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;Ljava/nio/charset/Charset;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljavax/tools/DiagnosticListener;Ljava/io/PrintWriter;)Lcom/sun/tools/javap/JavapFileManager;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavapFileManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;Ljava/nio/charset/Charset;)V", "private")]
	public JavapFileManager(Dova.JDK.com.sun.tools.javac.util.Context arg0, Dova.JDK.java.nio.charset.Charset arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javap/JavapFileManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/tools/DiagnosticListener;Ljava/io/PrintWriter;)Lcom/sun/tools/javap/JavapFileManager;", "public static")]
	public static Dova.JDK.com.sun.tools.javap.JavapFileManager create(Dova.JDK.javax.tools.DiagnosticListener arg0, Dova.JDK.java.io.PrintWriter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javap.JavapFileManager>(ret);
	}
}
