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

namespace Dova.JDK.jdk.@internal.org.jline.terminal.impl;

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal;", "public")]
public partial class PosixPtyTerminal
	: Dova.JDK.jdk.@internal.org.jline.terminal.impl.AbstractPosixTerminal
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PosixPtyTerminal()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "out", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "masterInput", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "masterOutput", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "input", "Ljdk/internal/org/jline/utils/NonBlockingInputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "output", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reader", "Ljdk/internal/org/jline/utils/NonBlockingReader;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "writer", "Ljava/io/PrintWriter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "inputPumpThread", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "outputPumpThread", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "paused", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PosixPtyTerminal", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;Z)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PosixPtyTerminal", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PosixPtyTerminal", "(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resume", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reader", "()Ljdk/internal/org/jline/utils/NonBlockingReader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "writer", "()Ljava/io/PrintWriter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "input", "()Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "output", "()Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "canPauseResume", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pause", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pause", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "paused", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pumpIn", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pumpOut", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doClose", "()V"));
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private final")]
	public Dova.JDK.java.io.InputStream @in_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private final")]
	public Dova.JDK.java.io.OutputStream @out_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private final")]
	public Dova.JDK.java.io.InputStream masterInput_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private final")]
	public Dova.JDK.java.io.OutputStream masterOutput_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/NonBlockingInputStream;", "private final")]
	public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream input_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private final")]
	public Dova.JDK.java.io.OutputStream output_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/NonBlockingReader;", "private final")]
	public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader reader_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
	public Dova.JDK.java.io.PrintWriter writer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object @lock_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
	public Dova.JDK.java.lang.Thread inputPumpThread_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private")]
	public Dova.JDK.java.lang.Thread outputPumpThread_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool paused_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PosixPtyTerminal(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;Z)V", "public")]
	public PosixPtyTerminal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty arg2, Dova.JDK.java.io.InputStream arg3, Dova.JDK.java.io.OutputStream arg4, Dova.JDK.java.nio.charset.Charset arg5, Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler arg6, bool arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;)V", "public")]
	public PosixPtyTerminal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty arg2, Dova.JDK.java.io.InputStream arg3, Dova.JDK.java.io.OutputStream arg4, Dova.JDK.java.nio.charset.Charset arg5, Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler arg6) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/internal/org/jline/terminal/spi/Pty;Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V", "public")]
	public PosixPtyTerminal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty arg2, Dova.JDK.java.io.InputStream arg3, Dova.JDK.java.io.OutputStream arg4, Dova.JDK.java.nio.charset.Charset arg5) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void resume()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/NonBlockingReader;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader reader()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/PrintWriter;", "public")]
	public Dova.JDK.java.io.PrintWriter writer()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream input()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/OutputStream;", "public")]
	public Dova.JDK.java.io.OutputStream output()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool canPauseResume()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void pause(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void pause()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool paused()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void pumpIn()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void pumpOut()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void doClose()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal$InputStreamWrapper;", "private")]
	public partial class InputStreamWrapper
		: Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InputStreamWrapper()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal$InputStreamWrapper;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "in", "Ljdk/internal/org/jline/utils/NonBlockingInputStream;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "closed", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InputStreamWrapper", "(Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal;Ljdk/internal/org/jline/utils/NonBlockingInputStream;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "read", "(JZ)I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/NonBlockingInputStream;", "private final")]
		public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream @in_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private final")]
		public Dova.JDK.java.util.concurrent.atomic.AtomicBoolean closed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InputStreamWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal;Ljdk/internal/org/jline/utils/NonBlockingInputStream;)V", "protected")]
		public InputStreamWrapper(Dova.JDK.jdk.@internal.org.jline.terminal.impl.PosixPtyTerminal arg0, Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingInputStream arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/impl/PosixPtyTerminal$InputStreamWrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(JZ)I", "public")]
		public int read(long arg0, bool arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}
}