/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaIOFilePermissionAccess;", "public abstract interface")]
public partial interface JavaIOFilePermissionAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaIOFilePermissionAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaIOFilePermissionAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newPermUsingAltPath", "(Ljava/io/FilePermission;)Ljava/io/FilePermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newPermPlusAltPath", "(Ljava/io/FilePermission;)Ljava/io/FilePermission;"));
	}

	[JniSignatureAttribute("(Ljava/io/FilePermission;)Ljava/io/FilePermission;", "public abstract")]
	Dova.JDK.java.io.FilePermission newPermUsingAltPath(Dova.JDK.java.io.FilePermission arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FilePermission>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FilePermission;)Ljava/io/FilePermission;", "public abstract")]
	Dova.JDK.java.io.FilePermission newPermPlusAltPath(Dova.JDK.java.io.FilePermission arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FilePermission>(ret);
	}
}
