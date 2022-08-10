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

namespace Dova.JDK.java.beans;

[JniSignatureAttribute("Ljava/beans/VetoableChangeSupport;", "public")]
public partial class VetoableChangeSupport
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VetoableChangeSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/VetoableChangeSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "map", "Ljava/beans/VetoableChangeSupport$VetoableChangeListenerMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "source", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialPersistentFields", "[Ljava/io/ObjectStreamField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "VetoableChangeSupport", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasListeners", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireVetoableChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireVetoableChange", "(Ljava/lang/String;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireVetoableChange", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireVetoableChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeVetoableChangeListener", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVetoableChangeListeners", "(Ljava/lang/String;)[Ljava/beans/VetoableChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVetoableChangeListeners", "()[Ljava/beans/VetoableChangeListener;"));
	}

	[JniSignatureAttribute("Ljava/beans/VetoableChangeSupport$VetoableChangeListenerMap;", "private")]
	public Dova.JDK.java.beans.VetoableChangeSupport.VetoableChangeListenerMap map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.VetoableChangeSupport.VetoableChangeListenerMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/io/ObjectStreamField;", "private static final")]
	public static JavaArray<Dova.JDK.java.io.ObjectStreamField> serialPersistentFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectStreamField>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VetoableChangeSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public VetoableChangeSupport(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/VetoableChangeSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool hasListeners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void fireVetoableChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZZ)V", "public")]
	public void fireVetoableChange(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
	public void fireVetoableChange(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void fireVetoableChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void addVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)V", "public")]
	public void removeVetoableChangeListener(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/beans/VetoableChangeListener;", "public")]
	public JavaArray<Dova.JDK.java.beans.VetoableChangeListener> getVetoableChangeListeners(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljava/beans/VetoableChangeListener;", "public")]
	public JavaArray<Dova.JDK.java.beans.VetoableChangeListener> getVetoableChangeListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
	}

	[JniSignatureAttribute("Ljava/beans/VetoableChangeSupport$VetoableChangeListenerMap;", "private static final")]
	public partial class VetoableChangeListenerMap
		: Dova.JDK.java.beans.ChangeListenerMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static VetoableChangeListenerMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/VetoableChangeSupport$VetoableChangeListenerMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY", "[Ljava/beans/VetoableChangeListener;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "VetoableChangeListenerMap", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newArray_0", "(I)[Ljava/util/EventListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newArray_1", "(I)[Ljava/beans/VetoableChangeListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extract", "(Ljava/util/EventListener;)Ljava/util/EventListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extract", "(Ljava/beans/VetoableChangeListener;)Ljava/beans/VetoableChangeListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newProxy", "(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)Ljava/beans/VetoableChangeListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newProxy", "(Ljava/lang/String;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		}

		[JniSignatureAttribute("[Ljava/beans/VetoableChangeListener;", "private static final")]
		public static JavaArray<Dova.JDK.java.beans.VetoableChangeListener> EMPTY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public VetoableChangeListenerMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public VetoableChangeListenerMap() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/VetoableChangeSupport$VetoableChangeListenerMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)[Ljava/util/EventListener;", "protected volatile")]
		public JavaArray<Dova.JDK.java.util.EventListener> newArray_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.EventListener>>(ret);
		}

		[JniSignatureAttribute("(I)[Ljava/beans/VetoableChangeListener;", "protected")]
		public JavaArray<Dova.JDK.java.beans.VetoableChangeListener> newArray_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.beans.VetoableChangeListener>>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/EventListener;)Ljava/util/EventListener;", "public volatile")]
		public Dova.JDK.java.util.EventListener extract(Dova.JDK.java.util.EventListener arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
		}

		[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)Ljava/beans/VetoableChangeListener;", "public")]
		public Dova.JDK.java.beans.VetoableChangeListener extract(Dova.JDK.java.beans.VetoableChangeListener arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.VetoableChangeListener>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/beans/VetoableChangeListener;)Ljava/beans/VetoableChangeListener;", "protected")]
		public Dova.JDK.java.beans.VetoableChangeListener newProxy(Dova.JDK.java.lang.String arg0, Dova.JDK.java.beans.VetoableChangeListener arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.VetoableChangeListener>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected volatile")]
		public Dova.JDK.java.util.EventListener newProxy(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.EventListener arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
		}
	}
}
