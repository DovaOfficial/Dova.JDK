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

namespace Dova.JDK.sun.java2d.xr;

[JniSignatureAttribute("Lsun/java2d/xr/MaskTileManager;", "public")]
public partial class MaskTileManager
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MaskTileManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/MaskTileManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mainTile", "Lsun/java2d/xr/MaskTile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tileList", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allocatedTiles", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xTiles", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yTiles", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xrMgr", "Lsun/java2d/xr/XRCompositeManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "con", "Lsun/java2d/xr/XRBackend;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskPixmap", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskPicture", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maskGC", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/xr/XRCompositeManager;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uploadMask", "(IIII[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearUploadMask", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compositeSingleTile", "(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/MaskTile;Lsun/java2d/xr/DirtyRegion;ZIILsun/java2d/xr/XRColor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocTiles", "(Lsun/java2d/xr/DirtyRegion;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tileRects", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limitRectCoords", "(Lsun/java2d/xr/GrowableRectArray;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillMask", "(Lsun/java2d/xr/XRSurfaceData;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMainTile", "()Lsun/java2d/xr/MaskTile;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MASK_SIZE_Property
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

	[JniSignatureAttribute("Lsun/java2d/xr/MaskTile;", "")]
	public Dova.JDK.sun.java2d.xr.MaskTile mainTile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.MaskTile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
	public Dova.JDK.java.util.ArrayList tileList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int allocatedTiles_Property
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

	[JniSignatureAttribute("I", "")]
	public int xTiles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int yTiles_Property
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

	[JniSignatureAttribute("Lsun/java2d/xr/XRCompositeManager;", "")]
	public Dova.JDK.sun.java2d.xr.XRCompositeManager xrMgr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRCompositeManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/java2d/xr/XRBackend;", "")]
	public Dova.JDK.sun.java2d.xr.XRBackend con_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRBackend>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int maskPixmap_Property
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

	[JniSignatureAttribute("I", "")]
	public int maskPicture_Property
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

	[JniSignatureAttribute("J", "")]
	public long maskGC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MaskTileManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRCompositeManager;I)V", "public")]
	public MaskTileManager(Dova.JDK.sun.java2d.xr.XRCompositeManager arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/MaskTileManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IIII[B)I", "public")]
	public int uploadMask(int arg0, int arg1, int arg2, int arg3, JavaArray<byte> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(III)V", "public")]
	public void clearUploadMask(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;Lsun/java2d/xr/MaskTile;Lsun/java2d/xr/DirtyRegion;ZIILsun/java2d/xr/XRColor;)V", "protected")]
	public void compositeSingleTile(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0, Dova.JDK.sun.java2d.xr.MaskTile arg1, Dova.JDK.sun.java2d.xr.DirtyRegion arg2, bool arg3, int arg4, int arg5, Dova.JDK.sun.java2d.xr.XRColor arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/DirtyRegion;)V", "protected")]
	public void allocTiles(Dova.JDK.sun.java2d.xr.DirtyRegion arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void tileRects()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/GrowableRectArray;I)V", "private")]
	public void limitRectCoords(Dova.JDK.sun.java2d.xr.GrowableRectArray arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/xr/XRSurfaceData;)V", "public")]
	public void fillMask(Dova.JDK.sun.java2d.xr.XRSurfaceData arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Lsun/java2d/xr/MaskTile;", "public")]
	public Dova.JDK.sun.java2d.xr.MaskTile getMainTile()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.MaskTile>(ret);
	}
}
