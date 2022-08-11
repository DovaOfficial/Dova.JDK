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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XkbEvent;", "public")]
public partial class XkbEvent
	: Dova.JDK.sun.awt.X11.XWrapperBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XkbEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XkbEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "should_free_memory", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pData", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Lsun/awt/X11/XEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "zero", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_any", "()Lsun/awt/X11/XkbAnyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_device", "()Lsun/awt/X11/XkbExtensionDeviceNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_message", "()Lsun/awt/X11/XkbActionMessageEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_new_kbd", "()Lsun/awt/X11/XkbNewKeyboardNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_map", "()Lsun/awt/X11/XkbMapNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_ctrls", "()Lsun/awt/X11/XkbControlsNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_indicators", "()Lsun/awt/X11/XkbIndicatorNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_names", "()Lsun/awt/X11/XkbNamesNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_compat", "()Lsun/awt/X11/XkbCompatMapNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_bell", "()Lsun/awt/X11/XkbBellNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_accessx", "()Lsun/awt/X11/XkbAccessXNotifyEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_core", "()Lsun/awt/X11/XEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_type", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPData", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set_type", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldsAsString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_state", "()Lsun/awt/X11/XkbStateNotifyEvent;"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private")]
	public Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool should_free_memory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("J", "")]
	public long pData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XkbEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public XkbEvent(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XkbEvent() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XkbEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XEvent;", "public volatile")]
	public Dova.JDK.sun.awt.X11.XEvent clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEvent>(ret);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getSize()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void zero()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbAnyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbAnyEvent get_any()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbAnyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbExtensionDeviceNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbExtensionDeviceNotifyEvent get_device()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbExtensionDeviceNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbActionMessageEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbActionMessageEvent get_message()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbActionMessageEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbNewKeyboardNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbNewKeyboardNotifyEvent get_new_kbd()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbNewKeyboardNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbMapNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbMapNotifyEvent get_map()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbMapNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbControlsNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbControlsNotifyEvent get_ctrls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbControlsNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbIndicatorNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbIndicatorNotifyEvent get_indicators()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbIndicatorNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbNamesNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbNamesNotifyEvent get_names()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbNamesNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbCompatMapNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbCompatMapNotifyEvent get_compat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbCompatMapNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbBellNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbBellNotifyEvent get_bell()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbBellNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbAccessXNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbAccessXNotifyEvent get_accessx()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbAccessXNotifyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XEvent get_core()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEvent>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int get_type()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDataSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getPData()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void set_type(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getFieldsAsString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XkbStateNotifyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XkbStateNotifyEvent get_state()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XkbStateNotifyEvent>(ret);
	}
}
