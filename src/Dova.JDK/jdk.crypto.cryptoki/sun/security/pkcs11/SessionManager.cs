/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.pkcs11;

[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager;", "final")]
public partial class SessionManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SessionManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/SessionManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_MAX_SESSIONS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Lsun/security/util/Debug;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lsun/security/pkcs11/Token;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxSessions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeSessions", "Ljava/util/concurrent/atomic/AtomicInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objSessions", "Lsun/security/pkcs11/SessionManager$Pool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opSessions", "Lsun/security/pkcs11/SessionManager$Pool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxActiveSessions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxActiveSessionsLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "openSessionFlags", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/Token;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureValid", "(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjSession", "()Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseSession", "(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpSession", "()Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "demoteObjSession", "(Lsun/security/pkcs11/Session;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearPools", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "killSession", "(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openSession", "()Lsun/security/pkcs11/Session;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lowMaxSessions", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeSession", "(Lsun/security/pkcs11/Session;)V"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_MAX_SESSIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/Debug;", "private static final")]
	public static Dova.JDK.sun.security.util.Debug debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.Debug>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/Token;", "private final")]
	public Dova.JDK.sun.security.pkcs11.Token token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int maxSessions_Property
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

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicInteger;", "private")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicInteger activeSessions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager$Pool;", "private final")]
	public Dova.JDK.sun.security.pkcs11.SessionManager.Pool objSessions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.SessionManager.Pool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager$Pool;", "private final")]
	public Dova.JDK.sun.security.pkcs11.SessionManager.Pool opSessions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.SessionManager.Pool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxActiveSessions_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object maxActiveSessionsLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long openSessionFlags_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SessionManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Token;)V", "")]
	public SessionManager(Dova.JDK.sun.security.pkcs11.Token arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/pkcs11/SessionManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;", "private")]
	public Dova.JDK.sun.security.pkcs11.Session ensureValid(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session getObjSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session releaseSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session getOpSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)V", "")]
	public void demoteObjSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void clearPools()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Lsun/security/pkcs11/Session;", "")]
	public Dova.JDK.sun.security.pkcs11.Session killSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "private")]
	public Dova.JDK.sun.security.pkcs11.Session openSession()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool lowMaxSessions()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)V", "private")]
	public void closeSession(Dova.JDK.sun.security.pkcs11.Session arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager$Pool;", "public static final")]
	public partial class Pool
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pool()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/pkcs11/SessionManager$Pool;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mgr", "Lsun/security/pkcs11/SessionManager;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pool", "Ljava/util/AbstractQueue;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "SESSION_MAX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/pkcs11/SessionManager;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Lsun/security/pkcs11/Session;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poll", "()Lsun/security/pkcs11/Session;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "(Lsun/security/pkcs11/Session;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closeAll", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "free", "()V"));
		}

		[JniSignatureAttribute("Lsun/security/pkcs11/SessionManager;", "private final")]
		public Dova.JDK.sun.security.pkcs11.SessionManager mgr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.SessionManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/AbstractQueue;", "private final")]
		public Dova.JDK.java.util.AbstractQueue pool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.AbstractQueue>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int SESSION_MAX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool closed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pool(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/pkcs11/SessionManager;Z)V", "")]
		public Pool(Dova.JDK.sun.security.pkcs11.SessionManager arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/pkcs11/SessionManager$Pool;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)Z", "")]
		public bool remove(Dova.JDK.sun.security.pkcs11.Session arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/pkcs11/Session;", "")]
		public Dova.JDK.sun.security.pkcs11.Session poll()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.pkcs11.Session>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/pkcs11/Session;)V", "")]
		public void release(Dova.JDK.sun.security.pkcs11.Session arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void closeAll()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()V", "")]
		public void free()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}
}
