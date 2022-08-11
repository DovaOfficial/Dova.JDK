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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification;", "public abstract")]
public partial class AssociationChangeNotification
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.nio.sctp.Notification
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AssociationChangeNotification()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/AssociationChangeNotification;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "event", "()Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "association", "()Lcom/sun/nio/sctp/Association;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AssociationChangeNotification(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AssociationChangeNotification() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/AssociationChangeNotification;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent @event()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/Association;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.Association association()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
	public partial class AssocChangeEvent
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AssocChangeEvent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMM_UP", "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMM_LOST", "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESTART", "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHUTDOWN", "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANT_START", "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;"));
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent COMM_UP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent COMM_LOST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent RESTART_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent SHUTDOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent CANT_START_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AssocChangeEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AssocChangeEvent(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "public static")]
		public static Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/nio/sctp/AssociationChangeNotification$AssocChangeEvent;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.AssociationChangeNotification.AssocChangeEvent>>(ret);
		}
	}
}
