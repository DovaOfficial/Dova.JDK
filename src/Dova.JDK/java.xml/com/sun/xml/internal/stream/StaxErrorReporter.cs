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

namespace Dova.JDK.com.sun.xml.@internal.stream;

[JniSignatureAttribute("Lcom/sun/xml/internal/stream/StaxErrorReporter;", "public")]
public partial class StaxErrorReporter
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.XMLErrorReporter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StaxErrorReporter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/xml/internal/stream/StaxErrorReporter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fXMLReporter", "Ljavax/xml/stream/XMLReporter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportError", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertToStaxLocation", "(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;)Ljavax/xml/stream/Location;"));
	}

	[JniSignatureAttribute("Ljavax/xml/stream/XMLReporter;", "protected")]
	public Dova.JDK.javax.xml.stream.XMLReporter fXMLReporter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.XMLReporter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StaxErrorReporter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;)V", "public")]
	public StaxErrorReporter(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.PropertyManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public StaxErrorReporter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/xml/internal/stream/StaxErrorReporter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/PropertyManager;)V", "public")]
	public void reset(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.PropertyManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;S)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String reportError(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, short arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLLocator;)Ljavax/xml/stream/Location;", "")]
	public Dova.JDK.javax.xml.stream.Location convertToStaxLocation(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLLocator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.stream.Location>(ret);
	}
}
