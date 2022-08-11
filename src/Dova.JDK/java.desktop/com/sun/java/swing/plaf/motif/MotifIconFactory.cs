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

namespace Dova.JDK.com.sun.java.swing.plaf.motif;

[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory;", "public")]
public partial class MotifIconFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MotifIconFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "checkBoxIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "radioButtonIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuItemCheckIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuItemArrowIcon", "Ljavax/swing/Icon;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "menuArrowIcon", "Ljavax/swing/Icon;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuItemArrowIcon", "()Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuItemCheckIcon", "()Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMenuArrowIcon", "()Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRadioButtonIcon", "()Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCheckBoxIcon", "()Ljavax/swing/Icon;"));
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private static")]
	public static Dova.JDK.javax.swing.Icon checkBoxIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private static")]
	public static Dova.JDK.javax.swing.Icon radioButtonIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private static")]
	public static Dova.JDK.javax.swing.Icon menuItemCheckIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private static")]
	public static Dova.JDK.javax.swing.Icon menuItemArrowIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Icon;", "private static")]
	public static Dova.JDK.javax.swing.Icon menuArrowIcon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MotifIconFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MotifIconFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getMenuItemArrowIcon()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getMenuItemCheckIcon()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getMenuArrowIcon()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getRadioButtonIcon()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Icon;", "public static")]
	public static Dova.JDK.javax.swing.Icon getCheckBoxIcon()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemArrowIcon;", "private static")]
	public partial class MenuItemArrowIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
		, Dova.JDK.javax.swing.plaf.UIResource
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuItemArrowIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemArrowIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MenuItemArrowIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MenuItemArrowIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemArrowIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuArrowIcon;", "private static")]
	public partial class MenuArrowIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
		, Dova.JDK.javax.swing.plaf.UIResource
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuArrowIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuArrowIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focus", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlight", "Ljava/awt/Color;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color focus_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color shadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color highlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MenuArrowIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MenuArrowIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuArrowIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$CheckBoxIcon;", "private static")]
	public partial class CheckBoxIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
		, Dova.JDK.javax.swing.plaf.UIResource
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckBoxIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$CheckBoxIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "csize", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "control", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foreground", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlight", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightShadow", "Ljava/awt/Color;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawCheckBezel", "(Ljava/awt/Graphics;IIIZZZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawCheckBezelOut", "(Ljava/awt/Graphics;III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int csize_Property
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

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color control_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color foreground_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color shadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color highlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color lightShadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckBoxIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CheckBoxIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory$CheckBoxIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;IIIZZZZ)V", "public")]
		public void drawCheckBezel(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, bool arg4, bool arg5, bool arg6, bool arg7)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;III)V", "public")]
		public void drawCheckBezelOut(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$RadioButtonIcon;", "private static")]
	public partial class RadioButtonIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
		, Dova.JDK.javax.swing.plaf.UIResource
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RadioButtonIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$RadioButtonIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dot", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "highlight", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shadow", "Ljava/awt/Color;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color dot_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color highlight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color shadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RadioButtonIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public RadioButtonIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory$RadioButtonIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemCheckIcon;", "private static")]
	public partial class MenuItemCheckIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
		, Dova.JDK.javax.swing.plaf.UIResource
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MenuItemCheckIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemCheckIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MenuItemCheckIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MenuItemCheckIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/swing/plaf/motif/MotifIconFactory$MenuItemCheckIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
