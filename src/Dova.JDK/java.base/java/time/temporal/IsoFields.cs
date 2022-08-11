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

[JniSignatureAttribute("Ljava/time/temporal/IsoFields;", "public final")]
public partial class IsoFields
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IsoFields()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/IsoFields;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAY_OF_QUARTER", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUARTER_OF_YEAR", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_OF_WEEK_BASED_YEAR", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_BASED_YEAR", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_BASED_YEARS", "Ljava/time/temporal/TemporalUnit;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUARTER_YEARS", "Ljava/time/temporal/TemporalUnit;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isIso", "(Ljava/time/temporal/TemporalAccessor;)Z"));
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalField DAY_OF_QUARTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalField QUARTER_OF_YEAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalField WEEK_OF_WEEK_BASED_YEAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalField WEEK_BASED_YEAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalUnit WEEK_BASED_YEARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalUnit QUARTER_YEARS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IsoFields(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public IsoFields() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/temporal/IsoFields;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Z", "static")]
	public static bool isIso(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Field;", "private abstract static")]
	public partial class Field
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.java.time.temporal.TemporalField
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Field()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/IsoFields$Field;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAY_OF_QUARTER", "Ljava/time/temporal/IsoFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUARTER_OF_YEAR", "Ljava/time/temporal/IsoFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_OF_WEEK_BASED_YEAR", "Ljava/time/temporal/IsoFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_BASED_YEAR", "Ljava/time/temporal/IsoFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUARTER_DAYS", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/time/temporal/IsoFields$Field;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/time/temporal/IsoFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/time/temporal/IsoFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/time/temporal/IsoFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTimeBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rangeRefinedBy", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDateBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWeekBasedYear", "(Ljava/time/LocalDate;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWeekRange", "(Ljava/time/LocalDate;)Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWeekRange", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureIso", "(Ljava/time/temporal/TemporalAccessor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWeek", "(Ljava/time/LocalDate;)I"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Field DAY_OF_QUARTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Field QUARTER_OF_YEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Field WEEK_OF_WEEK_BASED_YEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Field WEEK_BASED_YEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> QUARTER_DAYS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/time/temporal/IsoFields$Field;", "private static final")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Field(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Field(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/temporal/IsoFields$Field;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/time/temporal/IsoFields$Field;", "public static")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/temporal/IsoFields$Field;", "public static")]
		public static Dova.JDK.java.time.temporal.IsoFields.Field valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Field>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/temporal/IsoFields$Field;", "private static")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Field>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTimeBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;", "public")]
		public Dova.JDK.java.time.temporal.ValueRange rangeRefinedBy(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDateBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/LocalDate;)I", "private static")]
		public static int getWeekBasedYear(Dova.JDK.java.time.LocalDate arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/LocalDate;)Ljava/time/temporal/ValueRange;", "private static")]
		public static Dova.JDK.java.time.temporal.ValueRange getWeekRange(Dova.JDK.java.time.LocalDate arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("(I)I", "private static")]
		public static int getWeekRange(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)V", "private static")]
		public static void ensureIso(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljava/time/LocalDate;)I", "private static")]
		public static int getWeek(Dova.JDK.java.time.LocalDate arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Unit;", "private static final")]
	public partial class Unit
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.java.time.temporal.TemporalUnit
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Unit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/IsoFields$Unit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEEK_BASED_YEARS", "Ljava/time/temporal/IsoFields$Unit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUARTER_YEARS", "Ljava/time/temporal/IsoFields$Unit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "duration", "Ljava/time/Duration;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/time/temporal/IsoFields$Unit;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/time/Duration;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/time/temporal/IsoFields$Unit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/time/temporal/IsoFields$Unit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/time/temporal/IsoFields$Unit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "between", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDurationEstimated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDuration", "()Ljava/time/Duration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTo", "(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedBy", "(Ljava/time/temporal/Temporal;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTimeBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDateBased", "()Z"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Unit;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Unit WEEK_BASED_YEARS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Unit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/IsoFields$Unit;", "public static final")]
		public static Dova.JDK.java.time.temporal.IsoFields.Unit QUARTER_YEARS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Unit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/Duration;", "private final")]
		public Dova.JDK.java.time.Duration duration_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/time/temporal/IsoFields$Unit;", "private static final")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Unit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/time/Duration;)V", "private")]
		public Unit(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.time.Duration arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/temporal/IsoFields$Unit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/temporal/IsoFields$Unit;", "public static")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/temporal/IsoFields$Unit;", "public static")]
		public static Dova.JDK.java.time.temporal.IsoFields.Unit valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.IsoFields.Unit>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/temporal/IsoFields$Unit;", "private static")]
		public static JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.IsoFields.Unit>>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)J", "public")]
		public long between(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.Temporal arg1)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDurationEstimated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/time/Duration;", "public")]
		public Dova.JDK.java.time.Duration getDuration()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;", "public")]
		public Dova.JDK.java.lang.Object addTo(Dova.JDK.java.lang.Object arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Z", "public")]
		public bool isSupportedBy(Dova.JDK.java.time.temporal.Temporal arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTimeBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDateBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}
	}
}
