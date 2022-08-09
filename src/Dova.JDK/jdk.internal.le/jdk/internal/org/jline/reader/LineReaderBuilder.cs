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

namespace Dova.JDK.jdk.@internal.org.jline.reader;

[JniSignatureAttribute("Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public final")]
public partial class LineReaderBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LineReaderBuilder()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/reader/LineReaderBuilder;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "terminal", "Ljdk/internal/org/jline/terminal/Terminal;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "appName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "variables", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "options", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "history", "Ljdk/internal/org/jline/reader/History;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "completer", "Ljdk/internal/org/jline/reader/Completer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "memoryHistory", "Ljdk/internal/org/jline/reader/History;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "highlighter", "Ljdk/internal/org/jline/reader/Highlighter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "parser", "Ljdk/internal/org/jline/reader/Parser;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expander", "Ljdk/internal/org/jline/reader/Expander;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "completionMatcher", "Ljdk/internal/org/jline/reader/CompletionMatcher;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LineReaderBuilder", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "builder", "()Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "option", "(Ljdk/internal/org/jline/reader/LineReader$Option;Z)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "build", "()Ljdk/internal/org/jline/reader/LineReader;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parser", "(Ljdk/internal/org/jline/reader/Parser;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "completer", "(Ljdk/internal/org/jline/reader/Completer;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "history", "(Ljdk/internal/org/jline/reader/History;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "expander", "(Ljdk/internal/org/jline/reader/Expander;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "completionMatcher", "(Ljdk/internal/org/jline/reader/CompletionMatcher;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "variables", "(Ljava/util/Map;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "appName", "(Ljava/lang/String;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "terminal", "(Ljdk/internal/org/jline/terminal/Terminal;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "highlighter", "(Ljdk/internal/org/jline/reader/Highlighter;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "variable", "(Ljava/lang/String;Ljava/lang/Object;)Ljdk/internal/org/jline/reader/LineReaderBuilder;"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/terminal/Terminal;", "")]
	public Dova.JDK.jdk.@internal.org.jline.terminal.Terminal terminal_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.terminal.Terminal>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String appName_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map variables_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map options_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/History;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History history_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Completer;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Completer completer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Completer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/History;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.History memoryHistory_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.History>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Highlighter;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Highlighter highlighter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Highlighter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Parser;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Parser parser_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Parser>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/Expander;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.Expander expander_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.Expander>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/reader/CompletionMatcher;", "")]
	public Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher completionMatcher_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LineReaderBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public LineReaderBuilder() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/reader/LineReaderBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public static")]
	public static Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder builder()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/LineReader$Option;Z)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder option(Dova.JDK.jdk.@internal.org.jline.reader.LineReader.Option arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/org/jline/reader/LineReader;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReader build()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReader>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Parser;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder parser(Dova.JDK.jdk.@internal.org.jline.reader.Parser arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Completer;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder completer(Dova.JDK.jdk.@internal.org.jline.reader.Completer arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/History;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder history(Dova.JDK.jdk.@internal.org.jline.reader.History arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Expander;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder expander(Dova.JDK.jdk.@internal.org.jline.reader.Expander arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/CompletionMatcher;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder completionMatcher(Dova.JDK.jdk.@internal.org.jline.reader.CompletionMatcher arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder variables(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder appName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/terminal/Terminal;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder terminal(Dova.JDK.jdk.@internal.org.jline.terminal.Terminal arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/jline/reader/Highlighter;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder highlighter(Dova.JDK.jdk.@internal.org.jline.reader.Highlighter arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljdk/internal/org/jline/reader/LineReaderBuilder;", "public")]
	public Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder variable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.reader.LineReaderBuilder>(ret);
	}
}
