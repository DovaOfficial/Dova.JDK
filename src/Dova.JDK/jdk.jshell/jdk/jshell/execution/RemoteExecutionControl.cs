/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.jshell.execution;

[JniSignatureAttribute("Ljdk/jshell/execution/RemoteExecutionControl;", "public")]
public partial class RemoteExecutionControl
	: Dova.JDK.jdk.jshell.execution.DirectExecutionControl
	, Dova.JDK.jdk.jshell.spi.ExecutionControl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RemoteExecutionControl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/execution/RemoteExecutionControl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "inClientCode", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expectingStop", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "stopException", "Ljdk/jshell/execution/RemoteExecutionControl$StopExecutionException;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RemoteExecutionControl", "()V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RemoteExecutionControl", "(Ljdk/jshell/execution/LoaderDelegate;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invoke", "(Ljava/lang/reflect/Method;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "main", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "stop", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "throwConvertedInvocationException", "(Ljava/lang/Throwable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clientCodeEnter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clientCodeLeave", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "throwConvertedOtherException", "(Ljava/lang/Throwable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "redefine", "([Ljdk/jshell/spi/ExecutionControl$ClassBytecodes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "varValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inClientCode_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool expectingStop_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljdk/jshell/execution/RemoteExecutionControl$StopExecutionException;", "private final")]
	public Dova.JDK.jdk.jshell.execution.RemoteExecutionControl.StopExecutionException stopException_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.execution.RemoteExecutionControl.StopExecutionException>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RemoteExecutionControl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RemoteExecutionControl() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/execution/LoaderDelegate;)V", "public")]
	public RemoteExecutionControl(Dova.JDK.jdk.jshell.execution.LoaderDelegate arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/execution/RemoteExecutionControl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String invoke(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public static")]
	public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void stop()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String throwConvertedInvocationException(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void clientCodeEnter()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void clientCodeLeave()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String throwConvertedOtherException(Dova.JDK.java.lang.Throwable arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljdk/jshell/spi/ExecutionControl$ClassBytecodes;)V", "public")]
	public void redefine(JavaArray<Dova.JDK.jdk.jshell.spi.ExecutionControl.ClassBytecodes> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String varValue(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljdk/jshell/execution/RemoteExecutionControl$StopExecutionException;", "private")]
	public partial class StopExecutionException
		: Dova.JDK.java.lang.ThreadDeath
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StopExecutionException()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/execution/RemoteExecutionControl$StopExecutionException;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljdk/jshell/execution/RemoteExecutionControl;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "StopExecutionException", "(Ljdk/jshell/execution/RemoteExecutionControl;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fillInStackTrace", "()Ljava/lang/Throwable;"));
		}

		[JniSignatureAttribute("Ljdk/jshell/execution/RemoteExecutionControl;", "final")]
		public Dova.JDK.jdk.jshell.execution.RemoteExecutionControl this0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.execution.RemoteExecutionControl>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StopExecutionException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/execution/RemoteExecutionControl;)V", "private")]
		public StopExecutionException(Dova.JDK.jdk.jshell.execution.RemoteExecutionControl arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/execution/RemoteExecutionControl$StopExecutionException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Throwable;", "public synchronized")]
		public Dova.JDK.java.lang.Throwable fillInStackTrace()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
		}
	}
}
