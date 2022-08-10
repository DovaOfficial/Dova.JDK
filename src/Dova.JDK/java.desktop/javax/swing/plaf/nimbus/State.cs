/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "public abstract")]
public partial class State
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static State()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/State;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "standardStates", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Enabled", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MouseOver", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Pressed", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Disabled", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Focused", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Selected", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "Default", "Ljavax/swing/plaf/nimbus/State;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "State", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInState", "(Ljavax/swing/JComponent;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInState", "(Ljavax/swing/JComponent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isStandardStateName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getStandardState", "(Ljava/lang/String;)Ljavax/swing/plaf/nimbus/State$StandardState;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map standardStates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Enabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State MouseOver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Pressed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Disabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Focused_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Selected_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State;", "static final")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State Default_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public State(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public State(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/State;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Z", "")]
	public bool isInState(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Z", "protected abstract")]
	public bool isInState(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool isStandardStateName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/plaf/nimbus/State$StandardState;", "static")]
	public static Dova.JDK.javax.swing.plaf.nimbus.State.StandardState getStandardState(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.State.StandardState>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/State$StandardState;", "static final")]
	public partial class StandardState
		: Dova.JDK.javax.swing.plaf.nimbus.State
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StandardState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/State$StandardState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "state", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StandardState", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getState", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInState", "(Ljavax/swing/JComponent;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInState", "(Ljavax/swing/JComponent;I)Z"));
		}

		[JniSignatureAttribute("I", "private")]
		public int state_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StandardState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public StandardState(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/State$StandardState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String toString(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getState()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;)Z", "protected")]
		public bool isInState(Dova.JDK.javax.swing.JComponent arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Z", "")]
		public bool isInState(Dova.JDK.javax.swing.JComponent arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}
	}
}
