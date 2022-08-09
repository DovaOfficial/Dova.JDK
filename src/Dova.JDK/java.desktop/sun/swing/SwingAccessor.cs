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

namespace Dova.JDK.sun.swing;

[JniSignatureAttribute("Lsun/swing/SwingAccessor;", "public final")]
public partial class SwingAccessor
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SwingAccessor()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "jComponentAccessor", "Lsun/swing/SwingAccessor$JComponentAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "jtextComponentAccessor", "Lsun/swing/SwingAccessor$JTextComponentAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "jLightweightFrameAccessor", "Lsun/swing/SwingAccessor$JLightweightFrameAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "uiDefaultsAccessor", "Lsun/swing/SwingAccessor$UIDefaultsAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "repaintManagerAccessor", "Lsun/swing/SwingAccessor$RepaintManagerAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "popupFactoryAccessor", "Lsun/swing/SwingAccessor$PopupFactoryAccessor;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "keyStrokeAccessor", "Lsun/swing/SwingAccessor$KeyStrokeAccessor;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SwingAccessor", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "ensureClassInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getJTextComponentAccessor", "()Lsun/swing/SwingAccessor$JTextComponentAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setJLightweightFrameAccessor", "(Lsun/swing/SwingAccessor$JLightweightFrameAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getJLightweightFrameAccessor", "()Lsun/swing/SwingAccessor$JLightweightFrameAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setUIDefaultsAccessor", "(Lsun/swing/SwingAccessor$UIDefaultsAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getUIDefaultsAccessor", "()Lsun/swing/SwingAccessor$UIDefaultsAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setRepaintManagerAccessor", "(Lsun/swing/SwingAccessor$RepaintManagerAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getRepaintManagerAccessor", "()Lsun/swing/SwingAccessor$RepaintManagerAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getPopupFactoryAccessor", "()Lsun/swing/SwingAccessor$PopupFactoryAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setPopupFactoryAccessor", "(Lsun/swing/SwingAccessor$PopupFactoryAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getKeyStrokeAccessor", "()Lsun/swing/SwingAccessor$KeyStrokeAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setKeyStrokeAccessor", "(Lsun/swing/SwingAccessor$KeyStrokeAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getJComponentAccessor", "()Lsun/swing/SwingAccessor$JComponentAccessor;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setJTextComponentAccessor", "(Lsun/swing/SwingAccessor$JTextComponentAccessor;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setJComponentAccessor", "(Lsun/swing/SwingAccessor$JComponentAccessor;)V"));
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JComponentAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JComponentAccessor jComponentAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JComponentAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JTextComponentAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JTextComponentAccessor jtextComponentAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JTextComponentAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JLightweightFrameAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JLightweightFrameAccessor jLightweightFrameAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JLightweightFrameAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$UIDefaultsAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.UIDefaultsAccessor uiDefaultsAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.UIDefaultsAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$RepaintManagerAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.RepaintManagerAccessor repaintManagerAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.RepaintManagerAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$PopupFactoryAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.PopupFactoryAccessor popupFactoryAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.PopupFactoryAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$KeyStrokeAccessor;", "private static")]
	public static Dova.JDK.sun.swing.SwingAccessor.KeyStrokeAccessor keyStrokeAccessor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.KeyStrokeAccessor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SwingAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SwingAccessor() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/swing/SwingAccessor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void ensureClassInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$JTextComponentAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JTextComponentAccessor getJTextComponentAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JTextComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$JLightweightFrameAccessor;)V", "public static")]
	public static void setJLightweightFrameAccessor(Dova.JDK.sun.swing.SwingAccessor.JLightweightFrameAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$JLightweightFrameAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JLightweightFrameAccessor getJLightweightFrameAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JLightweightFrameAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$UIDefaultsAccessor;)V", "public static")]
	public static void setUIDefaultsAccessor(Dova.JDK.sun.swing.SwingAccessor.UIDefaultsAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$UIDefaultsAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.UIDefaultsAccessor getUIDefaultsAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.UIDefaultsAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$RepaintManagerAccessor;)V", "public static")]
	public static void setRepaintManagerAccessor(Dova.JDK.sun.swing.SwingAccessor.RepaintManagerAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$RepaintManagerAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.RepaintManagerAccessor getRepaintManagerAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.RepaintManagerAccessor>(ret);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$PopupFactoryAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.PopupFactoryAccessor getPopupFactoryAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.PopupFactoryAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$PopupFactoryAccessor;)V", "public static")]
	public static void setPopupFactoryAccessor(Dova.JDK.sun.swing.SwingAccessor.PopupFactoryAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$KeyStrokeAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.KeyStrokeAccessor getKeyStrokeAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.KeyStrokeAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$KeyStrokeAccessor;)V", "public static")]
	public static void setKeyStrokeAccessor(Dova.JDK.sun.swing.SwingAccessor.KeyStrokeAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/SwingAccessor$JComponentAccessor;", "public static")]
	public static Dova.JDK.sun.swing.SwingAccessor.JComponentAccessor getJComponentAccessor()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.SwingAccessor.JComponentAccessor>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$JTextComponentAccessor;)V", "public static")]
	public static void setJTextComponentAccessor(Dova.JDK.sun.swing.SwingAccessor.JTextComponentAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lsun/swing/SwingAccessor$JComponentAccessor;)V", "public static")]
	public static void setJComponentAccessor(Dova.JDK.sun.swing.SwingAccessor.JComponentAccessor arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JComponentAccessor;", "public abstract static interface")]
	public partial interface JComponentAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JComponentAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$JComponentAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "compWriteObjectNotify", "(Ljavax/swing/JComponent;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFlag", "(Ljavax/swing/JComponent;I)Z"));
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public abstract")]
		void compWriteObjectNotify(Dova.JDK.javax.swing.JComponent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Z", "public abstract")]
		bool getFlag(Dova.JDK.javax.swing.JComponent arg0, int arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JTextComponentAccessor;", "public abstract static interface")]
	public partial interface JTextComponentAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JTextComponentAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$JTextComponentAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dropLocationForPoint", "(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setDropLocation", "(Ljavax/swing/text/JTextComponent;Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;", "public abstract")]
		Dova.JDK.javax.swing.TransferHandler.DropLocation dropLocationForPoint(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TransferHandler.DropLocation>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object setDropLocation(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.javax.swing.TransferHandler.DropLocation arg1, Dova.JDK.java.lang.Object arg2, bool arg3)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$JLightweightFrameAccessor;", "public abstract static interface")]
	public partial interface JLightweightFrameAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JLightweightFrameAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$JLightweightFrameAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateCursor", "(Lsun/swing/JLightweightFrame;)V"));
		}

		[JniSignatureAttribute("(Lsun/swing/JLightweightFrame;)V", "public abstract")]
		void updateCursor(Dova.JDK.sun.swing.JLightweightFrame arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$UIDefaultsAccessor;", "public abstract static interface")]
	public partial interface UIDefaultsAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UIDefaultsAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$UIDefaultsAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addInternalBundle", "(Ljavax/swing/UIDefaults;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("(Ljavax/swing/UIDefaults;Ljava/lang/String;)V", "public abstract")]
		void addInternalBundle(Dova.JDK.javax.swing.UIDefaults arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$RepaintManagerAccessor;", "public abstract static interface")]
	public partial interface RepaintManagerAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RepaintManagerAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$RepaintManagerAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addRepaintListener", "(Ljavax/swing/RepaintManager;Lsun/swing/SwingUtilities2$RepaintListener;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeRepaintListener", "(Ljavax/swing/RepaintManager;Lsun/swing/SwingUtilities2$RepaintListener;)V"));
		}

		[JniSignatureAttribute("(Ljavax/swing/RepaintManager;Lsun/swing/SwingUtilities2$RepaintListener;)V", "public abstract")]
		void addRepaintListener(Dova.JDK.javax.swing.RepaintManager arg0, Dova.JDK.sun.swing.SwingUtilities2.RepaintListener arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/RepaintManager;Lsun/swing/SwingUtilities2$RepaintListener;)V", "public abstract")]
		void removeRepaintListener(Dova.JDK.javax.swing.RepaintManager arg0, Dova.JDK.sun.swing.SwingUtilities2.RepaintListener arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$PopupFactoryAccessor;", "public abstract static interface")]
	public partial interface PopupFactoryAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PopupFactoryAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$PopupFactoryAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getHeavyWeightPopup", "(Ljavax/swing/PopupFactory;Ljava/awt/Component;Ljava/awt/Component;II)Ljavax/swing/Popup;"));
		}

		[JniSignatureAttribute("(Ljavax/swing/PopupFactory;Ljava/awt/Component;Ljava/awt/Component;II)Ljavax/swing/Popup;", "public abstract")]
		Dova.JDK.javax.swing.Popup getHeavyWeightPopup(Dova.JDK.javax.swing.PopupFactory arg0, Dova.JDK.java.awt.Component arg1, Dova.JDK.java.awt.Component arg2, int arg3, int arg4)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Popup>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/SwingAccessor$KeyStrokeAccessor;", "public abstract static interface")]
	public partial interface KeyStrokeAccessor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyStrokeAccessor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/SwingAccessor$KeyStrokeAccessor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "create", "()Ljavax/swing/KeyStroke;"));
		}

		[JniSignatureAttribute("()Ljavax/swing/KeyStroke;", "public abstract")]
		Dova.JDK.javax.swing.KeyStroke create()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.KeyStroke>(ret);
		}
	}
}
