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

namespace Dova.JDK.java.awt.font;

[JniSignatureAttribute("Ljava/awt/font/GlyphJustificationInfo;", "public final")]
public partial class GlyphJustificationInfo
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GlyphJustificationInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/font/GlyphJustificationInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIORITY_KASHIDA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIORITY_WHITESPACE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIORITY_INTERCHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIORITY_NONE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "weight", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "growPriority", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "growAbsorb", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "growLeftLimit", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "growRightLimit", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shrinkPriority", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shrinkAbsorb", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shrinkLeftLimit", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shrinkRightLimit", "F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FZIFFZIFF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "priorityIsValid", "(I)Z"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PRIORITY_KASHIDA_Property
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
	public static int PRIORITY_WHITESPACE_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int PRIORITY_INTERCHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int PRIORITY_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("F", "public final")]
	public float weight_Property
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

	[JniSignatureAttribute("I", "public final")]
	public int growPriority_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "public final")]
	public bool growAbsorb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("F", "public final")]
	public float growLeftLimit_Property
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

	[JniSignatureAttribute("F", "public final")]
	public float growRightLimit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int shrinkPriority_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "public final")]
	public bool shrinkAbsorb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("F", "public final")]
	public float shrinkLeftLimit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("F", "public final")]
	public float shrinkRightLimit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GlyphJustificationInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(FZIFFZIFF)V", "public")]
	public GlyphJustificationInfo(float arg0, bool arg1, int arg2, float arg3, float arg4, bool arg5, int arg6, float arg7, float arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/font/GlyphJustificationInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Z", "private static")]
	public static bool priorityIsValid(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
