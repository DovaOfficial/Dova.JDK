/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.jfr.@internal.consumer;

[JniSignatureAttribute("Ljdk/jfr/internal/consumer/JdkJfrConsumer;", "public abstract")]
public partial class JdkJfrConsumer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JdkJfrConsumer()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/consumer/JdkJfrConsumer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljdk/jfr/internal/consumer/JdkJfrConsumer;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "JdkJfrConsumer", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "()Ljdk/jfr/internal/consumer/JdkJfrConsumer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setAccess", "(Ljdk/jfr/internal/consumer/JdkJfrConsumer;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedThreadGroup", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedThreadGroup;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedFrame", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedFrame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedThread", "(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedThread;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedMethod", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedMethod;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedEvent", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;JJ)Ljdk/jfr/consumer/RecordedEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "eventComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setStartTicks", "(Ljdk/jfr/consumer/RecordedEvent;J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setEndTicks", "(Ljdk/jfr/consumer/RecordedEvent;J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "eventValues", "(Ljdk/jfr/consumer/RecordedEvent;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newMetadataEvent", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/consumer/MetadataEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readTypes", "(Ljdk/jfr/consumer/RecordingFile;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "forceInitialization", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isLastEventInChunk", "(Ljdk/jfr/consumer/RecordingFile;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOffsetDataTime", "(Ljdk/jfr/consumer/RecordedObject;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedClass", "(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedClass;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedClassLoader", "(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedClassLoader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newRecordedStackTrace", "(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedStackTrace;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/JdkJfrConsumer;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer instance_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JdkJfrConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JdkJfrConsumer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/JdkJfrConsumer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jfr/internal/consumer/JdkJfrConsumer;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer instance()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/JdkJfrConsumer;)V", "public static")]
	public static void setAccess(Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedThreadGroup;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedThreadGroup newRecordedThreadGroup(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedThreadGroup>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedFrame;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedFrame newRecordedFrame(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedFrame>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedThread;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedThread newRecordedThread(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, long arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedThread>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedMethod;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedMethod newRecordedMethod(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedMethod>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;JJ)Ljdk/jfr/consumer/RecordedEvent;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedEvent newRecordedEvent(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, long arg2, long arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public abstract")]
	public Dova.JDK.java.util.Comparator eventComparator()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordedEvent;J)V", "public abstract")]
	public void setStartTicks(Dova.JDK.jdk.jfr.consumer.RecordedEvent arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordedEvent;J)V", "public abstract")]
	public void setEndTicks(Dova.JDK.jdk.jfr.consumer.RecordedEvent arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordedEvent;)[Ljava/lang/Object;", "public abstract")]
	public JavaArray<Dova.JDK.java.lang.Object> eventValues(Dova.JDK.jdk.jfr.consumer.RecordedEvent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/consumer/MetadataEvent;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.MetadataEvent newMetadataEvent(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.MetadataEvent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordingFile;)Ljava/util/List;", "public abstract")]
	public Dova.JDK.java.util.List readTypes(Dova.JDK.jdk.jfr.consumer.RecordingFile arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void forceInitialization()
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordingFile;)Z", "public abstract")]
	public bool isLastEventInChunk(Dova.JDK.jdk.jfr.consumer.RecordingFile arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/consumer/RecordedObject;Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getOffsetDataTime(Dova.JDK.jdk.jfr.consumer.RecordedObject arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedClass;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedClass newRecordedClass(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, long arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedClass>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedClassLoader;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedClassLoader newRecordedClassLoader(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, long arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;[Ljava/lang/Object;)Ljdk/jfr/consumer/RecordedStackTrace;", "public abstract")]
	public Dova.JDK.jdk.jfr.consumer.RecordedStackTrace newRecordedStackTrace(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.consumer.RecordedStackTrace>(ret);
	}
}
