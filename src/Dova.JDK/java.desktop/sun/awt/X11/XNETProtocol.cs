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

[JniSignatureAttribute("Lsun/awt/X11/XNETProtocol;", "final")]
public partial class XNETProtocol
	: Dova.JDK.sun.awt.X11.XProtocol
	, Dova.JDK.sun.awt.X11.XStateProtocol
	, Dova.JDK.sun.awt.X11.XLayerProtocol
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XNETProtocol()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XNETProtocol;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "log", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "iconLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "stateLog", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_UTF8_STRING", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_SUPPORTING_WM_CHECK", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_SUPPORTED", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_ACTIVE_WINDOW", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_NAME", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_MAXIMIZED_HORZ", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_MAXIMIZED_VERT", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_SHADED", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_ABOVE", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_MODAL", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_FULLSCREEN", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_BELOW", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_HIDDEN", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_SKIP_TASKBAR", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_STATE_SKIP_PAGER", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_TYPE", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_TYPE_NORMAL", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_TYPE_DIALOG", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_TYPE_UTILITY", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_TYPE_POPUP_MENU", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "XA_NET_WM_WINDOW_OPACITY", "Lsun/awt/X11/XAtom;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_NET_WM_STATE_REMOVE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_NET_WM_STATE_ADD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_NET_WM_STATE_TOGGLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportChecked", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "NetWindow", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "net_wm_name_cache", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "(Lsun/awt/X11/XWindowPeer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "active", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setState", "(Lsun/awt/X11/XWindowPeer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsLayer", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doOpacityProtocol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unshadeKludge", "(Lsun/awt/X11/XWindowPeer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doStateProtocol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestState", "(Lsun/awt/X11/XWindowPeer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestState", "(Lsun/awt/X11/XWindow;Lsun/awt/X11/XAtom;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInitialState", "(Lsun/awt/X11/XWindowPeer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStateImpl", "(Lsun/awt/X11/XWindowPeer;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLayerProtocol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStateHelper", "(Lsun/awt/X11/XWindowPeer;Lsun/awt/X11/XAtom;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detect", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsState", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStateChange", "(Lsun/awt/X11/XPropertyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doModalityProtocol", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setActiveWindow", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWMName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWMIcons", "(Lsun/awt/X11/XWindowPeer;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayer", "(Lsun/awt/X11/XWindowPeer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWMStateNetHidden", "(Lsun/awt/X11/XWindowPeer;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWMName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger iconLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static")]
	public static Dova.JDK.sun.util.logging.PlatformLogger stateLog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_UTF8_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_SUPPORTING_WM_CHECK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_SUPPORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_ACTIVE_WINDOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_MAXIMIZED_HORZ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_MAXIMIZED_VERT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_SHADED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_ABOVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_MODAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_FULLSCREEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_BELOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_HIDDEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_SKIP_TASKBAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_STATE_SKIP_PAGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "public final")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "public final")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_TYPE_NORMAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "public final")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_TYPE_DIALOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "public final")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_TYPE_UTILITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "public final")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_TYPE_POPUP_MENU_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XAtom;", "")]
	public Dova.JDK.sun.awt.X11.XAtom XA_NET_WM_WINDOW_OPACITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAtom>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int _NET_WM_STATE_REMOVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int _NET_WM_STATE_ADD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int _NET_WM_STATE_TOGGLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool supportChecked_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("J", "")]
	public long NetWindow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String net_wm_name_cache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XNETProtocol(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XNETProtocol() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XNETProtocol;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)I", "public")]
	public int getState(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool active()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;I)V", "public")]
	public void setState(Dova.JDK.sun.awt.X11.XWindowPeer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool supportsLayer(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool doOpacityProtocol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)V", "public")]
	public void unshadeKludge(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool doStateProtocol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;I)V", "private")]
	public void requestState(Dova.JDK.sun.awt.X11.XWindowPeer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindow;Lsun/awt/X11/XAtom;Z)V", "public")]
	public void requestState(Dova.JDK.sun.awt.X11.XWindow arg0, Dova.JDK.sun.awt.X11.XAtom arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;I)V", "private")]
	public void setInitialState(Dova.JDK.sun.awt.X11.XWindowPeer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)I", "")]
	public int getStateImpl(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool doLayerProtocol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;Lsun/awt/X11/XAtom;Z)V", "private")]
	public void setStateHelper(Dova.JDK.sun.awt.X11.XWindowPeer arg0, Dova.JDK.sun.awt.X11.XAtom arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "")]
	public void detect()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool supportsState(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XPropertyEvent;)Z", "public")]
	public bool isStateChange(Dova.JDK.sun.awt.X11.XPropertyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool doModalityProtocol()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void setActiveWindow(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isWMName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;Ljava/util/List;)V", "public")]
	public void setWMIcons(Dova.JDK.sun.awt.X11.XWindowPeer arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;I)V", "public")]
	public void setLayer(Dova.JDK.sun.awt.X11.XWindowPeer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindowPeer;)Z", "public")]
	public bool isWMStateNetHidden(Dova.JDK.sun.awt.X11.XWindowPeer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWMName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
