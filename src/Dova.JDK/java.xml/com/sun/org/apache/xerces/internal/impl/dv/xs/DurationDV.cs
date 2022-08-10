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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/DurationDV;", "public")]
public partial class DurationDV
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DurationDV()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/DurationDV;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DURATION_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "YEARMONTHDURATION_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DAYTIMEDURATION_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DATETIMES", "[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DurationDV", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDuration", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseSecond", "(Ljava/lang/String;II)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareDates", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Z)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compareResults", "(SSZ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getActualValue", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addDuration", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dateToString", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DURATION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int YEARMONTHDURATION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DAYTIMEDURATION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData> DATETIMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DurationDV(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DurationDV() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/DurationDV;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;", "protected")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData parse(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/Duration;", "protected")]
	public Dova.JDK.javax.xml.datatype.Duration getDuration(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)D", "protected")]
	public double parseSecond(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Z)S", "protected")]
	public short compareDates(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(SSZ)S", "private")]
	public short compareResults(short arg0, short arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/ValidationContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getActualValue(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.ValidationContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData addDuration(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String dateToString(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
