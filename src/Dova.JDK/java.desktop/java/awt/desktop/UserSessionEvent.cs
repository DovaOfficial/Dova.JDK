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

namespace Dova.JDK.java.awt.desktop;

[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent;", "public final")]
public partial class UserSessionEvent
	: Dova.JDK.java.awt.desktop.AppEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UserSessionEvent()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/desktop/UserSessionEvent;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reason", "Ljava/awt/desktop/UserSessionEvent$Reason;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UserSessionEvent", "(Ljava/awt/desktop/UserSessionEvent$Reason;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getReason", "()Ljava/awt/desktop/UserSessionEvent$Reason;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "private final")]
	public Dova.JDK.java.awt.desktop.UserSessionEvent.Reason reason_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UserSessionEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/UserSessionEvent$Reason;)V", "public")]
	public UserSessionEvent(Dova.JDK.java.awt.desktop.UserSessionEvent.Reason arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/desktop/UserSessionEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/desktop/UserSessionEvent$Reason;", "public")]
	public Dova.JDK.java.awt.desktop.UserSessionEvent.Reason getReason()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
	}

	[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "public static final")]
	public partial class Reason
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Reason()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/desktop/UserSessionEvent$Reason;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UNSPECIFIED", "Ljava/awt/desktop/UserSessionEvent$Reason;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSOLE", "Ljava/awt/desktop/UserSessionEvent$Reason;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REMOTE", "Ljava/awt/desktop/UserSessionEvent$Reason;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LOCK", "Ljava/awt/desktop/UserSessionEvent$Reason;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/awt/desktop/UserSessionEvent$Reason;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Reason", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/awt/desktop/UserSessionEvent$Reason;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/awt/desktop/UserSessionEvent$Reason;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/awt/desktop/UserSessionEvent$Reason;"));
		}

		[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "public static final")]
		public static Dova.JDK.java.awt.desktop.UserSessionEvent.Reason UNSPECIFIED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "public static final")]
		public static Dova.JDK.java.awt.desktop.UserSessionEvent.Reason CONSOLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "public static final")]
		public static Dova.JDK.java.awt.desktop.UserSessionEvent.Reason REMOTE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/desktop/UserSessionEvent$Reason;", "public static final")]
		public static Dova.JDK.java.awt.desktop.UserSessionEvent.Reason LOCK_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/awt/desktop/UserSessionEvent$Reason;", "private static final")]
		public static JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Reason(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Reason(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/desktop/UserSessionEvent$Reason;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/awt/desktop/UserSessionEvent$Reason;", "public static")]
		public static JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/awt/desktop/UserSessionEvent$Reason;", "public static")]
		public static Dova.JDK.java.awt.desktop.UserSessionEvent.Reason valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>(ret);
		}

		[JniSignatureAttribute("()[Ljava/awt/desktop/UserSessionEvent$Reason;", "private static")]
		public static JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.desktop.UserSessionEvent.Reason>>(ret);
		}
	}
}