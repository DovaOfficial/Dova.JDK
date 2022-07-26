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

namespace Dova.JDK.java.time.temporal;

[JniSignatureAttribute("Ljava/time/temporal/WeekFields;", "public final")]
public partial class WeekFields
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WeekFields()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/WeekFields;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO", "Ljava/time/temporal/WeekFields;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUNDAY_START", "Ljava/time/temporal/WeekFields;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_BASED_YEARS", "Ljava/time/temporal/TemporalUnit;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstDayOfWeek", "Ljava/time/DayOfWeek;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimalDays", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dayOfWeek", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weekOfMonth", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weekOfYear", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weekOfWeekBasedYear", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weekBasedYear", "Ljava/time/temporal/TemporalField;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/DayOfWeek;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/Locale;)Ljava/time/temporal/WeekFields;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/DayOfWeek;I)Ljava/time/temporal/WeekFields;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstDayOfWeek", "()Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimalDaysInFirstWeek", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dayOfWeek", "()Ljava/time/temporal/TemporalField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weekOfYear", "()Ljava/time/temporal/TemporalField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weekOfMonth", "()Ljava/time/temporal/TemporalField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weekOfWeekBasedYear", "()Ljava/time/temporal/TemporalField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "weekBasedYear", "()Ljava/time/temporal/TemporalField;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ConcurrentMap CACHE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/WeekFields;", "public static final")]
	public static Dova.JDK.java.time.temporal.WeekFields ISO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/WeekFields;", "public static final")]
	public static Dova.JDK.java.time.temporal.WeekFields SUNDAY_START_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalUnit WEEK_BASED_YEARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/time/DayOfWeek;", "private final")]
	public Dova.JDK.java.time.DayOfWeek firstDayOfWeek_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int minimalDays_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final transient")]
	public Dova.JDK.java.time.temporal.TemporalField dayOfWeek_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final transient")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfMonth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final transient")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfYear_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final transient")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfWeekBasedYear_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final transient")]
	public Dova.JDK.java.time.temporal.TemporalField weekBasedYear_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public WeekFields(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;I)V", "private")]
	public WeekFields(Dova.JDK.java.time.DayOfWeek arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/temporal/WeekFields;";
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

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/temporal/WeekFields;", "public static")]
	public static Dova.JDK.java.time.temporal.WeekFields of(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/DayOfWeek;I)Ljava/time/temporal/WeekFields;", "public static")]
	public static Dova.JDK.java.time.temporal.WeekFields of(Dova.JDK.java.time.DayOfWeek arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object readResolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/DayOfWeek;", "public")]
	public Dova.JDK.java.time.DayOfWeek getFirstDayOfWeek()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinimalDaysInFirstWeek()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalField;", "public")]
	public Dova.JDK.java.time.temporal.TemporalField dayOfWeek()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalField;", "public")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfYear()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalField;", "public")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfMonth()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalField;", "public")]
	public Dova.JDK.java.time.temporal.TemporalField weekOfWeekBasedYear()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalField;", "public")]
	public Dova.JDK.java.time.temporal.TemporalField weekBasedYear()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
	}

	[JniSignatureAttribute("Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
	public partial class ComputedDayOfField
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.temporal.TemporalField
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComputedDayOfField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/WeekFields$ComputedDayOfField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weekDef", "Ljava/time/temporal/WeekFields;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseUnit", "Ljava/time/temporal/TemporalUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rangeUnit", "Ljava/time/temporal/TemporalUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "range", "Ljava/time/temporal/ValueRange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAY_OF_WEEK_RANGE", "Ljava/time/temporal/ValueRange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_OF_MONTH_RANGE", "Ljava/time/temporal/ValueRange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_OF_YEAR_RANGE", "Ljava/time/temporal/ValueRange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_OF_WEEK_BASED_YEAR_RANGE", "Ljava/time/temporal/ValueRange;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/time/temporal/WeekFields;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/ValueRange;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_0", "(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_1", "(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/temporal/TemporalAccessor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "()Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedBy", "(Ljava/time/temporal/TemporalAccessor;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTimeBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrom", "(Ljava/time/temporal/TemporalAccessor;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustInto", "(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rangeRefinedBy", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDateBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseUnit", "()Ljava/time/temporal/TemporalUnit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRangeUnit", "()Ljava/time/temporal/TemporalUnit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDayOfWeekField", "(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofWeekOfMonthField", "(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofWeekOfYearField", "(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofWeekOfWeekBasedYearField", "(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofWeekBasedYearField", "(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedDayOfWeek", "(Ljava/time/temporal/TemporalAccessor;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedDayOfWeek", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startOfWeekOffset", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeWeek", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedWeekOfMonth", "(Ljava/time/temporal/TemporalAccessor;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedWeekOfYear", "(Ljava/time/temporal/TemporalAccessor;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedWeekOfWeekBasedYear", "(Ljava/time/temporal/TemporalAccessor;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedWeekBasedYear", "(Ljava/time/temporal/TemporalAccessor;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWeekBasedYear", "(Ljava/time/chrono/Chronology;III)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveWoM", "(Ljava/util/Map;Ljava/time/chrono/Chronology;IJJILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveWoY", "(Ljava/util/Map;Ljava/time/chrono/Chronology;IJILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveWBY", "(Ljava/util/Map;Ljava/time/chrono/Chronology;ILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rangeByWeek", "(Ljava/time/temporal/TemporalAccessor;Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rangeWeekOfWeekBasedYear", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/WeekFields;", "private final")]
		public Dova.JDK.java.time.temporal.WeekFields weekDef_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalUnit baseUnit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalUnit rangeUnit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private final")]
		public Dova.JDK.java.time.temporal.ValueRange range_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private static final")]
		public static Dova.JDK.java.time.temporal.ValueRange DAY_OF_WEEK_RANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private static final")]
		public static Dova.JDK.java.time.temporal.ValueRange WEEK_OF_MONTH_RANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private static final")]
		public static Dova.JDK.java.time.temporal.ValueRange WEEK_OF_YEAR_RANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private static final")]
		public static Dova.JDK.java.time.temporal.ValueRange WEEK_OF_WEEK_BASED_YEAR_RANGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComputedDayOfField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/time/temporal/WeekFields;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/ValueRange;)V", "private")]
		public ComputedDayOfField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.time.temporal.WeekFields arg1, Dova.JDK.java.time.temporal.TemporalUnit arg2, Dova.JDK.java.time.temporal.TemporalUnit arg3, Dova.JDK.java.time.temporal.ValueRange arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/temporal/WeekFields$ComputedDayOfField;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "public")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate resolve_0(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.temporal.TemporalAccessor arg1, Dova.JDK.java.time.format.ResolverStyle arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/temporal/TemporalAccessor;", "public volatile")]
		public Dova.JDK.java.time.temporal.TemporalAccessor resolve_1(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.temporal.TemporalAccessor arg1, Dova.JDK.java.time.format.ResolverStyle arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/temporal/ValueRange;", "public")]
		public Dova.JDK.java.time.temporal.ValueRange range()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDisplayName(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Z", "public")]
		public bool isSupportedBy(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTimeBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)J", "public")]
		public long getFrom(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;", "public")]
		public Dova.JDK.java.lang.Object adjustInto(Dova.JDK.java.lang.Object arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;", "public")]
		public Dova.JDK.java.time.temporal.ValueRange rangeRefinedBy(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDateBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/time/temporal/TemporalUnit;", "public")]
		public Dova.JDK.java.time.temporal.TemporalUnit getBaseUnit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/temporal/TemporalUnit;", "public")]
		public Dova.JDK.java.time.temporal.TemporalUnit getRangeUnit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
		public static Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField ofDayOfWeekField(Dova.JDK.java.time.temporal.WeekFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
		public static Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField ofWeekOfMonthField(Dova.JDK.java.time.temporal.WeekFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
		public static Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField ofWeekOfYearField(Dova.JDK.java.time.temporal.WeekFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
		public static Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField ofWeekOfWeekBasedYearField(Dova.JDK.java.time.temporal.WeekFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/WeekFields;)Ljava/time/temporal/WeekFields$ComputedDayOfField;", "static")]
		public static Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField ofWeekBasedYearField(Dova.JDK.java.time.temporal.WeekFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.WeekFields.ComputedDayOfField>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)I", "private")]
		public int localizedDayOfWeek(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "private")]
		public int localizedDayOfWeek(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "private")]
		public int startOfWeekOffset(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "private")]
		public int computeWeek(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)J", "private")]
		public long localizedWeekOfMonth(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)J", "private")]
		public long localizedWeekOfYear(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)I", "private")]
		public int localizedWeekOfWeekBasedYear(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)I", "private")]
		public int localizedWeekBasedYear(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/chrono/Chronology;III)Ljava/time/chrono/ChronoLocalDate;", "private")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate ofWeekBasedYear(Dova.JDK.java.time.chrono.Chronology arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/chrono/Chronology;IJJILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "private")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate resolveWoM(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.chrono.Chronology arg1, int arg2, long arg3, long arg4, int arg5, Dova.JDK.java.time.format.ResolverStyle arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/chrono/Chronology;IJILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "private")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate resolveWoY(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.chrono.Chronology arg1, int arg2, long arg3, int arg4, Dova.JDK.java.time.format.ResolverStyle arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/chrono/Chronology;ILjava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "private")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate resolveWBY(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.chrono.Chronology arg1, int arg2, Dova.JDK.java.time.format.ResolverStyle arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "private")]
		public Dova.JDK.java.time.temporal.ValueRange rangeByWeek(Dova.JDK.java.time.temporal.TemporalAccessor arg0, Dova.JDK.java.time.temporal.TemporalField arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;", "private")]
		public Dova.JDK.java.time.temporal.ValueRange rangeWeekOfWeekBasedYear(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}
	}
}
