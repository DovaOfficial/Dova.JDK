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

namespace Dova.JDK.com.sun.tools.javac.comp;

[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MatchBindingsComputer;", "public")]
public partial class MatchBindingsComputer
	: Dova.JDK.com.sun.tools.javac.tree.TreeScanner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MatchBindingsComputer()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/comp/MatchBindingsComputer;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY", "Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "matchBindingsComputerKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MatchBindingsComputer", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/MatchBindingsComputer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "union", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;[Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "binary", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "andOperation", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "finishBindings", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "switchCase", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "conditional", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "unary", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "guardedPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "intersection", "(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings EMPTY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key matchBindingsComputerKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MatchBindingsComputer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public MatchBindingsComputer(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/MatchBindingsComputer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/comp/MatchBindingsComputer;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;[Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private final transient")]
	public Dova.JDK.com.sun.tools.javac.util.List union(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, JavaArray<Dova.JDK.com.sun.tools.javac.util.List> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings binary(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings andOperation(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings finishBindings(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings switchCase(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings conditional(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg2, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings unary(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;)Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings guardedPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCGuardPattern arg0, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg1, Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.MatchBindingsComputer.MatchBindings>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List intersection(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;", "public static")]
	public partial class MatchBindings
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MatchBindings()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bindingsWhenTrue", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bindingsWhenFalse", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nullPattern", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MatchBindings", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MatchBindings", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Z)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.List bindingsWhenTrue_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.List bindingsWhenFalse_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "public final")]
		public bool nullPattern_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MatchBindings(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "public")]
		public MatchBindings(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Z)V", "public")]
		public MatchBindings(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, bool arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/comp/MatchBindingsComputer$MatchBindings;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
