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

namespace Dova.JDK.com.sun.tools.javac.util;

[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies;", "public abstract")]
public partial class Dependencies
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Dependencies()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dependenciesKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Dependencies", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/util/Dependencies;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "push", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pop", "()V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key dependenciesKey_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Dependencies(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Dependencies(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/util/Dependencies;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.Dependencies instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V", "public abstract")]
	public void push(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void pop()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$DummyDependencies;", "private static")]
	public partial class DummyDependencies
		: Dova.JDK.com.sun.tools.javac.util.Dependencies
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DummyDependencies()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$DummyDependencies;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DummyDependencies", "(Lcom/sun/tools/javac/util/Context;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "push", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pop", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DummyDependencies(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "private")]
		public DummyDependencies(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$DummyDependencies;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V", "public")]
		public void push(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "public")]
		public void pop()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;", "public static")]
	public partial class GraphDependencies
		: Dova.JDK.com.sun.tools.javac.util.Dependencies
		, Dova.JDK.java.io.Closeable
		, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GraphDependencies()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dependenciesModes", "Ljava/util/EnumSet;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dependenciesFile", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "nodeStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dependencyNodeMap", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GraphDependencies", "(Lcom/sun/tools/javac/util/Context;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "push", "(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "push", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pop", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "complete", "(Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNodes", "()Ljava/util/Collection;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isTerminal", "()Z"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "preRegister", "(Lcom/sun/tools/javac/util/Context;)V"));
		}

		[JniSignatureAttribute("Ljava/util/EnumSet;", "private")]
		public Dova.JDK.java.util.EnumSet dependenciesModes_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String dependenciesFile_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack nodeStack_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map dependencyNodeMap_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GraphDependencies(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "")]
		public GraphDependencies(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;", "protected")]
		public Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node push(Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;Lcom/sun/tools/javac/util/Dependencies$CompletionCause;)V", "public")]
		public void push(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "public")]
		public void pop()
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void complete(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/Collection;", "public")]
		public Dova.JDK.java.util.Collection getNodes()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTerminal()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "public static")]
		public static void preRegister(Dova.JDK.com.sun.tools.javac.util.Context arg0)
		{
			DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "static final")]
		public partial class DependenciesMode
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DependenciesMode()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOURCE", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REDUNDANT", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "opt", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DependenciesMode", "(Ljava/lang/String;ILjava/lang/String;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getDependenciesModes", "([Ljava/lang/String;)Ljava/util/EnumSet;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode SOURCE_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode CLASS_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode REDUNDANT_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/String;", "final")]
			public Dova.JDK.java.lang.String opt_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode> VALUES_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DependenciesMode(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
			public DependenciesMode(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode> values()
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$DependenciesMode;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode> _values()
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.DependenciesMode>>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/EnumSet;", "static")]
			public static Dova.JDK.java.util.EnumSet getDependenciesModes(JavaArray<Dova.JDK.java.lang.String> arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumSet>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode;", "public static")]
		public partial class CompletionNode
			: Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CompletionNode()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ck", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CompletionNode", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nodeAttributes", "()Ljava/util/Properties;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClassSymbol", "()Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind ck_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CompletionNode(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "")]
			public CompletionNode(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Properties;", "public")]
			public Dova.JDK.java.util.Properties nodeAttributes()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "public")]
			public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol getClassSymbol()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "static final")]
			public partial class Kind
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Kind()
				{
					ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;");
					ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SOURCE", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
					FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
					FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dotStyle", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
					ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Kind", "(Ljava/lang/String;ILjava/lang/String;)V"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
					MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
				}

				[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "public static final")]
				public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind SOURCE_Property
				{
					get
					{
						var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>(ret);
					}
					set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "public static final")]
				public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind CLASS_Property
				{
					get
					{
						var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>(ret);
					}
					set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("Ljava/lang/String;", "final")]
				public Dova.JDK.java.lang.String dotStyle_Property
				{
					get
					{
						var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "private static final")]
				public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind> VALUES_Property
				{
					get
					{
						var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>>(ret);
					}
					set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
				public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "public static")]
				public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind> values()
				{
					var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "public static")]
				public static Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>(ret);
				}

				[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "private static")]
				public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind> _values()
				{
					var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;", "public abstract static")]
		public partial class Node
			: Dova.JDK.com.sun.tools.javac.util.GraphUtils.AbstractNode
			, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DottableNode
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Node()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "depsByKind", "Ljava/util/EnumMap;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Node", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSupportedDependencyKinds", "()[Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDependenciesByKind", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Collection;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nodeAttributes", "()Ljava/util/Properties;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addDependency", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dependencyAttributes", "(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dependencyAttributes", "(Lcom/sun/tools/javac/util/GraphUtils$DottableNode;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;"));
			}

			[JniSignatureAttribute("Ljava/util/EnumMap;", "")]
			public Dova.JDK.java.util.EnumMap depsByKind_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.EnumMap>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Node(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "")]
			public Node(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;", "public")]
			public JavaArray<Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind> getSupportedDependencyKinds()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind>>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Collection;", "public")]
			public Dova.JDK.java.util.Collection getDependenciesByKind(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Properties;", "public")]
			public Dova.JDK.java.util.Properties nodeAttributes()
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;)V", "")]
			public void addDependency(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg1)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;", "public")]
			public Dova.JDK.java.util.Properties dependencyAttributes(Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg1)
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DottableNode;Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;)Ljava/util/Properties;", "public volatile")]
			public Dova.JDK.java.util.Properties dependencyAttributes(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DottableNode arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg1)
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Properties>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$PruneVisitor;", "private static")]
		public partial class PruneVisitor
			: Dova.JDK.com.sun.tools.javac.util.GraphUtils.NodeVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PruneVisitor()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$PruneVisitor;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PruneVisitor", "()V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitNode", "(Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitNode", "(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDependency", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/GraphUtils$Node;Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDependency", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PruneVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public PruneVisitor() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$PruneVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V", "public volatile")]
			public void visitNode(Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg0, Dova.JDK.java.lang.Object arg1)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V", "public")]
			public void visitNode(Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg0, Dova.JDK.java.lang.Void arg1)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/GraphUtils$Node;Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V", "public volatile")]
			public void visitDependency(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg1, Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg2, Dova.JDK.java.lang.Object arg3)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V", "public")]
			public void visitDependency(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg1, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg2, Dova.JDK.java.lang.Void arg3)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$FilterVisitor;", "private")]
		public partial class FilterVisitor
			: Dova.JDK.com.sun.tools.javac.util.GraphUtils.NodeVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FilterVisitor()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$FilterVisitor;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ck", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FilterVisitor", "(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitNode", "(Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitNode", "(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDependency", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/GraphUtils$Node;Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDependency", "(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;", "")]
			public Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind ck_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;", "final")]
			public Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies this0_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FilterVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$CompletionNode$Kind;)V", "private")]
			public FilterVisitor(Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.CompletionNode.Kind arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$FilterVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V", "public volatile")]
			public void visitNode(Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg0, Dova.JDK.java.lang.Object arg1)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V", "public")]
			public void visitNode(Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg0, Dova.JDK.java.lang.Void arg1)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/GraphUtils$Node;Lcom/sun/tools/javac/util/GraphUtils$Node;Ljava/lang/Object;)V", "public volatile")]
			public void visitDependency(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0, Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg1, Dova.JDK.com.sun.tools.javac.util.GraphUtils.Node arg2, Dova.JDK.java.lang.Object arg3)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/util/GraphUtils$DependencyKind;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Lcom/sun/tools/javac/util/Dependencies$GraphDependencies$Node;Ljava/lang/Void;)V", "public")]
			public void visitDependency(Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind arg0, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg1, Dova.JDK.com.sun.tools.javac.util.Dependencies.GraphDependencies.Node arg2, Dova.JDK.java.lang.Void arg3)
			{
				DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
	public partial class CompletionCause
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.com.sun.tools.javac.util.GraphUtils.DependencyKind
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionCause()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_READER", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HEADER_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HIERARCHY_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "IMPORTS_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEMBER_ENTER", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "RECORD_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MEMBERS_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PERMITS_PHASE", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER", "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CompletionCause", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause CLASS_READER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause HEADER_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause HIERARCHY_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause IMPORTS_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause MEMBER_ENTER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause RECORD_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause MEMBERS_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause PERMITS_PHASE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause OTHER_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompletionCause(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public CompletionCause(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Dependencies$CompletionCause;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/Dependencies$CompletionCause;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.Dependencies.CompletionCause>>(ret);
		}
	}
}
