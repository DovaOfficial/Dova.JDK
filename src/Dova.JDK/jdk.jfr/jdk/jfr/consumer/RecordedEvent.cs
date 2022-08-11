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

namespace Dova.JDK.jdk.jfr.consumer;

[JniSignatureAttribute("Ljdk/jfr/consumer/RecordedEvent;", "public final")]
public partial class RecordedEvent
	: Dova.JDK.jdk.jfr.consumer.RecordedObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordedEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/consumer/RecordedEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startTimeTicks", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endTimeTicks", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackTrace", "()Ljdk/jfr/consumer/RecordedStackTrace;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFields", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDuration", "()Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventType", "()Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartTime", "()Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndTime", "()Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDuration", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartTimeNanos", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndTimeNanos", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThread", "()Ljdk/jfr/consumer/RecordedThread;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "objectAt", "(I)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("J", "")]
	public long startTimeTicks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("J", "")]
	public long endTimeTicks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RecordedEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;JJ)V", "")]
	public RecordedEvent(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, long arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/consumer/RecordedEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jfr/consumer/RecordedStackTrace;", "public")]
	public Dova.JDK.jdk.jfr.consumer.RecordedStackTrace getStackTrace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedStackTrace>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration getDuration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/EventType;", "public")]
	public Dova.JDK.jdk.jfr.EventType getEventType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Instant;", "public")]
	public Dova.JDK.java.time.Instant getStartTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Instant;", "public")]
	public Dova.JDK.java.time.Instant getEndTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool hasDuration()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long getStartTimeNanos()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long getEndTimeNanos()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/consumer/RecordedThread;", "public")]
	public Dova.JDK.jdk.jfr.consumer.RecordedThread getThread()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedThread>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object objectAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
