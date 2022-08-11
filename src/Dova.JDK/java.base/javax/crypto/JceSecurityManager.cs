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

namespace Dova.JDK.javax.crypto;

[JniSignatureAttribute("Ljavax/crypto/JceSecurityManager;", "final")]
public partial class JceSecurityManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JceSecurityManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/crypto/JceSecurityManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultPolicy", "Ljavax/crypto/CryptoPermissions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exemptPolicy", "Ljavax/crypto/CryptoPermissions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allPerm", "Ljavax/crypto/CryptoAllPermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TrustedCallersCache", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "exemptCache", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE_NULL_MARK", "Ljavax/crypto/CryptoPermissions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljavax/crypto/JceSecurityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WALKER", "Ljava/lang/StackWalker;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCallerTrusted", "(Ljava/lang/Class;Ljava/security/Provider;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCryptoPermission", "(Ljava/lang/String;)Ljavax/crypto/CryptoPermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultPermission", "(Ljava/lang/String;)Ljavax/crypto/CryptoPermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAppPermissions", "(Ljava/net/URL;)Ljavax/crypto/CryptoPermissions;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCryptoPermissionFromURL", "(Ljava/net/URL;Ljava/lang/String;Ljavax/crypto/CryptoPermission;)Ljavax/crypto/CryptoPermission;"));
	}

	[JniSignatureAttribute("Ljavax/crypto/CryptoPermissions;", "private static final")]
	public static Dova.JDK.javax.crypto.CryptoPermissions defaultPolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermissions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/CryptoPermissions;", "private static final")]
	public static Dova.JDK.javax.crypto.CryptoPermissions exemptPolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermissions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/CryptoAllPermission;", "private static final")]
	public static Dova.JDK.javax.crypto.CryptoAllPermission allPerm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoAllPermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private static final")]
	public static Dova.JDK.java.util.Vector TrustedCallersCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ConcurrentMap exemptCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/CryptoPermissions;", "private static final")]
	public static Dova.JDK.javax.crypto.CryptoPermissions CACHE_NULL_MARK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermissions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/crypto/JceSecurityManager;", "static final")]
	public static Dova.JDK.javax.crypto.JceSecurityManager INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.JceSecurityManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StackWalker;", "static final")]
	public static Dova.JDK.java.lang.StackWalker WALKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StackWalker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JceSecurityManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public JceSecurityManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/crypto/JceSecurityManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/security/Provider;)Z", "")]
	public bool isCallerTrusted(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.security.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/crypto/CryptoPermission;", "")]
	public Dova.JDK.javax.crypto.CryptoPermission getCryptoPermission(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermission>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/crypto/CryptoPermission;", "private")]
	public Dova.JDK.javax.crypto.CryptoPermission getDefaultPermission(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermission>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljavax/crypto/CryptoPermissions;", "private static")]
	public static Dova.JDK.javax.crypto.CryptoPermissions getAppPermissions(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermissions>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;Ljavax/crypto/CryptoPermission;)Ljavax/crypto/CryptoPermission;", "")]
	public Dova.JDK.javax.crypto.CryptoPermission getCryptoPermissionFromURL(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.crypto.CryptoPermission arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.CryptoPermission>(ret);
	}
}
