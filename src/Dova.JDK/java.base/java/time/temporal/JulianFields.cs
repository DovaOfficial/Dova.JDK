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

[JniSignatureAttribute("Ljava/time/temporal/JulianFields;", "public final")]
public partial class JulianFields
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JulianFields()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/JulianFields;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JULIAN_DAY_OFFSET", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JULIAN_DAY", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIED_JULIAN_DAY", "Ljava/time/temporal/TemporalField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RATA_DIE", "Ljava/time/temporal/TemporalField;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long JULIAN_DAY_OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalField JULIAN_DAY_Property
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
	public static Dova.JDK.java.time.temporal.TemporalField MODIFIED_JULIAN_DAY_Property
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
	public static Dova.JDK.java.time.temporal.TemporalField RATA_DIE_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JulianFields(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public JulianFields() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/temporal/JulianFields;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljava/time/temporal/JulianFields$Field;", "private static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/JulianFields$Field;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JULIAN_DAY", "Ljava/time/temporal/JulianFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIED_JULIAN_DAY", "Ljava/time/temporal/JulianFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RATA_DIE", "Ljava/time/temporal/JulianFields$Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseUnit", "Ljava/time/temporal/TemporalUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rangeUnit", "Ljava/time/temporal/TemporalUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "range", "Ljava/time/temporal/ValueRange;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/time/temporal/JulianFields$Field;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/TemporalUnit;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/time/temporal/JulianFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/time/temporal/JulianFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_0", "(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/temporal/TemporalAccessor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_1", "(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "()Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/time/temporal/JulianFields$Field;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedBy", "(Ljava/time/temporal/TemporalAccessor;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTimeBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrom", "(Ljava/time/temporal/TemporalAccessor;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustInto", "(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rangeRefinedBy", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDateBased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseUnit", "()Ljava/time/temporal/TemporalUnit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRangeUnit", "()Ljava/time/temporal/TemporalUnit;"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/JulianFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.JulianFields.Field JULIAN_DAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.JulianFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/JulianFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.JulianFields.Field MODIFIED_JULIAN_DAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.JulianFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/JulianFields$Field;", "public static final")]
		public static Dova.JDK.java.time.temporal.JulianFields.Field RATA_DIE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.JulianFields.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final transient")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "private final transient")]
		public Dova.JDK.java.time.temporal.TemporalUnit baseUnit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalUnit;", "private final transient")]
		public Dova.JDK.java.time.temporal.TemporalUnit rangeUnit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/ValueRange;", "private final transient")]
		public Dova.JDK.java.time.temporal.ValueRange range_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final transient")]
		public long offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("[Ljava/time/temporal/JulianFields$Field;", "private static final")]
		public static JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Field(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/time/temporal/TemporalUnit;Ljava/time/temporal/TemporalUnit;J)V", "private")]
		public Field(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.time.temporal.TemporalUnit arg3, Dova.JDK.java.time.temporal.TemporalUnit arg4, long arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/temporal/JulianFields$Field;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/temporal/JulianFields$Field;", "public static")]
		public static JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/temporal/JulianFields$Field;", "public static")]
		public static Dova.JDK.java.time.temporal.JulianFields.Field valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.JulianFields.Field>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/temporal/TemporalAccessor;", "public volatile")]
		public Dova.JDK.java.time.temporal.TemporalAccessor resolve_0(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.temporal.TemporalAccessor arg1, Dova.JDK.java.time.format.ResolverStyle arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/temporal/TemporalAccessor;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "public")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate resolve_1(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.temporal.TemporalAccessor arg1, Dova.JDK.java.time.format.ResolverStyle arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/temporal/ValueRange;", "public")]
		public Dova.JDK.java.time.temporal.ValueRange range()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/temporal/JulianFields$Field;", "private static")]
		public static JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.temporal.JulianFields.Field>>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Z", "public")]
		public bool isSupportedBy(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTimeBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)J", "public")]
		public long getFrom(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;", "public")]
		public Dova.JDK.java.lang.Object adjustInto(Dova.JDK.java.lang.Object arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/temporal/ValueRange;", "public")]
		public Dova.JDK.java.time.temporal.ValueRange rangeRefinedBy(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDateBased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/time/temporal/TemporalUnit;", "public")]
		public Dova.JDK.java.time.temporal.TemporalUnit getBaseUnit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/temporal/TemporalUnit;", "public")]
		public Dova.JDK.java.time.temporal.TemporalUnit getRangeUnit()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalUnit>(ret);
		}
	}
}
