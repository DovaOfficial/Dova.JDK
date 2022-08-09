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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/ActionPropertyChangeListener;", "abstract")]
public partial class ActionPropertyChangeListener
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.beans.PropertyChangeListener
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ActionPropertyChangeListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/ActionPropertyChangeListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "queue", "Ljava/lang/ref/ReferenceQueue;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "target", "Ljavax/swing/ActionPropertyChangeListener$OwnedWeakReference;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "action", "Ljavax/swing/Action;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ActionPropertyChangeListener", "(Ljavax/swing/JComponent;Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getQueue", "()Ljava/lang/ref/ReferenceQueue;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTarget", "()Ljavax/swing/JComponent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setTarget", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAction", "()Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "actionPropertyChanged", "(Ljavax/swing/JComponent;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private static")]
	public static Dova.JDK.java.lang.@ref.ReferenceQueue queue_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/ActionPropertyChangeListener$OwnedWeakReference;", "private transient")]
	public Dova.JDK.javax.swing.ActionPropertyChangeListener.OwnedWeakReference target_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionPropertyChangeListener.OwnedWeakReference>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action action_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ActionPropertyChangeListener(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/Action;)V", "public")]
	public ActionPropertyChangeListener(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.Action arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/ActionPropertyChangeListener;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/ref/ReferenceQueue;", "private static")]
	public static Dova.JDK.java.lang.@ref.ReferenceQueue getQueue()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JComponent;", "public")]
	public Dova.JDK.java.lang.Object getTarget()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "private")]
	public void setTarget(Dova.JDK.java.lang.Object arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/Action;", "public")]
	public Dova.JDK.javax.swing.Action getAction()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V", "protected abstract")]
	public void actionPropertyChanged(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.Action arg1, Dova.JDK.java.beans.PropertyChangeEvent arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public final")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/ActionPropertyChangeListener$OwnedWeakReference;", "private static")]
	public partial class OwnedWeakReference
		: Dova.JDK.java.lang.@ref.WeakReference
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OwnedWeakReference()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/ActionPropertyChangeListener$OwnedWeakReference;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "owner", "Ljavax/swing/ActionPropertyChangeListener;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "OwnedWeakReference", "(Ljavax/swing/JComponent;Ljava/lang/ref/ReferenceQueue;Ljavax/swing/ActionPropertyChangeListener;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getOwner", "()Ljavax/swing/ActionPropertyChangeListener;"));
		}

		[JniSignatureAttribute("Ljavax/swing/ActionPropertyChangeListener;", "private")]
		public Dova.JDK.javax.swing.ActionPropertyChangeListener owner_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionPropertyChangeListener>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OwnedWeakReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/lang/ref/ReferenceQueue;Ljavax/swing/ActionPropertyChangeListener;)V", "")]
		public OwnedWeakReference(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.@ref.ReferenceQueue arg1, Dova.JDK.javax.swing.ActionPropertyChangeListener arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/ActionPropertyChangeListener$OwnedWeakReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/ActionPropertyChangeListener;", "public")]
		public Dova.JDK.javax.swing.ActionPropertyChangeListener getOwner()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionPropertyChangeListener>(ret);
		}
	}
}