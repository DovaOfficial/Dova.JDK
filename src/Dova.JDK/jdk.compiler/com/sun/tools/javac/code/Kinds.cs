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

[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds;", "public")]
public partial class Kinds
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Kinds()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Kinds;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "kindName", "(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Kinds$KindName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "kindName", "(Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;)Lcom/sun/tools/javac/code/Kinds$KindName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typeKindName", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Kinds$KindName;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Kinds(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Kinds() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Kinds;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)Lcom/sun/tools/javac/code/Kinds$KindName;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName kindName(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;)Lcom/sun/tools/javac/code/Kinds$KindName;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName kindName(Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/code/Kinds$KindName;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName typeKindName(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
	public partial class KindName
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.com.sun.tools.javac.api.Formattable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KindName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Kinds$KindName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEVAR", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOUND", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC_INIT", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE_INIT", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_COMPONENT", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Kinds$KindName;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Ljava/util/Locale;Lcom/sun/tools/javac/api/Messages;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Kinds$KindName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$KindName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Kinds$KindName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName CONSTRUCTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName ENUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName TYPEVAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName BOUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName VAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName STATIC_INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName INSTANCE_INIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName MODULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName RECORD_COMPONENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName RECORD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Kinds$KindName;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KindName(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public KindName(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Kinds$KindName;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Locale;Lcom/sun/tools/javac/api/Messages;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString(Dova.JDK.java.util.Locale arg0, Dova.JDK.com.sun.tools.javac.api.Messages arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$KindName;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$KindName;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindName valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$KindName;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static")]
	public partial class KindSelector
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KindSelector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Kinds$KindSelector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NIL", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PCK", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYP", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MTH", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POLY", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDL", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERR", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASG", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYP_PCK", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL_MTH", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL_POLY", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL_TYP", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAL_TYP_PCK", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Lcom/sun/tools/javac/code/Kinds$KindSelector;)Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subset", "(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kindNames", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector NIL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector PCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector TYP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector MTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector POLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector MDL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector ERR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector TYP_PCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAL_MTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAL_POLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAL_TYP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector VAL_TYP_PCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("B", "private final")]
		public byte data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KindSelector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public KindSelector(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Kinds$KindSelector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Lcom/sun/tools/javac/code/Kinds$KindSelector;)Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public static transient")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector of(JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z", "public")]
		public bool subset(Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set kindNames()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Kinds$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NIL", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PCK", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYP", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MTH", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POLY", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDL", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERR", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMBIGUOUS", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIDDEN", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATICERR", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MISSING_ENCL", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAD_RESTRICTED_TYPE", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSENT_VAR", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRONG_MTHS", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRONG_MTH", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSENT_MTH", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSENT_TYP", "Lcom/sun/tools/javac/code/Kinds$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kindName", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "absentKind", "Lcom/sun/tools/javac/code/Kinds$KindName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selector", "Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "category", "Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Kinds$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Kinds$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Kinds$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "betterThan", "(Lcom/sun/tools/javac/code/Kinds$Kind;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolutionError", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "kindName", "()Lcom/sun/tools/javac/code/Kinds$KindName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "absentKind", "()Lcom/sun/tools/javac/code/Kinds$KindName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSelector", "()Lcom/sun/tools/javac/code/Kinds$KindSelector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolutionTargetError", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind NIL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind PCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind TYP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind MTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind POLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind MDL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind ERR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind AMBIGUOUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind HIDDEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind STATICERR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind MISSING_ENCL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind BAD_RESTRICTED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind ABSENT_VAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind WRONG_MTHS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind WRONG_MTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind ABSENT_MTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind ABSENT_TYP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindName kindName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindName;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindName absentKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$KindSelector;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector selector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "private final")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category category_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Kinds$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category arg2, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category arg2, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindName;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category arg2, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg3, Dova.JDK.com.sun.tools.javac.code.Kinds.KindName arg4, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;Lcom/sun/tools/javac/code/Kinds$KindSelector;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category arg2, Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/code/Kinds$Kind$Category;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Kinds$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$Kind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$Kind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$KindSelector;)Z", "public")]
		public bool matches(Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$Kind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Kinds$Kind;)Z", "public")]
		public bool betterThan(Dova.JDK.com.sun.tools.javac.code.Kinds.Kind arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isResolutionError()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Kinds$KindName;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindName kindName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Kinds$KindName;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindName absentKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindName>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Kinds$KindSelector;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector toSelector()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.KindSelector>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isResolutionTargetError()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "private static final")]
		public partial class Category
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Category()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/code/Kinds$Kind$Category;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASIC", "Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLUTION", "Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLUTION_TARGET", "Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/code/Kinds$Kind$Category;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category BASIC_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category ERROR_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category RESOLUTION_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category RESOLUTION_TARGET_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Category(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Category(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/code/Kinds$Kind$Category;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/code/Kinds$Kind$Category;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.code.Kinds.Kind.Category>>(ret);
			}
		}
	}
}
