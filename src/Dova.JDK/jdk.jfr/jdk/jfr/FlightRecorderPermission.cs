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

namespace Dova.JDK.jdk.jfr;

[JniSignatureAttribute("Ljdk/jfr/FlightRecorderPermission;", "public final")]
public partial class FlightRecorderPermission
	: Dova.JDK.java.security.BasicPermission
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FlightRecorderPermission()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/FlightRecorderPermission;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FlightRecorderPermission", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FlightRecorderPermission(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public FlightRecorderPermission(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/FlightRecorderPermission;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljdk/jfr/FlightRecorderPermission$InternalAccess;", "private static final")]
	public partial class InternalAccess
		: Dova.JDK.jdk.jfr.@internal.PrivateAccess
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InternalAccess()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jfr/FlightRecorderPermission$InternalAccess;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InternalAccess", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getContext", "(Ljdk/jfr/SettingControl;)Ljava/security/AccessControlContext;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "(Ljava/lang/Object;)Ljdk/jfr/internal/Type;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newConfiguration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFieldName", "(Ljdk/jfr/ValueDescriptor;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isUnsigned", "(Ljdk/jfr/ValueDescriptor;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPlatformEventType", "(Ljdk/jfr/EventType;)Ljdk/jfr/internal/PlatformEventType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newEventSettings", "(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPlatformRecording", "(Ljdk/jfr/Recording;)Ljdk/jfr/internal/PlatformRecording;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newEventType", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/EventType;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newAnnotation", "(Ljdk/jfr/internal/Type;Ljava/util/List;Z)Ljdk/jfr/AnnotationElement;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newValueDescriptor", "(Ljava/lang/Class;Ljava/lang/String;)Ljdk/jfr/ValueDescriptor;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newValueDescriptor", "(Ljava/lang/String;Ljdk/jfr/internal/Type;Ljava/util/List;IZLjava/lang/String;)Ljdk/jfr/ValueDescriptor;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newSettingDescriptor", "(Ljdk/jfr/internal/Type;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jfr/SettingDescriptor;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPlatformRecorder", "()Ljdk/jfr/internal/PlatformRecorder;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isVisible", "(Ljdk/jfr/EventType;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAnnotations", "(Ljdk/jfr/ValueDescriptor;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setAnnotations", "(Ljdk/jfr/SettingDescriptor;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isConstantPool", "(Ljdk/jfr/ValueDescriptor;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InternalAccess(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public InternalAccess() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/FlightRecorderPermission$InternalAccess;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/SettingControl;)Ljava/security/AccessControlContext;", "public")]
		public Dova.JDK.java.security.AccessControlContext getContext(Dova.JDK.jdk.jfr.SettingControl arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/jfr/internal/Type;", "public")]
		public Dova.JDK.jdk.jfr.@internal.Type getType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;", "public")]
		public Dova.JDK.jdk.jfr.Configuration newConfiguration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.lang.String arg5)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.Configuration>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getFieldName(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Z", "public")]
		public bool isUnsigned(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/jfr/EventType;)Ljdk/jfr/internal/PlatformEventType;", "public")]
		public Dova.JDK.jdk.jfr.@internal.PlatformEventType getPlatformEventType(Dova.JDK.jdk.jfr.EventType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;", "public")]
		public Dova.JDK.jdk.jfr.EventSettings newEventSettings(Dova.JDK.jdk.jfr.@internal.management.EventSettingsModifier arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventSettings>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/Recording;)Ljdk/jfr/internal/PlatformRecording;", "public")]
		public Dova.JDK.jdk.jfr.@internal.PlatformRecording getPlatformRecording(Dova.JDK.jdk.jfr.Recording arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecording>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/EventType;", "public")]
		public Dova.JDK.jdk.jfr.EventType newEventType(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljava/util/List;Z)Ljdk/jfr/AnnotationElement;", "public")]
		public Dova.JDK.jdk.jfr.AnnotationElement newAnnotation(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.java.util.List arg1, bool arg2)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.AnnotationElement>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Ljdk/jfr/ValueDescriptor;", "public")]
		public Dova.JDK.jdk.jfr.ValueDescriptor newValueDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/Type;Ljava/util/List;IZLjava/lang/String;)Ljdk/jfr/ValueDescriptor;", "public")]
		public Dova.JDK.jdk.jfr.ValueDescriptor newValueDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.Type arg1, Dova.JDK.java.util.List arg2, int arg3, bool arg4, Dova.JDK.java.lang.String arg5)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jfr/SettingDescriptor;", "public")]
		public Dova.JDK.jdk.jfr.SettingDescriptor newSettingDescriptor(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.SettingDescriptor>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jfr/internal/PlatformRecorder;", "public")]
		public Dova.JDK.jdk.jfr.@internal.PlatformRecorder getPlatformRecorder()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecorder>(ret);
		}

		[JniSignatureAttribute("(Ljdk/jfr/EventType;)Z", "public")]
		public bool isVisible(Dova.JDK.jdk.jfr.EventType arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;Ljava/util/List;)V", "public")]
		public void setAnnotations(Dova.JDK.jdk.jfr.ValueDescriptor arg0, Dova.JDK.java.util.List arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/jfr/SettingDescriptor;Ljava/util/List;)V", "public")]
		public void setAnnotations(Dova.JDK.jdk.jfr.SettingDescriptor arg0, Dova.JDK.java.util.List arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Z", "public")]
		public bool isConstantPool(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}
	}
}
