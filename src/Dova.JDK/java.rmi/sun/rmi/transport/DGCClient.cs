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
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nextSequenceNum", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "vmid", "Ljava/rmi/dgc/VMID;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "leaseValue", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cleanInterval", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "gcInterval", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dirtyFailureRetries", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cleanFailureRetries", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "emptyObjIDArray", "[Ljava/rmi/server/ObjID;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "dgcID", "Ljava/rmi/server/ObjID;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOCKET_ACC", "Ljava/security/AccessControlContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSocketAcc", "()Ljava/security/AccessControlContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNextSequenceNum", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeRenewTime", "(JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerRefs", "(Lsun/rmi/transport/Endpoint;Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("J", "private static")]
	public static long nextSequenceNum_Property
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

	[JniSignatureAttribute("Ljava/rmi/dgc/VMID;", "private static")]
	public static Dova.JDK.java.rmi.dgc.VMID vmid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.dgc.VMID>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long leaseValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long cleanInterval_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long gcInterval_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int dirtyFailureRetries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int cleanFailureRetries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("[Ljava/rmi/server/ObjID;", "private static final")]
	public static JavaArray<Dova.JDK.java.rmi.server.ObjID> emptyObjIDArray_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/server/ObjID;", "private static final")]
	public static Dova.JDK.java.rmi.server.ObjID dgcID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.ObjID>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private static final")]
	public static Dova.JDK.java.security.AccessControlContext SOCKET_ACC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DGCClient(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public DGCClient() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/security/AccessControlContext;", "private static")]
	public static Dova.JDK.java.security.AccessControlContext createSocketAcc()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
	}

	[JniSignatureAttribute("()J", "private static synchronized")]
	public static long getNextSequenceNum()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)J", "private static")]
	public static long computeRenewTime(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;Ljava/util/List;)V", "static")]
	public static void registerRefs(Dova.JDK.sun.rmi.transport.Endpoint arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
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
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endpoint", "Lsun/rmi/transport/Endpoint;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dgc", "Ljava/rmi/dgc/DGC;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refTable", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invalidRefs", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "renewTime", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expirationTime", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirtyFailures", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirtyFailureStartTime", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirtyFailureDuration", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "renewCleanThread", "Ljava/lang/Thread;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interruptible", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refQueue", "Ljava/lang/ref/ReferenceQueue;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pendingCleans", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "endpointTable", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "gcLatencyRequest", "Lsun/rmi/transport/GC$LatencyRequest;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/Endpoint;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(Lsun/rmi/transport/Endpoint;)Lsun/rmi/transport/DGCClient$EndpointEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerRefs", "(Ljava/util/List;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeDirtyCall", "(Ljava/util/Set;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createObjIDArray", "(Ljava/util/Set;)[Ljava/rmi/server/ObjID;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenewTime", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeRefEntry", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processPhantomRefs", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeCleanCalls", "()V"));
		}

		[JniSignatureAttribute("Lsun/rmi/transport/Endpoint;", "private")]
		public Dova.JDK.sun.rmi.transport.Endpoint endpoint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Endpoint>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/rmi/dgc/DGC;", "private")]
		public Dova.JDK.java.rmi.dgc.DGC dgc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.dgc.DGC>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map refTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set invalidRefs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool removed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long renewTime_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long expirationTime_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int dirtyFailures_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long dirtyFailureStartTime_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("J", "private")]
		public long dirtyFailureDuration_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
		public Dova.JDK.java.lang.Thread renewCleanThread_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool interruptible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private")]
		public Dova.JDK.java.lang.@ref.ReferenceQueue refQueue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set pendingCleans_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static")]
		public static Dova.JDK.java.util.Map endpointTable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/rmi/transport/GC$LatencyRequest;", "private static")]
		public static Dova.JDK.sun.rmi.transport.GC.LatencyRequest gcLatencyRequest_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.GC.LatencyRequest>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[16], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EndpointEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;)V", "private")]
		public EndpointEntry(Dova.JDK.sun.rmi.transport.Endpoint arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/rmi/transport/Endpoint;)Lsun/rmi/transport/DGCClient$EndpointEntry;", "public static")]
		public static Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry lookup(Dova.JDK.sun.rmi.transport.Endpoint arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Z", "public")]
		public bool registerRefs(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;J)V", "private")]
		public void makeDirtyCall(Dova.JDK.java.util.Set arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)[Ljava/rmi/server/ObjID;", "private static")]
		public static JavaArray<Dova.JDK.java.rmi.server.ObjID> createObjIDArray(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
		}

		[JniSignatureAttribute("(J)V", "private")]
		public void setRenewTime(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;)V", "private")]
		public void removeRefEntry(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V", "private")]
		public void processPhantomRefs(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry.PhantomLiveRef arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void makeCleanCalls()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
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
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RenewCleanThread;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/rmi/transport/DGCClient$EndpointEntry;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/DGCClient$EndpointEntry;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
			}

			[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry;", "final")]
			public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RenewCleanThread(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry;)V", "private")]
			public RenewCleanThread(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RenewCleanThread;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void run()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
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
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ref", "Lsun/rmi/transport/LiveRef;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refSet", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dirtyFailed", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/rmi/transport/DGCClient$EndpointEntry;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/DGCClient$EndpointEntry;Lsun/rmi/transport/LiveRef;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRef", "()Lsun/rmi/transport/LiveRef;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInstanceToRefSet", "(Lsun/rmi/transport/LiveRef;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markDirtyFailed", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeInstanceFromRefSet", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRefSetEmpty", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDirtyFailed", "()Z"));
			}

			[JniSignatureAttribute("Lsun/rmi/transport/LiveRef;", "private")]
			public Dova.JDK.sun.rmi.transport.LiveRef @ref_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.LiveRef>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Set;", "private")]
			public Dova.JDK.java.util.Set refSet_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private")]
			public bool dirtyFailed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("Z", "static final")]
			public static bool assertionsDisabled_Property
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

			[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry;", "final")]
			public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RefEntry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry;Lsun/rmi/transport/LiveRef;)V", "public")]
			public RefEntry(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry arg0, Dova.JDK.sun.rmi.transport.LiveRef arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lsun/rmi/transport/LiveRef;", "public")]
			public Dova.JDK.sun.rmi.transport.LiveRef getRef()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.LiveRef>(ret);
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/LiveRef;)V", "public")]
			public void addInstanceToRefSet(Dova.JDK.sun.rmi.transport.LiveRef arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("()V", "public")]
			public void markDirtyFailed()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;)V", "public")]
			public void removeInstanceFromRefSet(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry.PhantomLiveRef arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRefSetEmpty()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasDirtyFailed()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
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
					ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;Lsun/rmi/transport/LiveRef;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRefEntry", "()Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;"));
				}

				[JniSignatureAttribute("Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;", "final")]
				public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry this1_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public PhantomLiveRef(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;Lsun/rmi/transport/LiveRef;)V", "public")]
				public PhantomLiveRef(Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry arg0, Dova.JDK.sun.rmi.transport.LiveRef arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry$PhantomLiveRef;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lsun/rmi/transport/DGCClient$EndpointEntry$RefEntry;", "public")]
				public Dova.JDK.sun.rmi.transport.DGCClient.EndpointEntry.RefEntry getRefEntry()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
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
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/DGCClient$EndpointEntry$CleanRequest;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objIDs", "[Ljava/rmi/server/ObjID;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sequenceNum", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strong", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failures", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/rmi/server/ObjID;JZ)V"));
			}

			[JniSignatureAttribute("[Ljava/rmi/server/ObjID;", "final")]
			public JavaArray<Dova.JDK.java.rmi.server.ObjID> objIDs_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.rmi.server.ObjID>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("J", "final")]
			public long sequenceNum_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool strong_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("I", "")]
			public int failures_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CleanRequest(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Ljava/rmi/server/ObjID;JZ)V", "")]
			public CleanRequest(JavaArray<Dova.JDK.java.rmi.server.ObjID> arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/rmi/transport/DGCClient$EndpointEntry$CleanRequest;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}
}
