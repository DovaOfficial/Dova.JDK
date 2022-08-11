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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XDropTargetProtocol;", "abstract")]
public partial class XDropTargetProtocol
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XDropTargetProtocol()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XDropTargetProtocol;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "logger", "Lsun/util/logging/PlatformLogger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Lsun/awt/X11/XDropTargetProtocolListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMBEDDER_ALREADY_REGISTERED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN_MESSAGE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTER_MESSAGE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOTION_MESSAGE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEAVE_MESSAGE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROP_MESSAGE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "motionPassedAlong", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "embedderRegistry", "Ljava/util/HashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11/XDropTargetProtocolListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceWindow", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMessageType", "(Lsun/awt/X11/XClientMessageEvent;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClientMessage", "(Lsun/awt/X11/XClientMessageEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeEmbedderRegistryEntry", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processClientMessageImpl", "(Lsun/awt/X11/XClientMessageEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postProcessClientMessage", "(Lsun/awt/X11/XClientMessageEvent;ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEmbedderRegistryEntry", "(J)Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustEventForForwarding", "(Lsun/awt/X11/XClientMessageEvent;Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardClientMessageToToplevel", "(JLsun/awt/X11/XClientMessageEvent;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDragOverComponent", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendEnterMessageToToplevel", "(JLsun/awt/X11/XClientMessageEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendLeaveMessageToToplevel", "(JLsun/awt/X11/XClientMessageEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocolListener", "()Lsun/awt/X11/XDropTargetProtocolListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProtocolName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerDropTarget", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterDropTarget", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerEmbedderDropSite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterEmbedderDropSite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerEmbeddedDropSite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterEmbeddedDropSite", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtocolSupported", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendResponse", "(JII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getData", "(JJ)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendDropDone", "(JZI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardEventToEmbedded", "(JJI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isXEmbedSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putEmbedderRegistryEntry", "(JZIJ)V"));
	}

	[JniSignatureAttribute("Lsun/util/logging/PlatformLogger;", "private static final")]
	public static Dova.JDK.sun.util.logging.PlatformLogger logger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.logging.PlatformLogger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XDropTargetProtocolListener;", "private final")]
	public Dova.JDK.sun.awt.X11.XDropTargetProtocolListener listener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDropTargetProtocolListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int EMBEDDER_ALREADY_REGISTERED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UNKNOWN_MESSAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ENTER_MESSAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MOTION_MESSAGE_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int LEAVE_MESSAGE_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int DROP_MESSAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool motionPassedAlong_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private final")]
	public Dova.JDK.java.util.HashMap embedderRegistry_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XDropTargetProtocol(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XDropTargetProtocolListener;)V", "protected")]
	public XDropTargetProtocol(Dova.JDK.sun.awt.X11.XDropTargetProtocolListener arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XDropTargetProtocol;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void cleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	public long getSourceWindow()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;)I", "public abstract")]
	public int getMessageType(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;)Z", "public final")]
	public bool processClientMessage(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "protected final")]
	public void removeEmbedderRegistryEntry(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;)Z", "protected abstract")]
	public bool processClientMessageImpl(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;ZI)V", "private")]
	public void postProcessClientMessage(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0, bool arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;", "protected final")]
	public Dova.JDK.sun.awt.X11.XDropTargetProtocol.EmbedderRegistryEntry getEmbedderRegistryEntry(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDropTargetProtocol.EmbedderRegistryEntry>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XClientMessageEvent;Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;)V", "public")]
	public void adjustEventForForwarding(Dova.JDK.sun.awt.X11.XClientMessageEvent arg0, Dova.JDK.sun.awt.X11.XDropTargetProtocol.EmbedderRegistryEntry arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(JLsun/awt/X11/XClientMessageEvent;)Z", "protected final")]
	public bool forwardClientMessageToToplevel(long arg0, Dova.JDK.sun.awt.X11.XClientMessageEvent arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isDragOverComponent()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/awt/X11/XClientMessageEvent;)V", "protected abstract")]
	public void sendEnterMessageToToplevel(long arg0, Dova.JDK.sun.awt.X11.XClientMessageEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(JLsun/awt/X11/XClientMessageEvent;)V", "protected abstract")]
	public void sendLeaveMessageToToplevel(long arg0, Dova.JDK.sun.awt.X11.XClientMessageEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("()Lsun/awt/X11/XDropTargetProtocolListener;", "protected final")]
	public Dova.JDK.sun.awt.X11.XDropTargetProtocolListener getProtocolListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XDropTargetProtocolListener>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getProtocolName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	public void registerDropTarget(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	public void unregisterDropTarget(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	public void registerEmbedderDropSite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	public void unregisterEmbedderDropSite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(J)V", "public abstract")]
	public void registerEmbeddedDropSite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(J)V", "public final")]
	public void unregisterEmbeddedDropSite(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(J)Z", "public abstract")]
	public bool isProtocolSupported(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JII)Z", "public abstract")]
	public bool sendResponse(long arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getData(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(JZI)Z", "public abstract")]
	public bool sendDropDone(long arg0, bool arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(JJI)Z", "public abstract")]
	public bool forwardEventToEmbedded(long arg0, long arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isXEmbedSupported()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(JZIJ)V", "protected final")]
	public void putEmbedderRegistryEntry(long arg0, bool arg1, int arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;", "protected static final")]
	public partial class EmbedderRegistryEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EmbedderRegistryEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overriden", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZIJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVersion", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOverriden", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxy", "()J"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool overriden_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int version_Property
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

		[JniSignatureAttribute("J", "private final")]
		public long proxy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EmbedderRegistryEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZIJ)V", "")]
		public EmbedderRegistryEntry(bool arg0, int arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XDropTargetProtocol$EmbedderRegistryEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getVersion()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isOverriden()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long getProxy()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
