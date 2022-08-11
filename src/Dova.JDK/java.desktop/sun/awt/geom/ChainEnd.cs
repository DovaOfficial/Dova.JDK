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

namespace Dova.JDK.sun.awt.geom;

[JniSignatureAttribute("Lsun/awt/geom/ChainEnd;", "final")]
public partial class ChainEnd
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ChainEnd()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/geom/ChainEnd;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "head", "Lsun/awt/geom/CurveLink;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tail", "Lsun/awt/geom/CurveLink;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "partner", "Lsun/awt/geom/ChainEnd;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "etag", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/geom/CurveLink;Lsun/awt/geom/ChainEnd;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "linkTo", "(Lsun/awt/geom/ChainEnd;)Lsun/awt/geom/CurveLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChain", "()Lsun/awt/geom/CurveLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOtherEnd", "(Lsun/awt/geom/ChainEnd;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPartner", "()Lsun/awt/geom/ChainEnd;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLink", "(Lsun/awt/geom/CurveLink;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX", "()D"));
	}

	[JniSignatureAttribute("Lsun/awt/geom/CurveLink;", "")]
	public Dova.JDK.sun.awt.geom.CurveLink head_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.CurveLink>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/geom/CurveLink;", "")]
	public Dova.JDK.sun.awt.geom.CurveLink tail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.CurveLink>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/geom/ChainEnd;", "")]
	public Dova.JDK.sun.awt.geom.ChainEnd partner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.ChainEnd>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int etag_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ChainEnd(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/geom/CurveLink;Lsun/awt/geom/ChainEnd;)V", "public")]
	public ChainEnd(Dova.JDK.sun.awt.geom.CurveLink arg0, Dova.JDK.sun.awt.geom.ChainEnd arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/geom/ChainEnd;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/geom/ChainEnd;)Lsun/awt/geom/CurveLink;", "public")]
	public Dova.JDK.sun.awt.geom.CurveLink linkTo(Dova.JDK.sun.awt.geom.ChainEnd arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.CurveLink>(ret);
	}

	[JniSignatureAttribute("()Lsun/awt/geom/CurveLink;", "public")]
	public Dova.JDK.sun.awt.geom.CurveLink getChain()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.CurveLink>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/geom/ChainEnd;)V", "public")]
	public void setOtherEnd(Dova.JDK.sun.awt.geom.ChainEnd arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Lsun/awt/geom/ChainEnd;", "public")]
	public Dova.JDK.sun.awt.geom.ChainEnd getPartner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.ChainEnd>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/geom/CurveLink;)V", "public")]
	public void addLink(Dova.JDK.sun.awt.geom.CurveLink arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getX()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}
}
