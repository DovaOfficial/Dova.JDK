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

namespace Dova.JDK.jdk.jfr.@internal.handlers;

[JniSignatureAttribute("Ljdk/jfr/internal/handlers/EventHandler;", "public abstract")]
public partial class EventHandler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/handlers/EventHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "platformEventType", "Ljdk/jfr/internal/PlatformEventType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventType", "Ljdk/jfr/EventType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eventControl", "Ljdk/jfr/internal/EventControl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLjdk/jfr/EventType;Ljdk/jfr/internal/EventControl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;Ljava/lang/String;IJJZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;Ljava/lang/String;IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(JJLjava/lang/String;JZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "timestamp", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "duration", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventType", "()Ljdk/jfr/EventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPlatformEventType", "()Ljdk/jfr/internal/PlatformEventType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwError", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEventControl", "()Ljdk/jfr/internal/EventControl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRegistered", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldCommit", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStringFieldWriter", "()Ljdk/jfr/internal/StringPool;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/PlatformEventType;", "protected final")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType platformEventType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/EventType;", "private final")]
	public Dova.JDK.jdk.jfr.EventType eventType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/EventControl;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.EventControl eventControl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.EventControl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EventHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZLjdk/jfr/EventType;Ljdk/jfr/internal/EventControl;)V", "")]
	public EventHandler(bool arg0, Dova.JDK.jdk.jfr.EventType arg1, Dova.JDK.jdk.jfr.@internal.EventControl arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/handlers/EventHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public final")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRegistered()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(JJLjava/lang/String;Ljava/lang/String;IJJZ)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4, long arg5, long arg6, bool arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(JJLjava/lang/String;Ljava/lang/String;IJ)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4, long arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(JJLjava/lang/String;Ljava/lang/Class;)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Class arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJLjava/lang/String;J)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, long arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJLjava/lang/String;Z)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JJLjava/lang/String;JZ)V", "public")]
	public void write(long arg0, long arg1, Dova.JDK.java.lang.String arg2, long arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private final")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private final")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()J", "public static")]
	public static long timestamp()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static")]
	public static long duration(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/EventType;", "public final")]
	public Dova.JDK.jdk.jfr.EventType getEventType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.EventType>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/PlatformEventType;", "public final")]
	public Dova.JDK.jdk.jfr.@internal.PlatformEventType getPlatformEventType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.PlatformEventType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void throwError(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/EventControl;", "public final")]
	public Dova.JDK.jdk.jfr.@internal.EventControl getEventControl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.EventControl>(ret);
	}

	[JniSignatureAttribute("(Z)Z", "public")]
	public bool setRegistered(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Z", "public final")]
	public bool shouldCommit(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/StringPool;", "protected final")]
	public Dova.JDK.jdk.jfr.@internal.StringPool createStringFieldWriter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.StringPool>(ret);
	}
}
