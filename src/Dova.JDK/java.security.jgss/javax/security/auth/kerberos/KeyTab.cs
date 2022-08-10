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

namespace Dova.JDK.javax.security.auth.kerberos;

[JniSignatureAttribute("Ljavax/security/auth/kerberos/KeyTab;", "public final")]
public partial class KeyTab
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyTab()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/security/auth/kerberos/KeyTab;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "file", "Ljava/io/File;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "princ", "Ljavax/security/auth/kerberos/KerberosPrincipal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bound", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "KeyTab", "(Ljavax/security/auth/kerberos/KerberosPrincipal;Ljava/io/File;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljavax/security/auth/kerberos/KerberosPrincipal;)Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljavax/security/auth/kerberos/KerberosPrincipal;Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "exists", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getKeys", "(Ljavax/security/auth/kerberos/KerberosPrincipal;)[Ljavax/security/auth/kerberos/KerberosKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "takeSnapshot", "()Lsun/security/krb5/internal/ktab/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getUnboundInstance", "(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getUnboundInstance", "()Ljavax/security/auth/kerberos/KeyTab;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEncryptionKeys", "(Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrincipal", "()Ljavax/security/auth/kerberos/KerberosPrincipal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isBound", "()Z"));
	}

	[JniSignatureAttribute("Ljava/io/File;", "private final")]
	public Dova.JDK.java.io.File file_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/security/auth/kerberos/KerberosPrincipal;", "private final")]
	public Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal princ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool bound_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyTab(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosPrincipal;Ljava/io/File;Z)V", "private")]
	public KeyTab(Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg0, Dova.JDK.java.io.File arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/security/auth/kerberos/KeyTab;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getInstance(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosPrincipal;)Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getInstance(Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosPrincipal;Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getInstance(Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg0, Dova.JDK.java.io.File arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool exists()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/security/auth/kerberos/KerberosPrincipal;)[Ljavax/security/auth/kerberos/KerberosKey;", "public")]
	public JavaArray<Dova.JDK.javax.security.auth.kerberos.KerberosKey> getKeys(Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.security.auth.kerberos.KerberosKey>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/krb5/internal/ktab/KeyTab;", "")]
	public Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab takeSnapshot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.@internal.ktab.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getUnboundInstance(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("()Ljavax/security/auth/kerberos/KeyTab;", "public static")]
	public static Dova.JDK.javax.security.auth.kerberos.KeyTab getUnboundInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KeyTab>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/PrincipalName;)[Lsun/security/krb5/EncryptionKey;", "")]
	public JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey> getEncryptionKeys(Dova.JDK.sun.security.krb5.PrincipalName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.krb5.EncryptionKey>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/security/auth/kerberos/KerberosPrincipal;", "public")]
	public Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal getPrincipal()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.kerberos.KerberosPrincipal>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isBound()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}
}
