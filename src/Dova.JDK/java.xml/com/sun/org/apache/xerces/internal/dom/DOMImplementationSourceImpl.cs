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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DOMImplementationSourceImpl;", "public")]
public partial class DOMImplementationSourceImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.org.w3c.dom.DOMImplementationSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMImplementationSourceImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DOMImplementationSourceImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "testImpl", "(Lorg/w3c/dom/DOMImplementation;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMImplementationSourceImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DOMImplementationSourceImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DOMImplementationSourceImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", "public")]
	public Dova.JDK.org.w3c.dom.DOMImplementation getDOMImplementation(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementation>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DOMImplementation;Ljava/lang/String;)Z", "")]
	public bool testImpl(Dova.JDK.org.w3c.dom.DOMImplementation arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", "public")]
	public Dova.JDK.org.w3c.dom.DOMImplementationList getDOMImplementationList(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementationList>(ret);
	}
}
