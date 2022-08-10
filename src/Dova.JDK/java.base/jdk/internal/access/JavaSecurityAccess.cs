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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaSecurityAccess;", "public abstract interface")]
public partial interface JavaSecurityAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaSecurityAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaSecurityAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doIntersectionPrivilege", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doIntersectionPrivilege", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getProtectDomains", "(Ljava/security/AccessControlContext;)[Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getProtectionDomainCache", "()Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;"));
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object doIntersectionPrivilege(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1, Dova.JDK.java.security.AccessControlContext arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object doIntersectionPrivilege(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AccessControlContext;)[Ljava/security/ProtectionDomain;", "public abstract")]
	JavaArray<Dova.JDK.java.security.ProtectionDomain> getProtectDomains(Dova.JDK.java.security.AccessControlContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.ProtectionDomain>>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;", "public abstract")]
	Dova.JDK.jdk.@internal.access.JavaSecurityAccess.ProtectionDomainCache getProtectionDomainCache()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess.ProtectionDomainCache>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;", "public abstract static interface")]
	public partial interface ProtectionDomainCache
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProtectionDomainCache()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "put", "(Ljava/security/ProtectionDomain;Ljava/security/PermissionCollection;)V"));
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", "public abstract")]
		Dova.JDK.java.security.PermissionCollection get(Dova.JDK.java.security.ProtectionDomain arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PermissionCollection>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;Ljava/security/PermissionCollection;)V", "public abstract")]
		void put(Dova.JDK.java.security.ProtectionDomain arg0, Dova.JDK.java.security.PermissionCollection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}
}
