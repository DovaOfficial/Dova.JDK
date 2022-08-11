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

namespace Dova.JDK.javax.tools;

[JniSignatureAttribute("Ljavax/tools/JavaFileObject;", "public abstract interface")]
public partial interface JavaFileObject
	: IJavaObject
	, Dova.JDK.javax.tools.FileObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaFileObject()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/JavaFileObject;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestingKind", "()Ljavax/lang/model/element/NestingKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessLevel", "()Ljavax/lang/model/element/Modifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/tools/JavaFileObject$Kind;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "public abstract")]
	bool isNameCompatible(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/NestingKind;", "public abstract")]
	Dova.JDK.javax.lang.model.element.NestingKind getNestingKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.NestingKind>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/Modifier;", "public abstract")]
	Dova.JDK.javax.lang.model.element.Modifier getAccessLevel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Modifier>(ret);
	}

	[JniSignatureAttribute("()Ljavax/tools/JavaFileObject$Kind;", "public abstract")]
	Dova.JDK.javax.tools.JavaFileObject.Kind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileObject$Kind;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/JavaFileObject$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE", "Ljavax/tools/JavaFileObject$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljavax/tools/JavaFileObject$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTML", "Ljavax/tools/JavaFileObject$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER", "Ljavax/tools/JavaFileObject$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extension", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/tools/JavaFileObject$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/tools/JavaFileObject$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/tools/JavaFileObject$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/tools/JavaFileObject$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileObject$Kind;", "public static final")]
		public static Dova.JDK.javax.tools.JavaFileObject.Kind SOURCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileObject$Kind;", "public static final")]
		public static Dova.JDK.javax.tools.JavaFileObject.Kind CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileObject$Kind;", "public static final")]
		public static Dova.JDK.javax.tools.JavaFileObject.Kind HTML_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileObject$Kind;", "public static final")]
		public static Dova.JDK.javax.tools.JavaFileObject.Kind OTHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String extension_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/tools/JavaFileObject$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/tools/JavaFileObject$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/tools/JavaFileObject$Kind;", "public static")]
		public static JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/JavaFileObject$Kind;", "public static")]
		public static Dova.JDK.javax.tools.JavaFileObject.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/tools/JavaFileObject$Kind;", "private static")]
		public static JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.JavaFileObject.Kind>>(ret);
		}
	}
}
