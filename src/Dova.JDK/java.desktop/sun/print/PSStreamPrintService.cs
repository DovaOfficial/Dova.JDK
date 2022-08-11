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

namespace Dova.JDK.sun.print;

[JniSignatureAttribute("Lsun/print/PSStreamPrintService;", "public")]
public partial class PSStreamPrintService
	: Dova.JDK.javax.print.StreamPrintService
	, Dova.JDK.sun.print.SunPrinterJobService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PSStreamPrintService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/PSStreamPrintService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "suppAttrCats", "[Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAXCOPIES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mediaSizes", "[Ljavax/print/attribute/standard/MediaSizeName;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/OutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/print/attribute/PrintServiceAttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/Class;)Ljavax/print/attribute/PrintServiceAttribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttributeCategorySupported", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedAttributeValues", "(Ljava/lang/Class;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAttributeValueSupported", "(Ljavax/print/attribute/Attribute;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedDocFlavors", "()[Ljavax/print/DocFlavor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedCopies", "(Ljavax/print/attribute/standard/Copies;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedMedia", "(Ljavax/print/attribute/standard/MediaSizeName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputFormat", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPrintJob", "()Ljavax/print/DocPrintJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "usesClass", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePrintServiceAttributeListener", "(Ljavax/print/event/PrintServiceAttributeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSupportedAttributeCategories", "()[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultAttributeValue", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnsupportedAttributes", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljavax/print/attribute/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceUIFactory", "()Ljavax/print/ServiceUIFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocFlavorSupported", "(Ljavax/print/DocFlavor;)Z"));
	}

	[JniSignatureAttribute("[Ljava/lang/Class;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.Class> suppAttrCats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int MAXCOPIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[Ljavax/print/attribute/standard/MediaSizeName;", "private static final")]
	public static JavaArray<Dova.JDK.javax.print.attribute.standard.MediaSizeName> mediaSizes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.standard.MediaSizeName>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PSStreamPrintService(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/OutputStream;)V", "public")]
	public PSStreamPrintService(Dova.JDK.java.io.OutputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/print/PSStreamPrintService;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/print/attribute/PrintServiceAttributeSet;", "public")]
	public Dova.JDK.javax.print.attribute.PrintServiceAttributeSet getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.PrintServiceAttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/print/attribute/PrintServiceAttribute;", "public")]
	public Dova.JDK.java.lang.Object getAttribute(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool isAttributeCategorySupported(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getSupportedAttributeValues(Dova.JDK.java.lang.Class arg0, Dova.JDK.javax.print.DocFlavor arg1, Dova.JDK.javax.print.attribute.AttributeSet arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/Attribute;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Z", "public")]
	public bool isAttributeValueSupported(Dova.JDK.javax.print.attribute.Attribute arg0, Dova.JDK.javax.print.DocFlavor arg1, Dova.JDK.javax.print.attribute.AttributeSet arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()[Ljavax/print/DocFlavor;", "public")]
	public JavaArray<Dova.JDK.javax.print.DocFlavor> getSupportedDocFlavors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.DocFlavor>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/standard/Copies;)Z", "private")]
	public bool isSupportedCopies(Dova.JDK.javax.print.attribute.standard.Copies arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/standard/MediaSizeName;)Z", "private")]
	public bool isSupportedMedia(Dova.JDK.javax.print.attribute.standard.MediaSizeName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getOutputFormat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/DocPrintJob;", "public")]
	public Dova.JDK.javax.print.DocPrintJob createPrintJob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.DocPrintJob>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
	public bool usesClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintServiceAttributeListener;)V", "public")]
	public void addPrintServiceAttributeListener(Dova.JDK.javax.print.@event.PrintServiceAttributeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintServiceAttributeListener;)V", "public")]
	public void removePrintServiceAttributeListener(Dova.JDK.javax.print.@event.PrintServiceAttributeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> getSupportedAttributeCategories()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDefaultAttributeValue(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)Ljavax/print/attribute/AttributeSet;", "public")]
	public Dova.JDK.javax.print.attribute.AttributeSet getUnsupportedAttributes(Dova.JDK.javax.print.DocFlavor arg0, Dova.JDK.javax.print.attribute.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.AttributeSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/ServiceUIFactory;", "public")]
	public Dova.JDK.javax.print.ServiceUIFactory getServiceUIFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.ServiceUIFactory>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/DocFlavor;)Z", "public")]
	public bool isDocFlavorSupported(Dova.JDK.javax.print.DocFlavor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}
}
