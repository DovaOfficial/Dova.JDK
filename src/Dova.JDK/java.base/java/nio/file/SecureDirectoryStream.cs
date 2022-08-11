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

[JniSignatureAttribute("Ljava/nio/file/SecureDirectoryStream;", "public abstract interface")]
public partial interface SecureDirectoryStream
	: IJavaObject
	, Dova.JDK.java.nio.file.DirectoryStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SecureDirectoryStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/SecureDirectoryStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newByteChannel", "(Ljava/lang/Object;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectoryStream", "(Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/lang/Object;Ljava/nio/file/SecureDirectoryStream;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/lang/Class;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/lang/Object;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteDirectory", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", "public abstract transient")]
	Dova.JDK.java.nio.channels.SeekableByteChannel newByteChannel(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SeekableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;", "public abstract transient")]
	Dova.JDK.java.nio.file.SecureDirectoryStream newDirectoryStream(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.SecureDirectoryStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/SecureDirectoryStream;Ljava/lang/Object;)V", "public abstract")]
	void move(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.SecureDirectoryStream arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/nio/file/attribute/FileAttributeView;", "public abstract")]
	Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "public abstract transient")]
	Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
	void deleteDirectory(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
	void deleteFile(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
