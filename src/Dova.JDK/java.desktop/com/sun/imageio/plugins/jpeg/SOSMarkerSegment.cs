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

namespace Dova.JDK.com.sun.imageio.plugins.jpeg;

[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment;", "")]
public partial class SOSMarkerSegment
	: Dova.JDK.com.sun.imageio.plugins.jpeg.MarkerSegment
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SOSMarkerSegment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startSpectralSelection", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endSpectralSelection", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "approxHigh", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "approxLow", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentSpecs", "[Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z[BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScanComponentSpec", "(BI)Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFromNativeNode", "(Lorg/w3c/dom/Node;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
	}

	[JniSignatureAttribute("I", "")]
	public int startSpectralSelection_Property
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
	public int endSpectralSelection_Property
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

	[JniSignatureAttribute("I", "")]
	public int approxHigh_Property
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

	[JniSignatureAttribute("I", "")]
	public int approxLow_Property
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

	[JniSignatureAttribute("[Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;", "")]
	public JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.SOSMarkerSegment.ScanComponentSpec> componentSpecs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.imageio.plugins.jpeg.SOSMarkerSegment.ScanComponentSpec>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SOSMarkerSegment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
	public SOSMarkerSegment(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
	public SOSMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Z[BI)V", "")]
	public SOSMarkerSegment(bool arg0, JavaArray<byte> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/imageio/stream/ImageOutputStream;)V", "")]
	public void write(Dova.JDK.javax.imageio.stream.ImageOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void print()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(BI)Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;", "")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.SOSMarkerSegment.ScanComponentSpec getScanComponentSpec(byte arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.SOSMarkerSegment.ScanComponentSpec>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Z)V", "")]
	public void updateFromNativeNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;", "static")]
	public partial class ScanComponentSpec
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ScanComponentSpec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentSelector", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcHuffTable", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acHuffTable", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		}

		[JniSignatureAttribute("I", "")]
		public int componentSelector_Property
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
		public int dcHuffTable_Property
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

		[JniSignatureAttribute("I", "")]
		public int acHuffTable_Property
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
		public ScanComponentSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
		public ScanComponentSpec(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
		public ScanComponentSpec(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(BI)V", "")]
		public ScanComponentSpec(byte arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/SOSMarkerSegment$ScanComponentSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object clone()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void print()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
		public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
		}
	}
}
