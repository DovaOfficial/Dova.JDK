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

namespace Dova.JDK.javax.print;

[JniSignatureAttribute("Ljavax/print/PrintService;", "public abstract interface")]
public partial interface PrintService
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/PrintService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljavax/print/attribute/PrintServiceAttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttribute", "(Ljava/lang/Class;)Ljavax/print/attribute/PrintServiceAttribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getUnsupportedAttributes", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljavax/print/attribute/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPrintJob", "()Ljavax/print/DocPrintJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addPrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removePrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSupportedDocFlavors", "()[Ljavax/print/DocFlavor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDocFlavorSupported", "(Ljavax/print/DocFlavor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSupportedAttributeCategories", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAttributeCategorySupported", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultAttributeValue", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSupportedAttributeValues", "(Ljava/lang/Class;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAttributeValueSupported", "(Ljavax/print/attribute/Attribute;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getServiceUIFactory", "()Ljavax/print/ServiceUIFactory;"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/print/attribute/PrintServiceAttributeSet;", "public abstract")]
	Dova.JDK.javax.print.attribute.PrintServiceAttributeSet getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.PrintServiceAttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/print/attribute/PrintServiceAttribute;", "public abstract")]
	Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljavax/print/attribute/AttributeSet;", "public abstract")]
	Dova.JDK.javax.print.attribute.AttributeSet getUnsupportedAttributes(Dova.JDK.javax.print.DocFlavor arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.AttributeSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/DocPrintJob;", "public abstract")]
	Dova.JDK.javax.print.DocPrintJob createPrintJob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.DocPrintJob>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintServiceAttributeListener;)V", "public abstract")]
	void addPrintServiceAttributeListener(Dova.JDK.javax.print.@event.PrintServiceAttributeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintServiceAttributeListener;)V", "public abstract")]
	void removePrintServiceAttributeListener(Dova.JDK.javax.print.@event.PrintServiceAttributeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/print/DocFlavor;", "public abstract")]
	JavaArray<Dova.JDK.javax.print.DocFlavor> getSupportedDocFlavors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.DocFlavor>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;)Z", "public abstract")]
	bool isDocFlavorSupported(Dova.JDK.javax.print.DocFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.Class> getSupportedAttributeCategories()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isAttributeCategorySupported(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getDefaultAttributeValue(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getSupportedAttributeValues(Dova.JDK.java.lang.Class arg0, Dova.JDK.javax.print.DocFlavor arg1, Dova.JDK.javax.print.attribute.AttributeSet arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/Attribute;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Z", "public abstract")]
	bool isAttributeValueSupported(Dova.JDK.javax.print.attribute.Attribute arg0, Dova.JDK.javax.print.DocFlavor arg1, Dova.JDK.javax.print.attribute.AttributeSet arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/print/ServiceUIFactory;", "public abstract")]
	Dova.JDK.javax.print.ServiceUIFactory getServiceUIFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.ServiceUIFactory>(ret);
	}
}
