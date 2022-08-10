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

namespace Dova.JDK.com.sun.tools.javac.code;

[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope;", "public abstract")]
public partial class Scope
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Scope()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "owner", "Lcom/sun/tools/javac/code/Symbol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "noFilter", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "listeners", "Lcom/sun/tools/javac/code/Scope$ScopeListenerList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Scope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "anyMatch", "(Ljava/util/function/Predicate;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findFirst", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findFirst", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "includes", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "includes", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope$LookupKind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol owner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private static final")]
	public static Dova.JDK.java.util.function.Predicate noFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeListenerList;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Scope.ScopeListenerList listeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.ScopeListenerList>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Scope(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "protected")]
	public Scope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public")]
	public bool anyMatch(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Symbol;", "public final")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol findFirst(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol findFirst(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public abstract")]
	public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public abstract")]
	public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;)Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getSymbols()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public abstract")]
	public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
	public bool includes(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope$LookupKind;)Z", "public")]
	public bool includes(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public abstract")]
	public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeListenerList;", "public static")]
	public partial class ScopeListenerList
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScopeListenerList()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ScopeListenerList;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "listeners", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopeListenerList", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "add", "(Lcom/sun/tools/javac/code/Scope$ScopeListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolAdded", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolRemoved", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "walkReferences", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;Z)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List listeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ScopeListenerList(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ScopeListenerList() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$ScopeListenerList;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$ScopeListener;)V", "")]
		public void add(Dova.JDK.com.sun.tools.javac.code.Scope.ScopeListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "")]
		public void symbolAdded(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "")]
		public void symbolRemoved(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;Z)V", "private")]
		public void walkReferences(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$LookupKind;", "public static final")]
	public partial class LookupKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LookupKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$LookupKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RECURSIVE", "Lcom/sun/tools/javac/code/Scope$LookupKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NON_RECURSIVE", "Lcom/sun/tools/javac/code/Scope$LookupKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Scope$LookupKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LookupKind", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/code/Scope$LookupKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Scope$LookupKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/code/Scope$LookupKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$LookupKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind RECURSIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$LookupKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind NON_RECURSIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Scope$LookupKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LookupKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public LookupKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$LookupKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Scope$LookupKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Scope$LookupKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Scope$LookupKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ErrorScope;", "public static")]
	public partial class ErrorScope
		: Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ErrorScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ErrorScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ErrorScope", "(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ErrorScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lookup", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "anyMatch", "(Ljava/util/function/Predicate;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findFirst", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dup", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "includes", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dupUnshared", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enterIfAbsent", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leave", "()Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enter", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ErrorScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;)V", "")]
		public ErrorScope(Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.Entry> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public ErrorScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$ErrorScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public volatile")]
		public void remove(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry lookup(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public volatile")]
		public bool anyMatch(Dova.JDK.java.util.function.Predicate arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol findFirst(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dup(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public volatile")]
		public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public volatile")]
		public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public volatile")]
		public bool includes(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public volatile")]
		public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dupUnshared(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public volatile")]
		public void enterIfAbsent(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope leave()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public volatile")]
		public void enter(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$CompoundScope;", "public static")]
	public partial class CompoundScope
		: Dova.JDK.com.sun.tools.javac.code.Scope
		, Dova.JDK.com.sun.tools.javac.code.Scope.ScopeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompoundScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$CompoundScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "subScopes", "Lcom/sun/tools/javac/util/ListBuffer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "mark", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CompoundScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMark", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendSubScope", "(Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolAdded", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolRemoved", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "prependSubScope", "(Lcom/sun/tools/javac/code/Scope;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/ListBuffer;", "")]
		public Dova.JDK.com.sun.tools.javac.util.ListBuffer subScopes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.ListBuffer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int mark_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompoundScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public CompoundScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$CompoundScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getMark()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;)V", "public")]
		public void appendSubScope(Dova.JDK.com.sun.tools.javac.code.Scope arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "public")]
		public void symbolAdded(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "public")]
		public void symbolRemoved(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;)V", "public")]
		public void prependSubScope(Dova.JDK.com.sun.tools.javac.code.Scope arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$FilterImportScope;", "private static")]
	public partial class FilterImportScope
		: Dova.JDK.com.sun.tools.javac.code.Scope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FilterImportScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$FilterImportScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "origin", "Lcom/sun/tools/javac/code/Scope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filterName", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filter", "Lcom/sun/tools/javac/code/Scope$ImportFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "imp", "Lcom/sun/tools/javac/tree/JCTree$JCImport;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cfHandler", "Ljava/util/function/BiConsumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FilterImportScope", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Types types_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Scope origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "private final")]
		public Dova.JDK.com.sun.tools.javac.util.Name filterName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ImportFilter;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.ImportFilter filter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.ImportFilter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCImport;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport imp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/BiConsumer;", "private final")]
		public Dova.JDK.java.util.function.BiConsumer cfHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FilterImportScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)V", "public")]
		public FilterImportScope(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.code.Scope.ImportFilter arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg4, Dova.JDK.java.util.function.BiConsumer arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$FilterImportScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isStaticallyImported()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$FilterImportScope$SymbolImporter;", "abstract")]
		public partial class SymbolImporter
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SymbolImporter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$FilterImportScope$SymbolImporter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "processed", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "delegates", "Lcom/sun/tools/javac/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inspectSuperTypes", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/tools/javac/code/Scope$FilterImportScope;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SymbolImporter", "(Lcom/sun/tools/javac/code/Scope$FilterImportScope;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doLookup", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Ljava/lang/Iterable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "importFrom", "(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
			}

			[JniSignatureAttribute("Ljava/util/Set;", "")]
			public Dova.JDK.java.util.Set processed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
			public Dova.JDK.com.sun.tools.javac.util.List delegates_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "final")]
			public bool inspectSuperTypes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$FilterImportScope;", "final")]
			public Dova.JDK.com.sun.tools.javac.code.Scope.FilterImportScope this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.FilterImportScope>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SymbolImporter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$FilterImportScope;Z)V", "public")]
			public SymbolImporter(Dova.JDK.com.sun.tools.javac.code.Scope.FilterImportScope arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$FilterImportScope$SymbolImporter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;)Ljava/lang/Iterable;", "abstract")]
			public Dova.JDK.java.lang.Iterable doLookup(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$TypeSymbol;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "")]
			public Dova.JDK.com.sun.tools.javac.util.List importFrom(Dova.JDK.com.sun.tools.javac.code.Symbol.TypeSymbol arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ImportFilter;", "public abstract static interface")]
	public partial interface ImportFilter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImportFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ImportFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accepts", "(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Symbol;)Z"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Symbol;)Z", "public abstract")]
		bool accepts(Dova.JDK.com.sun.tools.javac.code.Scope arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$StarImportScope;", "public static")]
	public partial class StarImportScope
		: Dova.JDK.com.sun.tools.javac.code.Scope.ImportScope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StarImportScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$StarImportScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StarImportScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "importAll", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isFilled", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StarImportScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public StarImportScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$StarImportScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)V", "public")]
		public void importAll(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1, Dova.JDK.com.sun.tools.javac.code.Scope.ImportFilter arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg3, Dova.JDK.java.util.function.BiConsumer arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFilled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$NamedImportScope;", "public static")]
	public partial class NamedImportScope
		: Dova.JDK.com.sun.tools.javac.code.Scope.ImportScope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedImportScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$NamedImportScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "name2Scopes", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NamedImportScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "appendScope", "(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalizeScope", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "importByName", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "importType", "(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map name2Scopes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedImportScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public NamedImportScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$NamedImportScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Scope appendScope(Dova.JDK.com.sun.tools.javac.code.Scope arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void finalizeScope()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Scope$ImportFilter;Lcom/sun/tools/javac/tree/JCTree$JCImport;Ljava/util/function/BiConsumer;)Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope importByName(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.code.Scope.ImportFilter arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg4, Dova.JDK.java.util.function.BiConsumer arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Scope;Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope importType(Dova.JDK.com.sun.tools.javac.code.Scope arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$NamedImportScope$SingleEntryScope;", "private static")]
		public partial class SingleEntryScope
			: Dova.JDK.com.sun.tools.javac.code.Scope
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SingleEntryScope()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$NamedImportScope$SingleEntryScope;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sym", "Lcom/sun/tools/javac/code/Symbol;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "content", "Lcom/sun/tools/javac/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "origin", "Lcom/sun/tools/javac/code/Scope;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SingleEntryScope", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "private final")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol sym_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private final")]
			public Dova.JDK.com.sun.tools.javac.util.List content_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope;", "private final")]
			public Dova.JDK.com.sun.tools.javac.code.Scope origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SingleEntryScope(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "public")]
			public SingleEntryScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, Dova.JDK.com.sun.tools.javac.code.Scope arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$NamedImportScope$SingleEntryScope;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
			public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
			public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
			public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ImportScope;", "public static")]
	public partial class ImportScope
		: Dova.JDK.com.sun.tools.javac.code.Scope.CompoundScope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImportScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ImportScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImportScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalizeScope", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "finalizeSingleScope", "(Lcom/sun/tools/javac/code/Scope;)Lcom/sun/tools/javac/code/Scope;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImportScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public ImportScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$ImportScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void finalizeScope()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope;)Lcom/sun/tools/javac/code/Scope;", "protected")]
		public Dova.JDK.com.sun.tools.javac.code.Scope finalizeSingleScope(Dova.JDK.com.sun.tools.javac.code.Scope arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "private static")]
	public partial class Entry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Entry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sym", "Lcom/sun/tools/javac/code/Symbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "shadowed", "Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextSibling", "Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "prevSibling", "Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "scope", "Lcom/sun/tools/javac/code/Scope$ScopeImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Entry", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope$Entry;Lcom/sun/tools/javac/code/Scope$Entry;Lcom/sun/tools/javac/code/Scope$ScopeImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()Lcom/sun/tools/javac/code/Scope$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "(Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Scope$Entry;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "private")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry shadowed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry nextSibling_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry prevSibling_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeImpl;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl scope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope$Entry;Lcom/sun/tools/javac/code/Scope$Entry;Lcom/sun/tools/javac/code/Scope$ScopeImpl;)V", "public")]
		public Entry(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope.Entry arg1, Dova.JDK.com.sun.tools.javac.code.Scope.Entry arg2, Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry next(Dova.JDK.java.util.function.Predicate arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeImpl;", "private static")]
	public partial class ScopeImpl
		: Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScopeImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ScopeImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "shared", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "next", "Lcom/sun/tools/javac/code/Scope$ScopeImpl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "table", "[Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hashMask", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "elems", "Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nelems", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "removeCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "sentinel", "Lcom/sun/tools/javac/code/Scope$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INITIAL_SIZE", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopeImpl", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopeImpl", "(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ScopeImpl", "(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lookup", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lookup", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Scope$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "anyMatch", "(Ljava/util/function/Predicate;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIndex", "(Lcom/sun/tools/javac/util/Name;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findFirst", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dup", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbolsByName", "(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSymbols", "(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "includes", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isStaticallyImported", "(Lcom/sun/tools/javac/code/Symbol;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dupUnshared", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enterIfAbsent", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leave", "()Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enter", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dble", "()V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int shared_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeImpl;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Scope$Entry;", "")]
		public JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.Entry> table_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int hashMask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry elems_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int nelems_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "")]
		public int removeCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$Entry;", "private static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Scope.Entry sentinel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int INITIAL_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ScopeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public ScopeImpl(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;I)V", "private")]
		public ScopeImpl(Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.Entry> arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Scope$ScopeImpl;Lcom/sun/tools/javac/code/Symbol;[Lcom/sun/tools/javac/code/Scope$Entry;)V", "private")]
		public ScopeImpl(Dova.JDK.com.sun.tools.javac.code.Scope.ScopeImpl arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1, JavaArray<Dova.JDK.com.sun.tools.javac.code.Scope.Entry> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$ScopeImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void remove(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/code/Scope$Entry;", "protected")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry lookup(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Scope$Entry;", "protected")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.Entry lookup(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.Entry>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;)Z", "public")]
		public bool anyMatch(Dova.JDK.java.util.function.Predicate arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)I", "")]
		public int getIndex(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;)Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol findFirst(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dup(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope getOrigin(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbolsByName(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/tools/javac/code/Scope$LookupKind;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getSymbols(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.tools.javac.code.Scope.LookupKind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool includes(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Z", "public")]
		public bool isStaticallyImported(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dupUnshared(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void enterIfAbsent(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope leave()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void enter(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void dble()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public abstract static")]
	public partial class WriteableScope
		: Dova.JDK.com.sun.tools.javac.code.Scope
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WriteableScope()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$WriteableScope;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "WriteableScope", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dup", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dup", "()Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dupUnshared", "()Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dupUnshared", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enterIfAbsent", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "leave", "()Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "enter", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WriteableScope(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public WriteableScope(Dova.JDK.com.sun.tools.javac.code.Symbol arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Scope$WriteableScope;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public abstract")]
		public void remove(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope create(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dup(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public final")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dupUnshared()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope dupUnshared(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public abstract")]
		public void enterIfAbsent(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope leave()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public abstract")]
		public void enter(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$ScopeListener;", "public abstract static interface")]
	public partial interface ScopeListener
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScopeListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Scope$ScopeListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolAdded", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "symbolRemoved", "(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "public abstract")]
		void symbolAdded(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;Lcom/sun/tools/javac/code/Scope;)V", "public abstract")]
		void symbolRemoved(Dova.JDK.com.sun.tools.javac.code.Symbol arg0, Dova.JDK.com.sun.tools.javac.code.Scope arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}
	}
}
