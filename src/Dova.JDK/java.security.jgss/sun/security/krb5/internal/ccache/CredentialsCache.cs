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

namespace Dova.JDK.sun.security.krb5.@internal.ccache;

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/CredentialsCache;", "public abstract")]
public partial class CredentialsCache
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CredentialsCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/CredentialsCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "singleton", "Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "cacheName", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CredentialsCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "update", "(Lsun/security/krb5/internal/ccache/Credentials;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "save", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCredsList", "()[Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConfigEntries", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultCreds", "()Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addConfigEntry", "(Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConfigEntry", "(Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "cacheName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrimaryPrincipal", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCreds", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCreds", "(Lsun/security/krb5/internal/LoginOptions;Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInitialCreds", "()Lsun/security/krb5/Credentials;"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/CredentialsCache;", "static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache singleton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String cacheName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CredentialsCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CredentialsCache() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/CredentialsCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/Credentials;)V", "public abstract")]
	public void update(Dova.JDK.sun.security.krb5.@internal.ccache.Credentials arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getInstance(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache getInstance(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void save()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache create(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache create(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials> getCredsList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	public Dova.JDK.java.util.List getConfigEntries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getDefaultCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V", "public abstract")]
	public void addConfigEntry(Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache.ConfigEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache.ConfigEntry getConfigEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache.ConfigEntry>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String cacheName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public abstract")]
	public Dova.JDK.sun.security.krb5.PrincipalName getPrimaryPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCreds(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/LoginOptions;Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;", "public abstract")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCreds(Dova.JDK.sun.security.krb5.@internal.LoginOptions arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public abstract")]
	public Dova.JDK.sun.security.krb5.Credentials getInitialCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;", "public static")]
	public partial class ConfigEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ConfigEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "princ", "Lsun/security/krb5/PrincipalName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "data", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ConfigEntry", "(Ljava/lang/String;Lsun/security/krb5/PrincipalName;[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrinc", "()Lsun/security/krb5/PrincipalName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSName", "()Lsun/security/krb5/PrincipalName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getData", "()[B"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "private final")]
		public Dova.JDK.sun.security.krb5.PrincipalName princ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ConfigEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/security/krb5/PrincipalName;[B)V", "public")]
		public ConfigEntry(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1, JavaArray<byte> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
		public Dova.JDK.sun.security.krb5.PrincipalName getPrinc()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public")]
		public Dova.JDK.sun.security.krb5.PrincipalName getSName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> getData()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}
}
