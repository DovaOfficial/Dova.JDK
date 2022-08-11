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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/XRTextRenderer;", "public")]
public partial class XRTextRenderer
	: Dova.JDK.sun.java2d.pipe.GlyphListPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRTextRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/XRTextRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ELT_GLYPH_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "glyphCache", "Lsun/font/XRGlyphCache;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskBuffer", "Lsun/java2d/xr/XRCompositeManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "backend", "Lsun/java2d/xr/XRBackend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eltList", "Lsun/java2d/xr/GrowableEltArray;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRCompositeManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawGlyphList", "(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_ELT_GLYPH_COUNT_Property
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

	[JniSignatureAttribute("Lsun/font/XRGlyphCache;", "")]
	public Dova.JDK.sun.font.XRGlyphCache glyphCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.XRGlyphCache>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "")]
	public Dova.JDK.sun.java2d.xr.XRCompositeManager maskBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRBackend;", "")]
	public Dova.JDK.sun.java2d.xr.XRBackend backend_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRBackend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/GrowableEltArray;", "")]
	public Dova.JDK.sun.java2d.xr.GrowableEltArray eltList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.GrowableEltArray>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRTextRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRCompositeManager;)V", "public")]
	public XRTextRenderer(Dova.JDK.sun.java2d.xr.XRCompositeManager arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/XRTextRenderer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;)V", "protected")]
	public void drawGlyphList(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.font.GlyphList arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
