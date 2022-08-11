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

namespace Dova.JDK.jdk.@internal.jshell.tool;

[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "")]
public partial class ConsoleIOContext
	: Dova.JDK.jdk.@internal.jshell.tool.IOContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConsoleIOContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HISTORY_LINE_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowIncompleteInputs", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "repl", "Ljdk/internal/jshell/tool/JShellTool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "input", "Ljdk/internal/jshell/tool/StopDetectingInputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalAttributes", "Ljdk/internal/org/jline/terminal/Attributes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Ljdk/internal/org/jline/reader/impl/LineReaderImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userInputHistory", "Ljdk/internal/org/jline/reader/History;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "historyLoad", "Ljava/time/Instant;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIXES_SHORTCUT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE_SEPARATOR", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE_SEPARATORS2", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTOPRINT_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEEDED_LINES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ESCAPE_TIMEOUT", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputBytes", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputBytesPointer", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIX_COMPUTERS", "[Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/JShellTool;Ljava/io/InputStream;Ljava/io/PrintStream;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resume", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suspend", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLine", "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "commonPrefix", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionState;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "countTrailintBackslashes", "(Ljava/lang/CharSequence;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readOutRemainingEscape", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSplitEntries", "(Ljava/lang/String;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "countPendingOpenBraces", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printColumns", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "terminalEditorRunning", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "beforeUserCode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "afterUserCode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceLastHistoryEntry", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndent", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUserInput", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixes", "(Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixes", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doPrintFullDocumentation", "(Ljava/util/List;Ljava/util/List;Z)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interactiveOutput", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "history", "(Z)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHistory", "()Ljdk/internal/org/jline/reader/History;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String HISTORY_LINE_PREFIX_Property
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

	[JniSignatureAttribute("Z", "final")]
	public bool allowIncompleteInputs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/JShellTool;", "final")]
	public Dova.JDK.jdk.@internal.jshell.tool.JShellTool repl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.JShellTool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/StopDetectingInputStream;", "final")]
	public Dova.JDK.jdk.@internal.jshell.tool.StopDetectingInputStream input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.StopDetectingInputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Attributes;", "final")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Attributes originalAttributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Attributes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/impl/LineReaderImpl;", "final")]
	public Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl @in_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/History;", "final")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History userInputHistory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/Instant;", "final")]
	public Dova.JDK.java.time.Instant historyLoad_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String prefix_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String FIXES_SHORTCUT_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LINE_SEPARATOR_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LINE_SEPARATORS2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int AUTOPRINT_THRESHOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int NEEDED_LINES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long ESCAPE_TIMEOUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> inputBytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int inputBytesPointer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("[Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;", "private static final")]
	public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.FixComputer> FIX_COMPUTERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.FixComputer>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConsoleIOContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljava/io/InputStream;Ljava/io/PrintStream;Z)V", "")]
	public ConsoleIOContext(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.java.io.InputStream arg1, Dova.JDK.java.io.PrintStream arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void resume()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void suspend()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readLine(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String commonPrefix(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionState;)Z", "private")]
	public bool complete(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionState arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)I", "private")]
	public int countTrailintBackslashes(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void readOutRemainingEscape(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream toSplitEntries(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private")]
	public int countPendingOpenBraces(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void printColumns(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool terminalEditorRunning()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void beforeUserCode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void afterUserCode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void replaceLastHistoryEntry(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setIndent(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()I", "public synchronized")]
	public int readUserInput()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;)V", "private")]
	public void fixes(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.FixComputer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool fixes()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Z)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "private")]
	public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result doPrintFullDocumentation(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool interactiveOutput()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable history(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/History;", "private")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History getHistory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$TestTerminal;", "private static final")]
	public partial class TestTerminal
		: Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.ProgrammaticInTerminal
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TestTerminal()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$TestTerminal;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljdk/internal/org/jline/terminal/Size;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeSize", "()Ljdk/internal/org/jline/terminal/Size;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TestTerminal(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "public")]
		public TestTerminal(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Ljdk/internal/org/jline/terminal/Size;)V", "private")]
		public TestTerminal(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.jdk.@internal.org.jline.terminal.Size arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$TestTerminal;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Size;", "private static")]
		public static Dova.JDK.jdk.@internal.org.jline.terminal.Size computeSize()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$ProgrammaticInTerminal;", "private static")]
	public partial class ProgrammaticInTerminal
		: Dova.JDK.jdk.@internal.org.jline.terminal.impl.LineDisciplineTerminal
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProgrammaticInTerminal()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$ProgrammaticInTerminal;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_HEIGHT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputReader", "Ljdk/internal/org/jline/utils/NonBlockingReader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bufferSize", "Ljdk/internal/org/jline/terminal/Size;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/io/OutputStream;ZLjdk/internal/org/jline/terminal/Size;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Ljdk/internal/org/jline/terminal/Size;Ljdk/internal/org/jline/terminal/Size;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reader", "()Ljdk/internal/org/jline/utils/NonBlockingReader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doClose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBufferSize", "()Ljdk/internal/org/jline/terminal/Size;"));
		}

		[JniSignatureAttribute("I", "protected static final")]
		public static int DEFAULT_HEIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/NonBlockingReader;", "private final")]
		public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader inputReader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Size;", "private final")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.Size bufferSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProgrammaticInTerminal(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;ZLjdk/internal/org/jline/terminal/Size;)V", "public")]
		public ProgrammaticInTerminal(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, bool arg2, Dova.JDK.jdk.@internal.org.jline.terminal.Size arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/io/InputStream;Ljava/io/OutputStream;Ljava/lang/String;Ljdk/internal/org/jline/terminal/Size;Ljdk/internal/org/jline/terminal/Size;)V", "protected")]
		public ProgrammaticInTerminal(Dova.JDK.java.io.InputStream arg0, Dova.JDK.java.io.OutputStream arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.jdk.@internal.org.jline.terminal.Size arg3, Dova.JDK.jdk.@internal.org.jline.terminal.Size arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$ProgrammaticInTerminal;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/internal/org/jline/utils/NonBlockingReader;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader reader()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.NonBlockingReader>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void doClose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Ljdk/internal/org/jline/terminal/Size;", "public")]
		public Dova.JDK.jdk.@internal.org.jline.terminal.Size getBufferSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Size>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionState;", "private static final")]
	public partial class CompletionState
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "todo", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int actionCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List todo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompletionState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CompletionState() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$ContinueCompletionTask;", "private static")]
	public partial class ContinueCompletionTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ContinueCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$ContinueCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ContinueCompletionTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ContinueCompletionTask() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$ContinueCompletionTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$OrdinaryCompletionTask;", "private final")]
	public partial class OrdinaryCompletionTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrdinaryCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$OrdinaryCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toShow", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cont", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showSmart", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;Ljava/lang/String;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List toShow_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String prefix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool cont_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool showSmart_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrdinaryCompletionTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;Ljava/lang/String;ZZ)V", "public")]
		public OrdinaryCompletionTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$OrdinaryCompletionTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$AllSuggestionsCompletionTask;", "private final")]
	public partial class AllSuggestionsCompletionTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AllSuggestionsCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$AllSuggestionsCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suggestions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anchor", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List suggestions_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int anchor_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AllSuggestionsCompletionTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;I)V", "public")]
		public AllSuggestionsCompletionTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$AllSuggestionsCompletionTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CommandSynopsisTask;", "private final")]
	public partial class CommandSynopsisTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CommandSynopsisTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$CommandSynopsisTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "synopsis", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List synopsis_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CommandSynopsisTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V", "public")]
		public CommandSynopsisTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$CommandSynopsisTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CommandFullDocumentationTask;", "private final")]
	public partial class CommandFullDocumentationTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CommandFullDocumentationTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$CommandFullDocumentationTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "todo", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List todo_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CommandFullDocumentationTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V", "public")]
		public CommandFullDocumentationTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$CommandFullDocumentationTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$NoopCompletionTask;", "private final")]
	public partial class NoopCompletionTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoopCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$NoopCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NoopCompletionTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;)V", "private")]
		public NoopCompletionTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$NoopCompletionTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$NoSuchCommandCompletionTask;", "private final")]
	public partial class NoSuchCommandCompletionTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoSuchCommandCompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$NoSuchCommandCompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NoSuchCommandCompletionTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;)V", "private")]
		public NoSuchCommandCompletionTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$NoSuchCommandCompletionTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionSignaturesTask;", "private final")]
	public partial class ExpressionSignaturesTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExpressionSignaturesTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionSignaturesTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doc", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List doc_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExpressionSignaturesTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V", "public")]
		public ExpressionSignaturesTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionSignaturesTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionJavadocTask;", "private final")]
	public partial class ExpressionJavadocTask
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExpressionJavadocTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionJavadocTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "todo", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/jshell/tool/ConsoleIOContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List todo_Property
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

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext;", "final")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExpressionJavadocTask(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/ConsoleIOContext;Ljava/util/List;)V", "public")]
		public ExpressionJavadocTask(Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$ExpressionJavadocTask;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask;", "private abstract static interface")]
	public partial interface CompletionTask
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String description()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public abstract")]
		Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result perform(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
		}

		[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
		public partial class Result
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Result()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_DATA", "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE", "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINISH", "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP", "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_NOREPAINT", "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;"));
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result NO_DATA_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result CONTINUE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result FINISH_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result SKIP_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static final")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result SKIP_NOREPAINT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "private static final")]
			public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Result(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Result(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static")]
			public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "public static")]
			public static Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>(ret);
			}

			[JniSignatureAttribute("()[Ljdk/internal/jshell/tool/ConsoleIOContext$CompletionTask$Result;", "private static")]
			public static JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.CompletionTask.Result>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;", "public abstract static")]
	public partial class FixComputer
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixComputer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shortcut", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showMenu", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(CZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compute", "(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$FixResult;"));
		}

		[JniSignatureAttribute("C", "private final")]
		public char shortcut_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool showMenu_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixComputer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(CZ)V", "public")]
		public FixComputer(char arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$FixComputer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/internal/jshell/tool/JShellTool;Ljava/lang/String;I)Ljdk/internal/jshell/tool/ConsoleIOContext$FixResult;", "public abstract")]
		public Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.FixResult compute(Dova.JDK.jdk.@internal.jshell.tool.JShellTool arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jshell.tool.ConsoleIOContext.FixResult>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$FixResult;", "public static")]
	public partial class FixResult
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$FixResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "error", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List fixes_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String error_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)V", "public")]
		public FixResult(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jshell/tool/ConsoleIOContext$FixResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/jshell/tool/ConsoleIOContext$Fix;", "public abstract static interface")]
	public partial interface Fix
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Fix()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jshell/tool/ConsoleIOContext$Fix;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "displayName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "perform", "(Ljdk/internal/org/jline/reader/impl/LineReaderImpl;)V"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String displayName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/impl/LineReaderImpl;)V", "public abstract")]
		void perform(Dova.JDK.jdk.@internal.org.jline.reader.impl.LineReaderImpl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
