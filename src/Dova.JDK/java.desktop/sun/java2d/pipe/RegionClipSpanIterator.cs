/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/RegionClipSpanIterator;", "public")]
public partial class RegionClipSpanIterator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.SpanIterator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RegionClipSpanIterator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/java2d/pipe/RegionClipSpanIterator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgn", "Lsun/java2d/pipe/Region;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanIter", "Lsun/java2d/pipe/SpanIterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "resetState", "Lsun/java2d/pipe/RegionIterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lwm", "Lsun/java2d/pipe/RegionIterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "row", "Lsun/java2d/pipe/RegionIterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "box", "Lsun/java2d/pipe/RegionIterator;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanlox", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanhix", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanloy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanhiy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lwmloy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lwmhiy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnlox", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnloy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnhix", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnhiy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnbndslox", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnbndsloy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnbndshix", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnbndshiy", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "rgnbox", "[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "spanbox", "[I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "doNextSpan", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "doNextBox", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "done", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RegionClipSpanIterator", "(Lsun/java2d/pipe/Region;Lsun/java2d/pipe/SpanIterator;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPathBox", "([I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "intersectClipBox", "(IIII)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNativeIterator", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nextSpan", "([I)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "skipDownTo", "(I)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/Region;", "")]
	public Dova.JDK.sun.java2d.pipe.Region rgn_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.Region>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/SpanIterator;", "")]
	public Dova.JDK.sun.java2d.pipe.SpanIterator spanIter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.SpanIterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RegionIterator;", "")]
	public Dova.JDK.sun.java2d.pipe.RegionIterator resetState_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RegionIterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RegionIterator;", "")]
	public Dova.JDK.sun.java2d.pipe.RegionIterator lwm_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RegionIterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RegionIterator;", "")]
	public Dova.JDK.sun.java2d.pipe.RegionIterator row_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RegionIterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RegionIterator;", "")]
	public Dova.JDK.sun.java2d.pipe.RegionIterator box_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RegionIterator>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "")]
	public int spanlox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "")]
	public int spanhix_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "")]
	public int spanloy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "")]
	public int spanhiy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("I", "")]
	public int lwmloy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("I", "")]
	public int lwmhiy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnlox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnloy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnhix_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnhiy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnbndslox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnbndsloy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnbndshix_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
	}

	[JniSignatureAttribute("I", "")]
	public int rgnbndshiy_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> rgnbox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> spanbox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "")]
	public bool doNextSpan_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[22], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool doNextBox_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
	}

	[JniSignatureAttribute("Z", "")]
	public bool done_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RegionClipSpanIterator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/Region;Lsun/java2d/pipe/SpanIterator;)V", "public")]
	public RegionClipSpanIterator(Dova.JDK.sun.java2d.pipe.Region arg0, Dova.JDK.sun.java2d.pipe.SpanIterator arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/RegionClipSpanIterator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([I)V", "public")]
	public void getPathBox(JavaArray<int> arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(IIII)V", "public")]
	public void intersectClipBox(int arg0, int arg1, int arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getNativeIterator()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("([I)Z", "public")]
	public bool nextSpan(JavaArray<int> arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void skipDownTo(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}