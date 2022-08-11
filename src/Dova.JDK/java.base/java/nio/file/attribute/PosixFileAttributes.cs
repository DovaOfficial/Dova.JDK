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

[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFileAttributes;", "public abstract interface")]
public partial interface PosixFileAttributes
	: IJavaObject
	, Dova.JDK.java.nio.file.attribute.BasicFileAttributes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PosixFileAttributes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/attribute/PosixFileAttributes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/nio/file/attribute/GroupPrincipal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permissions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "owner", "()Ljava/nio/file/attribute/UserPrincipal;"));
	}

	[JniSignatureAttribute("()Ljava/nio/file/attribute/GroupPrincipal;", "public abstract")]
	Dova.JDK.java.nio.file.attribute.GroupPrincipal group()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.GroupPrincipal>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set permissions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/attribute/UserPrincipal;", "public abstract")]
	Dova.JDK.java.nio.file.attribute.UserPrincipal owner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.UserPrincipal>(ret);
	}
}
