/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/Scrollbar;", "public")]
public partial class Scrollbar
	: Dova.JDK.java.awt.Component
	, Dova.JDK.java.awt.Adjustable
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Scrollbar()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/Scrollbar;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HORIZONTAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VERTICAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "value", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maximum", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minimum", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "visibleAmount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "orientation", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lineIncrement", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pageIncrement", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isAdjusting", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "adjustmentListener", "Ljava/awt/event/AdjustmentListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "base", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "nameCounter", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scrollbarSerializedDataVersion", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Scrollbar", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Scrollbar", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Scrollbar", "(IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValue", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaximum", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinimum", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOrientation", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMinimum", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrientation", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLineIncrement", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLineIncrement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPageIncrement", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPageIncrement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "processAdjustmentEvent", "(Ljava/awt/event/AdjustmentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVisibleAmount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setVisibleAmount", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setUnitIncrement", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getUnitIncrement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBlockIncrement", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBlockIncrement", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAdjustmentListeners", "()[Ljava/awt/event/AdjustmentListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValues", "(IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getValueIsAdjusting", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVisible", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getListeners", "(Ljava/lang/Class;)[Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMaximum", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "eventEnabled", "(Ljava/awt/AWTEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "processEvent", "(Ljava/awt/AWTEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "constructComponentName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setValueIsAdjusting", "(Z)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int HORIZONTAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int VERTICAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "")]
	public int value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "")]
	public int maximum_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "")]
	public int minimum_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "")]
	public int visibleAmount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("I", "")]
	public int orientation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "")]
	public int lineIncrement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "")]
	public int pageIncrement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Z", "transient")]
	public bool isAdjusting_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Ljava/awt/event/AdjustmentListener;", "transient")]
	public Dova.JDK.java.awt.@event.AdjustmentListener adjustmentListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.AdjustmentListener>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String @base_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static")]
	public static int nameCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int scrollbarSerializedDataVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Scrollbar(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public Scrollbar(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Scrollbar() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(IIIII)V", "public")]
	public Scrollbar(int arg0, int arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/Scrollbar;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setValue(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaximum()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinimum()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setOrientation(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMinimum(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOrientation()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public synchronized")]
	public void setLineIncrement(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLineIncrement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public synchronized")]
	public void setPageIncrement(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPageIncrement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentEvent;)V", "protected")]
	public void processAdjustmentEvent(Dova.JDK.java.awt.@event.AdjustmentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;)V", "public synchronized")]
	public void addAdjustmentListener(Dova.JDK.java.awt.@event.AdjustmentListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getVisibleAmount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setVisibleAmount(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setUnitIncrement(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getUnitIncrement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setBlockIncrement(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getBlockIncrement()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/AdjustmentListener;)V", "public synchronized")]
	public void removeAdjustmentListener(Dova.JDK.java.awt.@event.AdjustmentListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/event/AdjustmentListener;", "public synchronized")]
	public JavaArray<Dova.JDK.java.awt.@event.AdjustmentListener> getAdjustmentListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.AdjustmentListener>>(ret);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void setValues(int arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getValueIsAdjusting()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getVisible()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/util/EventListener;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaximum(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void addNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31]);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "")]
	public bool eventEnabled(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "protected")]
	public void processEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String constructComponentName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setValueIsAdjusting(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("Ljava/awt/Scrollbar$AccessibleAWTScrollBar;", "protected")]
	public partial class AccessibleAWTScrollBar
		: Dova.JDK.java.awt.Component.AccessibleAWTComponent
		, Dova.JDK.javax.accessibility.AccessibleValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleAWTScrollBar()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/Scrollbar$AccessibleAWTScrollBar;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljava/awt/Scrollbar;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AccessibleAWTScrollBar", "(Ljava/awt/Scrollbar;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccessibleValue", "()Ljavax/accessibility/AccessibleValue;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCurrentAccessibleValue", "()Ljava/lang/Number;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCurrentAccessibleValue", "(Ljava/lang/Number;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinimumAccessibleValue", "()Ljava/lang/Number;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaximumAccessibleValue", "()Ljava/lang/Number;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/awt/Scrollbar;", "final")]
		public Dova.JDK.java.awt.Scrollbar this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Scrollbar>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleAWTScrollBar(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Scrollbar;)V", "protected")]
		public AccessibleAWTScrollBar(Dova.JDK.java.awt.Scrollbar arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/Scrollbar$AccessibleAWTScrollBar;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleValue;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleValue getAccessibleValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleValue>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Number;", "public")]
		public Dova.JDK.java.lang.Number getCurrentAccessibleValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Number;)Z", "public")]
		public bool setCurrentAccessibleValue(Dova.JDK.java.lang.Number arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Number;", "public")]
		public Dova.JDK.java.lang.Number getMinimumAccessibleValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Number;", "public")]
		public Dova.JDK.java.lang.Number getMaximumAccessibleValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}
	}
}
