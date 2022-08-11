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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.jaxp;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/jaxp/JAXPVariableStack;", "public")]
public partial class JAXPVariableStack
	: Dova.JDK.com.sun.org.apache.xpath.@internal.VariableStack
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JAXPVariableStack()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/jaxp/JAXPVariableStack;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolver", "Ljavax/xml/xpath/XPathVariableResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/xpath/XPathVariableResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariableOrParam", "(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/utils/QName;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
	}

	[JniSignatureAttribute("Ljavax/xml/xpath/XPathVariableResolver;", "private final")]
	public Dova.JDK.javax.xml.xpath.XPathVariableResolver resolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathVariableResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JAXPVariableStack(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/xml/xpath/XPathVariableResolver;)V", "public")]
	public JAXPVariableStack(Dova.JDK.javax.xml.xpath.XPathVariableResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/jaxp/JAXPVariableStack;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;Lcom/sun/org/apache/xml/internal/utils/QName;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject getVariableOrParam(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, Dova.JDK.com.sun.org.apache.xml.@internal.utils.QName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}
}
