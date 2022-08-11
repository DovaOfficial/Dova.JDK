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

namespace Dova.JDK.java.nio.file;

[JniSignatureAttribute("Ljava/nio/file/SimpleFileVisitor;", "public")]
public partial class SimpleFileVisitor
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.nio.file.FileVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleFileVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/SimpleFileVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleFileVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SimpleFileVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/file/SimpleFileVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public")]
	public Dova.JDK.java.nio.file.FileVisitResult visitFile(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public")]
	public Dova.JDK.java.nio.file.FileVisitResult visitFileFailed(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.io.IOException arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public")]
	public Dova.JDK.java.nio.file.FileVisitResult preVisitDirectory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public")]
	public Dova.JDK.java.nio.file.FileVisitResult postVisitDirectory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.io.IOException arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}
}
