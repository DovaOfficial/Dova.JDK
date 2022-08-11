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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;", "public abstract")]
public partial class DTDDVFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DTDDVFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_FACTORY_CLASS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XML11_DATATYPE_VALIDATOR_FACTORY", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuiltInDV", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBuiltInTypes", "()Ljava/util/Map;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_FACTORY_CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XML11_DATATYPE_VALIDATOR_FACTORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DTDDVFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public DTDDVFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/DTDDVFactory;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DTDDVFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/DatatypeValidator;", "public abstract")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator getBuiltInDV(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.DatatypeValidator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	public Dova.JDK.java.util.Map getBuiltInTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}
}
