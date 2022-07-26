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

[JniSignatureAttribute("Lsun/util/calendar/Gregorian;", "public")]
public partial class Gregorian
	: Dova.JDK.sun.util.calendar.BaseCalendar
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Gregorian()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/Gregorian;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate_0", "(Ljava/util/TimeZone;)Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate_1", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate_0", "()Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCalendarDate_1", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_0", "(J)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_1", "(J)Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_0", "()Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_1", "()Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_0", "(JLjava/util/TimeZone;)Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_1", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_0", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/Gregorian$Date;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDate_1", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Gregorian(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Gregorian() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/calendar/Gregorian;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date newCalendarDate_0(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate_1(Dova.JDK.java.util.TimeZone arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date newCalendarDate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate newCalendarDate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(J)Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date getCalendarDate_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date getCalendarDate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date getCalendarDate_0(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_1(long arg0, Dova.JDK.java.util.TimeZone arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/Gregorian$Date;", "public")]
	public Dova.JDK.sun.util.calendar.Gregorian.Date getCalendarDate_0(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.Gregorian.Date>(ret);
	}

	[JniSignatureAttribute("(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "public volatile")]
	public Dova.JDK.sun.util.calendar.CalendarDate getCalendarDate_1(long arg0, Dova.JDK.sun.util.calendar.CalendarDate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.CalendarDate>(ret);
	}

	[JniSignatureAttribute("Lsun/util/calendar/Gregorian$Date;", "static")]
	public partial class Date
		: Dova.JDK.sun.util.calendar.BaseCalendar.Date
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Date()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/calendar/Gregorian$Date;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/TimeZone;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNormalizedYear", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizedYear", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Date(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public Date() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/TimeZone;)V", "protected")]
		public Date(Dova.JDK.java.util.TimeZone arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/calendar/Gregorian$Date;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)V", "public")]
		public void setNormalizedYear(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getNormalizedYear()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
