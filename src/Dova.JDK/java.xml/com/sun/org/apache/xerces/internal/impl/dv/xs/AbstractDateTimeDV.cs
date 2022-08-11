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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;", "public abstract")]
public partial class AbstractDateTimeDV
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.TypeValidator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractDateTimeDV()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YEAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "datatypeFactory", "Ljavax/xml/datatype/DatatypeFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/lang/StringBuffer;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/lang/StringBuffer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Ljava/lang/String;IIC)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mod", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseInt", "(Ljava/lang/String;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeZone", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDuration", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapYear", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSecond", "(Ljava/lang/String;II)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDate", "(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareDates", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Z)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareOrder", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneDate", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findUTCSign", "(Ljava/lang/String;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYearMonth", "(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseIntYear", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNextCharUTCSign", "(Ljava/lang/String;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maxDayInMonthFor", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fQuotient", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fQuotient", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modulo", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append2", "(Ljava/lang/StringBuffer;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append3", "(Ljava/lang/StringBuffer;D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllowedFacets", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIdentical", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseTimeZone", "(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateDateTime", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveUnnormalized", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetDateObj", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateToString", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFractionalSecondsAsBigDecimal", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLGregorianCalendar", "(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/XMLGregorianCalendar;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int YEAR_Property
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

	[JniSignatureAttribute("I", "protected static final")]
	public static int MONTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int DAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/datatype/DatatypeFactory;", "protected static final")]
	public static Dova.JDK.javax.xml.datatype.DatatypeFactory datatypeFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.DatatypeFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractDateTimeDV(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AbstractDateTimeDV() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;D)V", "protected final")]
	public void append(Dova.JDK.java.lang.StringBuffer arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;II)V", "protected final")]
	public void append(Dova.JDK.java.lang.StringBuffer arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IIC)I", "protected")]
	public int indexOf(Dova.JDK.java.lang.String arg0, int arg1, int arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public")]
	public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "protected")]
	public int mod(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void normalize(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)I", "protected")]
	public int parseInt(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;II)V", "protected")]
	public void getTimeZone(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void getTime(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/Duration;", "protected")]
	public Dova.JDK.javax.xml.datatype.Duration getDuration(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.Duration>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool isLeapYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)D", "protected")]
	public double parseSecond(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)I", "protected")]
	public int getDate(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Z)S", "protected")]
	public short compareDates(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)S", "protected")]
	public short compareOrder(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "private")]
	public void cloneDate(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)I", "protected")]
	public int findUTCSign(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)I", "protected")]
	public int getYearMonth(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "protected")]
	public int parseIntYear(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)Z", "protected final")]
	public bool isNextCharUTCSign(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "protected")]
	public int maxDayInMonthFor(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "protected")]
	public int fQuotient(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "protected")]
	public int fQuotient(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "protected")]
	public int modulo(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;D)V", "protected final")]
	public void append2(Dova.JDK.java.lang.StringBuffer arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuffer;D)V", "private")]
	public void append3(Dova.JDK.java.lang.StringBuffer arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("()S", "public")]
	public short getAllowedFacets()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "public")]
	public bool isIdentical(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void parseTimeZone(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void validateDateTime(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void saveUnnormalized(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)V", "protected")]
	public void resetDateObj(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String dateToString(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljava/math/BigDecimal;", "protected final")]
	public Dova.JDK.java.math.BigDecimal getFractionalSecondsAsBigDecimal(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;)Ljavax/xml/datatype/XMLGregorianCalendar;", "protected")]
	public Dova.JDK.javax.xml.datatype.XMLGregorianCalendar getXMLGregorianCalendar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV.DateTimeData arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.XMLGregorianCalendar>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;", "static final")]
	public partial class DateTimeData
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.XSDateTime
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DateTimeData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "year", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "month", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "day", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hour", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minute", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utc", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "second", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timezoneHr", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timezoneMin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalValue", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "normalized", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormYear", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormMonth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormDay", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormHour", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormMinute", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unNormSecond", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "position", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canonical", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIIIDILjava/lang/String;ZLcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize", "()Lcom/sun/org/apache/xerces/internal/xs/datatypes/XSDateTime;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonths", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeconds", "()D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDuration", "()Ljavax/xml/datatype/Duration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDays", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYears", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHours", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinutes", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNormalized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTimeZone", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeZoneHours", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeZoneMinutes", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLexicalValue", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;"));
		}

		[JniSignatureAttribute("I", "")]
		public int year_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int month_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int day_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int hour_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int minute_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int utc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("D", "")]
		public double second_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int timezoneHr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int timezoneMin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String originalValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool normalized_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int unNormYear_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int unNormMonth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int unNormDay_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int unNormHour_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int unNormMinute_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("D", "")]
		public double unNormSecond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int position_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private volatile")]
		public Dova.JDK.java.lang.String canonical_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DateTimeData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;)V", "public")]
		public DateTimeData(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(IIIIIDILjava/lang/String;ZLcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV;)V", "public")]
		public DateTimeData(int arg0, int arg1, int arg2, int arg3, int arg4, double arg5, int arg6, Dova.JDK.java.lang.String arg7, bool arg8, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.xs.AbstractDateTimeDV arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dv/xs/AbstractDateTimeDV$DateTimeData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/datatypes/XSDateTime;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.XSDateTime normalize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.datatypes.XSDateTime>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getMonths()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()D", "public")]
		public double getSeconds()
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/xml/datatype/Duration;", "public")]
		public Dova.JDK.javax.xml.datatype.Duration getDuration()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.Duration>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getDays()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getYears()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getHours()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getMinutes()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNormalized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasTimeZone()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTimeZoneHours()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTimeZoneMinutes()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getLexicalValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/xml/datatype/XMLGregorianCalendar;", "public")]
		public Dova.JDK.javax.xml.datatype.XMLGregorianCalendar getXMLGregorianCalendar()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.datatype.XMLGregorianCalendar>(ret);
		}
	}
}
