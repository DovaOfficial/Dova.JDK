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

[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
public partial class BoundMethodHandle
	: Dova.JDK.java.lang.invoke.MethodHandle
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BoundMethodHandle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/BoundMethodHandle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FIELD_COUNT_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FORM_EXPRESSION_THRESHOLD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPECIALIZER", "Ljava/lang/invoke/BoundMethodHandle$Specializer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BoundMethodHandle", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arg", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeReinvoker", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalProperties", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rebind", "()Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWith_0", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWith_1", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "editor", "()Ljava/lang/invoke/LambdaFormEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendL", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentL", "(ILjava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalValues_0", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalValues_1", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentI", "(II)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentJ", "(IJ)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentF", "(IF)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bindArgumentD", "(ID)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "speciesData", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesDataFor", "(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bindSingle", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bindSingle", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tooComplex", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fieldCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendI", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;I)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendJ", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;J)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendF", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;F)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendD", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;D)Ljava/lang/invoke/BoundMethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesData_L", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesData_LL", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesData_LLL", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesData_LLLL", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "speciesData_LLLLL", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FIELD_COUNT_THRESHOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FORM_EXPRESSION_THRESHOLD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$Specializer;", "static final")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer SPECIALIZER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BoundMethodHandle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)V", "")]
	public BoundMethodHandle(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/invoke/BoundMethodHandle;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object arg(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/BoundMethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle makeReinvoker(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object internalProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle rebind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWith_0(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/MethodHandle;", "volatile")]
	public Dova.JDK.java.lang.invoke.MethodHandle copyWith_1(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/LambdaFormEditor;", "")]
	public Dova.JDK.java.lang.invoke.LambdaFormEditor editor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.LambdaFormEditor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendL(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentL(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String internalValues_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "volatile")]
	public Dova.JDK.java.lang.Object internalValues_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentI(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(IJ)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentJ(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(IF)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentF(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(ID)Ljava/lang/invoke/BoundMethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle bindArgumentD(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesDataFor(Dova.JDK.java.lang.invoke.LambdaForm arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle bindSingle(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/invoke/LambdaForm$BasicType;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle bindSingle(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.invoke.LambdaForm.BasicType arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool tooComplex()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()I", "final")]
	public int fieldCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;I)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendI(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;J)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendJ(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;F)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendF(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;D)Ljava/lang/invoke/BoundMethodHandle;", "abstract")]
	public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendD(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData_L()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData_LL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData_LLL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData_LLLL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
	public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData_LLLLL()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
	}

	[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static final")]
	public partial class SpeciesData
		: Dova.JDK.java.lang.invoke.ClassSpecializer.SpeciesData
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SpeciesData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/BoundMethodHandle$SpeciesData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "extensions", "[Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SpeciesData", "(Ljava/lang/invoke/BoundMethodHandle$Specializer;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "extendWith", "(B)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveClassName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveTransformHelperArguments", "(Ljava/lang/invoke/MemberName;ILjava/util/List;Ljava/util/List;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveTypeString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "verifyTHAargs", "(Ljava/lang/invoke/MemberName;ILjava/util/List;Ljava/util/List;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveFieldTypes", "(Ljava/lang/Object;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveFieldTypes", "(Ljava/lang/String;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deriveTransformHelper", "(Ljava/lang/invoke/MemberName;I)Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("[Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "private final")]
		public JavaArray<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData> extensions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SpeciesData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle$Specializer;Ljava/lang/String;)V", "public")]
		public SpeciesData(Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/BoundMethodHandle$SpeciesData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(B)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData extendWith(byte arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String deriveClassName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;ILjava/util/List;Ljava/util/List;)Ljava/util/List;", "protected")]
		public Dova.JDK.java.util.List deriveTransformHelperArguments(Dova.JDK.java.lang.invoke.MemberName arg0, int arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String deriveTypeString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;ILjava/util/List;Ljava/util/List;)Z", "private")]
		public bool verifyTHAargs(Dova.JDK.java.lang.invoke.MemberName arg0, int arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/List;", "protected volatile")]
		public Dova.JDK.java.util.List deriveFieldTypes(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "protected")]
		public Dova.JDK.java.util.List deriveFieldTypes(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MemberName;I)Ljava/lang/invoke/MethodHandle;", "protected")]
		public Dova.JDK.java.lang.invoke.MethodHandle deriveTransformHelper(Dova.JDK.java.lang.invoke.MemberName arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$Specializer;", "static final")]
	public partial class Specializer
		: Dova.JDK.java.lang.invoke.ClassSpecializer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Specializer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/BoundMethodHandle$Specializer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPECIES_DATA_ACCESSOR", "Ljava/lang/invoke/MemberName;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BMH_TRANSFORMS", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TN_COPY_NO_EXTEND", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Specializer", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeFactory_0", "()Ljava/lang/invoke/ClassSpecializer$Factory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeFactory_1", "()Ljava/lang/invoke/BoundMethodHandle$Specializer$Factory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "topSpeciesKey_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "topSpeciesKey_1", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSpeciesData", "(Ljava/lang/Object;)Ljava/lang/invoke/ClassSpecializer$SpeciesData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSpeciesData", "(Ljava/lang/String;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MemberName;", "private static final")]
		public static Dova.JDK.java.lang.invoke.MemberName SPECIES_DATA_ACCESSOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MemberName>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/List;", "static final")]
		public static Dova.JDK.java.util.List BMH_TRANSFORMS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "static final")]
		public static int TN_COPY_NO_EXTEND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Specializer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Specializer() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/BoundMethodHandle$Specializer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/invoke/ClassSpecializer$Factory;", "protected volatile")]
		public Dova.JDK.java.lang.invoke.ClassSpecializer.Factory makeFactory_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.ClassSpecializer.Factory>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$Specializer$Factory;", "protected")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer.Factory makeFactory_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer.Factory>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object topSpeciesKey_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String topSpeciesKey_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/invoke/ClassSpecializer$SpeciesData;", "protected volatile")]
		public Dova.JDK.java.lang.invoke.ClassSpecializer.SpeciesData newSpeciesData(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.ClassSpecializer.SpeciesData>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "protected")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData newSpeciesData(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$Specializer$Factory;", "")]
		public partial class Factory
			: Dova.JDK.java.lang.invoke.ClassSpecializer.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/BoundMethodHandle$Specializer$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Factory", "(Ljava/lang/invoke/BoundMethodHandle$Specializer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "chooseFieldName", "(Ljava/lang/Class;I)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/invoke/BoundMethodHandle$Specializer;)V", "")]
			public Factory(Dova.JDK.java.lang.invoke.BoundMethodHandle.Specializer arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/lang/invoke/BoundMethodHandle$Specializer$Factory;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Class;I)Ljava/lang/String;", "protected")]
			public Dova.JDK.java.lang.String chooseFieldName(Dova.JDK.java.lang.Class arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$Species_L;", "private static final")]
	public partial class Species_L
		: Dova.JDK.java.lang.invoke.BoundMethodHandle
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Species_L()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/invoke/BoundMethodHandle$Species_L;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "argL0", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BMH_SPECIES", "Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Species_L", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "make", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWith_0", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWith_1", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendL", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "internalValues", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "speciesData", "()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendI", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;I)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendJ", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;J)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendF", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;F)Ljava/lang/invoke/BoundMethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyWithExtendD", "(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;D)Ljava/lang/invoke/BoundMethodHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object argL0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "static")]
		public static Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData BMH_SPECIES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Species_L(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)V", "private")]
		public Species_L(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/invoke/BoundMethodHandle$Species_L;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "static")]
		public static Dova.JDK.java.lang.invoke.BoundMethodHandle make(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWith_0(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;)Ljava/lang/invoke/MethodHandle;", "volatile")]
		public Dova.JDK.java.lang.invoke.MethodHandle copyWith_1(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;Ljava/lang/Object;)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendL(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "volatile")]
		public Dova.JDK.java.lang.Object internalValues()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/invoke/BoundMethodHandle$SpeciesData;", "")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData speciesData()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle.SpeciesData>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;I)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendI(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;J)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendJ(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, long arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;F)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendF(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, float arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljava/lang/invoke/LambdaForm;D)Ljava/lang/invoke/BoundMethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.BoundMethodHandle copyWithExtendD(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.java.lang.invoke.LambdaForm arg1, double arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.BoundMethodHandle>(ret);
		}
	}
}
