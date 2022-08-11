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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent;", "public final")]
public partial class TaskEvent
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TaskEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/TaskEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/source/util/TaskEvent$Kind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljavax/tools/JavaFileObject;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unit", "Lcom/sun/source/tree/CompilationUnitTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Ljavax/lang/model/element/TypeElement;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TaskEvent$Kind;Ljavax/tools/JavaFileObject;Lcom/sun/source/tree/CompilationUnitTree;Ljavax/lang/model/element/TypeElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TaskEvent$Kind;Lcom/sun/source/tree/CompilationUnitTree;Ljavax/lang/model/element/TypeElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TaskEvent$Kind;Lcom/sun/source/tree/CompilationUnitTree;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TaskEvent$Kind;Ljavax/tools/JavaFileObject;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TaskEvent$Kind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeElement", "()Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceFile", "()Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompilationUnit", "()Lcom/sun/source/tree/CompilationUnitTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/util/TaskEvent$Kind;"));
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "private")]
	public Dova.JDK.com.sun.source.util.TaskEvent.Kind kind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileObject;", "private")]
	public Dova.JDK.javax.tools.JavaFileObject file_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/CompilationUnitTree;", "private")]
	public Dova.JDK.com.sun.source.tree.CompilationUnitTree unit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CompilationUnitTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/element/TypeElement;", "private")]
	public Dova.JDK.javax.lang.model.element.TypeElement clazz_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TaskEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent$Kind;Ljavax/tools/JavaFileObject;Lcom/sun/source/tree/CompilationUnitTree;Ljavax/lang/model/element/TypeElement;)V", "private")]
	public TaskEvent(Dova.JDK.com.sun.source.util.TaskEvent.Kind arg0, Dova.JDK.javax.tools.JavaFileObject arg1, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg2, Dova.JDK.javax.lang.model.element.TypeElement arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent$Kind;Lcom/sun/source/tree/CompilationUnitTree;Ljavax/lang/model/element/TypeElement;)V", "public")]
	public TaskEvent(Dova.JDK.com.sun.source.util.TaskEvent.Kind arg0, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg1, Dova.JDK.javax.lang.model.element.TypeElement arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent$Kind;Lcom/sun/source/tree/CompilationUnitTree;)V", "public")]
	public TaskEvent(Dova.JDK.com.sun.source.util.TaskEvent.Kind arg0, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent$Kind;Ljavax/tools/JavaFileObject;)V", "public")]
	public TaskEvent(Dova.JDK.com.sun.source.util.TaskEvent.Kind arg0, Dova.JDK.javax.tools.JavaFileObject arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent$Kind;)V", "public")]
	public TaskEvent(Dova.JDK.com.sun.source.util.TaskEvent.Kind arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/TaskEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getTypeElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileObject;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject getSourceFile()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/CompilationUnitTree;", "public")]
	public Dova.JDK.com.sun.source.tree.CompilationUnitTree getCompilationUnit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CompilationUnitTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/TaskEvent$Kind;", "public")]
	public Dova.JDK.com.sun.source.util.TaskEvent.Kind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/TaskEvent$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSE", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENTER", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANALYZE", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERATE", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_PROCESSING", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_PROCESSING_ROUND", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPILATION", "Lcom/sun/source/util/TaskEvent$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/source/util/TaskEvent$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/source/util/TaskEvent$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/source/util/TaskEvent$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/source/util/TaskEvent$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind PARSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind ENTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind ANALYZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind GENERATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind ANNOTATION_PROCESSING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind ANNOTATION_PROCESSING_ROUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskEvent$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind COMPILATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/source/util/TaskEvent$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/source/util/TaskEvent$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/source/util/TaskEvent$Kind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/util/TaskEvent$Kind;", "public static")]
		public static Dova.JDK.com.sun.source.util.TaskEvent.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskEvent.Kind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/source/util/TaskEvent$Kind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.util.TaskEvent.Kind>>(ret);
		}
	}
}
