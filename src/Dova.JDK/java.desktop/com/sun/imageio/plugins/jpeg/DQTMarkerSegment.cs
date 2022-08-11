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

[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment;", "")]
public partial class DQTMarkerSegment
	: Dova.JDK.com.sun.imageio.plugins.jpeg.MarkerSegment
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DQTMarkerSegment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tables", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljavax/imageio/plugins/jpeg/JPEGQTable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljavax/imageio/stream/ImageOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChromaForLuma", "(Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;)Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQtableFromNode", "(Lorg/w3c/dom/Node;)Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "")]
	public Dova.JDK.java.util.List tables_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DQTMarkerSegment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
	public DQTMarkerSegment(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([Ljavax/imageio/plugins/jpeg/JPEGQTable;)V", "")]
	public DQTMarkerSegment(JavaArray<Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
	public DQTMarkerSegment(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(FZ)V", "")]
	public DQTMarkerSegment(float arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment;";
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

	[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;)Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;", "")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.DQTMarkerSegment.Qtable getChromaForLuma(Dova.JDK.com.sun.imageio.plugins.jpeg.DQTMarkerSegment.Qtable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.DQTMarkerSegment.Qtable>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;", "")]
	public Dova.JDK.com.sun.imageio.plugins.jpeg.DQTMarkerSegment.Qtable getQtableFromNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.imageio.plugins.jpeg.DQTMarkerSegment.Qtable>(ret);
	}

	[JniSignatureAttribute("()Ljavax/imageio/metadata/IIOMetadataNode;", "")]
	public Dova.JDK.javax.imageio.metadata.IIOMetadataNode getNativeNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.metadata.IIOMetadataNode>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;", "static")]
	public partial class Qtable
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Cloneable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Qtable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementPrecision", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableID", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "QTABLE_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zigzag", "[I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/Node;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/imageio/plugins/jpeg/JPEGQTable;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeNode", "()Ljavax/imageio/metadata/IIOMetadataNode;"));
		}

		[JniSignatureAttribute("I", "")]
		public int elementPrecision_Property
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
		public int tableID_Property
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

		[JniSignatureAttribute("I", "final")]
		public int QTABLE_SIZE_Property
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

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private final")]
		public JavaArray<int> zigzag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Qtable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
		public Qtable(Dova.JDK.org.w3c.dom.Node arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljavax/imageio/plugins/jpeg/JPEGQTable;I)V", "")]
		public Qtable(Dova.JDK.javax.imageio.plugins.jpeg.JPEGQTable arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/imageio/plugins/jpeg/JPEGBuffer;)V", "")]
		public Qtable(Dova.JDK.com.sun.imageio.plugins.jpeg.JPEGBuffer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("(ZF)V", "")]
		public Qtable(bool arg0, float arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/jpeg/DQTMarkerSegment$Qtable;";
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
