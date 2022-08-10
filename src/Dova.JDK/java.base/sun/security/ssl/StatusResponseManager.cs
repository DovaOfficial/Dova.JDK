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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager;", "final")]
public partial class StatusResponseManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StatusResponseManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/StatusResponseManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_CORE_THREADS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_CACHE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_CACHE_LIFETIME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "threadMgr", "Ljava/util/concurrent/ScheduledThreadPoolExecutor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responseCache", "Lsun/security/util/Cache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultResponder", "Ljava/net/URI;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "respOverride", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cacheCapacity", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cacheLifetime", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ignoreExtensions", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StatusResponseManager", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shutdown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "get", "(Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;Lsun/security/ssl/CertStatusExtension$CertStatusRequest;[Ljava/security/cert/X509Certificate;JLjava/util/concurrent/TimeUnit;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCacheLifetime", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCacheCapacity", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultResponder", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getURIOverride", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIgnoreExtensions", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "processStapling", "(Lsun/security/ssl/ServerHandshakeContext;)Lsun/security/ssl/StatusResponseManager$StaplingParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getURI", "(Ljava/security/cert/X509Certificate;)Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFromCache", "(Lsun/security/provider/certpath/CertId;Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;)Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_CORE_THREADS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_CACHE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_CACHE_LIFETIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ScheduledThreadPoolExecutor;", "private final")]
	public Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor threadMgr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ScheduledThreadPoolExecutor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/Cache;", "private final")]
	public Dova.JDK.sun.security.util.Cache responseCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Cache>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/net/URI;", "private final")]
	public Dova.JDK.java.net.URI defaultResponder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool respOverride_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "private final")]
	public int cacheCapacity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "private final")]
	public int cacheLifetime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool ignoreExtensions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StatusResponseManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public StatusResponseManager() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/StatusResponseManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "")]
	public void shutdown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;Lsun/security/ssl/CertStatusExtension$CertStatusRequest;[Ljava/security/cert/X509Certificate;JLjava/util/concurrent/TimeUnit;)Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map get(Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequestType arg0, Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequest arg1, JavaArray<Dova.JDK.java.security.cert.X509Certificate> arg2, long arg3, Dova.JDK.java.util.concurrent.TimeUnit arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()I", "")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int getCacheLifetime()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int getCacheCapacity()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "")]
	public Dova.JDK.java.net.URI getDefaultResponder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool getURIOverride()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool getIgnoreExtensions()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ServerHandshakeContext;)Lsun/security/ssl/StatusResponseManager$StaplingParameters;", "static final")]
	public static Dova.JDK.sun.security.ssl.StatusResponseManager.StaplingParameters processStapling(Dova.JDK.sun.security.ssl.ServerHandshakeContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.StaplingParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;)Ljava/net/URI;", "")]
	public Dova.JDK.java.net.URI getURI(Dova.JDK.java.security.cert.X509Certificate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/provider/certpath/CertId;Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;)Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;", "private")]
	public Dova.JDK.sun.security.ssl.StatusResponseManager.ResponseCacheEntry getFromCache(Dova.JDK.sun.security.provider.certpath.CertId arg0, Dova.JDK.sun.security.ssl.CertStatusExtension.OCSPStatusRequest arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.ResponseCacheEntry>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;", "static")]
	public partial class ResponseCacheEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ResponseCacheEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "status", "Lsun/security/provider/certpath/OCSPResponse$ResponseStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ocspBytes", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextUpdate", "Ljava/util/Date;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "singleResp", "Lsun/security/provider/certpath/OCSPResponse$SingleResponse;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "respId", "Lsun/security/provider/certpath/ResponderId;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ResponseCacheEntry", "([BLsun/security/provider/certpath/CertId;)V"));
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/OCSPResponse$ResponseStatus;", "final")]
		public Dova.JDK.sun.security.provider.certpath.OCSPResponse.ResponseStatus status_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.OCSPResponse.ResponseStatus>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[B", "final")]
		public JavaArray<byte> ocspBytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Date;", "final")]
		public Dova.JDK.java.util.Date nextUpdate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/OCSPResponse$SingleResponse;", "final")]
		public Dova.JDK.sun.security.provider.certpath.OCSPResponse.SingleResponse singleResp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.OCSPResponse.SingleResponse>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/ResponderId;", "final")]
		public Dova.JDK.sun.security.provider.certpath.ResponderId respId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.ResponderId>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ResponseCacheEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([BLsun/security/provider/certpath/CertId;)V", "")]
		public ResponseCacheEntry(JavaArray<byte> arg0, Dova.JDK.sun.security.provider.certpath.CertId arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$StatusInfo;", "")]
	public partial class StatusInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StatusInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/StatusResponseManager$StatusInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cert", "Ljava/security/cert/X509Certificate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cid", "Lsun/security/provider/certpath/CertId;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responder", "Ljava/net/URI;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responseData", "Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StatusInfo", "(Lsun/security/ssl/StatusResponseManager;Lsun/security/ssl/StatusResponseManager$StatusInfo;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StatusInfo", "(Lsun/security/ssl/StatusResponseManager;Ljava/security/cert/X509Certificate;Lsun/security/provider/certpath/CertId;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StatusInfo", "(Lsun/security/ssl/StatusResponseManager;Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/security/cert/X509Certificate;", "final")]
		public Dova.JDK.java.security.cert.X509Certificate cert_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.cert.X509Certificate>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/provider/certpath/CertId;", "final")]
		public Dova.JDK.sun.security.provider.certpath.CertId cid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.provider.certpath.CertId>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/net/URI;", "final")]
		public Dova.JDK.java.net.URI responder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;", "")]
		public Dova.JDK.sun.security.ssl.StatusResponseManager.ResponseCacheEntry responseData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.ResponseCacheEntry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StatusInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/StatusResponseManager;Lsun/security/ssl/StatusResponseManager$StatusInfo;)V", "")]
		public StatusInfo(Dova.JDK.sun.security.ssl.StatusResponseManager arg0, Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/StatusResponseManager;Ljava/security/cert/X509Certificate;Lsun/security/provider/certpath/CertId;)V", "")]
		public StatusInfo(Dova.JDK.sun.security.ssl.StatusResponseManager arg0, Dova.JDK.java.security.cert.X509Certificate arg1, Dova.JDK.sun.security.provider.certpath.CertId arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/StatusResponseManager;Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V", "")]
		public StatusInfo(Dova.JDK.sun.security.ssl.StatusResponseManager arg0, Dova.JDK.java.security.cert.X509Certificate arg1, Dova.JDK.java.security.cert.X509Certificate arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/StatusResponseManager$StatusInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$OCSPFetchCall;", "")]
	public partial class OCSPFetchCall
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.concurrent.Callable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OCSPFetchCall()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/StatusResponseManager$OCSPFetchCall;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "statInfo", "Lsun/security/ssl/StatusResponseManager$StatusInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ocspRequest", "Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "extensions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responderIds", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lsun/security/ssl/StatusResponseManager;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OCSPFetchCall", "(Lsun/security/ssl/StatusResponseManager;Lsun/security/ssl/StatusResponseManager$StatusInfo;Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "call_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "call_1", "()Lsun/security/ssl/StatusResponseManager$StatusInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addToCache", "(Lsun/security/provider/certpath/CertId;Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNextTaskDelay", "(Ljava/util/Date;)J"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$StatusInfo;", "")]
		public Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo statInfo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;", "")]
		public Dova.JDK.sun.security.ssl.CertStatusExtension.OCSPStatusRequest ocspRequest_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CertStatusExtension.OCSPStatusRequest>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "")]
		public Dova.JDK.java.util.List extensions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "")]
		public Dova.JDK.java.util.List responderIds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager;", "final")]
		public Dova.JDK.sun.security.ssl.StatusResponseManager this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OCSPFetchCall(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/StatusResponseManager;Lsun/security/ssl/StatusResponseManager$StatusInfo;Lsun/security/ssl/CertStatusExtension$OCSPStatusRequest;)V", "public")]
		public OCSPFetchCall(Dova.JDK.sun.security.ssl.StatusResponseManager arg0, Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo arg1, Dova.JDK.sun.security.ssl.CertStatusExtension.OCSPStatusRequest arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/StatusResponseManager$OCSPFetchCall;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object call_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lsun/security/ssl/StatusResponseManager$StatusInfo;", "public")]
		public Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo call_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.StatusResponseManager.StatusInfo>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/provider/certpath/CertId;Lsun/security/ssl/StatusResponseManager$ResponseCacheEntry;)V", "private")]
		public void addToCache(Dova.JDK.sun.security.provider.certpath.CertId arg0, Dova.JDK.sun.security.ssl.StatusResponseManager.ResponseCacheEntry arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Date;)J", "private")]
		public long getNextTaskDelay(Dova.JDK.java.util.Date arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/StatusResponseManager$StaplingParameters;", "static final")]
	public partial class StaplingParameters
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StaplingParameters()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/StatusResponseManager$StaplingParameters;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "statusRespExt", "Lsun/security/ssl/SSLExtension;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "statReqType", "Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "statReqData", "Lsun/security/ssl/CertStatusExtension$CertStatusRequest;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "responseMap", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StaplingParameters", "(Lsun/security/ssl/SSLExtension;Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;Lsun/security/ssl/CertStatusExtension$CertStatusRequest;Ljava/util/Map;)V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/SSLExtension;", "final")]
		public Dova.JDK.sun.security.ssl.SSLExtension statusRespExt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtension>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;", "final")]
		public Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequestType statReqType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequestType>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/security/ssl/CertStatusExtension$CertStatusRequest;", "final")]
		public Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequest statReqData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequest>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "final")]
		public Dova.JDK.java.util.Map responseMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StaplingParameters(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/SSLExtension;Lsun/security/ssl/CertStatusExtension$CertStatusRequestType;Lsun/security/ssl/CertStatusExtension$CertStatusRequest;Ljava/util/Map;)V", "")]
		public StaplingParameters(Dova.JDK.sun.security.ssl.SSLExtension arg0, Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequestType arg1, Dova.JDK.sun.security.ssl.CertStatusExtension.CertStatusRequest arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/StatusResponseManager$StaplingParameters;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
