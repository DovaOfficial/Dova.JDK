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

namespace Dova.JDK.sun.java2d.marlin;

[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier;", "final")]
public partial class CollinearSimplifier
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.marlin.DPathConsumer2D
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CollinearSimplifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/CollinearSimplifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EPS", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lsun/java2d/marlin/DPathConsumer2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "px1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "py1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "px2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "py2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pslope", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Lsun/java2d/marlin/DPathConsumer2D;)Lsun/java2d/marlin/CollinearSimplifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveTo", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "quadTo", "(DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "curveTo", "(DDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pathDone", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeConsumer", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "closePath", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lineTo", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitStashedLine", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSlope", "(DDDD)D"));
	}

	[JniSignatureAttribute("D", "static final")]
	public static double EPS_Property
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

	[JniSignatureAttribute("Lsun/java2d/marlin/DPathConsumer2D;", "")]
	public Dova.JDK.sun.java2d.marlin.DPathConsumer2D @delegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.DPathConsumer2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "")]
	public Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState state_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("D", "")]
	public double px1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("D", "")]
	public double py1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("D", "")]
	public double px2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("D", "")]
	public double py2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("D", "")]
	public double pslope_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CollinearSimplifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public CollinearSimplifier() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/CollinearSimplifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/marlin/DPathConsumer2D;)Lsun/java2d/marlin/CollinearSimplifier;", "public")]
	public Dova.JDK.sun.java2d.marlin.CollinearSimplifier init(Dova.JDK.sun.java2d.marlin.DPathConsumer2D arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier>(ret);
	}

	[JniSignatureAttribute("(DD)V", "public")]
	public void moveTo(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(DDDD)V", "public")]
	public void quadTo(double arg0, double arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(DDDDDD)V", "public")]
	public void curveTo(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()V", "public")]
	public void pathDone()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getNativeConsumer()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void closePath()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(DD)V", "public")]
	public void lineTo(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void emitStashedLine()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(DDDD)D", "private static")]
	public static double getSlope(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "static final")]
	public partial class SimplifierState
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimplifierState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Empty", "Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PreviousPoint", "Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PreviousLine", "Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;"));
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState Empty_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState PreviousPoint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "public static final")]
		public static Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState PreviousLine_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "private static final")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimplifierState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public SimplifierState(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "public static")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "public static")]
		public static Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>(ret);
		}

		[JniSignatureAttribute("()[Lsun/java2d/marlin/CollinearSimplifier$SimplifierState;", "private static")]
		public static JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.java2d.marlin.CollinearSimplifier.SimplifierState>>(ret);
		}
	}
}
