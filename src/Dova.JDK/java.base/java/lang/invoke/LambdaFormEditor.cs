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

namespace Dova.JDK.java.lang.invoke;

[JniSignatureAttribute("Ljava/lang/invoke/LambdaFormEditor;", "")]
public partial class LambdaFormEditor
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LambdaFormEditor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaFormEditor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lambdaForm", "Ljava/lang/invoke/LambdaForm;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BIND_ARG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ADD_ARG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DUP_ARG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPREAD_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILTER_ARG", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILTER_RETURN", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILTER_RETURN_TO_ZERO", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLLECT_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLLECT_ARGS_TO_VOID", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLLECT_ARGS_TO_ARRAY", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOLD_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOLD_ARGS_TO_VOID", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PERMUTE_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOCAL_TYPES", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOLD_SELECT_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOLD_SELECT_ARGS_TO_VOID", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILTER_SELECT_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REPEAT_FILTER_ARGS", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MIN_CACHE_ARRAY_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_CACHE_ARRAY_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LambdaFormEditor", "(Ljava/lang/invoke/LambdaForm;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "buffer", "()Ljava/lang/invoke/LambdaFormBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "spreadArgumentsForm", "(ILjava/lang/Class;I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "collectArgumentsForm", "(ILjava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentL", "(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lambdaFormEditor", "(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaFormEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dupArgumentForm", "(II)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addArgumentForm", "(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "permuteArgumentsForm", "(I[I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentI", "(Ljava/lang/invoke/BoundMethodHandle;II)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentJ", "(Ljava/lang/invoke/BoundMethodHandle;IJ)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentF", "(Ljava/lang/invoke/BoundMethodHandle;IF)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentD", "(Ljava/lang/invoke/BoundMethodHandle;ID)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filterReturnForm", "(Ljava/lang/invoke/LambdaForm$BasicType;Z)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filterRepeatedArgumentForm", "(Ljava/lang/invoke/LambdaForm$BasicType;[I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filterArgumentForm", "(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "collectReturnValueForm", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "foldArgumentsForm", "(IZLjava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "foldArgumentsForm", "(IZLjava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "filterArgumentsForm", "(ILjava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSpeciesData", "(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "oldSpeciesData", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentType", "(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentForm", "(I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInCache", "(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "putInCache", "(Ljava/lang/invoke/LambdaFormEditor$TransformKey;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeArgumentCombinationForm", "(ILjava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeArgumentCombinationForm", "(ILjava/lang/invoke/MethodType;[IZZ)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "formParametersMatch", "(Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/LambdaForm$BasicType;[I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeRepeatedFilterForm", "(Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "permutedTypesMatch", "([I[Ljava/lang/invoke/LambdaForm$BasicType;[Ljava/lang/invoke/LambdaForm$Name;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "noteLoopLocalTypesForm", "(I[Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;"));
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaForm;", "final")]
	public Dova.JDK.java.lang.invoke.LambdaForm lambdaForm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte BIND_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte ADD_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte DUP_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte SPREAD_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FILTER_ARG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FILTER_RETURN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FILTER_RETURN_TO_ZERO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte COLLECT_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte COLLECT_ARGS_TO_VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte COLLECT_ARGS_TO_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FOLD_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FOLD_ARGS_TO_VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte PERMUTE_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte LOCAL_TYPES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FOLD_SELECT_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FOLD_SELECT_ARGS_TO_VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte FILTER_SELECT_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("B", "private static final")]
	public static byte REPEAT_FILTER_ARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[18], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MIN_CACHE_ARRAY_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_CACHE_ARRAY_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[21], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LambdaFormEditor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;)V", "private")]
	public LambdaFormEditor(Dova.JDK.java.lang.invoke.LambdaForm arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaFormEditor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/invoke/LambdaFormBuffer;", "private")]
	public Dova.JDK.java.lang.invoke.LambdaFormBuffer buffer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormBuffer>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;I)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm spreadArgumentsForm(int arg0, Dova.JDK.java.lang.Class arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm collectArgumentsForm(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentL(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaFormEditor;", "static")]
	public static Dova.JDK.java.lang.invoke.LambdaFormEditor lambdaFormEditor(Dova.JDK.java.lang.invoke.LambdaForm arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm dupArgumentForm(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm addArgumentForm(int arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(I[I)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm permuteArgumentsForm(int arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;II)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentI(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;IJ)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentJ(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;IF)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentF(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;ID)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentD(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;Z)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm filterReturnForm(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;[I)Ljava/lang/invoke/LambdaForm;", "transient")]
	public Dova.JDK.java.lang.invoke.LambdaForm filterRepeatedArgumentForm(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm filterArgumentForm(int arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm collectReturnValueForm(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(IZLjava/lang/invoke/MethodType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm foldArgumentsForm(int arg0, bool arg1, Dova.JDK.java.lang.invoke.MethodType arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(IZLjava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;", "transient")]
	public Dova.JDK.java.lang.invoke.LambdaForm foldArgumentsForm(int arg0, bool arg1, Dova.JDK.java.lang.invoke.MethodType arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;", "transient")]
	public Dova.JDK.java.lang.invoke.LambdaForm filterArgumentsForm(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "private")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData newSpeciesData(Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "private")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData oldSpeciesData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle;ILjava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/MethodType;", "private")]
	public Dova.JDK.java.lang.invoke.MethodType bindArgumentType(Dova.JDK.java.lang.invoke.BoundMethodHandle arg0, int arg1, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm bindArgumentForm(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Ljava/lang/invoke/LambdaForm;", "private")]
	public Dova.JDK.java.lang.invoke.LambdaForm getInCache(Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$TransformKey;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaForm;", "private")]
	public Dova.JDK.java.lang.invoke.LambdaForm putInCache(Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;ZZ)Ljava/lang/invoke/LambdaForm;", "private")]
	public Dova.JDK.java.lang.invoke.LambdaForm makeArgumentCombinationForm(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1, bool arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/invoke/MethodType;[IZZ)Ljava/lang/invoke/LambdaForm;", "private")]
	public Dova.JDK.java.lang.invoke.LambdaForm makeArgumentCombinationForm(int arg0, Dova.JDK.java.lang.invoke.MethodType arg1, JavaArray<int> arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/LambdaForm$BasicType;[I)Z", "private transient")]
	public bool formParametersMatch(Dova.JDK.java.lang.invoke.LambdaForm arg0, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg1, JavaArray<int> arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;[I)Ljava/lang/invoke/LambdaForm;", "private transient")]
	public Dova.JDK.java.lang.invoke.LambdaForm makeRepeatedFilterForm(Dova.JDK.java.lang.invoke.MethodType arg0, JavaArray<int> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("([I[Ljava/lang/invoke/LambdaForm$BasicType;[Ljava/lang/invoke/LambdaForm$Name;I)Z", "static")]
	public static bool permutedTypesMatch(JavaArray<int> arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> arg1, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.Name> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(I[Ljava/lang/invoke/LambdaForm$BasicType;)Ljava/lang/invoke/LambdaForm;", "")]
	public Dova.JDK.java.lang.invoke.LambdaForm noteLoopLocalTypesForm(int arg0, JavaArray<Dova.JDK.java.lang.invoke.LambdaForm.BasicType> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaForm>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaFormEditor$Transform;", "private static final")]
	public partial class Transform
		: Dova.JDK.java.lang.@ref.SoftReference
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Transform()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaFormEditor$Transform;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "packedBytes", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fullBytes", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Transform", "(J[BLjava/lang/invoke/LambdaForm;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/invoke/LambdaFormEditor$Transform;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("J", "final")]
		public long packedBytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("[B", "final")]
		public JavaArray<byte> fullBytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Transform(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J[BLjava/lang/invoke/LambdaForm;)V", "private")]
		public Transform(long arg0, JavaArray<byte> arg1, Dova.JDK.java.lang.invoke.LambdaForm arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaFormEditor$Transform;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$Transform;)Z", "private")]
		public bool equals(Dova.JDK.java.lang.invoke.LambdaFormEditor.Transform arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Z", "private")]
		public bool equals(Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "private static final")]
	public partial class TransformKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TransformKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/LambdaFormEditor$TransformKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "packedBytes", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fullBytes", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NO_BYTES", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRESS_TEST", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKED_BYTE_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKED_BYTE_MASK", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKED_BYTE_MAX_LENGTH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TransformKey", "(J[B)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TransformKey", "([B)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TransformKey", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/invoke/LambdaFormEditor$Transform;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(BI)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(B[I)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(BII)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(BI[I)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(BIII)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(BII[B)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "withResult", "(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaFormEditor$Transform;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "packedBytes", "(II)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "packedBytes", "(IIII)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "packedBytes", "([B)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "packedBytes", "(III)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fullBytes", "([I)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bval", "(I)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "inRange", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ofBothArrays", "(B[I[B)Ljava/lang/invoke/LambdaFormEditor$TransformKey;"));
		}

		[JniSignatureAttribute("J", "final")]
		public long packedBytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("[B", "final")]
		public JavaArray<byte> fullBytes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[B", "private static final")]
		public static JavaArray<byte> NO_BYTES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool STRESS_TEST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PACKED_BYTE_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PACKED_BYTE_MASK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PACKED_BYTE_MAX_LENGTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TransformKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J[B)V", "private")]
		public TransformKey(long arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("([B)V", "private")]
		public TransformKey(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(J)V", "private")]
		public TransformKey(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/LambdaFormEditor$TransformKey;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$Transform;)Z", "private")]
		public bool equals(Dova.JDK.java.lang.invoke.LambdaFormEditor.Transform arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaFormEditor$TransformKey;)Z", "private")]
		public bool equals(Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(BI)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(B[I)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static transient")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, JavaArray<int> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(BII)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(BI[I)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, int arg1, JavaArray<int> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(BIII)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(BII[B)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey of(byte arg0, int arg1, int arg2, JavaArray<byte> arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/LambdaFormEditor$Transform;", "")]
		public Dova.JDK.java.lang.invoke.LambdaFormEditor.Transform withResult(Dova.JDK.java.lang.invoke.LambdaForm arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.Transform>(ret);
		}

		[JniSignatureAttribute("(II)J", "private static")]
		public static long packedBytes(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(IIII)J", "private static")]
		public static long packedBytes(int arg0, int arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("([B)J", "private static")]
		public static long packedBytes(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(III)J", "private static")]
		public static long packedBytes(int arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("([I)[B", "private static transient")]
		public static JavaArray<byte> fullBytes(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(I)B", "private static")]
		public static byte bval(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "private static")]
		public static bool inRange(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("(B[I[B)Ljava/lang/invoke/LambdaFormEditor$TransformKey;", "private static")]
		public static Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey ofBothArrays(byte arg0, JavaArray<int> arg1, JavaArray<byte> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor.TransformKey>(ret);
		}
	}
}
