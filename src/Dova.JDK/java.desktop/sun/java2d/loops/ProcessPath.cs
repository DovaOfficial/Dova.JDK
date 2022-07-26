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

namespace Dova.JDK.sun.java2d.loops;

[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath;", "public")]
public partial class ProcessPath
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProcessPath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PH_MODE_DRAW_CLIP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PH_MODE_FILL_CLIP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noopEndSubPathHandler", "Lsun/java2d/loops/ProcessPath$EndSubPathHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPER_BND", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWER_BND", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FWD_PREC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDP_PREC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDP_HALF_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPPER_OUT_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOWER_OUT_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALC_UBND", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALC_LBND", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EPSFX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EPSF", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDP_W_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MDP_F_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_CUB_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_QUAD_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_CUB_STEPS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_QUAD_STEPS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_CUB_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_QUAD_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_CUB_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_QUAD_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_CUB_DEC_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_CUB_INC_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_QUAD_DEC_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_QUAD_INC_BND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_A_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_B_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_C_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_A_MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_B_MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUB_C_MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUAD_A_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUAD_B_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUAD_A_MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUAD_B_MDP_MULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRES_MIN_CLIPPED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRES_MAX_CLIPPED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRES_NOT_CLIPPED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CRES_INVISIBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DF_MAX_POINT", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fillPath", "(Lsun/java2d/loops/ProcessPath$DrawHandler;Ljava/awt/geom/Path2D$Float;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawPath", "(Lsun/java2d/loops/ProcessPath$DrawHandler;Lsun/java2d/loops/ProcessPath$EndSubPathHandler;Ljava/awt/geom/Path2D$Float;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "drawPath", "(Lsun/java2d/loops/ProcessPath$DrawHandler;Ljava/awt/geom/Path2D$Float;II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doProcessPath", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;Ljava/awt/geom/Path2D$Float;FF)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "FillPolygon", "(Lsun/java2d/loops/ProcessPath$FillProcessHandler;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CLIP", "(FFFFD)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CLIP", "(IIIID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TESTANDCLIP", "(FF[FIIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "TESTANDCLIP", "(II[IIIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessMonotonicQuad", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DrawMonotonicQuad", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[FZ[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessFirstMonotonicPartOfQuad", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[IF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessMonotonicCubic", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "DrawMonotonicCubic", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[FZ[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessFirstMonotonicPartOfCubic", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[IF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "IS_CLIPPED", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CLIPCLAMP", "(FF[FIIIIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "CLIPCLAMP", "(II[IIIIIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessLine", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;FFFF[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessQuad", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ProcessCubic", "(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PH_MODE_DRAW_CLIP_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int PH_MODE_FILL_CLIP_Property
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

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$EndSubPathHandler;", "public static")]
	public static Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler noopEndSubPathHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float UPPER_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float LOWER_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FWD_PREC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MDP_PREC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MDP_HALF_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int UPPER_OUT_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LOWER_OUT_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float CALC_UBND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float CALC_LBND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int EPSFX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("F", "public static final")]
	public static float EPSF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MDP_W_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MDP_F_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_CUB_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_QUAD_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_CUB_STEPS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_QUAD_STEPS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_CUB_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_QUAD_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_CUB_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_QUAD_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_CUB_DEC_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_CUB_INC_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_QUAD_DEC_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_QUAD_INC_BND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_A_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_B_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_C_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_A_MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_B_MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CUB_C_MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int QUAD_A_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int QUAD_B_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int QUAD_A_MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int QUAD_B_MDP_MULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CRES_MIN_CLIPPED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CRES_MAX_CLIPPED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CRES_NOT_CLIPPED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CRES_INVISIBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DF_MAX_POINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProcessPath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ProcessPath() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;Ljava/awt/geom/Path2D$Float;II)Z", "public static")]
	public static bool fillPath(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;Lsun/java2d/loops/ProcessPath$EndSubPathHandler;Ljava/awt/geom/Path2D$Float;II)Z", "public static")]
	public static bool drawPath(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0, Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler arg1, Dova.JDK.java.awt.geom.Path2D.Float arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;Ljava/awt/geom/Path2D$Float;II)Z", "public static")]
	public static bool drawPath(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;Ljava/awt/geom/Path2D$Float;FF)Z", "private static")]
	public static bool doProcessPath(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, Dova.JDK.java.awt.geom.Path2D.Float arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$FillProcessHandler;I)V", "private static")]
	public static void FillPolygon(Dova.JDK.sun.java2d.loops.ProcessPath.FillProcessHandler arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(FFFFD)F", "private static")]
	public static float CLIP(float arg0, float arg1, float arg2, float arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(IIIID)I", "private static")]
	public static int CLIP(int arg0, int arg1, int arg2, int arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(FF[FIIII)I", "private static")]
	public static int TESTANDCLIP(float arg0, float arg1, JavaArray<float> arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(II[IIIII)I", "private static")]
	public static int TESTANDCLIP(int arg0, int arg1, JavaArray<int> arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V", "private static")]
	public static void ProcessMonotonicQuad(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[FZ[I)V", "private static")]
	public static void DrawMonotonicQuad(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, bool arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[IF)V", "private static")]
	public static void ProcessFirstMonotonicPartOfQuad(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2, float arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V", "private static")]
	public static void ProcessMonotonicCubic(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[FZ[I)V", "private static")]
	public static void DrawMonotonicCubic(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, bool arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[IF)V", "private static")]
	public static void ProcessFirstMonotonicPartOfCubic(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2, float arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)Z", "private static")]
	public static bool IS_CLIPPED(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(FF[FIIIIII)I", "private static")]
	public static int CLIPCLAMP(float arg0, float arg1, JavaArray<float> arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(II[IIIIIII)I", "private static")]
	public static int CLIPCLAMP(int arg0, int arg1, JavaArray<int> arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;FFFF[I)V", "private static")]
	public static void ProcessLine(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, float arg1, float arg2, float arg3, float arg4, JavaArray<int> arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V", "private static")]
	public static void ProcessQuad(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$ProcessHandler;[F[I)V", "private static")]
	public static void ProcessCubic(Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler arg0, JavaArray<float> arg1, JavaArray<int> arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$FillProcessHandler;", "private static")]
	public partial class FillProcessHandler
		: Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FillProcessHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$FillProcessHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fd", "Lsun/java2d/loops/ProcessPath$FillData;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/ProcessPath$DrawHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFixedLine", "(IIII[IZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processEndSubPath", "()V"));
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$FillData;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.FillData fd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.FillData>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FillProcessHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;)V", "")]
		public FillProcessHandler(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$FillProcessHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IIII[IZZ)V", "public")]
		public void processFixedLine(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, bool arg5, bool arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("()V", "public")]
		public void processEndSubPath()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$DrawHandler;", "public abstract static")]
	public partial class DrawHandler
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DrawHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$DrawHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xMin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yMin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xMax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yMax", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xMinf", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yMinf", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xMaxf", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yMaxf", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strokeControl", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIII)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawPixel", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawScanline", "(III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustBounds", "(IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawLine", "(IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIIII)V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int xMin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int yMin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int xMax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int yMax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float xMinf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float yMinf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float xMaxf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("F", "public")]
		public float yMaxf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int strokeControl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DrawHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IIII)V", "public")]
		public DrawHandler(int arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(IIIII)V", "public")]
		public DrawHandler(int arg0, int arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$DrawHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(II)V", "public abstract")]
		public void drawPixel(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(III)V", "public abstract")]
		public void drawScanline(int arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(IIII)V", "public")]
		public void adjustBounds(int arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(IIII)V", "public abstract")]
		public void drawLine(int arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(IIII)V", "public")]
		public void setBounds(int arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(IIIII)V", "public")]
		public void setBounds(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$ProcessHandler;", "public abstract static")]
	public partial class ProcessHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProcessHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$ProcessHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dhnd", "Lsun/java2d/loops/ProcessPath$DrawHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clipMode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/ProcessPath$DrawHandler;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFixedLine", "(IIII[IZZ)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$DrawHandler;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler dhnd_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int clipMode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProcessHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;I)V", "public")]
		public ProcessHandler(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$ProcessHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IIII[IZZ)V", "public abstract")]
		public void processFixedLine(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, bool arg5, bool arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$DrawProcessHandler;", "private static")]
	public partial class DrawProcessHandler
		: Dova.JDK.sun.java2d.loops.ProcessPath.ProcessHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DrawProcessHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$DrawProcessHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processESP", "Lsun/java2d/loops/ProcessPath$EndSubPathHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/ProcessPath$DrawHandler;Lsun/java2d/loops/ProcessPath$EndSubPathHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processFixedLine", "(IIII[IZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processEndSubPath", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "PROCESS_POINT", "(IIZ[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "PROCESS_LINE", "(IIIIZ[I)V"));
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$EndSubPathHandler;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler processESP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DrawProcessHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$DrawHandler;Lsun/java2d/loops/ProcessPath$EndSubPathHandler;)V", "public")]
		public DrawProcessHandler(Dova.JDK.sun.java2d.loops.ProcessPath.DrawHandler arg0, Dova.JDK.sun.java2d.loops.ProcessPath.EndSubPathHandler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$DrawProcessHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IIII[IZZ)V", "public")]
		public void processFixedLine(int arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, bool arg5, bool arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("()V", "public")]
		public void processEndSubPath()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(IIZ[I)V", "")]
		public void PROCESS_POINT(int arg0, int arg1, bool arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(IIIIZ[I)V", "")]
		public void PROCESS_LINE(int arg0, int arg1, int arg2, int arg3, bool arg4, JavaArray<int> arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$EndSubPathHandler;", "public abstract static interface")]
	public partial interface EndSubPathHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EndSubPathHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$EndSubPathHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processEndSubPath", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void processEndSubPath()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$FillData;", "private static")]
	public partial class FillData
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FillData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$FillData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plgPnts", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plgYMin", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plgYMax", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnded", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPoint", "(IIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnded", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "")]
		public Dova.JDK.java.util.List plgPnts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int plgYMin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int plgYMax_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FillData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public FillData() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$FillData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEnded()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(IIZ)V", "public")]
		public void addPoint(int arg0, int arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool setEnded()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Point;", "private static")]
	public partial class Point
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Point()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$Point;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastPoint", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Lsun/java2d/loops/ProcessPath$Point;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lsun/java2d/loops/ProcessPath$Point;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextByY", "Lsun/java2d/loops/ProcessPath$Point;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "edge", "Lsun/java2d/loops/ProcessPath$Edge;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIZ)V"));
		}

		[JniSignatureAttribute("I", "public")]
		public int x_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int y_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool lastPoint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Point;", "public")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Point prev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Point>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Point;", "public")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Point next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Point>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Point;", "public")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Point nextByY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Point>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Edge;", "public")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Edge edge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Edge>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Point(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IIZ)V", "public")]
		public Point(int arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$Point;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$ActiveEdgeList;", "private static")]
	public partial class ActiveEdgeList
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ActiveEdgeList()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$ActiveEdgeList;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "head", "Lsun/java2d/loops/ProcessPath$Edge;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Lsun/java2d/loops/ProcessPath$Point;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delete", "(Lsun/java2d/loops/ProcessPath$Edge;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sort", "()V"));
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Edge;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Edge head_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Edge>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ActiveEdgeList(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ActiveEdgeList() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$ActiveEdgeList;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$Point;I)V", "public")]
		public void insert(Dova.JDK.sun.java2d.loops.ProcessPath.Point arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEmpty()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$Edge;)V", "public")]
		public void delete(Dova.JDK.sun.java2d.loops.ProcessPath.Edge arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void sort()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Edge;", "private static")]
	public partial class Edge
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Edge()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/ProcessPath$Edge;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dx", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "p", "Lsun/java2d/loops/ProcessPath$Point;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prev", "Lsun/java2d/loops/ProcessPath$Edge;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lsun/java2d/loops/ProcessPath$Edge;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/ProcessPath$Point;III)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int x_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int dx_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Point;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Point p_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Point>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int dir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Edge;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Edge prev_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Edge>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/java2d/loops/ProcessPath$Edge;", "")]
		public Dova.JDK.sun.java2d.loops.ProcessPath.Edge next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.ProcessPath.Edge>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Edge(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/java2d/loops/ProcessPath$Point;III)V", "public")]
		public Edge(Dova.JDK.sun.java2d.loops.ProcessPath.Point arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/java2d/loops/ProcessPath$Edge;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
