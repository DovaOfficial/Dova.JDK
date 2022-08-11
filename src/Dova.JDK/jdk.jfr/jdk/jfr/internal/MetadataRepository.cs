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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/MetadataRepository;", "public final")]
public partial class MetadataRepository
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetadataRepository()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/MetadataRepository;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jvm", "Ljdk/jfr/internal/JVM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Ljdk/jfr/internal/MetadataRepository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeEventTypes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeControls", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeLibrary", "Ljdk/jfr/internal/TypeLibrary;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "settingsManager", "Ljdk/jfr/internal/SettingsManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mirrors", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "staleMetadata", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unregistered", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastUnloaded", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputChange", "Ljava/time/Instant;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Ljdk/jfr/internal/MetadataRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/Class;)Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "(Ljava/lang/Class;Z)Ljdk/jfr/internal/handlers/EventHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregister", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeJVMEventTypes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEventHandlers", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findMirrorType", "(Ljava/lang/Class;)Ljdk/jfr/internal/PlatformEventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeHandler", "(Ljava/lang/Class;Ljdk/jfr/internal/PlatformEventType;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/internal/handlers/EventHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStaleMetadata", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSettings", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventControls", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryRepresentation", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeDescriptorInJVM", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterUnloaded", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRegisteredEventTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUnregistered", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unhideInternalTypes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerMirror", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventType", "(Ljava/lang/Class;)Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibleTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOutput", "(Ljava/lang/String;)Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disableEvents", "()V"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/JVM;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.JVM jvm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.JVM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/MetadataRepository;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.MetadataRepository instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataRepository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List nativeEventTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List nativeControls_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/TypeLibrary;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.TypeLibrary typeLibrary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.TypeLibrary>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SettingsManager;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.SettingsManager settingsManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SettingsManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map mirrors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool staleMetadata_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool unregistered_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long lastUnloaded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljava/time/Instant;", "private")]
	public Dova.JDK.java.time.Instant outputChange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetadataRepository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MetadataRepository() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/MetadataRepository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public synchronized")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/MetadataRepository;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.MetadataRepository getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.MetadataRepository>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/EventType;", "public synchronized")]
	public Dova.JDK.jdk.jfr.EventType register(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/EventType;", "public synchronized")]
	public Dova.JDK.jdk.jfr.EventType register(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Z)Ljdk/jfr/internal/handlers/EventHandler;", "private")]
	public Dova.JDK.jdk.jfr.@internal.handlers.EventHandler getHandler(Dova.JDK.java.lang.Class arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.handlers.EventHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public synchronized")]
	public void unregister(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "synchronized")]
	public bool isEnabled(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void initializeJVMEventTypes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getEventHandlers()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/internal/PlatformEventType;", "private")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType findMirrorType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljdk/jfr/internal/PlatformEventType;Ljava/util/List;Ljava/util/List;)Ljdk/jfr/internal/handlers/EventHandler;", "private")]
	public Dova.JDK.jdk.jfr.@internal.handlers.EventHandler makeHandler(Dova.JDK.java.lang.Class arg0, Dova.JDK.jdk.jfr.@internal.PlatformEventType arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.handlers.EventHandler>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void setStaleMetadata()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public synchronized")]
	public void setSettings(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
	public Dova.JDK.java.util.List getEventControls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()[B", "private")]
	public JavaArray<byte> getBinaryRepresentation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void storeDescriptorInJVM()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void unregisterUnloaded()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
	public Dova.JDK.java.util.List getRegisteredEventTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void setUnregistered()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void unhideInternalTypes()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public synchronized")]
	public void registerMirror(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/EventType;", "public synchronized")]
	public Dova.JDK.jdk.jfr.EventType getEventType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
	public Dova.JDK.java.util.List getVisibleTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/Instant;", "synchronized")]
	public Dova.JDK.java.time.Instant setOutput(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void disableEvents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}
}
