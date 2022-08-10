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

[JniSignatureAttribute("Ljava/lang/constant/DynamicConstantDesc;", "public abstract")]
public partial class DynamicConstantDesc
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.constant.ConstantDesc
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DynamicConstantDesc()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DynamicConstantDesc;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bootstrapMethod", "Ljava/lang/constant/DirectMethodHandleDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bootstrapArgs", "[Ljava/lang/constant/ConstantDesc;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "constantName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "constantType", "Ljava/lang/constant/ClassDesc;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DynamicConstantDesc", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/constant/DirectMethodHandleDesc;)Ljava/lang/constant/DynamicConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "resolveConstantDesc", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bootstrapMethod", "()Ljava/lang/constant/DirectMethodHandleDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ofNamed", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "constantType", "()Ljava/lang/constant/ClassDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "constantName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bootstrapArgs", "()[Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryCanonicalize", "()Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ofCanonical", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bootstrapArgsList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizeNull", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizeEnum", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizePrimitiveClass", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizeStaticFieldVarHandle", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizeFieldVarHandle", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canonicalizeArrayVarHandle", "(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;"));
	}

	[JniSignatureAttribute("Ljava/lang/constant/DirectMethodHandleDesc;", "private final")]
	public Dova.JDK.java.lang.constant.DirectMethodHandleDesc bootstrapMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/constant/ConstantDesc;", "private final")]
	public JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> bootstrapArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ConstantDesc>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String constantName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/constant/ClassDesc;", "private final")]
	public Dova.JDK.java.lang.constant.ClassDesc constantType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DynamicConstantDesc(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)V", "protected transient")]
	public DynamicConstantDesc(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.ClassDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/constant/DynamicConstantDesc;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicConstantDesc;", "public static transient")]
	public static Dova.JDK.java.lang.constant.DynamicConstantDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;)Ljava/lang/constant/DynamicConstantDesc;", "public static")]
	public static Dova.JDK.java.lang.constant.DynamicConstantDesc of(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object resolveConstantDesc(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/DirectMethodHandleDesc;", "public")]
	public Dova.JDK.java.lang.constant.DirectMethodHandleDesc bootstrapMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DirectMethodHandleDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/DynamicConstantDesc;", "public static transient")]
	public static Dova.JDK.java.lang.constant.DynamicConstantDesc ofNamed(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.ClassDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.DynamicConstantDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ClassDesc;", "public")]
	public Dova.JDK.java.lang.constant.ClassDesc constantType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ClassDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String constantName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/constant/ConstantDesc;", "public")]
	public JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> bootstrapArgs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.constant.ConstantDesc>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/constant/ConstantDesc;", "private")]
	public Dova.JDK.java.lang.constant.ConstantDesc tryCanonicalize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)Ljava/lang/constant/ConstantDesc;", "public static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc ofCanonical(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.ClassDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List bootstrapArgsList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizeNull(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizeEnum(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizePrimitiveClass(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizeStaticFieldVarHandle(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizeFieldVarHandle(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/constant/DynamicConstantDesc;)Ljava/lang/constant/ConstantDesc;", "private static")]
	public static Dova.JDK.java.lang.constant.ConstantDesc canonicalizeArrayVarHandle(Dova.JDK.java.lang.constant.DynamicConstantDesc arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.constant.ConstantDesc>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/constant/DynamicConstantDesc$AnonymousDynamicConstantDesc;", "private static")]
	public partial class AnonymousDynamicConstantDesc
		: Dova.JDK.java.lang.constant.DynamicConstantDesc
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnonymousDynamicConstantDesc()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DynamicConstantDesc$AnonymousDynamicConstantDesc;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnonymousDynamicConstantDesc", "(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnonymousDynamicConstantDesc(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/constant/DirectMethodHandleDesc;Ljava/lang/String;Ljava/lang/constant/ClassDesc;[Ljava/lang/constant/ConstantDesc;)V", "transient")]
		public AnonymousDynamicConstantDesc(Dova.JDK.java.lang.constant.DirectMethodHandleDesc arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.constant.ClassDesc arg2, JavaArray<Dova.JDK.java.lang.constant.ConstantDesc> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/constant/DynamicConstantDesc$AnonymousDynamicConstantDesc;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/lang/constant/DynamicConstantDesc$CanonicalMapHolder;", "private static final")]
	public partial class CanonicalMapHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CanonicalMapHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/constant/DynamicConstantDesc$CanonicalMapHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CANONICAL_MAP", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CanonicalMapHolder", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "static final")]
		public static Dova.JDK.java.util.Map CANONICAL_MAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CanonicalMapHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CanonicalMapHolder() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/constant/DynamicConstantDesc$CanonicalMapHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
