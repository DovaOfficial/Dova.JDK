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

namespace Dova.JDK.java.lang.constant;

[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc;", "public abstract interface")]
public partial interface DirectMethodHandleDesc
	: IJavaObject
	, Dova.JDK.java.lang.constant.MethodHandleDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DirectMethodHandleDesc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DirectMethodHandleDesc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "methodName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "kind", "()Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "refKind", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "owner", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lookupDescriptor", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isOwnerInterface", "()Z"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String methodName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public abstract")]
	Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind kind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int refKind()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public abstract")]
	Dova.JDK.java.lang.constant.ClassDesc owner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String lookupDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isOwnerInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DirectMethodHandleDesc$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STATIC", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERFACE_STATIC", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VIRTUAL", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERFACE_VIRTUAL", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPECIAL", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERFACE_SPECIAL", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTRUCTOR", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GETTER", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SETTER", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STATIC_GETTER", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STATIC_SETTER", "Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "refKind", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isInterface", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TABLE", "[Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Kind", "(Ljava/lang/String;IIZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Kind", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(IZ)Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(I)Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/lang/constant/DirectMethodHandleDesc$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isVirtualMethod", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "tableIndex", "(IZ)I"));
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind INTERFACE_STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind VIRTUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind INTERFACE_VIRTUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind SPECIAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind INTERFACE_SPECIAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind CONSTRUCTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind GETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind SETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind STATIC_GETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static final")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind STATIC_SETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "public final")]
		public int refKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("Z", "public final")]
		public bool isInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("[Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind> TABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IIZ)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/constant/DirectMethodHandleDesc$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static")]
		public static JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>>(ret);
		}

		[JniSignatureAttribute("(IZ)Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind valueOf(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "public static")]
		public static Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind valueOf(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/constant/DirectMethodHandleDesc$Kind;", "private static")]
		public static JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.DirectMethodHandleDesc.Kind>>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isVirtualMethod()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(IZ)I", "private static")]
		public static int tableIndex(int arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}
	}
}
