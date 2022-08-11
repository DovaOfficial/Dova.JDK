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

namespace Dova.JDK.javax.swing.plaf.metal;

[JniSignatureAttribute("Ljavax/swing/plaf/metal/MetalTheme;", "public abstract")]
public partial class MetalTheme
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetalTheme()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/MetalTheme;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTROL_TEXT_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM_TEXT_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USER_TEXT_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_TEXT_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WINDOW_TITLE_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUB_TEXT_FONT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "white", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "black", "Ljavax/swing/plaf/ColorUIResource;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControl", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlDarkShadow", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlShadow", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlInfo", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlack", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWhite", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextHighlightColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHighlightedTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryControlHighlight", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlHighlight", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuSelectedBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuSelectedForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceleratorForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceleratorSelectedForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addCustomEntriesToTable", "(Ljavax/swing/UIDefaults;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSystemTheme", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlDisabled", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDesktopColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryControl", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryControlShadow", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryControlDarkShadow", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryControlInfo", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInactiveControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInactiveSystemTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleInactiveBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleInactiveForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuDisabledForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeparatorBackground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeparatorForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "()V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CONTROL_TEXT_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SYSTEM_TEXT_FONT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int USER_TEXT_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MENU_TEXT_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int WINDOW_TITLE_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SUB_TEXT_FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "static")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource white_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource black_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetalTheme(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public MetalTheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/MetalTheme;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getFocusColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlDarkShadow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlShadow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getBlack()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWhite()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWindowBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getUserTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getTextHighlightColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getHighlightedTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimaryControlHighlight()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlHighlight()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuSelectedBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuSelectedForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getAcceleratorForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getAcceleratorSelectedForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)V", "public")]
	public void addCustomEntriesToTable(Dova.JDK.javax.swing.UIDefaults arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isSystemTheme()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected abstract")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getControlTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getSystemTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getUserTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getMenuTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getWindowTitleFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public abstract")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getSubTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlDisabled()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getDesktopColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimaryControl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimaryControlShadow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimaryControlDarkShadow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimaryControlInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSystemTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getInactiveControlTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getInactiveSystemTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWindowTitleBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWindowTitleForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWindowTitleInactiveBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getWindowTitleInactiveForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuDisabledForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSeparatorBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSeparatorForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void install()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51]);
	}
}
