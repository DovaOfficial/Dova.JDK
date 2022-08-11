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

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;", "public")]
public partial class DeferredCompletionFailureHandler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DeferredCompletionFailureHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "deferredCompletionFailureHandlerKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userCodeHandler", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "speculativeCodeHandler", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javacCodeHandler", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHandler", "(Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;)Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAPICompletionFailure", "(Lcom/sun/tools/javac/code/Symbol$CompletionFailure;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSymbolRemoved", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSymbolCompleteFailed", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeferredCompleter", "(Lcom/sun/tools/javac/code/Symbol$Completer;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key deferredCompletionFailureHandlerKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler userCodeHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler speculativeCodeHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler javacCodeHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "private")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DeferredCompletionFailureHandler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public DeferredCompletionFailureHandler(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;)Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler setHandler(Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler.Handler>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$CompletionFailure;)V", "public")]
	public void handleAPICompletionFailure(Dova.JDK.com.sun.tools.javac.code.Symbol.CompletionFailure arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "public")]
	public void classSymbolRemoved(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V", "public")]
	public void classSymbolCompleteFailed(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$Completer;)Z", "public")]
	public bool isDeferredCompleter(Dova.JDK.com.sun.tools.javac.code.Symbol.Completer arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;", "public abstract static interface")]
	public partial interface Handler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstall", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleAPICompletionFailure", "(Lcom/sun/tools/javac/code/Symbol$CompletionFailure;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSymbolRemoved", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSymbolCompleteFailed", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void uninstall()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$CompletionFailure;)V", "public abstract")]
		void handleAPICompletionFailure(Dova.JDK.com.sun.tools.javac.code.Symbol.CompletionFailure arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "public abstract")]
		void classSymbolRemoved(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V", "public abstract")]
		void classSymbolCompleteFailed(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void install()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$DeferredCompleter;", "private")]
	public partial class DeferredCompleter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DeferredCompleter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$DeferredCompleter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origCompleter", "Lcom/sun/tools/javac/code/Symbol$Completer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;Lcom/sun/tools/javac/code/Symbol$Completer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$Completer;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.Completer origCompleter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.Completer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DeferredCompleter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;Lcom/sun/tools/javac/code/Symbol$Completer;)V", "public")]
		public DeferredCompleter(Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$DeferredCompleter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void complete(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$FlipSymbolDescription;", "private static")]
	public partial class FlipSymbolDescription
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FlipSymbolDescription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$FlipSymbolDescription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "members", "Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completer", "Lcom/sun/tools/javac/code/Symbol$Completer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flip", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope members_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$Completer;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.Completer completer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.Completer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FlipSymbolDescription(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/code/Symbol$Completer;)V", "public")]
		public FlipSymbolDescription(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler$FlipSymbolDescription;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flip()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
