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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/CoreMetrics;", "public final")]
public partial class CoreMetrics
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CoreMetrics()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/CoreMetrics;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ascent", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "descent", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "leading", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "height", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "baselineIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "baselineOffsets", "[F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "strikethroughOffset", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "strikethroughThickness", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "underlineOffset", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "underlineThickness", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ssOffset", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "italicAngle", "F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CoreMetrics", "(FFFFI[FFFFFFF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "get", "(Ljava/awt/font/LineMetrics;)Lsun/font/CoreMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Lsun/font/CoreMetrics;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "effectiveBaselineOffset", "([F)F"));
	}

	[JniSignatureAttribute("F", "public final")]
	public float ascent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float descent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float leading_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float height_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "public final")]
	public int baselineIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("[F", "public final")]
	public JavaArray<float> baselineOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("F", "public final")]
	public float strikethroughOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float strikethroughThickness_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float underlineOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float underlineThickness_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float ssOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("F", "public final")]
	public float italicAngle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CoreMetrics(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(FFFFI[FFFFFFF)V", "public")]
	public CoreMetrics(float arg0, float arg1, float arg2, float arg3, int arg4, JavaArray<float> arg5, float arg6, float arg7, float arg8, float arg9, float arg10, float arg11) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/CoreMetrics;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/font/LineMetrics;)Lsun/font/CoreMetrics;", "public static")]
	public static Dova.JDK.sun.font.CoreMetrics get(Dova.JDK.java.awt.font.LineMetrics arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.CoreMetrics>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/font/CoreMetrics;)Z", "public")]
	public bool equals(Dova.JDK.sun.font.CoreMetrics arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("([F)F", "public")]
	public float effectiveBaselineOffset(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}
}
