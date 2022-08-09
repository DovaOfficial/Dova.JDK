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

namespace Dova.JDK.java.security;

[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "public")]
public partial class ProtectionDomain
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProtectionDomain()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/ProtectionDomain;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "filePermCompatInPD", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "codesource", "Ljava/security/CodeSource;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "classloader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "principals", "[Ljava/security/Principal;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "permissions", "Ljava/security/PermissionCollection;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "hasAllPerm", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "staticPermissions", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "key", "Ljava/security/ProtectionDomain$Key;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProtectionDomain", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProtectionDomain", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCodeSource", "()Ljava/security/CodeSource;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "implies", "(Ljava/security/Permission;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "seeAllp", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mergePermissions", "()Ljava/security/PermissionCollection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPermissions", "()Ljava/security/PermissionCollection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPrincipals", "()[Ljava/security/Principal;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "staticPermissionsOnly", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "impliesWithAltFilePerm", "(Ljava/security/Permission;)Z"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool filePermCompatInPD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/security/CodeSource;", "private")]
	public Dova.JDK.java.security.CodeSource codesource_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader classloader_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/security/Principal;", "private")]
	public JavaArray<Dova.JDK.java.security.Principal> principals_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.Principal>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/PermissionCollection;", "private")]
	public Dova.JDK.java.security.PermissionCollection permissions_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PermissionCollection>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasAllPerm_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool staticPermissions_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain$Key;", "final")]
	public Dova.JDK.java.security.ProtectionDomain.Key key_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain.Key>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProtectionDomain(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V", "public")]
	public ProtectionDomain(Dova.JDK.java.security.CodeSource arg0, Dova.JDK.java.security.PermissionCollection arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLoader;[Ljava/security/Principal;)V", "public")]
	public ProtectionDomain(Dova.JDK.java.security.CodeSource arg0, Dova.JDK.java.security.PermissionCollection arg1, Dova.JDK.java.lang.ClassLoader arg2, JavaArray<Dova.JDK.java.security.Principal> arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/security/ProtectionDomain;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public final")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/CodeSource;", "public final")]
	public Dova.JDK.java.security.CodeSource getCodeSource()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Permission;)Z", "public")]
	public bool implies(Dova.JDK.java.security.Permission arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool seeAllp()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/security/PermissionCollection;", "private")]
	public Dova.JDK.java.security.PermissionCollection mergePermissions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PermissionCollection>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/PermissionCollection;", "public final")]
	public Dova.JDK.java.security.PermissionCollection getPermissions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PermissionCollection>(ret);
	}

	[JniSignatureAttribute("()[Ljava/security/Principal;", "public final")]
	public JavaArray<Dova.JDK.java.security.Principal> getPrincipals()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.Principal>>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool staticPermissionsOnly()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Permission;)Z", "")]
	public bool impliesWithAltFilePerm(Dova.JDK.java.security.Permission arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain$Key;", "static final")]
	public partial class Key
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Key()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/ProtectionDomain$Key;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Key", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Key(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Key() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/security/ProtectionDomain$Key;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain$DebugHolder;", "private static")]
	public partial class DebugHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DebugHolder()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/ProtectionDomain$DebugHolder;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "debug", "Lsun/security/util/Debug;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DebugHolder", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
		public static Dova.JDK.sun.security.util.Debug debug_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DebugHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DebugHolder() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/security/ProtectionDomain$DebugHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain$JavaSecurityAccessImpl;", "private static")]
	public partial class JavaSecurityAccessImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.access.JavaSecurityAccess
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JavaSecurityAccessImpl()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/security/ProtectionDomain$JavaSecurityAccessImpl;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JavaSecurityAccessImpl", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCombinedACC", "(Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doIntersectionPrivilege", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doIntersectionPrivilege", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getProtectDomains", "(Ljava/security/AccessControlContext;)[Ljava/security/ProtectionDomain;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getProtectionDomainCache", "()Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JavaSecurityAccessImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public JavaSecurityAccessImpl() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/security/ProtectionDomain$JavaSecurityAccessImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/security/AccessControlContext;", "private static")]
		public static Dova.JDK.java.security.AccessControlContext getCombinedACC(Dova.JDK.java.security.AccessControlContext arg0, Dova.JDK.java.security.AccessControlContext arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object doIntersectionPrivilege(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1, Dova.JDK.java.security.AccessControlContext arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object doIntersectionPrivilege(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.security.AccessControlContext arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/AccessControlContext;)[Ljava/security/ProtectionDomain;", "public")]
		public JavaArray<Dova.JDK.java.security.ProtectionDomain> getProtectDomains(Dova.JDK.java.security.AccessControlContext arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.ProtectionDomain>>(ret);
		}

		[JniSignatureAttribute("()Ljdk/internal/access/JavaSecurityAccess$ProtectionDomainCache;", "public")]
		public Dova.JDK.jdk.@internal.access.JavaSecurityAccess.ProtectionDomainCache getProtectionDomainCache()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaSecurityAccess.ProtectionDomainCache>(ret);
		}
	}
}