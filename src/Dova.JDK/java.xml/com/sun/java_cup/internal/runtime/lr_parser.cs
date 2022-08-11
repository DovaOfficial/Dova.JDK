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

namespace Dova.JDK.com.sun.java_cup.@internal.runtime;

[JniSignatureAttribute("Lcom/sun/java_cup/internal/runtime/lr_parser;", "public abstract")]
public partial class lr_parser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static lr_parser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java_cup/internal/runtime/lr_parser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_GROUP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_OPERATOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID_TOTAL_OPERATOR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLiteral", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "grpCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "totalOpCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_error_sync_size", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_done_parsing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cur_token", "Lcom/sun/java_cup/internal/runtime/Symbol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stack", "Ljava/util/Stack;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "production_tab", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action_tab", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reduce_tab", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_scanner", "Lcom/sun/java_cup/internal/runtime/Scanner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookahead", "[Lcom/sun/java_cup/internal/runtime/Symbol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookahead_pos", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java_cup/internal/runtime/Scanner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "([II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "()Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "()Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCount", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unpackFromStrings", "([Ljava/lang/String;)[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "production_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "action_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init_actions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "do_action", "(ILcom/sun/java_cup/internal/runtime/lr_parser;Ljava/util/Stack;I)Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start_state", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start_production", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "EOF_sym", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error_sym", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report_error", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report_fatal_error", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "done_parsing", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setScanner", "(Lcom/sun/java_cup/internal/runtime/Scanner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScanner", "()Lcom/sun/java_cup/internal/runtime/Scanner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "user_init", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_action", "(II)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_reduce", "(II)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "syntax_error", "(Lcom/sun/java_cup/internal/runtime/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error_recovery", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unrecovered_syntax_error", "(Lcom/sun/java_cup/internal/runtime/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug_message", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug_shift", "(Lcom/sun/java_cup/internal/runtime/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug_reduce", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find_recovery_config", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read_lookahead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "try_parse_ahead", "(Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cur_err_token", "()Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restart_lookahead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse_lookahead", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shift_under_error", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error_sync_size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "advance_lookahead", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump_stack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug_stack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug_parse", "()Lcom/sun/java_cup/internal/runtime/Symbol;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ID_GROUP_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int ID_OPERATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ID_TOTAL_OPERATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isLiteral_Property
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

	[JniSignatureAttribute("I", "private")]
	public int grpCount_Property
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

	[JniSignatureAttribute("I", "private")]
	public int opCount_Property
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

	[JniSignatureAttribute("I", "private")]
	public int totalOpCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int _error_sync_size_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool _done_parsing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int tos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java_cup/internal/runtime/Symbol;", "protected")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol cur_token_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Stack;", "protected")]
	public Dova.JDK.java.util.Stack stack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "protected")]
	public JavaArray<JavaArray<short>> production_tab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "protected")]
	public JavaArray<JavaArray<short>> action_tab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "protected")]
	public JavaArray<JavaArray<short>> reduce_tab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java_cup/internal/runtime/Scanner;", "private")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner _scanner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/java_cup/internal/runtime/Symbol;", "protected")]
	public JavaArray<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol> lookahead_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int lookahead_pos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public lr_parser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public lr_parser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Scanner;)V", "public")]
	public lr_parser(Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java_cup/internal/runtime/lr_parser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([II)Z", "private")]
	public bool contains(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Symbol;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol parse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Symbol;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol scan()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getCount(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/String;)[[S", "protected static")]
	public static JavaArray<JavaArray<short>> unpackFromStrings(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()[[S", "public abstract")]
	public JavaArray<JavaArray<short>> production_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()[[S", "public abstract")]
	public JavaArray<JavaArray<short>> action_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()[[S", "public abstract")]
	public JavaArray<JavaArray<short>> reduce_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void init_actions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(ILcom/sun/java_cup/internal/runtime/lr_parser;Ljava/util/Stack;I)Lcom/sun/java_cup/internal/runtime/Symbol;", "public abstract")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol do_action(int arg0, Dova.JDK.com.sun.java_cup.@internal.runtime.lr_parser arg1, Dova.JDK.java.util.Stack arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int start_state()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int start_production()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int EOF_sym()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int error_sym()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void report_error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void report_fatal_error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void done_parsing()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Scanner;)V", "public")]
	public void setScanner(Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Scanner;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner getScanner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void user_init()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(II)S", "protected final")]
	public short get_action(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)S", "protected final")]
	public short get_reduce(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Symbol;)V", "public")]
	public void syntax_error(Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool error_recovery(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Symbol;)V", "public")]
	public void unrecovered_syntax_error(Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void debug_message(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Symbol;)V", "public")]
	public void debug_shift(Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(III)V", "public")]
	public void debug_reduce(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool find_recovery_config(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void read_lookahead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
	}

	[JniSignatureAttribute("(Z)Z", "protected")]
	public bool try_parse_ahead(bool arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Symbol;", "protected")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol cur_err_token()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void restart_lookahead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public void parse_lookahead(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool shift_under_error()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int error_sync_size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool advance_lookahead()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void dump_stack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void debug_stack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("()Lcom/sun/java_cup/internal/runtime/Symbol;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol debug_parse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}
}
