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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/StAXValidatorHelper;", "public final")]
public partial class StAXValidatorHelper
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.ValidatorHelper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StAXValidatorHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/jaxp/validation/StAXValidatorHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComponentManager", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/XMLSchemaValidatorComponentManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identityTransformer1", "Ljavax/xml/transform/Transformer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identityTransformer2", "Ljavax/xml/transform/sax/TransformerHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lcom/sun/org/apache/xerces/internal/jaxp/validation/ValidatorHandlerImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/jaxp/validation/XMLSchemaValidatorComponentManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/XMLSchemaValidatorComponentManager;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.XMLSchemaValidatorComponentManager fComponentManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.XMLSchemaValidatorComponentManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/Transformer;", "private")]
	public Dova.JDK.javax.xml.transform.Transformer identityTransformer1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.Transformer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/sax/TransformerHandler;", "private")]
	public Dova.JDK.javax.xml.transform.sax.TransformerHandler identityTransformer2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.sax.TransformerHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/jaxp/validation/ValidatorHandlerImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.ValidatorHandlerImpl handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.ValidatorHandlerImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StAXValidatorHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/jaxp/validation/XMLSchemaValidatorComponentManager;)V", "public")]
	public StAXValidatorHelper(Dova.JDK.com.sun.org.apache.xerces.@internal.jaxp.validation.XMLSchemaValidatorComponentManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/jaxp/validation/StAXValidatorHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", "public")]
	public void validate(Dova.JDK.javax.xml.transform.Source arg0, Dova.JDK.javax.xml.transform.Result arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
