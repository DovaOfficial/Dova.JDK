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

namespace Dova.JDK.sun.util.calendar;

[JniSignatureAttribute("Lsun/util/calendar/AbstractCalendar;", "public abstract")]
public partial class AbstractCalendar
	: Dova.JDK.sun.util.calendar.CalendarSystem
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractCalendar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/AbstractCalendar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECOND_IN_MILLIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINUTE_IN_MILLIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HOUR_IN_MILLIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAY_IN_MILLIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EPOCH_OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eras", "[Lsun/util/calendar/Era;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEras", "()[Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEras", "([Lsun/util/calendar/Era;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTime", "(Lsun/util/calendar/CalendarDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDayOfWeekDateOnOrBefore", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFixedDate", "(Lsun/util/calendar/CalendarDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeOfDay", "(Lsun/util/calendar/CalendarDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeOfDayValue", "(Lsun/util/calendar/CalendarDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDayOfWeekDateBefore", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDayOfWeekDateAfter", "(JI)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWeekLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateTime", "(Lsun/util/calendar/CalendarDate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalizeTime", "(Lsun/util/calendar/CalendarDate;)I"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SECOND_IN_MILLIS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MINUTE_IN_MILLIS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int HOUR_IN_MILLIS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int DAY_IN_MILLIS_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int EPOCH_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("[Lsun/util/calendar/Era;", "private")]
	public JavaArray<Dova.JDK.sun.util.calendar.Era> eras_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.util.calendar.Era>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractCalendar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AbstractCalendar() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/AbstractCalendar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lsun/util/calendar/Era;", "public")]
	public JavaArray<Dova.JDK.sun.util.calendar.Era> getEras()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.util.calendar.Era>>(ret);
	}

	[JniSignatureAttribute("([Lsun/util/calendar/Era;)V", "protected")]
	public void setEras(JavaArray<Dova.JDK.sun.util.calendar.Era> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)J", "public")]
	public long getTime(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "protected abstract")]
	public bool isLeapYear(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/util/calendar/Era;", "public")]
	public Dova.JDK.sun.util.calendar.Era getEra(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Era>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setTimeOfDay(Dova.JDK.sun.util.calendar.CalendarDate arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;J)V", "protected abstract")]
	public void getCalendarDateFromFixedDate(Dova.JDK.sun.util.calendar.CalendarDate arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(JI)J", "public static")]
	public static long getDayOfWeekDateOnOrBefore(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)J", "protected abstract")]
	public long getFixedDate(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V", "public")]
	public void setEra(Dova.JDK.sun.util.calendar.CalendarDate arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)J", "protected")]
	public long getTimeOfDay(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)J", "public")]
	public long getTimeOfDayValue(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getDayOfWeekDateBefore(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(JI)J", "static")]
	public static long getDayOfWeekDateAfter(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWeekLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate getNthDayOfWeek(int arg0, int arg1, Dova.JDK.sun.util.calendar.CalendarDate arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public")]
	public bool validateTime(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)I", "")]
	public int normalizeTime(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}
}
