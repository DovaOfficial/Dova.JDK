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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.utils;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/utils/SignatureElementProxy;", "public abstract")]
public partial class SignatureElementProxy
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.utils.ElementProxy
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureElementProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/utils/SignatureElementProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Element;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Document;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseNamespace", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureElementProxy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;)V", "public")]
	public SignatureElementProxy(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Document;)V", "public")]
	public SignatureElementProxy(Dova.JDK.org.w3c.dom.Document arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public SignatureElementProxy() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/utils/SignatureElementProxy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getBaseNamespace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
