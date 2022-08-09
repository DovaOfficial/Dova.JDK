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

namespace Dova.JDK.sun.rmi.transport;

[JniSignatureAttribute("Lsun/rmi/transport/DGCClient;", "final")]
public partial class DGCClient
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DGCClient()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "nextSequenceNum", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "vmid", "Ljava/rmi/dgc/VMID;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "leaseValue", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cleanInterval", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "gcInterval", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dirtyFailureRetries", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cleanFailureRetries", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "emptyObjIDArray", "[Ljava/rmi/server/ObjID;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dgcID", "Ljava/rmi/server/ObjID;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOCKET_ACC", "Ljava/security/AccessControlContext;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DGCClient", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createSocketAcc", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getNextSequenceNum", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "computeRenewTime", "(JJ)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "registerRefs", "(Lsun/rmi/transport/Endpoint;Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("J", "private static")]
	public static long nextSequenceNum_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/rmi/dgc/VMID;", "private static")]
	public static Dova.JDK.java.rmi.dgc.VMID vmid_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.dgc.VMID>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long leaseValue_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long cleanInterval_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long gcInterval_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int dirtyFailureRetries_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int cleanFailureRetries_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("[Ljava/rmi/server/ObjID;", "private static final")]
	public static JavaArray<Dova.JDK.java.rmi.server.ObjID> emptyObjIDArray_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/rmi/server/ObjID;", "private static final")]
	public static Dova.JDK.java.rmi.server.ObjID dgcID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.ObjID>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static final")]
	public static Dova.JDK.java.security.AccessControlContext SOCKET_ACC_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DGCClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DGCClient() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext createSocketAcc()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()J", "private static synchronized")]
	public static long getNextSequenceNum()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "private static")]
	public static long computeRenewTime(long arg0, long arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;Ljava/util/List;)V", "static")]
	public static void registerRefs(Dova.JDK.sun.rmi.transport.Endpoint arg0, Dova.JDK.java.util.List arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry;", "private static")]
	public partial class EndpointEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EndpointEntry()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "endpoint", "Lsun/rmi/transport/Endpoint;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dgc", "Ljava/rmi/dgc/DGC;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "refTable", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "invalidRefs", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "removed", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "renewTime", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expirationTime", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dirtyFailures", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dirtyFailureStartTime", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dirtyFailureDuration", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "renewCleanThread", "Ljava/lang/Thread;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "interruptible", "Z"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "refQueue", "Ljava/lang/ref/ReferenceQueue;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pendingCleans", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "endpointTable", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "gcLatencyRequest", "Lsun/rmi/transport/GC$LatencyRequest;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EndpointEntry", "(Lsun/rmi/transport/Endpoint;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lookup", "(Lsun/rmi/transport/Endpoint;)Lsun/rmi/transport/DGCClient$EndpointEntry;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "registerRefs", "(Ljava/util/List;)Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeDirtyCall", "(Ljava/util/Set;J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createObjIDArray", "(Ljava/util/Set;)[Ljava/rmi/server/ObjID;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setRenewTime", "(J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeRefEntry", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "processPhantomRefs", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "makeCleanCalls", "()V"));
		}

		[JniSignatureAttribute("Lsun/rmi/transport/Endpoint;", "private")]
		public Dova.JDK.sun.rmi.transport.Endpoint endpoint_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Endpoint>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/rmi/dgc/DGC;", "private")]
		public Dova.JDK.java.rmi.dgc.DGC dgc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.dgc.DGC>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map refTable_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set invalidRefs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool removed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long renewTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long expirationTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int dirtyFailures_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long dirtyFailureStartTime_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("J", "private")]
		public long dirtyFailureDuration_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
		public Dova.JDK.java.lang.Thread renewCleanThread_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool interruptible_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private")]
		public Dova.JDK.java.lang.@ref.ReferenceQueue refQueue_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set pendingCleans_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static")]
		public static Dova.JDK.java.util.Map endpointTable_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/rmi/transport/GC$LatencyRequest;", "private static")]
		public static Dova.JDK.sun.rmi.transport.GC.LatencyRequest gcLatencyRequest_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.GC.LatencyRequest>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EndpointEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;)V", "private")]
		public EndpointEntry(Dova.JDK.sun.rmi.transport.Endpoint arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;)Lsun/rmi/transport/DGCClient$EndpointEntry;", "public static")]
		public static Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry lookup(Dova.JDK.sun.rmi.transport.Endpoint arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Z", "public")]
		public bool registerRefs(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;J)V", "private")]
		public void makeDirtyCall(Dova.JDK.java.util.Set arg0, long arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)[Ljava/rmi/server/ObjID;", "private static")]
		public static JavaArray<Dova.JDK.java.rmi.server.ObjID> createObjIDArray(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
		}

		[JniSignatureAttribute("(J)V", "private")]
		public void setRenewTime(long arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;)V", "private")]
		public void removeRefEntry(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V", "private")]
		public void processPhantomRefs(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry.PhantomLiveRef arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void makeCleanCalls()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$RenewCleanThread;", "private")]
		public partial class RenewCleanThread
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.lang.Runnable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RenewCleanThread()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RenewCleanThread;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/rmi/transport/DGCClient$EndpointEntry;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RenewCleanThread", "(Lsun/rmi/transport/DGCClient$EndpointEntry;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			}

			[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry;", "final")]
			public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry this0_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RenewCleanThread(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry;)V", "private")]
			public RenewCleanThread(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RenewCleanThread;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void run()
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}

		[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;", "private")]
		public partial class RefEntry
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RefEntry()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ref", "Lsun/rmi/transport/LiveRef;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "refSet", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dirtyFailed", "Z"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/rmi/transport/DGCClient$EndpointEntry;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RefEntry", "(Lsun/rmi/transport/DGCClient$EndpointEntry;Lsun/rmi/transport/LiveRef;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRef", "()Lsun/rmi/transport/LiveRef;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addInstanceToRefSet", "(Lsun/rmi/transport/LiveRef;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "markDirtyFailed", "()V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeInstanceFromRefSet", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isRefSetEmpty", "()Z"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasDirtyFailed", "()Z"));
			}

			[JniSignatureAttribute("Lsun/rmi/transport/LiveRef;", "private")]
			public Dova.JDK.sun.rmi.transport.LiveRef @ref_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.LiveRef>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/util/Set;", "private")]
			public Dova.JDK.java.util.Set refSet_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "private")]
			public bool dirtyFailed_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("Z", "static final")]
			public static bool assertionsDisabled_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry;", "final")]
			public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry this0_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RefEntry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry;Lsun/rmi/transport/LiveRef;)V", "public")]
			public RefEntry(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry arg0, Dova.JDK.sun.rmi.transport.LiveRef arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lsun/rmi/transport/LiveRef;", "public")]
			public Dova.JDK.sun.rmi.transport.LiveRef getRef()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.LiveRef>(ret);
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/LiveRef;)V", "public")]
			public void addInstanceToRefSet(Dova.JDK.sun.rmi.transport.LiveRef arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("()V", "public")]
			public void markDirtyFailed()
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V", "public")]
			public void removeInstanceFromRefSet(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry.PhantomLiveRef arg0)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRefSetEmpty()
			{
				var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasDirtyFailed()
			{
				var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}

			[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;", "private")]
			public partial class PhantomLiveRef
				: Dova.JDK.java.lang.@ref.PhantomReference
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static PhantomLiveRef()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$1", "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PhantomLiveRef", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;Lsun/rmi/transport/LiveRef;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRefEntry", "()Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;"));
				}

				[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;", "final")]
				public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry this1_Property
				{
					get
					{
						var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry>(ret);
					}
					set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public PhantomLiveRef(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;Lsun/rmi/transport/LiveRef;)V", "public")]
				public PhantomLiveRef(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry arg0, Dova.JDK.sun.rmi.transport.LiveRef arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;", "public")]
				public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry getRefEntry()
				{
					var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$CleanRequest;", "private static")]
		public partial class CleanRequest
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CleanRequest()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$CleanRequest;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "objIDs", "[Ljava/rmi/server/ObjID;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "sequenceNum", "J"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "strong", "Z"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "failures", "I"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CleanRequest", "([Ljava/rmi/server/ObjID;JZ)V"));
			}

			[JniSignatureAttribute("[Ljava/rmi/server/ObjID;", "final")]
			public JavaArray<Dova.JDK.java.rmi.server.ObjID> objIDs_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("J", "final")]
			public long sequenceNum_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("Z", "final")]
			public bool strong_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("I", "")]
			public int failures_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CleanRequest(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Ljava/rmi/server/ObjID;JZ)V", "")]
			public CleanRequest(JavaArray<Dova.JDK.java.rmi.server.ObjID> arg0, long arg1, bool arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$CleanRequest;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}
}