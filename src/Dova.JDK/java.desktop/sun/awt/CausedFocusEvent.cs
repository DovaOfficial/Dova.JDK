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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/CausedFocusEvent;", "")]
public partial class CausedFocusEvent
	: Dova.JDK.java.awt.@event.FocusEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CausedFocusEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/CausedFocusEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dummy", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cause", "Lsun/awt/CausedFocusEvent$Cause;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;IZLjava/awt/Component;Lsun/awt/CausedFocusEvent$Cause;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lsun/awt/CausedFocusEvent;)Z"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "private static final")]
	public static Dova.JDK.java.awt.Component dummy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "private final")]
	public Dova.JDK.sun.awt.CausedFocusEvent.Cause cause_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CausedFocusEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IZLjava/awt/Component;Lsun/awt/CausedFocusEvent$Cause;)V", "private")]
	public CausedFocusEvent(Dova.JDK.java.awt.Component arg0, int arg1, bool arg2, Dova.JDK.java.awt.Component arg3, Dova.JDK.sun.awt.CausedFocusEvent.Cause arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/CausedFocusEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object readResolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/CausedFocusEvent;)Z", "static")]
	public static bool access_000(Dova.JDK.sun.awt.CausedFocusEvent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "private static final")]
	public partial class Cause
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Cause()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/CausedFocusEvent$Cause;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOUSE_EVENT", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL_UP", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL_DOWN", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL_FORWARD", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAVERSAL_BACKWARD", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANUAL_REQUEST", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTOMATIC_TRAVERSE", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROLLBACK", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE_SYSTEM", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACTIVATION", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLEAR_GLOBAL_FOCUS_OWNER", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETARGETED", "Lsun/awt/CausedFocusEvent$Cause;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/awt/CausedFocusEvent$Cause;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/awt/CausedFocusEvent$Cause;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/awt/CausedFocusEvent$Cause;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/awt/CausedFocusEvent$Cause;"));
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause UNKNOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause MOUSE_EVENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause TRAVERSAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause TRAVERSAL_UP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause TRAVERSAL_DOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause TRAVERSAL_FORWARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause TRAVERSAL_BACKWARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause MANUAL_REQUEST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause AUTOMATIC_TRAVERSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause ROLLBACK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause NATIVE_SYSTEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause ACTIVATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause CLEAR_GLOBAL_FOCUS_OWNER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/CausedFocusEvent$Cause;", "public static final")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause RETARGETED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/awt/CausedFocusEvent$Cause;", "private static final")]
		public static JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Cause(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Cause(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/CausedFocusEvent$Cause;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/awt/CausedFocusEvent$Cause;", "public static")]
		public static JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/awt/CausedFocusEvent$Cause;", "public static")]
		public static Dova.JDK.sun.awt.CausedFocusEvent.Cause valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.CausedFocusEvent.Cause>(ret);
		}

		[JniSignatureAttribute("()[Lsun/awt/CausedFocusEvent$Cause;", "private static")]
		public static JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.CausedFocusEvent.Cause>>(ret);
		}
	}
}
