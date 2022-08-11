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

[JniSignatureAttribute("Ljava/time/temporal/TemporalQueries;", "public final")]
public partial class TemporalQueries
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TemporalQueries()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/temporal/TemporalQueries;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZONE_ID", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHRONO", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRECISION", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZONE", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_DATE", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_TIME", "Ljava/time/temporal/TemporalQuery;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "offset", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zone", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "precision", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "chronology", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "zoneId", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "localDate", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "localTime", "()Ljava/time/temporal/TemporalQuery;"));
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery ZONE_ID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery CHRONO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery PRECISION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery ZONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery LOCAL_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery LOCAL_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TemporalQueries(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public TemporalQueries() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/temporal/TemporalQueries;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery offset()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery zone()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery precision()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery chronology()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery zoneId()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery localDate()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static")]
	public static Dova.JDK.java.time.temporal.TemporalQuery localTime()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}
}
