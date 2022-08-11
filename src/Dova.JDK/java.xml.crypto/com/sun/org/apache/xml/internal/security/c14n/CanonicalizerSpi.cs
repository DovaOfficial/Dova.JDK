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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.c14n;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/c14n/CanonicalizerSpi;", "public abstract")]
public partial class CanonicalizerSpi
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CanonicalizerSpi()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/c14n/CanonicalizerSpi;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalizeXPathNodeSet", "(Ljava/util/Set;Ljava/lang/String;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalizeXPathNodeSet", "(Ljava/util/Set;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalize", "([BLjava/io/OutputStream;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetURI", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalizeSubTree", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalizeSubTree", "(Lorg/w3c/dom/Node;Ljava/lang/String;ZLjava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineCanonicalizeSubTree", "(Lorg/w3c/dom/Node;Ljava/io/OutputStream;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CanonicalizerSpi(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CanonicalizerSpi() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/c14n/CanonicalizerSpi;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/io/OutputStream;)V", "public abstract")]
	public void engineCanonicalizeXPathNodeSet(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/io/OutputStream;)V", "public abstract")]
	public void engineCanonicalizeXPathNodeSet(Dova.JDK.java.util.Set arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("([BLjava/io/OutputStream;Z)V", "public")]
	public void engineCanonicalize(JavaArray<byte> arg0, Dova.JDK.java.io.OutputStream arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String engineGetURI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/io/OutputStream;)V", "public abstract")]
	public void engineCanonicalizeSubTree(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.io.OutputStream arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;ZLjava/io/OutputStream;)V", "public abstract")]
	public void engineCanonicalizeSubTree(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.io.OutputStream arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/io/OutputStream;)V", "public abstract")]
	public void engineCanonicalizeSubTree(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}
}
