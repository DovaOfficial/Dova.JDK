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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/AbstractLauncher;", "abstract")]
public partial class AbstractLauncher
	: Dova.JDK.com.sun.tools.jdi.ConnectorImpl
	, Dova.JDK.com.sun.jdi.connect.LaunchingConnector
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractLauncher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/AbstractLauncher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "grp", "Ljava/lang/ThreadGroup;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AbstractLauncher", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "description", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tokenizeCommand", "(Ljava/lang/String;C)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "launch", "([Ljava/lang/String;Ljava/lang/String;Lcom/sun/jdi/connect/spi/TransportService$ListenKey;Lcom/sun/jdi/connect/spi/TransportService;)Lcom/sun/jdi/VirtualMachine;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "launch", "(Ljava/util/Map;)Lcom/sun/jdi/VirtualMachine;"));
	}

	[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "")]
	public Dova.JDK.java.lang.ThreadGroup grp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractLauncher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public AbstractLauncher() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/AbstractLauncher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String description()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;C)[Ljava/lang/String;", "")]
	public JavaArray<Dova.JDK.java.lang.String> tokenizeCommand(Dova.JDK.java.lang.String arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;Ljava/lang/String;Lcom/sun/jdi/connect/spi/TransportService$ListenKey;Lcom/sun/jdi/connect/spi/TransportService;)Lcom/sun/jdi/VirtualMachine;", "protected")]
	public Dova.JDK.com.sun.jdi.VirtualMachine launch(JavaArray<Dova.JDK.java.lang.String> arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey arg2, Dova.JDK.com.sun.jdi.connect.spi.TransportService arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Lcom/sun/jdi/VirtualMachine;", "public abstract")]
	public Dova.JDK.com.sun.jdi.VirtualMachine launch(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.VirtualMachine>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/AbstractLauncher$Helper;", "private")]
	public partial class Helper
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Helper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/AbstractLauncher$Helper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "address", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "listenKey", "Lcom/sun/jdi/connect/spi/TransportService$ListenKey;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ts", "Lcom/sun/jdi/connect/spi/TransportService;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "commandArray", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "process", "Ljava/lang/Process;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "connection", "Lcom/sun/jdi/connect/spi/Connection;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "acceptException", "Ljava/io/IOException;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exited", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/tools/jdi/AbstractLauncher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Helper", "(Lcom/sun/tools/jdi/AbstractLauncher;[Ljava/lang/String;Ljava/lang/String;Lcom/sun/jdi/connect/spi/TransportService$ListenKey;Lcom/sun/jdi/connect/spi/TransportService;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "connection", "()Lcom/sun/jdi/connect/spi/Connection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "process", "()Ljava/lang/Process;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "launchAndAccept", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "acceptConnection", "()Ljava/lang/Thread;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "monitorTarget", "()Ljava/lang/Thread;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "commandString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "notifyOfExit", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "notifyOfConnection", "(Lcom/sun/jdi/connect/spi/Connection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "notifyOfAcceptException", "(Ljava/io/IOException;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String address_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/TransportService$ListenKey;", "private")]
		public Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey listenKey_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/TransportService;", "private")]
		public Dova.JDK.com.sun.jdi.connect.spi.TransportService ts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.TransportService>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
		public JavaArray<Dova.JDK.java.lang.String> commandArray_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Process;", "private")]
		public Dova.JDK.java.lang.Process process_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/Connection;", "private")]
		public Dova.JDK.com.sun.jdi.connect.spi.Connection connection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.Connection>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/io/IOException;", "private")]
		public Dova.JDK.java.io.IOException acceptException_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool exited_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/AbstractLauncher;", "final")]
		public Dova.JDK.com.sun.tools.jdi.AbstractLauncher this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.AbstractLauncher>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Helper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdi/AbstractLauncher;[Ljava/lang/String;Ljava/lang/String;Lcom/sun/jdi/connect/spi/TransportService$ListenKey;Lcom/sun/jdi/connect/spi/TransportService;)V", "")]
		public Helper(Dova.JDK.com.sun.tools.jdi.AbstractLauncher arg0, JavaArray<Dova.JDK.java.lang.String> arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey arg3, Dova.JDK.com.sun.jdi.connect.spi.TransportService arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/AbstractLauncher$Helper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/jdi/connect/spi/Connection;", "")]
		public Dova.JDK.com.sun.jdi.connect.spi.Connection connection()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.Connection>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Process;", "")]
		public Dova.JDK.java.lang.Process process()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Process>(ret);
		}

		[JniSignatureAttribute("()V", "synchronized")]
		public void launchAndAccept()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()Ljava/lang/Thread;", "")]
		public Dova.JDK.java.lang.Thread acceptConnection()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Thread;", "")]
		public Dova.JDK.java.lang.Thread monitorTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String commandString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "synchronized")]
		public void notifyOfExit()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Lcom/sun/jdi/connect/spi/Connection;)V", "synchronized")]
		public void notifyOfConnection(Dova.JDK.com.sun.jdi.connect.spi.Connection arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/io/IOException;)V", "synchronized")]
		public void notifyOfAcceptException(Dova.JDK.java.io.IOException arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}
}
