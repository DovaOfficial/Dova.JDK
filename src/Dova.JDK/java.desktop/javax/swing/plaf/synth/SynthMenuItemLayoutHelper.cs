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

namespace Dova.JDK.javax.swing.plaf.synth;

[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;", "")]
public partial class SynthMenuItemLayoutHelper
	: Dova.JDK.sun.swing.MenuItemLayoutHelper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthMenuItemLayoutHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ACC_OR_ARROW_WIDTH", "Lsun/swing/StringUIClientPropertyKey;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTR_ALIGNMENT_1", "Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTR_ALIGNMENT_2", "Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RTL_ALIGNMENT_1", "Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RTL_ALIGNMENT_2", "Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Ljavax/swing/plaf/synth/SynthContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accContext", "Ljavax/swing/plaf/synth/SynthContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accStyle", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gu", "Ljavax/swing/plaf/synth/SynthGraphicsUtils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accGu", "Ljavax/swing/plaf/synth/SynthGraphicsUtils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alignAcceleratorText", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxAccOrArrowWidth", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/JMenuItem;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljava/awt/Rectangle;ILjava/lang/String;ZZLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "()Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphicsUtils", "()Ljavax/swing/plaf/synth/SynthGraphicsUtils;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignAcceleratorText", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "alignAcceleratorText", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccContext", "()Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcWidthsAndHeights", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calcMaxWidths", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccStyle", "()Ljavax/swing/plaf/synth/SynthStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccGraphicsUtils", "()Ljavax/swing/plaf/synth/SynthGraphicsUtils;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxAccOrArrowWidth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareForLayout", "(Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLTRColumnAlignment", "()Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRTLColumnAlignment", "()Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutIconAndTextInLabelRect", "(Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyle", "()Ljavax/swing/plaf/synth/SynthStyle;"));
	}

	[JniSignatureAttribute("Lsun/swing/StringUIClientPropertyKey;", "public static final")]
	public static Dova.JDK.sun.swing.StringUIClientPropertyKey MAX_ACC_OR_ARROW_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.StringUIClientPropertyKey>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public static final")]
	public static Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment LTR_ALIGNMENT_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public static final")]
	public static Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment LTR_ALIGNMENT_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public static final")]
	public static Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment RTL_ALIGNMENT_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public static final")]
	public static Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment RTL_ALIGNMENT_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext accContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle accStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthGraphicsUtils;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils gu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthGraphicsUtils;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils accGu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool alignAcceleratorText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxAccOrArrowWidth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SynthMenuItemLayoutHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/plaf/synth/SynthContext;Ljavax/swing/JMenuItem;Ljavax/swing/Icon;Ljavax/swing/Icon;Ljava/awt/Rectangle;ILjava/lang/String;ZZLjava/lang/String;)V", "public")]
	public SynthMenuItemLayoutHelper(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.javax.swing.plaf.synth.SynthContext arg1, Dova.JDK.javax.swing.JMenuItem arg2, Dova.JDK.javax.swing.Icon arg3, Dova.JDK.javax.swing.Icon arg4, Dova.JDK.java.awt.Rectangle arg5, int arg6, Dova.JDK.java.lang.String arg7, bool arg8, bool arg9, Dova.JDK.java.lang.String arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthMenuItemLayoutHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthContext;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthGraphicsUtils;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils getGraphicsUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool getAlignAcceleratorText(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool alignAcceleratorText()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthContext;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getAccContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calcWidthsAndHeights()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void calcMaxWidths()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthStyle;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle getAccStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthGraphicsUtils;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils getAccGraphicsUtils()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthGraphicsUtils>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxAccOrArrowWidth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "protected")]
	public void prepareForLayout(Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public")]
	public Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment getLTRColumnAlignment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
	}

	[JniSignatureAttribute("()Lsun/swing/MenuItemLayoutHelper$ColumnAlignment;", "public")]
	public Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment getRTLColumnAlignment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.MenuItemLayoutHelper.ColumnAlignment>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/MenuItemLayoutHelper$LayoutResult;)V", "protected")]
	public void layoutIconAndTextInLabelRect(Dova.JDK.sun.swing.MenuItemLayoutHelper.LayoutResult arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/synth/SynthStyle;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle getStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
	}
}
