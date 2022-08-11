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

namespace Dova.JDK.sun.security.krb5;

[JniSignatureAttribute("Lsun/security/krb5/KerberosSecrets;", "public")]
public partial class KerberosSecrets
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KerberosSecrets()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/krb5/KerberosSecrets;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "javaxSecurityAuthKerberosAccess", "Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaxSecurityAuthKerberosAccess", "()Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setJavaxSecurityAuthKerberosAccess", "(Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;)V"));
	}

	[JniSignatureAttribute("Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;", "private static")]
	public static Dova.JDK.sun.security.krb5.JavaxSecurityAuthKerberosAccess javaxSecurityAuthKerberosAccess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.JavaxSecurityAuthKerberosAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KerberosSecrets(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public KerberosSecrets() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/krb5/KerberosSecrets;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;", "public static")]
	public static Dova.JDK.sun.security.krb5.JavaxSecurityAuthKerberosAccess getJavaxSecurityAuthKerberosAccess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.krb5.JavaxSecurityAuthKerberosAccess>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/krb5/JavaxSecurityAuthKerberosAccess;)V", "public static")]
	public static void setJavaxSecurityAuthKerberosAccess(Dova.JDK.sun.security.krb5.JavaxSecurityAuthKerberosAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}
}
