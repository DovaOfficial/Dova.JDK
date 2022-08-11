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

namespace Dova.JDK.javax.swing.plaf.basic;

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML;", "public")]
public partial class BasicHTML
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicHTML()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicHTML;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "htmlDisable", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "propertyKey", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "documentBaseKey", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "basicHTMLFactory", "Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "basicHTMLViewFactory", "Ljavax/swing/text/ViewFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "styleChanges", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFactory", "()Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateRenderer", "(Ljavax/swing/JComponent;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHTMLBaseline", "(Ljavax/swing/text/View;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasParagraph", "(Ljavax/swing/text/View;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isHTMLString", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createHTMLView", "(Ljavax/swing/JComponent;Ljava/lang/String;)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/text/View;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/JComponent;IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBaseline", "(Ljavax/swing/text/View;Ljava/awt/Shape;)I"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String htmlDisable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String propertyKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String documentBaseKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;", "private static")]
	public static Dova.JDK.javax.swing.plaf.basic.BasicHTML.BasicEditorKit basicHTMLFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicHTML.BasicEditorKit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/ViewFactory;", "private static")]
	public static Dova.JDK.javax.swing.text.ViewFactory basicHTMLViewFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String styleChanges_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicHTML(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicHTML() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicHTML;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;", "static")]
	public static Dova.JDK.javax.swing.plaf.basic.BasicHTML.BasicEditorKit getFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicHTML.BasicEditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/lang/String;)V", "public static")]
	public static void updateRenderer(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;II)I", "public static")]
	public static int getHTMLBaseline(Dova.JDK.javax.swing.text.View arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)Z", "private static")]
	public static bool hasParagraph(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public static")]
	public static bool isHTMLString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljava/lang/String;)Ljavax/swing/text/View;", "public static")]
	public static Dova.JDK.javax.swing.text.View createHTMLView(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;II)I", "static")]
	public static int getBaseline(Dova.JDK.javax.swing.text.View arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;IIII)I", "static")]
	public static int getBaseline(Dova.JDK.javax.swing.JComponent arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;Ljava/awt/Shape;)I", "private static")]
	public static int getBaseline(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.java.awt.Shape arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;", "static")]
	public partial class BasicEditorKit
		: Dova.JDK.javax.swing.text.html.HTMLEditorKit
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicEditorKit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultStyles", "Ljavax/swing/text/html/StyleSheet;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewFactory", "()Ljavax/swing/text/ViewFactory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultDocument", "(Ljava/awt/Font;Ljava/awt/Color;)Ljavax/swing/text/Document;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/StyleSheet;", "private static")]
		public static Dova.JDK.javax.swing.text.html.StyleSheet defaultStyles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicEditorKit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BasicEditorKit() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicHTML$BasicEditorKit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/text/ViewFactory;", "public")]
		public Dova.JDK.javax.swing.text.ViewFactory getViewFactory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/Color;)Ljavax/swing/text/Document;", "public")]
		public Dova.JDK.javax.swing.text.Document createDefaultDocument(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.Color arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/StyleSheet;", "public")]
		public Dova.JDK.javax.swing.text.html.StyleSheet getStyleSheet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML$Renderer;", "static")]
	public partial class Renderer
		: Dova.JDK.javax.swing.text.View
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Renderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicHTML$Renderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "width", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "view", "Ljavax/swing/text/View;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factory", "Ljavax/swing/text/ViewFactory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "host", "Ljavax/swing/JComponent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComponent;Ljavax/swing/text/ViewFactory;Ljavax/swing/text/View;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParent", "(Ljavax/swing/text/View;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(FF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "()Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewFactory", "()Ljavax/swing/text/ViewFactory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignment", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(ILjavax/swing/text/Position$Bias;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "()Ljavax/swing/text/Document;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContainer", "()Ljava/awt/Container;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getView", "(I)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferenceChanged", "(Ljavax/swing/text/View;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int width_Property
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

		[JniSignatureAttribute("Ljavax/swing/text/View;", "private")]
		public Dova.JDK.javax.swing.text.View view_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/ViewFactory;", "private")]
		public Dova.JDK.javax.swing.text.ViewFactory factory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComponent;", "private")]
		public Dova.JDK.javax.swing.JComponent host_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Renderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/text/ViewFactory;Ljavax/swing/text/View;)V", "")]
		public Renderer(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.text.ViewFactory arg1, Dova.JDK.javax.swing.text.View arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicHTML$Renderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/View;)V", "public")]
		public void setParent(Dova.JDK.javax.swing.text.View arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(FF)V", "public")]
		public void setSize(float arg0, float arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public")]
		public Dova.JDK.javax.swing.text.Element getElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMinimumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMaximumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/ViewFactory;", "public")]
		public Dova.JDK.javax.swing.text.ViewFactory getViewFactory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getViewCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getAlignment(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I", "public")]
		public int viewToModel(float arg0, float arg1, Dova.JDK.java.awt.Shape arg2, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape modelToView(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1, int arg2, Dova.JDK.javax.swing.text.Position.Bias arg3, Dova.JDK.java.awt.Shape arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape modelToView(int arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Document;", "public")]
		public Dova.JDK.javax.swing.text.Document getDocument()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Container;", "public")]
		public Dova.JDK.java.awt.Container getContainer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Container>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getPreferredSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/swing/text/View;", "public")]
		public Dova.JDK.javax.swing.text.View getView(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/View;ZZ)V", "public")]
		public void preferenceChanged(Dova.JDK.javax.swing.text.View arg0, bool arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML$BasicHTMLViewFactory;", "static")]
	public partial class BasicHTMLViewFactory
		: Dova.JDK.javax.swing.text.html.HTMLEditorKit.HTMLFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicHTMLViewFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicHTML$BasicHTMLViewFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicHTMLViewFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BasicHTMLViewFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicHTML$BasicHTMLViewFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "public")]
		public Dova.JDK.javax.swing.text.View create(Dova.JDK.javax.swing.text.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicHTML$BasicDocument;", "static")]
	public partial class BasicDocument
		: Dova.JDK.javax.swing.text.html.HTMLDocument
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicDocument()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicHTML$BasicDocument;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/StyleSheet;Ljava/awt/Font;Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFontAndColor", "(Ljava/awt/Font;Ljava/awt/Color;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicDocument(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/StyleSheet;Ljava/awt/Font;Ljava/awt/Color;)V", "")]
		public BasicDocument(Dova.JDK.javax.swing.text.html.StyleSheet arg0, Dova.JDK.java.awt.Font arg1, Dova.JDK.java.awt.Color arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicHTML$BasicDocument;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/Color;)V", "private")]
		public void setFontAndColor(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.Color arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}
}
