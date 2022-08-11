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

[JniSignatureAttribute("Ljavax/swing/DelegatingDefaultFocusManager;", "final")]
public partial class DelegatingDefaultFocusManager
	: Dova.JDK.javax.swing.DefaultFocusManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DelegatingDefaultFocusManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/DelegatingDefaultFocusManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljava/awt/KeyboardFocusManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/KeyboardFocusManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActiveWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultFocusTraversalPolicy", "(Ljava/awt/FocusTraversalPolicy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearGlobalFocusOwner", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusedWindow", "()Ljava/awt/Window;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusNextComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusPreviousComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upFocusCycle", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "downFocusCycle", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultFocusTraversalKeys", "(ILjava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlobalCurrentFocusCycleRoot", "(Ljava/awt/Container;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeKeyEventDispatcher", "(Ljava/awt/KeyEventDispatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchKeyEvent", "(Ljava/awt/event/KeyEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegate", "()Ljava/awt/KeyboardFocusManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatchEvent", "(Ljava/awt/AWTEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermanentFocusOwner", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyEvent", "(Ljava/awt/Component;Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentFocusCycleRoot", "()Ljava/awt/Container;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFocusTraversalPolicy", "()Ljava/awt/FocusTraversalPolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultFocusTraversalKeys", "(I)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager;", "private final")]
	public Dova.JDK.java.awt.KeyboardFocusManager @delegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DelegatingDefaultFocusManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/KeyboardFocusManager;)V", "")]
	public DelegatingDefaultFocusManager(Dova.JDK.java.awt.KeyboardFocusManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/DelegatingDefaultFocusManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/Window;", "public")]
	public Dova.JDK.java.awt.Window getActiveWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/FocusTraversalPolicy;)V", "public")]
	public void setDefaultFocusTraversalPolicy(Dova.JDK.java.awt.FocusTraversalPolicy arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearGlobalFocusOwner()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Ljava/awt/Window;", "public")]
	public Dova.JDK.java.awt.Window getFocusedWindow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void focusNextComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void focusPreviousComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void upFocusCycle(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void downFocusCycle(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(ILjava/util/Set;)V", "public")]
	public void setDefaultFocusTraversalKeys(int arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
	public void setGlobalCurrentFocusCycleRoot(Dova.JDK.java.awt.Container arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventDispatcher;)V", "public")]
	public void addKeyEventDispatcher(Dova.JDK.java.awt.KeyEventDispatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/KeyEventDispatcher;)V", "public")]
	public void removeKeyEventDispatcher(Dova.JDK.java.awt.KeyEventDispatcher arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)Z", "public")]
	public bool dispatchKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/KeyboardFocusManager;", "")]
	public Dova.JDK.java.awt.KeyboardFocusManager getDelegate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)Z", "public")]
	public bool dispatchEvent(Dova.JDK.java.awt.AWTEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getPermanentFocusOwner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/event/KeyEvent;)V", "public")]
	public void processKeyEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.@event.KeyEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Container;", "public")]
	public Dova.JDK.java.awt.Container getCurrentFocusCycleRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/FocusTraversalPolicy;", "public")]
	public Dova.JDK.java.awt.FocusTraversalPolicy getDefaultFocusTraversalPolicy()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FocusTraversalPolicy>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getDefaultFocusTraversalKeys(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.PropertyChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
	public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}
}
