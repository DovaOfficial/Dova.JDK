/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljdk/jfr/internal/PrivateAccess;", "public abstract")]
public partial class PrivateAccess
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrivateAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/PrivateAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "instance", "Ljdk/jfr/internal/PrivateAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrivateAccess", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljdk/jfr/internal/PrivateAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContext", "(Ljdk/jfr/SettingControl;)Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getType", "(Ljava/lang/Object;)Ljdk/jfr/internal/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newConfiguration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFieldName", "(Ljdk/jfr/ValueDescriptor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isUnsigned", "(Ljdk/jfr/ValueDescriptor;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPlatformEventType", "(Ljdk/jfr/EventType;)Ljdk/jfr/internal/PlatformEventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEventSettings", "(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPlatformRecording", "(Ljdk/jfr/Recording;)Ljdk/jfr/internal/PlatformRecording;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setPrivateAccess", "(Ljdk/jfr/internal/PrivateAccess;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEventType", "(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newAnnotation", "(Ljdk/jfr/internal/Type;Ljava/util/List;Z)Ljdk/jfr/AnnotationElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newValueDescriptor", "(Ljava/lang/String;Ljdk/jfr/internal/Type;Ljava/util/List;IZLjava/lang/String;)Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newValueDescriptor", "(Ljava/lang/Class;Ljava/lang/String;)Ljdk/jfr/ValueDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSettingDescriptor", "(Ljdk/jfr/internal/Type;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jfr/SettingDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPlatformRecorder", "()Ljdk/jfr/internal/PlatformRecorder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isVisible", "(Ljdk/jfr/EventType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAnnotations", "(Ljdk/jfr/SettingDescriptor;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAnnotations", "(Ljdk/jfr/ValueDescriptor;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isConstantPool", "(Ljdk/jfr/ValueDescriptor;)Z"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/PrivateAccess;", "private static volatile")]
	public static Dova.JDK.jdk.jfr.@internal.PrivateAccess instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PrivateAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrivateAccess(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PrivateAccess() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/PrivateAccess;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/jfr/internal/PrivateAccess;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.PrivateAccess getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PrivateAccess>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/SettingControl;)Ljava/security/AccessControlContext;", "public abstract")]
	public Dova.JDK.java.security.AccessControlContext getContext(Dova.JDK.jdk.jfr.SettingControl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljdk/jfr/internal/Type;", "public abstract")]
	public Dova.JDK.jdk.jfr.@internal.Type getType(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;)Ljdk/jfr/Configuration;", "public abstract")]
	public Dova.JDK.jdk.jfr.Configuration newConfiguration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.lang.String arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getFieldName(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Z", "public abstract")]
	public bool isUnsigned(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/EventType;)Ljdk/jfr/internal/PlatformEventType;", "public abstract")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType getPlatformEventType(Dova.JDK.jdk.jfr.EventType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/management/EventSettingsModifier;)Ljdk/jfr/EventSettings;", "public abstract")]
	public Dova.JDK.jdk.jfr.EventSettings newEventSettings(Dova.JDK.jdk.jfr.@internal.management.EventSettingsModifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventSettings>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/Recording;)Ljdk/jfr/internal/PlatformRecording;", "public abstract")]
	public Dova.JDK.jdk.jfr.@internal.PlatformRecording getPlatformRecording(Dova.JDK.jdk.jfr.Recording arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecording>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PrivateAccess;)V", "public static")]
	public static void setPrivateAccess(Dova.JDK.jdk.jfr.@internal.PrivateAccess arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/PlatformEventType;)Ljdk/jfr/EventType;", "public abstract")]
	public Dova.JDK.jdk.jfr.EventType newEventType(Dova.JDK.jdk.jfr.@internal.PlatformEventType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljava/util/List;Z)Ljdk/jfr/AnnotationElement;", "public abstract")]
	public Dova.JDK.jdk.jfr.AnnotationElement newAnnotation(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.AnnotationElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/jfr/internal/Type;Ljava/util/List;IZLjava/lang/String;)Ljdk/jfr/ValueDescriptor;", "public abstract")]
	public Dova.JDK.jdk.jfr.ValueDescriptor newValueDescriptor(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.jfr.@internal.Type arg1, Dova.JDK.java.util.List arg2, int arg3, bool arg4, Dova.JDK.java.lang.String arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Ljdk/jfr/ValueDescriptor;", "public abstract")]
	public Dova.JDK.jdk.jfr.ValueDescriptor newValueDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.ValueDescriptor>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Ljdk/jfr/SettingDescriptor;", "public abstract")]
	public Dova.JDK.jdk.jfr.SettingDescriptor newSettingDescriptor(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.SettingDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/PlatformRecorder;", "public abstract")]
	public Dova.JDK.jdk.jfr.@internal.PlatformRecorder getPlatformRecorder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformRecorder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/EventType;)Z", "public abstract")]
	public bool isVisible(Dova.JDK.jdk.jfr.EventType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/SettingDescriptor;Ljava/util/List;)V", "public abstract")]
	public void setAnnotations(Dova.JDK.jdk.jfr.SettingDescriptor arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;Ljava/util/List;)V", "public abstract")]
	public void setAnnotations(Dova.JDK.jdk.jfr.ValueDescriptor arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/ValueDescriptor;)Z", "public abstract")]
	public bool isConstantPool(Dova.JDK.jdk.jfr.ValueDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}
}
