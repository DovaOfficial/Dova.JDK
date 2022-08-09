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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/EventControl;", "public final")]
public partial class EventControl
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventControl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/EventControl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FIELD_SETTING_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_ENABLED", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_THRESHOLD", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_STACK_TRACE", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_PERIOD", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_CUTOFF", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_THROTTLE", "Ljdk/jfr/internal/Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "settingInfos", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "namedControls", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type", "Ljdk/jfr/internal/PlatformEventType;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "idName", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EventControl", "(Ljdk/jfr/internal/PlatformEventType;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EventControl", "(Ljdk/jfr/internal/PlatformEventType;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljdk/jfr/internal/PlatformEventType;Ljava/util/List;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "disable", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineThreshold", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addControl", "(Ljava/lang/String;Ljdk/jfr/internal/Control;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineStackTrace", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "definePeriod", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineCutoff", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineThrottle", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "defineEnabled", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "defineSettings", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasControl", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "defineSetting", "(Ljava/lang/Class;Ljava/lang/reflect/Method;Ljdk/jfr/internal/PlatformEventType;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "instantiateSettingControl", "(Ljava/lang/Class;)Ljdk/jfr/SettingControl;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writeActiveSettingEvent", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNamedControls", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEventType", "()Ljdk/jfr/internal/PlatformEventType;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSettingsId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSettingInfos", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String FIELD_SETTING_PREFIX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_ENABLED_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_THRESHOLD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_STACK_TRACE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_PERIOD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_CUTOFF_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/Type;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.Type TYPE_THROTTLE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private final")]
	public Dova.JDK.java.util.ArrayList settingInfos_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private final")]
	public Dova.JDK.java.util.ArrayList namedControls_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/PlatformEventType;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType type_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String idName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EventControl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)V", "")]
	public EventControl(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;Ljava/lang/Class;)V", "")]
	public EventControl(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0, Dova.JDK.java.lang.Class arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/EventControl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;Ljava/util/List;Ljava/lang/Class;)V", "static")]
	public static void remove(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "")]
	public void disable()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control defineThreshold(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/Control;)V", "private")]
	public void addControl(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.Control arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control defineStackTrace(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control definePeriod(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control defineCutoff(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control defineThrottle(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/internal/Control;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.Control defineEnabled(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
	public void defineSettings(Dova.JDK.java.lang.Class arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool hasControl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/reflect/Method;Ljdk/jfr/internal/PlatformEventType;Ljava/lang/String;)V", "private")]
	public void defineSetting(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.jdk.jfr.@internal.PlatformEventType arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljdk/jfr/SettingControl;", "private")]
	public Dova.JDK.jdk.jfr.SettingControl instantiateSettingControl(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.SettingControl>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void writeActiveSettingEvent()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "public")]
	public Dova.JDK.java.util.ArrayList getNamedControls()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/PlatformEventType;", "public")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType getEventType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSettingsId()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getSettingInfos()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/EventControl$NamedControl;", "static final")]
	public partial class NamedControl
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedControl()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/internal/EventControl$NamedControl;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "control", "Ljdk/jfr/internal/Control;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NamedControl", "(Ljava/lang/String;Ljdk/jfr/internal/Control;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/jfr/internal/Control;", "public final")]
		public Dova.JDK.jdk.jfr.@internal.Control control_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Control>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedControl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/Control;)V", "")]
		public NamedControl(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.Control arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/EventControl$NamedControl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
