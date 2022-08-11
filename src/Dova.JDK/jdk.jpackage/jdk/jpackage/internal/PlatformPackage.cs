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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/PlatformPackage;", "abstract interface")]
public partial interface PlatformPackage
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PlatformPackage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/PlatformPackage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installedApplicationLayout", "()Ljdk/jpackage/internal/ApplicationLayout;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceRoot", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceApplicationLayout", "()Ljdk/jpackage/internal/ApplicationLayout;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "public abstract")]
	Dova.JDK.jdk.jpackage.@internal.ApplicationLayout installedApplicationLayout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public abstract")]
	Dova.JDK.java.nio.file.Path sourceRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jpackage/internal/ApplicationLayout;", "public abstract")]
	Dova.JDK.jdk.jpackage.@internal.ApplicationLayout sourceApplicationLayout()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.ApplicationLayout>(ret);
	}
}
