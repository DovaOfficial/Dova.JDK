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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/MenuSelectionManager;", "public")]
public partial class MenuSelectionManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuSelectionManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/MenuSelectionManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selection", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRACE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERBOSE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_SELECTION_MANAGER_KEY", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeEvent", "Ljavax/swing/event/ChangeEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listenerList", "Ljavax/swing/event/EventListenerList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printMenuElementArray", "([Ljavax/swing/MenuElement;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printMenuElementArray", "([Ljavax/swing/MenuElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComponentPartOfCurrentMenu", "(Ljavax/swing/MenuElement;Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComponentPartOfCurrentMenu", "(Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentForPoint", "(Ljava/awt/Component;Ljava/awt/Point;)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedPath", "()[Ljavax/swing/MenuElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireStateChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defaultManager", "()Ljavax/swing/MenuSelectionManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedPath", "([Ljavax/swing/MenuElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearSelectedPath", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyEvent", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseEvent", "(Ljava/awt/event/MouseEvent;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private")]
	public Dova.JDK.java.util.Vector selection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool TRACE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool VERBOSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private static final")]
	public static Dova.JDK.java.lang.StringBuilder MENU_SELECTION_MANAGER_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeEvent;", "protected transient")]
	public Dova.JDK.javax.swing.@event.ChangeEvent changeEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/EventListenerList;", "protected")]
	public Dova.JDK.javax.swing.@event.EventListenerList listenerList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.EventListenerList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MenuSelectionManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MenuSelectionManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/MenuSelectionManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljavax/swing/MenuElement;Z)V", "private")]
	public void printMenuElementArray(JavaArray<Dova.JDK.javax.swing.MenuElement> arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("([Ljavax/swing/MenuElement;)V", "private")]
	public void printMenuElementArray(JavaArray<Dova.JDK.javax.swing.MenuElement> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/MenuElement;Ljava/awt/Component;)Z", "private")]
	public bool isComponentPartOfCurrentMenu(Dova.JDK.javax.swing.MenuElement arg0, Dova.JDK.java.awt.Component arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public")]
	public bool isComponentPartOfCurrentMenu(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Point;)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component componentForPoint(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Point arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/MenuElement;", "public")]
	public JavaArray<Dova.JDK.javax.swing.MenuElement> getSelectedPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.MenuElement>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public")]
	public void removeChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public")]
	public void addChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/ChangeListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.ChangeListener> getChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.ChangeListener>>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void fireStateChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Ljavax/swing/MenuSelectionManager;", "public static")]
	public static Dova.JDK.javax.swing.MenuSelectionManager defaultManager()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.MenuSelectionManager>(ret);
	}

	[JniSignatureAttribute("([Ljavax/swing/MenuElement;)V", "public")]
	public void setSelectedPath(JavaArray<Dova.JDK.javax.swing.MenuElement> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearSelectedPath()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void processKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void processMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}
}
