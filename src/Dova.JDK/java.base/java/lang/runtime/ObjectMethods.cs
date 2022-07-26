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

namespace Dova.JDK.java.lang.runtime;

[JniSignatureAttribute("Ljava/lang/runtime/ObjectMethods;", "public")]
public partial class ObjectMethods
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjectMethods()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/runtime/ObjectMethods;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_STRING_CONCAT_SLOTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESCRIPTOR_MT", "Ljava/lang/invoke/MethodType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMES_MT", "Ljava/lang/invoke/MethodType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALSE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_IS_INSTANCE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_EQUALS", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECTS_EQUALS", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECTS_HASHCODE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECTS_TOSTRING", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_EQ", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_HASHCODE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_TO_STRING", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING_FORMAT", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HASH_COMBINER", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveEquals", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveHashers", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveToString", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "split", "([Ljava/lang/invoke/MethodHandle;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(JJ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(FF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(ZZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(BB)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(SS)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(CC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eq", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasher", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/invoke/TypeDescriptor;Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equalator", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeEquals", "(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeHashCode", "(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeToString", "(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/Class;[Ljava/lang/invoke/MethodHandle;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashCombiner", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringifier", "(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_STRING_CONCAT_SLOTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodType DESCRIPTOR_MT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodType;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodType NAMES_MT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle FALSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle ZERO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle CLASS_IS_INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_EQUALS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECTS_EQUALS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECTS_HASHCODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECTS_TOSTRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_EQ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_HASHCODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_TO_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle STRING_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle HASH_COMBINER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap primitiveEquals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap primitiveHashers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private static final")]
	public static Dova.JDK.java.util.HashMap primitiveToString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ObjectMethods(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ObjectMethods() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/runtime/ObjectMethods;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/invoke/MethodHandle;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List split(JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(JJ)Z", "private static")]
	public static bool eq(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(FF)Z", "private static")]
	public static bool eq(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "private static")]
	public static bool eq(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ZZ)Z", "private static")]
	public static bool eq(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(BB)Z", "private static")]
	public static bool eq(byte arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "private static")]
	public static bool eq(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(SS)Z", "private static")]
	public static bool eq(short arg0, short arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(CC)Z", "private static")]
	public static bool eq(char arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "private static")]
	public static bool eq(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle hasher(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/String;Ljava/lang/invoke/TypeDescriptor;Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/invoke/MethodHandle;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object bootstrap(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.invoke.TypeDescriptor arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle equalator(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeEquals(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeHashCode(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandles$Lookup;Ljava/lang/Class;[Ljava/lang/invoke/MethodHandle;Ljava/util/List;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle makeToString(Dova.JDK.java.lang.invoke.MethodHandles.Lookup arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.invoke.MethodHandle> arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(II)I", "private static")]
	public static int hashCombiner(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle stringifier(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}
}
