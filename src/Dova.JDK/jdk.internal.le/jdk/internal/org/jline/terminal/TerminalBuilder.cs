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

namespace Dova.JDK.jdk.@internal.org.jline.terminal;

[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public final")]
public partial class TerminalBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TerminalBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/TerminalBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_ENCODING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_CODEPAGE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_JNA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_JANSI", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_EXEC", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_DUMB", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_DUMB_COLOR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_NON_BLOCKING_READS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_COLOR_DISTANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROP_DISABLE_ALTERNATE_CHARSET", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM_TERMINAL", "Ljava/util/concurrent/atomic/AtomicReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TERMINAL_OVERRIDE", "Ljava/util/concurrent/atomic/AtomicReference;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljava/io/InputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/OutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoding", "Ljava/nio/charset/Charset;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "codepage", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "system", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jna", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jansi", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exec", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dumb", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color", "Ljava/lang/Boolean;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributes", "Ljdk/internal/org/jline/terminal/Attributes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "Ljdk/internal/org/jline/terminal/Size;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeSignals", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputStreamWrapper", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signalHandler", "Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paused", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "type", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "(Ljdk/internal/org/jline/terminal/Size;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "builder", "()Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "system", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encoding", "(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encoding", "(Ljava/nio/charset/Charset;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exec", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "color", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jna", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljdk/internal/org/jline/terminal/Terminal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attributes", "(Ljdk/internal/org/jline/terminal/Attributes;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dumb", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paused", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeSignals", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inputStreamWrapper", "(Ljava/util/function/Function;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalHandler", "(Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "jansi", "(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "codepage", "(I)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Ljdk/internal/org/jline/terminal/Terminal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getParentProcessCommand", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setTerminalOverride", "(Ljdk/internal/org/jline/terminal/Terminal;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "streams", "(Ljava/io/InputStream;Ljava/io/OutputStream;)Ljdk/internal/org/jline/terminal/TerminalBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "terminal", "()Ljdk/internal/org/jline/terminal/Terminal;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_ENCODING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_CODEPAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_JNA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_JANSI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_EXEC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_DUMB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_DUMB_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_NON_BLOCKING_READS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_COLOR_DISTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROP_DISABLE_ALTERNATE_CHARSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicReference SYSTEM_TERMINAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicReference TERMINAL_OVERRIDE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/InputStream;", "private")]
	public Dova.JDK.java.io.InputStream @in_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/OutputStream;", "private")]
	public Dova.JDK.java.io.OutputStream @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/charset/Charset;", "private")]
	public Dova.JDK.java.nio.charset.Charset encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int codepage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean system_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean jna_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean jansi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean exec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean dumb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean color_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Attributes attributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Size;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Size size_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool nativeSignals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private")]
	public Dova.JDK.java.util.function.Function inputStreamWrapper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler signalHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool paused_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TerminalBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public TerminalBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/TerminalBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder name(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder type(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "private static")]
	public static Dova.JDK.java.lang.Boolean getBoolean(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Boolean arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object load(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Size;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder size(Dova.JDK.jdk.@internal.org.jline.terminal.Size arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder builder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder system(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder encoding(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/charset/Charset;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder encoding(Dova.JDK.java.nio.charset.Charset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder exec(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder color(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder jna(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Terminal;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal build()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Attributes;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder attributes(Dova.JDK.jdk.@internal.org.jline.terminal.Attributes arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder dumb(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder paused(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder nativeSignals(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder inputStreamWrapper(Dova.JDK.java.util.function.Function arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal$SignalHandler;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder signalHandler(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal.SignalHandler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder jansi(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder codepage(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Terminal;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal doBuild()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getParentProcessCommand()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;)V", "public static")]
	public static void setTerminalOverride(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)Ljdk/internal/org/jline/terminal/TerminalBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder streams(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.TerminalBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Terminal;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.terminal.Terminal terminal()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/TerminalBuilder$TerminalBuilderSupport;", "private static")]
	public partial class TerminalBuilderSupport
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TerminalBuilderSupport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/jline/terminal/TerminalBuilder$TerminalBuilderSupport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jansiSupport", "Ljdk/internal/org/jline/terminal/spi/JansiSupport;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jnaSupport", "Ljdk/internal/org/jline/terminal/spi/JnaSupport;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pty", "Ljdk/internal/org/jline/terminal/spi/Pty;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "consoleOutput", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExecPty", "()Ljdk/internal/org/jline/terminal/spi/Pty;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasJansiSupport", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJansiSupport", "()Ljdk/internal/org/jline/terminal/spi/JansiSupport;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConsoleInput", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConsoleOutput", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasJnaSupport", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJnaSupport", "()Ljdk/internal/org/jline/terminal/spi/JnaSupport;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/spi/JansiSupport;", "private")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.JansiSupport jansiSupport_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.JansiSupport>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/spi/JnaSupport;", "private")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.JnaSupport jnaSupport_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.JnaSupport>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/spi/Pty;", "private")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty pty_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool consoleOutput_Property
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
		public TerminalBuilderSupport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZZ)V", "")]
		public TerminalBuilderSupport(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/terminal/TerminalBuilder$TerminalBuilderSupport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/spi/Pty;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty getExecPty()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.Pty>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasJansiSupport()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/spi/JansiSupport;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.JansiSupport getJansiSupport()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.JansiSupport>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isConsoleInput()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isConsoleOutput()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasJnaSupport()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/spi/JnaSupport;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.spi.JnaSupport getJnaSupport()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.spi.JnaSupport>(ret);
		}
	}
}
