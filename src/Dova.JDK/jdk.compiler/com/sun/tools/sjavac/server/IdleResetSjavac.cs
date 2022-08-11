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

namespace Dova.JDK.com.sun.tools.sjavac.server;

[JniSignatureAttribute("Lcom/sun/tools/sjavac/server/IdleResetSjavac;", "public")]
public partial class IdleResetSjavac
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.sjavac.server.Sjavac
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IdleResetSjavac()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/sjavac/server/IdleResetSjavac;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lcom/sun/tools/sjavac/server/Sjavac;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toShutdown", "Lcom/sun/tools/sjavac/server/Terminable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "idlenessTimer", "Ljava/util/Timer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "idleTimeout", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outstandingCalls", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "idlenessTimerTask", "Ljava/util/TimerTask;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/sjavac/server/Sjavac;Lcom/sun/tools/sjavac/server/Terminable;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shutdown", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "([Ljava/lang/String;)Lcom/sun/tools/javac/main/Main$Result;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endCall", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scheduleTimeout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startCall", "()V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/server/Sjavac;", "private final")]
	public Dova.JDK.com.sun.tools.sjavac.server.Sjavac @delegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.server.Sjavac>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/server/Terminable;", "private final")]
	public Dova.JDK.com.sun.tools.sjavac.server.Terminable toShutdown_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.server.Terminable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Timer;", "private final")]
	public Dova.JDK.java.util.Timer idlenessTimer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Timer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long idleTimeout_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int outstandingCalls_Property
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

	[JniSignatureAttribute("Ljava/util/TimerTask;", "private")]
	public Dova.JDK.java.util.TimerTask idlenessTimerTask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.TimerTask>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IdleResetSjavac(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/server/Sjavac;Lcom/sun/tools/sjavac/server/Terminable;J)V", "public")]
	public IdleResetSjavac(Dova.JDK.com.sun.tools.sjavac.server.Sjavac arg0, Dova.JDK.com.sun.tools.sjavac.server.Terminable arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/sjavac/server/IdleResetSjavac;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void shutdown()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Lcom/sun/tools/javac/main/Main$Result;", "public")]
	public Dova.JDK.com.sun.tools.javac.main.Main.Result compile(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Main.Result>(ret);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void endCall()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void scheduleTimeout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "private synchronized")]
	public void startCall()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}
}
