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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/DOMDocumentHandler;", "abstract interface")]
public partial interface DOMDocumentHandler
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLDocumentHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMDocumentHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/DOMDocumentHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "comment", "(Lorg/w3c/dom/Comment;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDOMResult", "(Ljavax/xml/transform/dom/DOMResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setIgnoringCharacters", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cdata", "(Lorg/w3c/dom/CDATASection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doctypeDecl", "(Lorg/w3c/dom/DocumentType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "characters", "(Lorg/w3c/dom/Text;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "processingInstruction", "(Lorg/w3c/dom/ProcessingInstruction;)V"));
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Comment;)V", "public abstract")]
	void comment(Dova.JDK.org.w3c.dom.Comment arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/dom/DOMResult;)V", "public abstract")]
	void setDOMResult(Dova.JDK.javax.xml.transform.dom.DOMResult arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setIgnoringCharacters(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/CDATASection;)V", "public abstract")]
	void cdata(Dova.JDK.org.w3c.dom.CDATASection arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/DocumentType;)V", "public abstract")]
	void doctypeDecl(Dova.JDK.org.w3c.dom.DocumentType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Text;)V", "public abstract")]
	void characters(Dova.JDK.org.w3c.dom.Text arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/ProcessingInstruction;)V", "public abstract")]
	void processingInstruction(Dova.JDK.org.w3c.dom.ProcessingInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
