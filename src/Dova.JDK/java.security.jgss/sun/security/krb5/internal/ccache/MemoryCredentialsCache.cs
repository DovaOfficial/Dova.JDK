/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.krb5.@internal.ccache;

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/MemoryCredentialsCache;", "public abstract")]
public partial class MemoryCredentialsCache
	: Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemoryCredentialsCache()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/krb5/internal/ccache/MemoryCredentialsCache;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MemoryCredentialsCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "update", "(Lsun/security/krb5/internal/ccache/Credentials;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "save", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "exists", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCredsList", "()[Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCCacheInstance", "(Lsun/security/krb5/PrincipalName;Ljava/io/File;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCCacheInstance", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPrimaryPrincipal", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCreds", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MemoryCredentialsCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MemoryCredentialsCache() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/MemoryCredentialsCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/Credentials;)V", "public abstract")]
	public void update(Dova.JDK.sun.security.krb5.@internal.ccache.Credentials arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void save()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	public bool exists(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials> getCredsList()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/io/File;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "private static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getCCacheInstance(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.io.File arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "private static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getCCacheInstance(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public abstract")]
	public Dova.JDK.sun.security.krb5.PrincipalName getPrimaryPrincipal()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCreds(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}
}