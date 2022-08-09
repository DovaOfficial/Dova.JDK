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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/TreeDissector;", "")]
public partial class TreeDissector
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreeDissector()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/TreeDissector;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bt", "Ljdk/jshell/TaskFactory$BaseTask;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "targetClass", "Lcom/sun/source/tree/ClassTree;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "targetCompilationUnit", "Lcom/sun/source/tree/CompilationUnitTree;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "theSourcePositions", "Lcom/sun/source/util/SourcePositions;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "isClassOrInterface", "Ljava/util/function/Predicate;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TreeDissector", "(Ljdk/jshell/TaskFactory$BaseTask;Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/ClassTree;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "signature", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Type$MethodType;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "method", "(Ljdk/jshell/MethodSnippet;)Lcom/sun/source/tree/MethodTree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "classes", "(Ljava/lang/Iterable;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "classes", "(Lcom/sun/source/tree/CompilationUnitTree;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "types", "()Lcom/sun/tools/javac/code/Types;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "trees", "()Lcom/sun/source/util/Trees;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeToRange", "(Lcom/sun/source/tree/Tree;)Ljdk/jshell/Wrap$Range;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSourcePositions", "()Lcom/sun/source/util/SourcePositions;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createByFirstClass", "(Ljdk/jshell/TaskFactory$BaseTask;)Ljdk/jshell/TreeDissector;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "createBySnippet", "(Ljdk/jshell/TaskFactory$BaseTask;Ljdk/jshell/Snippet;)Ljdk/jshell/TreeDissector;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "treeListToRange", "(Ljava/util/List;)Ljdk/jshell/Wrap$Range;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "firstStatement", "()Lcom/sun/source/tree/StatementTree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "firstVariable", "()Lcom/sun/source/tree/VariableTree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "typeOfMethod", "(Ljdk/jshell/MethodSnippet;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "printType", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljdk/jshell/JShell;Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEndPosition", "(Lcom/sun/source/tree/Tree;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getStartPosition", "(Lcom/sun/source/tree/Tree;)I"));
	}

	[JniSignatureAttribute("Ljdk/jshell/TaskFactory$BaseTask;", "private final")]
	public Dova.JDK.jdk.jshell.TaskFactory.BaseTask bt_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.TaskFactory.BaseTask>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/ClassTree;", "private final")]
	public Dova.JDK.com.sun.source.tree.ClassTree targetClass_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ClassTree>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/CompilationUnitTree;", "private final")]
	public Dova.JDK.com.sun.source.tree.CompilationUnitTree targetCompilationUnit_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CompilationUnitTree>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/source/util/SourcePositions;", "private")]
	public Dova.JDK.com.sun.source.util.SourcePositions theSourcePositions_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.SourcePositions>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private static final")]
	public static Dova.JDK.java.util.function.Predicate isClassOrInterface_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TreeDissector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$BaseTask;Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/ClassTree;)V", "private")]
	public TreeDissector(Dova.JDK.jdk.jshell.TaskFactory.BaseTask arg0, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg1, Dova.JDK.com.sun.source.tree.ClassTree arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/TreeDissector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/code/Type$MethodType;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String signature(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.code.Type.MethodType arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/MethodSnippet;)Lcom/sun/source/tree/MethodTree;", "")]
	public Dova.JDK.com.sun.source.tree.MethodTree method(Dova.JDK.jdk.jshell.MethodSnippet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MethodTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/stream/Stream;", "private static")]
	public static Dova.JDK.java.util.stream.Stream classes(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;)Ljava/util/stream/Stream;", "private static")]
	public static Dova.JDK.java.util.stream.Stream classes(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Types;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Types types()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/Trees;", "")]
	public Dova.JDK.com.sun.source.util.Trees trees()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.Trees>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;)Ljdk/jshell/Wrap$Range;", "")]
	public Dova.JDK.jdk.jshell.Wrap.Range treeToRange(Dova.JDK.com.sun.source.tree.Tree arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap.Range>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/SourcePositions;", "")]
	public Dova.JDK.com.sun.source.util.SourcePositions getSourcePositions()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.SourcePositions>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$BaseTask;)Ljdk/jshell/TreeDissector;", "static")]
	public static Dova.JDK.jdk.jshell.TreeDissector createByFirstClass(Dova.JDK.jdk.jshell.TaskFactory.BaseTask arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.TreeDissector>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$BaseTask;Ljdk/jshell/Snippet;)Ljdk/jshell/TreeDissector;", "static")]
	public static Dova.JDK.jdk.jshell.TreeDissector createBySnippet(Dova.JDK.jdk.jshell.TaskFactory.BaseTask arg0, Dova.JDK.jdk.jshell.Snippet arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.TreeDissector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljdk/jshell/Wrap$Range;", "")]
	public Dova.JDK.jdk.jshell.Wrap.Range treeListToRange(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap.Range>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "")]
	public Dova.JDK.com.sun.source.tree.StatementTree firstStatement()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "")]
	public Dova.JDK.com.sun.source.tree.VariableTree firstVariable()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/MethodSnippet;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String typeOfMethod(Dova.JDK.jdk.jshell.MethodSnippet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljdk/jshell/JShell;Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String printType(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.jdk.jshell.JShell arg1, Dova.JDK.javax.lang.model.type.TypeMirror arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;)I", "")]
	public int getEndPosition(Dova.JDK.com.sun.source.tree.Tree arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;)I", "")]
	public int getStartPosition(Dova.JDK.com.sun.source.tree.Tree arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/jshell/TreeDissector$TDSignatureGenerator;", "private static")]
	public partial class TDSignatureGenerator
		: Dova.JDK.com.sun.tools.javac.code.Types.SignatureGenerator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TDSignatureGenerator()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/TreeDissector$TDSignatureGenerator;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "sb", "Ljava/lang/StringBuilder;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "TDSignatureGenerator", "(Lcom/sun/tools/javac/code/Types;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "append", "(C)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "append", "(Lcom/sun/tools/javac/util/Name;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "append", "([B)V"));
		}

		[JniSignatureAttribute("Ljava/lang/StringBuilder;", "")]
		public Dova.JDK.java.lang.StringBuilder sb_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TDSignatureGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)V", "")]
		public TDSignatureGenerator(Dova.JDK.com.sun.tools.javac.code.Types arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/TreeDissector$TDSignatureGenerator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(C)V", "protected")]
		public void append(char arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)V", "protected")]
		public void append(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([B)V", "protected")]
		public void append(JavaArray<byte> arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
