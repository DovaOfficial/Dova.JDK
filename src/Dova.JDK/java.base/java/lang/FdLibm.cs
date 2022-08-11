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

namespace Dova.JDK.java.lang;

[JniSignatureAttribute("Ljava/lang/FdLibm;", "")]
public partial class FdLibm
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FdLibm()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/FdLibm;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INFINITY", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "__LO", "(DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "__LO", "(D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "__HI", "(D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "__HI", "(DI)D"));
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double INFINITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FdLibm(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public FdLibm() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/lang/FdLibm;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(DI)D", "private static")]
	public static double __LO(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)I", "private static")]
	public static int __LO(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)I", "private static")]
	public static int __HI(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DI)D", "private static")]
	public static double __HI(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljava/lang/FdLibm$Exp;", "static")]
	public partial class Exp
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Exp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/FdLibm$Exp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "one", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "half", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "huge", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "twom1000", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "o_threshold", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "u_threshold", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ln2HI", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ln2LO", "[D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "invln2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P1", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P2", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P3", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P4", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P5", "D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compute", "(D)D"));
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double one_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("[D", "private static final")]
		public static JavaArray<double> half_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double huge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double twom1000_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double o_threshold_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double u_threshold_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("[D", "private static final")]
		public static JavaArray<double> ln2HI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[D", "private static final")]
		public static JavaArray<double> ln2LO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double invln2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double P1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double P2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double P3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double P4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double P5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Exp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Exp() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/FdLibm$Exp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(D)D", "public static")]
		public static double compute(double arg0)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/FdLibm$Pow;", "public static")]
	public partial class Pow
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Pow()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/FdLibm$Pow;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compute", "(DD)D"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Pow(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Pow() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/FdLibm$Pow;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(DD)D", "public static")]
		public static double compute(double arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/FdLibm$Hypot;", "public static")]
	public partial class Hypot
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Hypot()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/FdLibm$Hypot;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TWO_MINUS_600", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TWO_PLUS_600", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compute", "(DD)D"));
		}

		[JniSignatureAttribute("D", "public static final")]
		public static double TWO_MINUS_600_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("D", "public static final")]
		public static double TWO_PLUS_600_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Hypot(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Hypot() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/FdLibm$Hypot;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(DD)D", "public static")]
		public static double compute(double arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/lang/FdLibm$Cbrt;", "public static")]
	public partial class Cbrt
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Cbrt()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/lang/FdLibm$Cbrt;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "C", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "E", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "F", "D"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "G", "D"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compute", "(D)D"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int B1_Property
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

		[JniSignatureAttribute("I", "private static final")]
		public static int B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double C_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double D_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double E_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double F_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("D", "private static final")]
		public static double G_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Cbrt(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Cbrt() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/lang/FdLibm$Cbrt;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(D)D", "public static")]
		public static double compute(double arg0)
		{
			var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
