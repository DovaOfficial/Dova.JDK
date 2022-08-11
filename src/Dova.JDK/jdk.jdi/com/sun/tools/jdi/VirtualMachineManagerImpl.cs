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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/VirtualMachineManagerImpl;", "public")]
public partial class VirtualMachineManagerImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.tools.jdi.VirtualMachineManagerService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VirtualMachineManagerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/VirtualMachineManagerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectors", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultConnector", "Lcom/sun/jdi/connect/LaunchingConnector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targets", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainGroupForJDI", "Ljava/lang/ThreadGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vmSequenceNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "majorVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "minorVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "vmm", "Lcom/sun/tools/jdi/VirtualMachineManagerImpl;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disposeVirtualMachine", "(Lcom/sun/jdi/VirtualMachine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allConnectors", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "virtualMachineManager", "()Lcom/sun/jdi/VirtualMachineManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVirtualMachine", "(Lcom/sun/jdi/connect/spi/Connection;Ljava/lang/Process;)Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVirtualMachine", "(Lcom/sun/jdi/connect/spi/Connection;)Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultConnector", "()Lcom/sun/jdi/connect/LaunchingConnector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConnector", "(Lcom/sun/jdi/connect/Connector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "launchingConnectors", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultConnector", "(Lcom/sun/jdi/connect/LaunchingConnector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attachingConnectors", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listeningConnectors", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connectedVirtualMachines", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeConnector", "(Lcom/sun/jdi/connect/Connector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVirtualMachine", "(Lcom/sun/jdi/VirtualMachine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mainGroupForJDI", "()Ljava/lang/ThreadGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "majorInterfaceVersion", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minorInterfaceVersion", "()I"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List connectors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jdi/connect/LaunchingConnector;", "private")]
	public Dova.JDK.com.sun.jdi.connect.LaunchingConnector defaultConnector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.LaunchingConnector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List targets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "private final")]
	public Dova.JDK.java.lang.ThreadGroup mainGroupForJDI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private")]
	public Dova.JDK.java.util.ResourceBundle messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int vmSequenceNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int majorVersion_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int minorVersion_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/VirtualMachineManagerImpl;", "private static")]
	public static Dova.JDK.com.sun.tools.jdi.VirtualMachineManagerImpl vmm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.VirtualMachineManagerImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VirtualMachineManagerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public VirtualMachineManagerImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/VirtualMachineManagerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;)V", "")]
	public void disposeVirtualMachine(Dova.JDK.com.sun.jdi.VirtualMachine arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List allConnectors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/VirtualMachineManager;", "public static")]
	public static Dova.JDK.com.sun.jdi.VirtualMachineManager virtualMachineManager()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachineManager>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/spi/Connection;Ljava/lang/Process;)Lcom/sun/jdi/VirtualMachine;", "public synchronized")]
	public Dova.JDK.com.sun.jdi.VirtualMachine createVirtualMachine(Dova.JDK.com.sun.jdi.connect.spi.Connection arg0, Dova.JDK.java.lang.Process arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/spi/Connection;)Lcom/sun/jdi/VirtualMachine;", "public")]
	public Dova.JDK.com.sun.jdi.VirtualMachine createVirtualMachine(Dova.JDK.com.sun.jdi.connect.spi.Connection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/connect/LaunchingConnector;", "public")]
	public Dova.JDK.com.sun.jdi.connect.LaunchingConnector defaultConnector()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.LaunchingConnector>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/Connector;)V", "public")]
	public void addConnector(Dova.JDK.com.sun.jdi.connect.Connector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List launchingConnectors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/LaunchingConnector;)V", "public")]
	public void setDefaultConnector(Dova.JDK.com.sun.jdi.connect.LaunchingConnector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List attachingConnectors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List listeningConnectors()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List connectedVirtualMachines()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/Connector;)V", "public")]
	public void removeConnector(Dova.JDK.com.sun.jdi.connect.Connector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;)V", "public")]
	public void addVirtualMachine(Dova.JDK.com.sun.jdi.VirtualMachine arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/ThreadGroup;", "")]
	public Dova.JDK.java.lang.ThreadGroup mainGroupForJDI()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int majorInterfaceVersion()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int minorInterfaceVersion()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}
}
