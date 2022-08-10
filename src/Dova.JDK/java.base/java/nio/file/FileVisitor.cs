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

namespace Dova.JDK.java.nio.file;

[JniSignatureAttribute("Ljava/nio/file/FileVisitor;", "public abstract interface")]
public partial interface FileVisitor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/FileVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitFileFailed", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "preVisitDirectory", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public abstract")]
	Dova.JDK.java.nio.file.FileVisitResult visitFile(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public abstract")]
	Dova.JDK.java.nio.file.FileVisitResult visitFileFailed(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.io.IOException arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public abstract")]
	Dova.JDK.java.nio.file.FileVisitResult preVisitDirectory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public abstract")]
	Dova.JDK.java.nio.file.FileVisitResult postVisitDirectory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.io.IOException arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
	}
}
