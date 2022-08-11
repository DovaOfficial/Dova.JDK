/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "")]
public partial class Token
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Token()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/Token;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_INTERVAL", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Lsun/security/pkcs11/SunPKCS11;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p11", "Lsun/security/pkcs11/wrapper/PKCS11;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "config", "Lsun/security/pkcs11/Config;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokenInfo", "Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sessionManager", "Lsun/security/pkcs11/SessionManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "templateManager", "Lsun/security/pkcs11/TemplateManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "explicitCancel", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secretCache", "Lsun/security/pkcs11/KeyCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "privateCache", "Lsun/security/pkcs11/KeyCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rsaFactory", "Lsun/security/pkcs11/P11KeyFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dsaFactory", "Lsun/security/pkcs11/P11KeyFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dhFactory", "Lsun/security/pkcs11/P11KeyFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ecFactory", "Lsun/security/pkcs11/P11KeyFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mechInfoMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "secureRandom", "Lsun/security/pkcs11/P11SecureRandom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyStore", "Lsun/security/pkcs11/P11KeyStore;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastPresentCheck", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokenId", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeProtected", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loggedIn", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastLoginCheck", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_LOCK", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_MECH", "Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportsRawSecretKeyImport", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serializedTokens", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/SunPKCS11;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPresent", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "destroy", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureValid", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjSession", "()Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseSession", "(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpSession", "()Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsRawSecretKeyImport", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoggedInNow", "(Lsun/security/pkcs11/Session;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoggedIn", "(Lsun/security/pkcs11/Session;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killSession", "(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureLoggedIn", "(Lsun/security/pkcs11/Session;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWriteProtected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRandom", "()Lsun/security/pkcs11/P11SecureRandom;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyStore", "()Lsun/security/pkcs11/P11KeyStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMechanismInfo", "(J)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokenId", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyFactory", "(Ljava/lang/String;)Lsun/security/pkcs11/P11KeyFactory;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long CHECK_INTERVAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/SunPKCS11;", "final")]
	public Dova.JDK.sun.security.pkcs11.SunPKCS11 provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.SunPKCS11>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/PKCS11;", "final")]
	public Dova.JDK.sun.security.pkcs11.wrapper.PKCS11 p11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.PKCS11>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Config;", "final")]
	public Dova.JDK.sun.security.pkcs11.Config config_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Config>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_TOKEN_INFO;", "final")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO tokenInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_TOKEN_INFO>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager;", "final")]
	public Dova.JDK.sun.security.pkcs11.SessionManager sessionManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.SessionManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/TemplateManager;", "private final")]
	public Dova.JDK.sun.security.pkcs11.TemplateManager templateManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.TemplateManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool explicitCancel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/KeyCache;", "final")]
	public Dova.JDK.sun.security.pkcs11.KeyCache secretCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.KeyCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/KeyCache;", "final")]
	public Dova.JDK.sun.security.pkcs11.KeyCache privateCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.KeyCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyFactory;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11KeyFactory rsaFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyFactory;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11KeyFactory dsaFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyFactory;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11KeyFactory dhFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyFactory;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11KeyFactory ecFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map mechInfoMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11SecureRandom;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11SecureRandom secureRandom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11SecureRandom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyStore;", "private volatile")]
	public Dova.JDK.sun.security.pkcs11.P11KeyStore keyStore_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyStore>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool removable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool valid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastPresentCheck_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> tokenId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool writeProtected_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool loggedIn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastLoginCheck_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object CHECK_LOCK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;", "private static final")]
	public static Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO INVALID_MECH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean supportsRawSecretKeyImport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List serializedTokens_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Token(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/SunPKCS11;)V", "")]
	public Token(Dova.JDK.sun.security.pkcs11.SunPKCS11 arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/Token;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(J)Z", "")]
	public bool isPresent(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void destroy()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;JJ[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;)[Lsun/security/pkcs11/wrapper/CK_ATTRIBUTE;", "")]
	public JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> getAttributes(Dova.JDK.java.lang.String arg0, long arg1, long arg2, JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.pkcs11.wrapper.CK_ATTRIBUTE>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void ensureValid()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session getObjSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session releaseSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session getOpSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool supportsRawSecretKeyImport()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Z", "")]
	public bool isLoggedInNow(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Z", "")]
	public bool isLoggedIn(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session killSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)V", "")]
	public void ensureLoggedIn(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isWriteProtected()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/P11SecureRandom;", "")]
	public Dova.JDK.sun.security.pkcs11.P11SecureRandom getRandom()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11SecureRandom>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/P11KeyStore;", "")]
	public Dova.JDK.sun.security.pkcs11.P11KeyStore getKeyStore()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyStore>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/security/pkcs11/wrapper/CK_MECHANISM_INFO;", "")]
	public Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO getMechanismInfo(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.wrapper.CK_MECHANISM_INFO>(ret);
	}

	[JniSignatureAttribute("()[B", "private synchronized")]
	public JavaArray<byte> getTokenId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/pkcs11/P11KeyFactory;", "")]
	public Dova.JDK.sun.security.pkcs11.P11KeyFactory getKeyFactory(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11KeyFactory>(ret);
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Token$TokenRep;", "private static")]
	public partial class TokenRep
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TokenRep()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/Token$TokenRep;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokenId", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> tokenId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TokenRep(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/pkcs11/Token;)V", "")]
		public TokenRep(Dova.JDK.sun.security.pkcs11.Token arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/Token$TokenRep;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object readResolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
