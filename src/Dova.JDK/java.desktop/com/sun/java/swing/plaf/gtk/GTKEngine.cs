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

namespace Dova.JDK.com.sun.java.swing.plaf.gtk;

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine;", "")]
public partial class GTKEngine
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GTKEngine()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/gtk/GTKEngine;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "regionToWidgetTypeMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cache", "Lsun/swing/ImageCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "w0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "h0", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "graphics", "Ljava/awt/Graphics;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cacheArgs", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLOR_MODELS", "[Ljava/awt/image/ColorModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAND_OFFSETS", "[[I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackground", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/awt/Color;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSetting", "(Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintFocus", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWidgetType", "(Ljavax/swing/JComponent;Ljavax/swing/plaf/synth/Region;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_arrow", "(IIILjava/lang/String;IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTextDirection", "(Ljavax/swing/plaf/synth/SynthContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_box", "(IIILjava/lang/String;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_box_gap", "(IIILjava/lang/String;IIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_check", "(IILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_expander", "(IILjava/lang/String;IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_extension", "(IIILjava/lang/String;IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_flat_box", "(IIILjava/lang/String;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_focus", "(IILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_handle", "(IIILjava/lang/String;IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_hline", "(IILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_option", "(IILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_shadow", "(IIILjava/lang/String;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_slider", "(IIILjava/lang/String;IIIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_vline", "(IILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_paint_background", "(IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeStartPainting", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishPainting", "()Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finishPainting", "(Z)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeFinishPainting", "([III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_switch_theme", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "native_get_gtk_setting", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeSetRangeValue", "(IDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintArrow", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Lcom/sun/java/swing/plaf/gtk/GTKConstants$ArrowType;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBox", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBoxGap", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$PositionType;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintCheck", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintExpander", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ExpanderStyle;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintExtension", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$PositionType;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintFlatBox", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILjavax/swing/plaf/synth/ColorType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintHandle", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$Orientation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintHline", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintOption", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintShadow", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintSlider", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$Orientation;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintVline", "(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintCachedImage", "(Ljava/awt/Graphics;IIII[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startPainting", "(Ljava/awt/Graphics;IIII[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "themeChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRangeValue", "(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;DDDD)V"));
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine;", "static final")]
	public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CACHE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static")]
	public static Dova.JDK.java.util.HashMap regionToWidgetTypeMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/ImageCache;", "private")]
	public Dova.JDK.sun.swing.ImageCache cache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.ImageCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int x0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int y0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int w0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int h0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Graphics;", "private")]
	public Dova.JDK.java.awt.Graphics graphics_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> cacheArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/awt/image/ColorModel;", "private static final")]
	public static JavaArray<Dova.JDK.java.awt.image.ColorModel> COLOR_MODELS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.image.ColorModel>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "private static final")]
	public static JavaArray<JavaArray<int>> BAND_OFFSETS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GTKEngine(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public GTKEngine() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/gtk/GTKEngine;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/awt/Color;IIII)V", "public")]
	public void paintBackground(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.java.awt.Color arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getSetting(Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V", "public")]
	public void paintFocus(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.java.lang.String arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/plaf/synth/Region;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "static")]
	public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType getWidgetType(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.plaf.synth.Region arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIII)V", "private native")]
	public void native_paint_arrow(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;)I", "private static")]
	public static int getTextDirection(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIIII)V", "private native")]
	public void native_paint_box(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIIIII)V", "private native")]
	public void native_paint_box_gap(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIII)V", "private native")]
	public void native_paint_check(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIIII)V", "private native")]
	public void native_paint_expander(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIII)V", "private native")]
	public void native_paint_extension(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIIZ)V", "private native")]
	public void native_paint_flat_box(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, bool arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIII)V", "private native")]
	public void native_paint_focus(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIII)V", "private native")]
	public void native_paint_handle(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIII)V", "private native")]
	public void native_paint_hline(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIII)V", "private native")]
	public void native_paint_option(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIIII)V", "private native")]
	public void native_paint_shadow(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(IIILjava/lang/String;IIIIIZ)V", "private native")]
	public void native_paint_slider(int arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(IILjava/lang/String;IIII)V", "private native")]
	public void native_paint_vline(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(IIIIII)V", "private native")]
	public void native_paint_background(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(II)V", "private native")]
	public void nativeStartPainting(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage finishPainting()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage finishPainting(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("([III)I", "private native")]
	public int nativeFinishPainting(JavaArray<int> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "private native")]
	public void native_switch_theme()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "private native")]
	public Dova.JDK.java.lang.Object native_get_gtk_setting(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IDDDD)V", "private native")]
	public void nativeSetRangeValue(int arg0, double arg1, double arg2, double arg3, double arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Lcom/sun/java/swing/plaf/gtk/GTKConstants$ArrowType;Ljava/lang/String;IIII)V", "public")]
	public void paintArrow(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ArrowType arg5, Dova.JDK.java.lang.String arg6, int arg7, int arg8, int arg9, int arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIII)V", "public")]
	public void paintBox(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$PositionType;II)V", "public")]
	public void paintBoxGap(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.PositionType arg10, int arg11, int arg12)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;Ljava/lang/String;IIII)V", "public")]
	public void paintCheck(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ExpanderStyle;Ljava/lang/String;IIII)V", "public")]
	public void paintExpander(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ExpanderStyle arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$PositionType;I)V", "public")]
	public void paintExtension(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.PositionType arg10, int arg11)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILjavax/swing/plaf/synth/ColorType;)V", "public")]
	public void paintFlatBox(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.javax.swing.plaf.synth.ColorType arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$Orientation;)V", "public")]
	public void paintHandle(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.Orientation arg10)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V", "public")]
	public void paintHline(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.java.lang.String arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;Ljava/lang/String;IIII)V", "public")]
	public void paintOption(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIII)V", "public")]
	public void paintShadow(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILcom/sun/java/swing/plaf/gtk/GTKConstants$ShadowType;Ljava/lang/String;IIIILcom/sun/java/swing/plaf/gtk/GTKConstants$Orientation;Z)V", "public")]
	public void paintSlider(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.ShadowType arg4, Dova.JDK.java.lang.String arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.com.sun.java.swing.plaf.gtk.GTKConstants.Orientation arg10, bool arg11)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;ILjava/lang/String;IIII)V", "public")]
	public void paintVline(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.plaf.synth.Region arg2, int arg3, Dova.JDK.java.lang.String arg4, int arg5, int arg6, int arg7, int arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIII[Ljava/lang/Object;)Z", "public transient")]
	public bool paintCachedImage(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<Dova.JDK.java.lang.Object> arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIII[Ljava/lang/Object;)V", "public transient")]
	public void startPainting(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<Dova.JDK.java.lang.Object> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()V", "public")]
	public void themeChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/Region;DDDD)V", "")]
	public void setRangeValue(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.javax.swing.plaf.synth.Region arg1, double arg2, double arg3, double arg4, double arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "static final")]
	public partial class WidgetType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WidgetType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUTTON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_BOX", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_BOX_MENU_ITEM", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLOR_CHOOSER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMBO_BOX", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMBO_BOX_ARROW_BUTTON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMBO_BOX_TEXT_FIELD", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESKTOP_ICON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESKTOP_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDITOR_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORMATTED_TEXT_FIELD", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HANDLE_BOX", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HPROGRESS_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSCROLL_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSCROLL_BAR_BUTTON_LEFT", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSCROLL_BAR_BUTTON_RIGHT", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSCROLL_BAR_TRACK", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSCROLL_BAR_THUMB", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSEPARATOR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSLIDER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSLIDER_TRACK", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSLIDER_THUMB", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSPLIT_PANE_DIVIDER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNAL_FRAME", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNAL_FRAME_TITLE_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMAGE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LABEL", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIST", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_ITEM", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_ITEM_ACCELERATOR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PANEL", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PASSWORD_FIELD", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POPUP_MENU", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POPUP_MENU_SEPARATOR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RADIO_BUTTON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RADIO_BUTTON_MENU_ITEM", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCROLL_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPINNER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPINNER_ARROW_BUTTON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPINNER_TEXT_FIELD", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPLIT_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABBED_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABBED_PANE_TAB_AREA", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABBED_PANE_CONTENT", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABBED_PANE_TAB", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_HEADER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT_AREA", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT_FIELD", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT_PANE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TITLED_BORDER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOGGLE_BUTTON", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOOL_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOOL_BAR_DRAG_WINDOW", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOOL_BAR_SEPARATOR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOOL_TIP", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TREE", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TREE_CELL", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VIEWPORT", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VPROGRESS_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSCROLL_BAR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSCROLL_BAR_BUTTON_UP", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSCROLL_BAR_BUTTON_DOWN", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSCROLL_BAR_TRACK", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSCROLL_BAR_THUMB", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSEPARATOR", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSLIDER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSLIDER_TRACK", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSLIDER_THUMB", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSPLIT_PANE_DIVIDER", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType BUTTON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType CHECK_BOX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType CHECK_BOX_MENU_ITEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType COLOR_CHOOSER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType COMBO_BOX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType COMBO_BOX_ARROW_BUTTON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType COMBO_BOX_TEXT_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType DESKTOP_ICON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType DESKTOP_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType EDITOR_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType FORMATTED_TEXT_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HANDLE_BOX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HPROGRESS_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSCROLL_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSCROLL_BAR_BUTTON_LEFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSCROLL_BAR_BUTTON_RIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSCROLL_BAR_TRACK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSCROLL_BAR_THUMB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSLIDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSLIDER_TRACK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSLIDER_THUMB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType HSPLIT_PANE_DIVIDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType INTERNAL_FRAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType INTERNAL_FRAME_TITLE_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType IMAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType LABEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType LIST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType MENU_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType MENU_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType MENU_ITEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType MENU_ITEM_ACCELERATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType OPTION_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType PANEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType PASSWORD_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType POPUP_MENU_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType POPUP_MENU_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType RADIO_BUTTON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType RADIO_BUTTON_MENU_ITEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType ROOT_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType SCROLL_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType SPINNER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType SPINNER_ARROW_BUTTON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType SPINNER_TEXT_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType SPLIT_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABBED_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABBED_PANE_TAB_AREA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABBED_PANE_CONTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABBED_PANE_TAB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TABLE_HEADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TEXT_AREA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TEXT_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TEXT_PANE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TITLED_BORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TOGGLE_BUTTON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TOOL_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TOOL_BAR_DRAG_WINDOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TOOL_BAR_SEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TOOL_TIP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TREE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType TREE_CELL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VIEWPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VPROGRESS_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSCROLL_BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSCROLL_BAR_BUTTON_UP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSCROLL_BAR_BUTTON_DOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSCROLL_BAR_TRACK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSCROLL_BAR_THUMB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSEPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSLIDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSLIDER_TRACK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSLIDER_THUMB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType VSPLIT_PANE_DIVIDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WidgetType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public WidgetType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "public static")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$WidgetType;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.WidgetType>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "static final")]
	public partial class Settings
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Settings()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTK_FONT_NAME", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTK_ICON_SIZES", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTK_CURSOR_BLINK", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTK_CURSOR_BLINK_TIME", "Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;"));
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings GTK_FONT_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings GTK_ICON_SIZES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings GTK_CURSOR_BLINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static final")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings GTK_CURSOR_BLINK_TIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Settings(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Settings(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "public static")]
		public static Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/java/swing/plaf/gtk/GTKEngine$Settings;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java.swing.plaf.gtk.GTKEngine.Settings>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/gtk/GTKEngine$CustomRegion;", "static")]
	public partial class CustomRegion
		: Dova.JDK.javax.swing.plaf.synth.Region
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CustomRegion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/gtk/GTKEngine$CustomRegion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TITLED_BORDER", "Ljavax/swing/plaf/synth/Region;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/synth/Region;", "static")]
		public static Dova.JDK.javax.swing.plaf.synth.Region TITLED_BORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.Region>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CustomRegion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public CustomRegion(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/gtk/GTKEngine$CustomRegion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
