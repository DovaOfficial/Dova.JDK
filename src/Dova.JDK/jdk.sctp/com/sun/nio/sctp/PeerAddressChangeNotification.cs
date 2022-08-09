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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification;", "public abstract")]
public partial class PeerAddressChangeNotification
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.nio.sctp.Notification
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PeerAddressChangeNotification()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/nio/sctp/PeerAddressChangeNotification;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PeerAddressChangeNotification", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "event", "()Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "address", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "association", "()Lcom/sun/nio/sctp/Association;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PeerAddressChangeNotification(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public PeerAddressChangeNotification() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/PeerAddressChangeNotification;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent @event()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress address()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/Association;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.Association association()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
	public partial class AddressChangeEvent
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AddressChangeEvent()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_AVAILABLE", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_UNREACHABLE", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_REMOVED", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_ADDED", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_MADE_PRIMARY", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ADDR_CONFIRMED", "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AddressChangeEvent", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;"));
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_AVAILABLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_UNREACHABLE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_REMOVED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_ADDED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_MADE_PRIMARY_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static final")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent ADDR_CONFIRMED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AddressChangeEvent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AddressChangeEvent(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "public static")]
		public static Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/nio/sctp/PeerAddressChangeNotification$AddressChangeEvent;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.nio.sctp.PeerAddressChangeNotification.AddressChangeEvent>>(ret);
		}
	}
}
