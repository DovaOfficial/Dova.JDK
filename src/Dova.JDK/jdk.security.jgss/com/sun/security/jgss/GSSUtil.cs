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

namespace Dova.JDK.com.sun.security.jgss;

[JniSignatureAttribute("Lcom/sun/security/jgss/GSSUtil;", "public")]
public partial class GSSUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GSSUtil()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/security/jgss/GSSUtil;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSubject", "(Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/GSSCredential;)Ljavax/security/auth/Subject;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GSSUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public GSSUtil() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/security/jgss/GSSUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/ietf/jgss/GSSName;Lorg/ietf/jgss/GSSCredential;)Ljavax/security/auth/Subject;", "public static")]
	public static Dova.JDK.javax.security.auth.Subject createSubject(Dova.JDK.org.ietf.jgss.GSSName arg0, Dova.JDK.org.ietf.jgss.GSSCredential arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.security.auth.Subject>(ret);
	}
}
