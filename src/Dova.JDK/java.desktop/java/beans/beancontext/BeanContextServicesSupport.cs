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

namespace Dova.JDK.java.beans.beancontext;

[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport;", "public")]
public partial class BeanContextServicesSupport
	: Dova.JDK.java.beans.beancontext.BeanContextSupport
	, Dova.JDK.java.beans.beancontext.BeanContextServices
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BeanContextServicesSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "services", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serializable", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSProxyServiceProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bcsListeners", "Ljava/util/ArrayList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServices;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getService", "(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBCSChild", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/beans/beancontext/BeanContextSupport$BCSChild;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "childJustRemovedHook", "(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextSupport$BCSChild;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bcsPreSerializationHook", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bcsPreDeserializationHook", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createBCSSServiceProvider", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Ljava/beans/beancontext/BeanContextServicesSupport$BCSSServiceProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBeanContextServicesPeer", "()Ljava/beans/beancontext/BeanContextServices;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireServiceAdded", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireServiceAdded", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireServiceRevoked", "(Ljava/lang/Class;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireServiceRevoked", "(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getChildBeanContextServicesListener", "(Ljava/lang/Object;)Ljava/beans/beancontext/BeanContextServicesListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseBeanContextResources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeBeanContextResources", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceRevoked", "(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceAvailable", "(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentServiceSelectors", "(Ljava/lang/Class;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addService", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addService", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revokeService", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasService", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseService", "(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentServiceClasses", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeBeanContextServicesListener", "(Ljava/beans/beancontext/BeanContextServicesListener;)V"));
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

	[JniSignatureAttribute("Ljava/util/HashMap;", "protected transient")]
	public Dova.JDK.java.util.HashMap services_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected transient")]
	public int serializable_Property
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

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSProxyServiceProvider;", "protected transient")]
	public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSProxyServiceProvider proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSProxyServiceProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "protected transient")]
	public Dova.JDK.java.util.ArrayList bcsListeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BeanContextServicesSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BeanContextServicesSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;)V", "public")]
	public BeanContextServicesSupport(Dova.JDK.java.beans.beancontext.BeanContextServices arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;)V", "public")]
	public BeanContextServicesSupport(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.util.Locale arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;Z)V", "public")]
	public BeanContextServicesSupport(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.util.Locale arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/util/Locale;ZZ)V", "public")]
	public BeanContextServicesSupport(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.util.Locale arg1, bool arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void initialize()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private synchronized")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private synchronized")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getService(Dova.JDK.java.beans.beancontext.BeanContextChild arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/beans/beancontext/BeanContextSupport$BCSChild;", "protected")]
	public Dova.JDK.java.beans.beancontext.BeanContextSupport.BCSChild createBCSChild(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextSupport.BCSChild>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextSupport$BCSChild;)V", "protected")]
	public void childJustRemovedHook(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.beancontext.BeanContextSupport.BCSChild arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "protected synchronized")]
	public void bcsPreSerializationHook(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "protected synchronized")]
	public void bcsPreDeserializationHook(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Ljava/beans/beancontext/BeanContextServicesSupport$BCSSServiceProvider;", "protected")]
	public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSServiceProvider createBCSSServiceProvider(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSServiceProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextServices;", "public")]
	public Dova.JDK.java.beans.beancontext.BeanContextServices getBeanContextServicesPeer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServices>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected final")]
	public void fireServiceAdded(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", "protected final")]
	public void fireServiceAdded(Dova.JDK.java.beans.beancontext.BeanContextServiceAvailableEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Z)V", "protected final")]
	public void fireServiceRevoked(Dova.JDK.java.lang.Class arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V", "protected final")]
	public void fireServiceRevoked(Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/beans/beancontext/BeanContextServicesListener;", "protected static final")]
	public static Dova.JDK.java.beans.beancontext.BeanContextServicesListener getChildBeanContextServicesListener(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesListener>(ret);
	}

	[JniSignatureAttribute("()V", "protected synchronized")]
	public void releaseBeanContextResources()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "protected synchronized")]
	public void initializeBeanContextResources()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V", "public")]
	public void serviceRevoked(Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceAvailableEvent;)V", "public")]
	public void serviceAvailable(Dova.JDK.java.beans.beancontext.BeanContextServiceAvailableEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator getCurrentServiceSelectors(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)Z", "protected")]
	public bool addService(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)Z", "public")]
	public bool addService(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V", "public")]
	public void revokeService(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public synchronized")]
	public bool hasService(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextChild;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
	public void releaseService(Dova.JDK.java.beans.beancontext.BeanContextChild arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator getCurrentServiceClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesListener;)V", "public")]
	public void addBeanContextServicesListener(Dova.JDK.java.beans.beancontext.BeanContextServicesListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesListener;)V", "public")]
	public void removeBeanContextServicesListener(Dova.JDK.java.beans.beancontext.BeanContextServicesListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;", "protected")]
	public partial class BCSSChild
		: Dova.JDK.java.beans.beancontext.BeanContextSupport.BCSChild
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BCSSChild()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceClasses", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceRequestors", "Ljava/util/HashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/beans/beancontext/BeanContextServicesSupport;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServicesSupport;Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "usingService", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;ZLjava/beans/beancontext/BeanContextServiceRevokedListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanupReferences", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revokeAllDelegatedServicesNow", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revokeService", "(Ljava/lang/Class;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseService", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
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

		[JniSignatureAttribute("Ljava/util/HashMap;", "private transient")]
		public Dova.JDK.java.util.HashMap serviceClasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/HashMap;", "private transient")]
		public Dova.JDK.java.util.HashMap serviceRequestors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport;", "final")]
		public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BCSSChild(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesSupport;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public BCSSChild(Dova.JDK.java.beans.beancontext.BeanContextServicesSupport arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;ZLjava/beans/beancontext/BeanContextServiceRevokedListener;)V", "synchronized")]
		public void usingService(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg3, bool arg4, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("()V", "")]
		public void cleanupReferences()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()V", "")]
		public void revokeAllDelegatedServicesNow()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;ZZ)V", "synchronized")]
		public void revokeService(Dova.JDK.java.lang.Class arg0, bool arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "synchronized")]
		public void releaseService(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;", "")]
		public partial class BCSSCServiceClassRef
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BCSSCServiceClassRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceClass", "Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceProvider", "Ljava/beans/beancontext/BeanContextServiceProvider;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceRefs", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegateProvider", "Ljava/beans/beancontext/BeanContextServiceProvider;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegateRefs", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "requestors", "Ljava/util/HashMap;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "entries", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceProvider", "()Ljava/beans/beancontext/BeanContextServiceProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyAndMaybeSetProvider", "(Ljava/beans/beancontext/BeanContextServiceProvider;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verifyRequestor", "(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRequestor", "(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRef", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegateProvider", "()Ljava/beans/beancontext/BeanContextServiceProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseRef", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeRequestor", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneOfEntries", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRefs", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDelegateRefs", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceRefs", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDelegated", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceClass", "()Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "")]
			public Dova.JDK.java.lang.Class serviceClass_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServiceProvider;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider serviceProvider_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "")]
			public int serviceRefs_Property
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

			[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServiceProvider;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider delegateProvider_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "")]
			public int delegateRefs_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("Ljava/util/HashMap;", "")]
			public Dova.JDK.java.util.HashMap requestors_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BCSSCServiceClassRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;Z)V", "")]
			public BCSSCServiceClassRef(Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "")]
			public bool isEmpty()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "")]
			public Dova.JDK.java.util.Iterator entries()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextServiceProvider;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider getServiceProvider()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
			}

			[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceProvider;Z)V", "")]
			public void verifyAndMaybeSetProvider(Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg0, bool arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)V", "")]
			public void verifyRequestor(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/beancontext/BeanContextServiceRevokedListener;)V", "")]
			public void addRequestor(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			}

			[JniSignatureAttribute("(Z)V", "")]
			public void addRef(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextServiceProvider;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider getDelegateProvider()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
			}

			[JniSignatureAttribute("(Z)V", "")]
			public void releaseRef(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
			public void removeRequestor(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "")]
			public Dova.JDK.java.util.Iterator cloneOfEntries()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()I", "")]
			public int getRefs()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getDelegateRefs()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
				return ret;
			}

			[JniSignatureAttribute("()I", "")]
			public int getServiceRefs()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isDelegated()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Class;", "")]
			public Dova.JDK.java.lang.Class getServiceClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceRef;", "")]
		public partial class BCSSCServiceRef
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BCSSCServiceRef()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceRef;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceClassRef", "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refCnt", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegated", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRef", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceClassRef", "()Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDelegated", "()Z"));
			}

			[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild.BCSSCServiceClassRef serviceClassRef_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild.BCSSCServiceClassRef>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "")]
			public int refCnt_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "")]
			public bool delegated_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BCSSCServiceRef(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild;Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;Z)V", "")]
			public BCSSCServiceRef(Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild arg0, Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild.BCSSCServiceClassRef arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceRef;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "")]
			public int release()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()V", "")]
			public void addRef()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextServicesSupport$BCSSChild$BCSSCServiceClassRef;", "")]
			public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild.BCSSCServiceClassRef getServiceClassRef()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport.BCSSChild.BCSSCServiceClassRef>(ret);
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isDelegated()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSServiceProvider;", "protected static")]
	public partial class BCSSServiceProvider
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BCSSServiceProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSServiceProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceProvider", "Ljava/beans/beancontext/BeanContextServiceProvider;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceProvider", "()Ljava/beans/beancontext/BeanContextServiceProvider;"));
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

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServiceProvider;", "protected")]
		public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider serviceProvider_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BCSSServiceProvider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/beans/beancontext/BeanContextServiceProvider;)V", "")]
		public BCSSServiceProvider(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSServiceProvider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/beans/beancontext/BeanContextServiceProvider;", "protected")]
		public Dova.JDK.java.beans.beancontext.BeanContextServiceProvider getServiceProvider()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServiceProvider>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSProxyServiceProvider;", "protected")]
	public partial class BCSSProxyServiceProvider
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.beancontext.BeanContextServiceProvider
		, Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BCSSProxyServiceProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/beancontext/BeanContextServicesSupport$BCSSProxyServiceProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestingCtxt", "Ljava/beans/beancontext/BeanContextServices;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljava/beans/beancontext/BeanContextServicesSupport;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/beans/beancontext/BeanContextServicesSupport;Ljava/beans/beancontext/BeanContextServices;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getService", "(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serviceRevoked", "(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentServiceSelectors", "(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Class;)Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseService", "(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Object;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServices;", "private")]
		public Dova.JDK.java.beans.beancontext.BeanContextServices nestingCtxt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServices>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/beans/beancontext/BeanContextServicesSupport;", "final")]
		public Dova.JDK.java.beans.beancontext.BeanContextServicesSupport this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.beancontext.BeanContextServicesSupport>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BCSSProxyServiceProvider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServicesSupport;Ljava/beans/beancontext/BeanContextServices;)V", "")]
		public BCSSProxyServiceProvider(Dova.JDK.java.beans.beancontext.BeanContextServicesSupport arg0, Dova.JDK.java.beans.beancontext.BeanContextServices arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/beancontext/BeanContextServicesSupport$BCSSProxyServiceProvider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getService(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Object arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServiceRevokedEvent;)V", "public")]
		public void serviceRevoked(Dova.JDK.java.beans.beancontext.BeanContextServiceRevokedEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Class;)Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator getCurrentServiceSelectors(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/beans/beancontext/BeanContextServices;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
		public void releaseService(Dova.JDK.java.beans.beancontext.BeanContextServices arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}
}
