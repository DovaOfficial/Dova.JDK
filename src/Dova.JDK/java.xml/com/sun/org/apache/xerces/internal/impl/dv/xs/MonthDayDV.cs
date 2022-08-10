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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/MonthDayDV;", "public")]
public partial class MonthDayDV
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonthDayDV()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/MonthDayDV;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MONTHDAY_SIZE", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MonthDayDV", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dateToString", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getActualValue", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getXMLGregorianCalendar", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/XMLGregorianCalendar;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MONTHDAY_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MonthDayDV(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MonthDayDV() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/MonthDayDV;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData parse(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String dateToString(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getActualValue(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/XMLGregorianCalendar;", "protected")]
	public Dova.JDK.javax.xml.datatype.XMLGregorianCalendar getXMLGregorianCalendar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.XMLGregorianCalendar>(ret);
	}
}
