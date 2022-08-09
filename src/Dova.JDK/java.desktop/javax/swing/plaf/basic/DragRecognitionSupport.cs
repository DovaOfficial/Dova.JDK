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

namespace Dova.JDK.javax.swing.plaf.basic;

[JniSignatureAttribute("Ljavax/swing/plaf/basic/DragRecognitionSupport;", "")]
public partial class DragRecognitionSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DragRecognitionSupport()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/plaf/basic/DragRecognitionSupport;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "motionThreshold", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dndArmedEvent", "Ljava/awt/event/MouseEvent;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "component", "Ljavax/swing/JComponent;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DragRecognitionSupport", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDragRecognitionSupport", "()Ljavax/swing/plaf/basic/DragRecognitionSupport;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mousePressedImpl", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mouseReleasedImpl", "(Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mouseDraggedImpl", "(Ljava/awt/event/MouseEvent;Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clearState", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "mapDragOperationFromModifiers", "(Ljava/awt/event/MouseEvent;Ljavax/swing/TransferHandler;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mouseReleased", "(Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;)Z"));
	}

	[JniSignatureAttribute("I", "private")]
	public int motionThreshold_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/awt/event/MouseEvent;", "private")]
	public Dova.JDK.java.awt.@event.MouseEvent dndArmedEvent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/JComponent;", "private")]
	public Dova.JDK.javax.swing.JComponent component_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DragRecognitionSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public DragRecognitionSupport() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/DragRecognitionSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/DragRecognitionSupport;", "private static")]
	public static Dova.JDK.javax.swing.plaf.basic.DragRecognitionSupport getDragRecognitionSupport()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.DragRecognitionSupport>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "private")]
	public bool mousePressedImpl(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;", "private")]
	public Dova.JDK.java.awt.@event.MouseEvent mouseReleasedImpl(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;)Z", "private")]
	public bool mouseDraggedImpl(Dova.JDK.java.awt.@event.MouseEvent arg0, Dova.JDK.javax.swing.plaf.basic.DragRecognitionSupport.BeforeDrag arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void clearState()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Ljavax/swing/TransferHandler;)I", "private")]
	public int mapDragOperationFromModifiers(Dova.JDK.java.awt.@event.MouseEvent arg0, Dova.JDK.javax.swing.TransferHandler arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Z", "public static")]
	public static bool mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;", "public static")]
	public static Dova.JDK.java.awt.@event.MouseEvent mouseReleased(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;)Z", "public static")]
	public static bool mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0, Dova.JDK.javax.swing.plaf.basic.DragRecognitionSupport.BeforeDrag arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;", "public abstract static interface")]
	public partial interface BeforeDrag
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BeforeDrag()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/plaf/basic/DragRecognitionSupport$BeforeDrag;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragStarting", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public abstract")]
		void dragStarting(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}
}
