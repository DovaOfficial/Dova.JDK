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

namespace Dova.JDK.java.nio.file.attribute;

[JniSignatureAttribute("Ljava/nio/file/attribute/BasicFileAttributeView;", "public abstract interface")]
public partial interface BasicFileAttributeView
	: IJavaObject
	, Dova.JDK.java.nio.file.attribute.FileAttributeView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicFileAttributeView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/attribute/BasicFileAttributeView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimes", "(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "public abstract")]
	Dova.JDK.java.nio.file.attribute.BasicFileAttributes readAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V", "public abstract")]
	void setTimes(Dova.JDK.java.nio.file.attribute.FileTime arg0, Dova.JDK.java.nio.file.attribute.FileTime arg1, Dova.JDK.java.nio.file.attribute.FileTime arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}
}
