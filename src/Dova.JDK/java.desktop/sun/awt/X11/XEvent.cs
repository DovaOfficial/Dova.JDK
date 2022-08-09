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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XEvent;", "public")]
public partial class XEvent
	: Dova.JDK.sun.awt.X11.XWrapperBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XEvent()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/X11/XEvent;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "unsafe", "Ljdk/internal/misc/Unsafe;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "should_free_memory", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pData", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XEvent", "(J)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XEvent", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clone", "()Lsun/awt/X11/XEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "zero", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_type", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xany", "()Lsun/awt/X11/XAnyEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xproperty", "()Lsun/awt/X11/XPropertyEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xclient", "()Lsun/awt/X11/XClientMessageEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xkey", "()Lsun/awt/X11/XKeyEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xbutton", "()Lsun/awt/X11/XButtonEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xmotion", "()Lsun/awt/X11/XMotionEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xcrossing", "()Lsun/awt/X11/XCrossingEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xfocus", "()Lsun/awt/X11/XFocusChangeEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xexpose", "()Lsun/awt/X11/XExposeEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xgraphicsexpose", "()Lsun/awt/X11/XGraphicsExposeEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xnoexpose", "()Lsun/awt/X11/XNoExposeEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xvisibility", "()Lsun/awt/X11/XVisibilityEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xcreatewindow", "()Lsun/awt/X11/XCreateWindowEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xdestroywindow", "()Lsun/awt/X11/XDestroyWindowEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xunmap", "()Lsun/awt/X11/XUnmapEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xmap", "()Lsun/awt/X11/XMapEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xmaprequest", "()Lsun/awt/X11/XMapRequestEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xreparent", "()Lsun/awt/X11/XReparentEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xconfigure", "()Lsun/awt/X11/XConfigureEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xgravity", "()Lsun/awt/X11/XGravityEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xresizerequest", "()Lsun/awt/X11/XResizeRequestEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xconfigurerequest", "()Lsun/awt/X11/XConfigureRequestEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xcirculate", "()Lsun/awt/X11/XCirculateEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xcirculaterequest", "()Lsun/awt/X11/XCirculateRequestEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xselectionclear", "()Lsun/awt/X11/XSelectionClearEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xselectionrequest", "()Lsun/awt/X11/XSelectionRequestEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xselection", "()Lsun/awt/X11/XSelectionEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xcolormap", "()Lsun/awt/X11/XColormapEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xmapping", "()Lsun/awt/X11/XMappingEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xerror", "()Lsun/awt/X11/XErrorEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_xkeymap", "()Lsun/awt/X11/XKeymapEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_pad", "(I)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get_pad", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDataSize", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPData", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "set_type", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "set_pad", "(IJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFieldsAsString", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljdk/internal/misc/Unsafe;", "private")]
	public Dova.JDK.jdk.@internal.misc.Unsafe @unsafe_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.misc.Unsafe>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool should_free_memory_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("J", "")]
	public long pData_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public XEvent(long arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XEvent() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XEvent;", "public volatile")]
	public Dova.JDK.sun.awt.X11.XEvent clone()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XEvent>(ret);
	}

	[JniSignatureAttribute("()I", "public static")]
	public static int getSize()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public volatile")]
	public void zero()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int get_type()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XAnyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XAnyEvent get_xany()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XAnyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XPropertyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XPropertyEvent get_xproperty()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XPropertyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XClientMessageEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XClientMessageEvent get_xclient()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XClientMessageEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XKeyEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XKeyEvent get_xkey()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XKeyEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XButtonEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XButtonEvent get_xbutton()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XButtonEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XMotionEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XMotionEvent get_xmotion()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XMotionEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XCrossingEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XCrossingEvent get_xcrossing()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCrossingEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XFocusChangeEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XFocusChangeEvent get_xfocus()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XFocusChangeEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XExposeEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XExposeEvent get_xexpose()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XExposeEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XGraphicsExposeEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XGraphicsExposeEvent get_xgraphicsexpose()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XGraphicsExposeEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XNoExposeEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XNoExposeEvent get_xnoexpose()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XNoExposeEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XVisibilityEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XVisibilityEvent get_xvisibility()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XVisibilityEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XCreateWindowEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XCreateWindowEvent get_xcreatewindow()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCreateWindowEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XDestroyWindowEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XDestroyWindowEvent get_xdestroywindow()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDestroyWindowEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XUnmapEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XUnmapEvent get_xunmap()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XUnmapEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XMapEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XMapEvent get_xmap()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XMapEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XMapRequestEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XMapRequestEvent get_xmaprequest()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XMapRequestEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XReparentEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XReparentEvent get_xreparent()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XReparentEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XConfigureEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XConfigureEvent get_xconfigure()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XConfigureEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XGravityEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XGravityEvent get_xgravity()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XGravityEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XResizeRequestEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XResizeRequestEvent get_xresizerequest()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XResizeRequestEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XConfigureRequestEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XConfigureRequestEvent get_xconfigurerequest()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XConfigureRequestEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XCirculateEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XCirculateEvent get_xcirculate()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCirculateEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XCirculateRequestEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XCirculateRequestEvent get_xcirculaterequest()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XCirculateRequestEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XSelectionClearEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XSelectionClearEvent get_xselectionclear()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XSelectionClearEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XSelectionRequestEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XSelectionRequestEvent get_xselectionrequest()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XSelectionRequestEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XSelectionEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XSelectionEvent get_xselection()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XSelectionEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XColormapEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XColormapEvent get_xcolormap()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XColormapEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XMappingEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XMappingEvent get_xmapping()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XMappingEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XErrorEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XErrorEvent get_xerror()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XErrorEvent>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XKeymapEvent;", "public")]
	public Dova.JDK.sun.awt.X11.XKeymapEvent get_xkeymap()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XKeymapEvent>(ret);
	}

	[JniSignatureAttribute("(I)J", "public")]
	public long get_pad(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long get_pad()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDataSize()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getPData()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void set_type(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(IJ)V", "public")]
	public void set_pad(int arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getFieldsAsString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
