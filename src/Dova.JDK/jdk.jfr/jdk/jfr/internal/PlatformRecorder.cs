/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/PlatformRecorder;", "public final")]
public partial class PlatformRecorder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PlatformRecorder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/PlatformRecorder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "recordings", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "changeListeners", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "repository", "Ljdk/jfr/internal/Repository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "jvm", "Ljdk/jfr/internal/JVM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "activeRecordingEvent", "Ljdk/jfr/EventType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "activeSettingEvent", "Ljdk/jfr/EventType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "shutdownHook", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "timer", "Ljava/util/Timer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "recordingCounter", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "currentChunk", "Ljdk/jfr/internal/RepositoryChunk;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inShutdown", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PlatformRecorder", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljdk/jfr/internal/PlatformRecording;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stop", "(Ljdk/jfr/internal/PlatformRecording;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "destroy", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finish", "(Ljdk/jfr/internal/PlatformRecording;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "removeListener", "(Ljdk/jfr/FlightRecorderListener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "addListener", "(Ljdk/jfr/FlightRecorderListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "takeNap", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newRecording", "(Ljava/util/Map;)Ljdk/jfr/internal/PlatformRecording;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newRecording", "(Ljava/util/Map;J)Ljdk/jfr/internal/PlatformRecording;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRecordings", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newCopy", "(Ljdk/jfr/internal/PlatformRecording;Z)Ljdk/jfr/Recording;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "startDiskMonitor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createTimer", "()Ljava/util/Timer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateSettings", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeMetaEvents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finishChunk", "(Ljdk/jfr/internal/RepositoryChunk;Ljava/time/Instant;Ljdk/jfr/internal/PlatformRecording;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dumpMemoryToDestination", "(Ljdk/jfr/internal/PlatformRecording;)Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateSettingsButIgnoreRecording", "(Ljdk/jfr/internal/PlatformRecording;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRunningRecordings", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rotateDisk", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTimer", "()Ljava/util/Timer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newTemporaryRecording", "()Ljdk/jfr/internal/PlatformRecording;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillWithDiskChunks", "(Ljdk/jfr/internal/PlatformRecording;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeChunkList", "(Ljava/time/Instant;Ljava/time/Instant;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "periodicTask", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInShutDown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "migrate", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillWithRecordedData", "(Ljdk/jfr/internal/PlatformRecording;Ljava/lang/Boolean;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "notifyRecorderInitialized", "(Ljdk/jfr/FlightRecorder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isToDisk", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getListeners", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "disableEvents", "()V"));
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private final")]
	public Dova.JDK.java.util.ArrayList recordings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static final")]
	public static Dova.JDK.java.util.List changeListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Repository;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.Repository repository_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Repository>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/JVM;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.JVM jvm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.JVM>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/EventType;", "private final")]
	public Dova.JDK.jdk.jfr.EventType activeRecordingEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/EventType;", "private final")]
	public Dova.JDK.jdk.jfr.EventType activeSettingEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private final")]
	public Dova.JDK.java.lang.Thread shutdownHook_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Timer;", "private")]
	public Dova.JDK.java.util.Timer timer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Timer>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private")]
	public long recordingCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/RepositoryChunk;", "private")]
	public Dova.JDK.jdk.jfr.@internal.RepositoryChunk currentChunk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.RepositoryChunk>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inShutdown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PlatformRecorder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PlatformRecorder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/PlatformRecorder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)J", "synchronized")]
	public long start(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)V", "synchronized")]
	public void stop(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void destroy()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)V", "synchronized")]
	public void finish(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/FlightRecorderListener;)Z", "public static synchronized")]
	public static bool removeListener(Dova.JDK.jdk.jfr.FlightRecorderListener arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/FlightRecorderListener;)V", "public static synchronized")]
	public static void addListener(Dova.JDK.jdk.jfr.FlightRecorderListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(J)V", "private")]
	public void takeNap(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/jfr/internal/PlatformRecording;", "public synchronized")]
	public Dova.JDK.jdk.jfr.@internal.PlatformRecording newRecording(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecording>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;J)Ljdk/jfr/internal/PlatformRecording;", "private synchronized")]
	public Dova.JDK.jdk.jfr.@internal.PlatformRecording newRecording(Dova.JDK.java.util.Map arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecording>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
	public Dova.JDK.java.util.List getRecordings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;Z)Ljdk/jfr/Recording;", "synchronized")]
	public Dova.JDK.jdk.jfr.Recording newCopy(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.Recording>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void startDiskMonitor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()Ljava/util/Timer;", "private static")]
	public static Dova.JDK.java.util.Timer createTimer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Timer>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateSettings()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void writeMetaEvents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/RepositoryChunk;Ljava/time/Instant;Ljdk/jfr/internal/PlatformRecording;)V", "private")]
	public void finishChunk(Dova.JDK.jdk.jfr.@internal.RepositoryChunk arg0, Dova.JDK.java.time.Instant arg1, Dova.JDK.jdk.jfr.@internal.PlatformRecording arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)Ljava/time/Instant;", "private")]
	public Dova.JDK.java.time.Instant dumpMemoryToDestination(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)V", "")]
	public void updateSettingsButIgnoreRecording(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getRunningRecordings()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void rotateDisk()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("()Ljava/util/Timer;", "synchronized")]
	public Dova.JDK.java.util.Timer getTimer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Timer>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/PlatformRecording;", "public")]
	public Dova.JDK.jdk.jfr.@internal.PlatformRecording newTemporaryRecording()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecording>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;)V", "private")]
	public void fillWithDiskChunks(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;Ljava/time/Instant;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List makeChunkList(Dova.JDK.java.time.Instant arg0, Dova.JDK.java.time.Instant arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void periodicTask()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void setInShutDown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "public synchronized")]
	public void migrate(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformRecording;Ljava/lang/Boolean;)V", "public synchronized")]
	public void fillWithRecordedData(Dova.JDK.jdk.jfr.@internal.PlatformRecording arg0, Dova.JDK.java.lang.Boolean arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/FlightRecorder;)V", "public static")]
	public static void notifyRecorderInitialized(Dova.JDK.jdk.jfr.FlightRecorder arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isToDisk()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "static synchronized")]
	public static Dova.JDK.java.util.List getListeners()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void disableEvents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31]);
	}
}
