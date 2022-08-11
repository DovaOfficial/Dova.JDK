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

namespace Dova.JDK.javax.swing.colorchooser;

[JniSignatureAttribute("Ljavax/swing/colorchooser/SlidingSpinner;", "final")]
public partial class SlidingSpinner
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.@event.ChangeListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SlidingSpinner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/colorchooser/SlidingSpinner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "panel", "Ljavax/swing/colorchooser/ColorPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Ljavax/swing/JComponent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "model", "Ljavax/swing/SpinnerNumberModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "slider", "Ljavax/swing/JSlider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spinner", "Ljavax/swing/JSpinner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internal", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/colorchooser/ColorPanel;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSlider", "()Ljavax/swing/JSlider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRange", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpinner", "()Ljavax/swing/JSpinner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "()Ljavax/swing/JComponent;"));
	}

	[JniSignatureAttribute("Ljavax/swing/colorchooser/ColorPanel;", "private final")]
	public Dova.JDK.javax.swing.colorchooser.ColorPanel panel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.colorchooser.ColorPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComponent;", "private final")]
	public Dova.JDK.javax.swing.JComponent label_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SpinnerNumberModel;", "private final")]
	public Dova.JDK.javax.swing.SpinnerNumberModel model_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SpinnerNumberModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JSlider;", "private final")]
	public Dova.JDK.javax.swing.JSlider slider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSlider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JSpinner;", "private final")]
	public Dova.JDK.javax.swing.JSpinner spinner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSpinner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool @internal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SlidingSpinner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/colorchooser/ColorPanel;Ljavax/swing/JComponent;)V", "")]
	public SlidingSpinner(Dova.JDK.javax.swing.colorchooser.ColorPanel arg0, Dova.JDK.javax.swing.JComponent arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/colorchooser/SlidingSpinner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()F", "")]
	public float getValue()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(F)V", "")]
	public void setValue(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JSlider;", "")]
	public Dova.JDK.javax.swing.JSlider getSlider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSlider>(ret);
	}

	[JniSignatureAttribute("(II)V", "")]
	public void setRange(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/JSpinner;", "")]
	public Dova.JDK.javax.swing.JSpinner getSpinner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSpinner>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
	public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/JComponent;", "")]
	public Dova.JDK.javax.swing.JComponent getLabel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
	}
}
