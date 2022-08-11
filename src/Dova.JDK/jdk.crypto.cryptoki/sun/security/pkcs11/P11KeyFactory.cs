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

[JniSignatureAttribute("Lsun/security/pkcs11/P11KeyFactory;", "abstract")]
public partial class P11KeyFactory
	: Dova.JDK.java.security.KeyFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static P11KeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/P11KeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lsun/security/pkcs11/Token;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "keyTypes", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertKey", "(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;)Lsun/security/pkcs11/P11Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implTranslatePublicKey", "(Ljava/security/PublicKey;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implTranslatePrivateKey", "(Ljava/security/PrivateKey;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implGetPublicKeySpec", "(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implGetPrivateKeySpec", "(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implGetSoftwareFactory", "()Ljava/security/KeyFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addKeyType", "(Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPKCS11KeyType", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;"));
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "final")]
	public Dova.JDK.sun.security.pkcs11.Token token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map keyTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public P11KeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/lang/String;)V", "")]
	public P11KeyFactory(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/P11KeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;Ljava/security/Key;Ljava/lang/String;)Lsun/security/pkcs11/P11Key;", "static")]
	public static Dova.JDK.sun.security.pkcs11.P11Key convertKey(Dova.JDK.sun.security.pkcs11.Token arg0, Dova.JDK.java.security.Key arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.P11Key>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PublicKey;)Ljava/security/PublicKey;", "abstract")]
	public Dova.JDK.java.security.PublicKey implTranslatePublicKey(Dova.JDK.java.security.PublicKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivateKey;)Ljava/security/PrivateKey;", "abstract")]
	public Dova.JDK.java.security.PrivateKey implTranslatePrivateKey(Dova.JDK.java.security.PrivateKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;", "abstract")]
	public Dova.JDK.java.lang.Object implGetPublicKeySpec(Dova.JDK.sun.security.pkcs11.P11Key arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.sun.security.pkcs11.Session> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/P11Key;Ljava/lang/Class;[Lsun/security/pkcs11/Session;)Ljava/security/spec/KeySpec;", "abstract")]
	public Dova.JDK.java.lang.Object implGetPrivateKeySpec(Dova.JDK.sun.security.pkcs11.P11Key arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.sun.security.pkcs11.Session> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/security/KeyFactory;", "abstract")]
	public Dova.JDK.java.security.KeyFactory implGetSoftwareFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)Ljava/security/Key;", "protected final")]
	public Dova.JDK.java.security.Key engineTranslateKey(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;J)V", "private static")]
	public static void addKeyType(Dova.JDK.java.lang.String arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "static")]
	public static long getPKCS11KeyType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "protected final")]
	public Dova.JDK.java.lang.Object engineGetKeySpec(Dova.JDK.java.security.Key arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
