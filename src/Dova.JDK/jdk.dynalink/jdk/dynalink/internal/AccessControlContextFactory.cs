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

namespace Dova.JDK.jdk.dynalink.@internal;

[JniSignatureAttribute("Ljdk/dynalink/internal/AccessControlContextFactory;", "public final")]
public partial class AccessControlContextFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccessControlContextFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/internal/AccessControlContextFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeRuntimePermissions", "([Ljava/lang/String;)[Ljava/security/Permission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAccessControlContext", "([Ljava/security/Permission;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAccessControlContext", "([Ljava/lang/String;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAccessControlContext", "()Ljava/security/AccessControlContext;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AccessControlContextFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public AccessControlContextFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/internal/AccessControlContextFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/String;)[Ljava/security/Permission;", "private static transient")]
	public static JavaArray<Dova.JDK.java.security.Permission> makeRuntimePermissions(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.Permission>>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/Permission;)Ljava/security/AccessControlContext;", "public static transient")]
	public static Dova.JDK.java.security.AccessControlContext createAccessControlContext(JavaArray<Dova.JDK.java.security.Permission> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/security/AccessControlContext;", "public static transient")]
	public static Dova.JDK.java.security.AccessControlContext createAccessControlContext(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "public static")]
	public static Dova.JDK.java.security.AccessControlContext createAccessControlContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}
}
