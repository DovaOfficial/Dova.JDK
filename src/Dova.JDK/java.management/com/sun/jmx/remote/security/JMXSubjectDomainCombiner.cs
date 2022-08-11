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

namespace Dova.JDK.com.sun.jmx.remote.security;

[JniSignatureAttribute("Lcom/sun/jmx/remote/security/JMXSubjectDomainCombiner;", "public")]
public partial class JMXSubjectDomainCombiner
	: Dova.JDK.javax.security.auth.SubjectDomainCombiner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JMXSubjectDomainCombiner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/security/JMXSubjectDomainCombiner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nullCodeSource", "Ljava/security/CodeSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pdNoPerms", "Ljava/security/ProtectionDomain;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/security/auth/Subject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getContext", "(Ljavax/security/auth/Subject;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDomainCombinerContext", "(Ljavax/security/auth/Subject;)Ljava/security/AccessControlContext;"));
	}

	[JniSignatureAttribute("Ljava/security/CodeSource;", "private static final")]
	public static Dova.JDK.java.security.CodeSource nullCodeSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.CodeSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private static final")]
	public static Dova.JDK.java.security.ProtectionDomain pdNoPerms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JMXSubjectDomainCombiner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)V", "public")]
	public JMXSubjectDomainCombiner(Dova.JDK.javax.security.auth.Subject arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/security/JMXSubjectDomainCombiner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/security/AccessControlContext;", "public static")]
	public static Dova.JDK.java.security.AccessControlContext getContext(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/security/ProtectionDomain;", "public")]
	public JavaArray<Dova.JDK.java.security.ProtectionDomain> combine(JavaArray<Dova.JDK.java.security.ProtectionDomain> arg0, JavaArray<Dova.JDK.java.security.ProtectionDomain> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.ProtectionDomain>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/security/auth/Subject;)Ljava/security/AccessControlContext;", "public static")]
	public static Dova.JDK.java.security.AccessControlContext getDomainCombinerContext(Dova.JDK.javax.security.auth.Subject arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}
}
