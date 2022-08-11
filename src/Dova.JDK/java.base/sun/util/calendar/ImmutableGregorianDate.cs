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

[JniSignatureAttribute("Lsun/util/calendar/ImmutableGregorianDate;", "")]
public partial class ImmutableGregorianDate
	: Dova.JDK.sun.util.calendar.BaseCalendar.Date
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImmutableGregorianDate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/ImmutableGregorianDate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "date", "Lsun/util/calendar/BaseCalendar$Date;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/util/calendar/BaseCalendar$Date;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsupported", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addYear", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getZone", "()Ljava/util/TimeZone;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeconds", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapYear", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfWeek", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra", "()Lsun/util/calendar/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimeOfDay", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDate", "(III)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocale", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNormalizedYear", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizedYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMonth", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHours", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHours", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinutes", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMinutes", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSeconds", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNormalized", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDaylightTime", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getZoneOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setZone", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMillis", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setYear", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDaylightSaving", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEra", "(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setZoneOffset", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDaylightSaving", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLeapYear", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNormalized", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeOfDay", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStandardTime", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMillis", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDayOfWeek", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMonth", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHours", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMinutes", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSeconds", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMillis", "(I)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDate", "(III)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStandardTime", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameDate", "(Lsun/util/calendar/CalendarDate;)Z"));
	}

	[JniSignatureAttribute("Lsun/util/calendar/BaseCalendar$Date;", "private final")]
	public Dova.JDK.sun.util.calendar.BaseCalendar.Date date_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.BaseCalendar.Date>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImmutableGregorianDate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/util/calendar/BaseCalendar$Date;)V", "")]
	public ImmutableGregorianDate(Dova.JDK.sun.util.calendar.BaseCalendar.Date arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/ImmutableGregorianDate;";
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

	[JniSignatureAttribute("()V", "private")]
	public void unsupported()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfMonth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/TimeZone;", "public")]
	public Dova.JDK.java.util.TimeZone getZone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.TimeZone>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSeconds()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLeapYear()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMonth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfWeek()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/util/calendar/Era;", "public")]
	public Dova.JDK.sun.util.calendar.Era getEra()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Era>(ret);
	}

	[JniSignatureAttribute("(J)V", "protected")]
	public void setTimeOfDay(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(IIII)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setTimeOfDay(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(III)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setDate(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "protected")]
	public void setLocale(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setNormalizedYear(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNormalizedYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setDayOfMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHours()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setHours(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinutes()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setMinutes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setSeconds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNormalized()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDaylightTime()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getZoneOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setZone(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMillis()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDaylightSaving()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setEra(Dova.JDK.sun.util.calendar.Era arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setZoneOffset(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setDaylightSaving(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setLeapYear(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void setNormalized(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getTimeOfDay()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStandardTime()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate setMillis(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setDayOfWeek(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addDayOfMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addHours(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addMinutes(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addSeconds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addMillis(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(III)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addDate(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(IIII)Lsun/util/calendar/CalendarDate;", "public")]
	public Dova.JDK.sun.util.calendar.CalendarDate addTimeOfDay(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setStandardTime(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lsun/util/calendar/CalendarDate;)Z", "public")]
	public bool isSameDate(Dova.JDK.sun.util.calendar.CalendarDate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return ret;
	}
}
