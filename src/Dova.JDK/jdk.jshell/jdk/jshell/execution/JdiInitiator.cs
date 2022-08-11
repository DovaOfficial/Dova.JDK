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

namespace Dova.JDK.jdk.jshell.execution;

[JniSignatureAttribute("Ljdk/jshell/execution/JdiInitiator;", "public")]
public partial class JdiInitiator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JdiInitiator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/execution/JdiInitiator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONNECT_TIMEOUT_FACTOR", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectTimeout", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vm", "Lcom/sun/jdi/VirtualMachine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "process", "Ljava/lang/Process;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connector", "Lcom/sun/jdi/connect/Connector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remoteAgent", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectorArgs", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/util/List;Ljava/lang/String;ZLjava/lang/String;ILjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/Throwable;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTempFile", "(Ljava/lang/String;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "()Ljava/lang/Process;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "vm", "()Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "launchArgs", "(ILjava/lang/String;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeConnectorArgs", "(Lcom/sun/jdi/connect/Connector;Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "launchTarget", "()Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listenTarget", "(ILjava/util/List;)Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timedVirtualMachineCreation", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/Callable;)Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportLaunchFail", "(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/lang/InternalError;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readFile", "(Ljava/io/File;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findConnector", "(Ljava/lang/String;)Lcom/sun/jdi/connect/Connector;"));
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double CONNECT_TIMEOUT_FACTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int connectTimeout_Property
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

	[JniSignatureAttribute("Lcom/sun/jdi/VirtualMachine;", "private")]
	public Dova.JDK.com.sun.jdi.VirtualMachine vm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Process;", "private")]
	public Dova.JDK.java.lang.Process process_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jdi/connect/Connector;", "private final")]
	public Dova.JDK.com.sun.jdi.connect.Connector connector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.Connector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String remoteAgent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map connectorArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JdiInitiator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/util/List;Ljava/lang/String;ZLjava/lang/String;ILjava/util/Map;)V", "public")]
	public JdiInitiator(int arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, bool arg3, Dova.JDK.java.lang.String arg4, int arg5, Dova.JDK.java.util.Map arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/execution/JdiInitiator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private transient")]
	public void debug(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/String;)V", "private")]
	public void debug(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/File;", "private")]
	public Dova.JDK.java.io.File createTempFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Process;", "public")]
	public Dova.JDK.java.lang.Process process()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/VirtualMachine;", "public")]
	public Dova.JDK.com.sun.jdi.VirtualMachine vm()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map launchArgs(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/Connector;Ljava/util/Map;)Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map mergeConnectorArgs(Dova.JDK.com.sun.jdi.connect.Connector arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/VirtualMachine;", "private")]
	public Dova.JDK.com.sun.jdi.VirtualMachine launchTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/List;)Lcom/sun/jdi/VirtualMachine;", "private")]
	public Dova.JDK.com.sun.jdi.VirtualMachine listenTarget(int arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Ljava/util/concurrent/Callable;)Lcom/sun/jdi/VirtualMachine;", "")]
	public Dova.JDK.com.sun.jdi.VirtualMachine timedVirtualMachineCreation(Dova.JDK.java.util.concurrent.Callable arg0, Dova.JDK.java.util.concurrent.Callable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/String;)Ljava/lang/InternalError;", "private")]
	public Dova.JDK.java.lang.InternalError reportLaunchFail(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.InternalError>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String readFile(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jdi/connect/Connector;", "private")]
	public Dova.JDK.com.sun.jdi.connect.Connector findConnector(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.Connector>(ret);
	}
}
