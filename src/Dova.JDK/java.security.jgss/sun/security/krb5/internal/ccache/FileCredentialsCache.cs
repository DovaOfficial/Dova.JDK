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

namespace Dova.JDK.sun.security.krb5.@internal.ccache;

[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/FileCredentialsCache;", "public")]
public partial class FileCredentialsCache
	: Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache
	, Dova.JDK.sun.security.krb5.@internal.ccache.FileCCacheConstants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileCredentialsCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/internal/ccache/FileCredentialsCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lsun/security/krb5/internal/ccache/Tag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primaryPrincipal", "Lsun/security/krb5/PrincipalName;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "credentialsList", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dir", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configEntries", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Lsun/security/krb5/internal/ccache/Credentials;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "([Ljava/lang/String;[Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "save", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exists", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exec", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "acquireInstance", "()Lsun/security/krb5/internal/ccache/FileCredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "acquireInstance", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCredsList", "()[Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkValidation", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfigEntries", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultCreds", "()Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConfigEntry", "(Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultCacheName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "New", "(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryPrincipal", "()Lsun/security/krb5/PrincipalName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreds", "(Lsun/security/krb5/internal/LoginOptions;Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCreds", "(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialCreds", "()Lsun/security/krb5/Credentials;"));
	}

	[JniSignatureAttribute("I", "public")]
	public int version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/internal/ccache/Tag;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Tag tag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Tag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/krb5/PrincipalName;", "public")]
	public Dova.JDK.sun.security.krb5.PrincipalName primaryPrincipal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector credentialsList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String dir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List configEntries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FileCredentialsCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public FileCredentialsCache() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/internal/ccache/FileCredentialsCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/Credentials;)V", "public synchronized")]
	public void update(Dova.JDK.sun.security.krb5.@internal.ccache.Credentials arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "synchronized")]
	public void load(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/String;[Ljava/lang/String;)Z", "")]
	public bool match(JavaArray<Dova.JDK.java.lang.String> arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)V", "synchronized")]
	public void init(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void save()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool exists(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String exec(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/FileCredentialsCache;", "public static")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache acquireInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;", "public static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache acquireInstance(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/krb5/internal/ccache/Credentials;", "public synchronized")]
	public JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials> getCredsList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String checkValidation(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getConfigEntries()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ccache/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getDefaultCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/ccache/CredentialsCache$ConfigEntry;)V", "public")]
	public void addConfigEntry(Dova.JDK.sun.security.krb5.@internal.ccache.CredentialsCache.ConfigEntry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getDefaultCacheName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;", "static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache New(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;Ljava/lang/String;)Lsun/security/krb5/internal/ccache/FileCredentialsCache;", "static synchronized")]
	public static Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache New(Dova.JDK.sun.security.krb5.PrincipalName arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.FileCredentialsCache>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/PrincipalName;", "public synchronized")]
	public Dova.JDK.sun.security.krb5.PrincipalName getPrimaryPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.PrincipalName>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/internal/LoginOptions;Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCreds(Dova.JDK.sun.security.krb5.@internal.LoginOptions arg0, Dova.JDK.sun.security.krb5.PrincipalName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)Lsun/security/krb5/internal/ccache/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.@internal.ccache.Credentials getCreds(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ccache.Credentials>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/Credentials;", "public")]
	public Dova.JDK.sun.security.krb5.Credentials getInitialCreds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.Credentials>(ret);
	}
}
