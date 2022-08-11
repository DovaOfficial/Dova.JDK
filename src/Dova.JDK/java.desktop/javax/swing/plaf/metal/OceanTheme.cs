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

namespace Dova.JDK.javax.swing.plaf.metal;

[JniSignatureAttribute("Ljavax/swing/plaf/metal/OceanTheme;", "public")]
public partial class OceanTheme
	: Dova.JDK.javax.swing.plaf.metal.DefaultMetalTheme
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OceanTheme()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/OceanTheme;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMARY1", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMARY2", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMARY3", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDARY1", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDARY2", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDARY3", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTROL_TEXT_COLOR", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INACTIVE_CONTROL_TEXT_COLOR", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU_DISABLED_FOREGROUND", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OCEAN_BLACK", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OCEAN_DROP", "Ljavax/swing/plaf/ColorUIResource;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHastenedIcon", "(Ljava/lang/String;Ljavax/swing/UIDefaults;)Ljavax/swing/Icon;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlack", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addCustomEntriesToTable", "(Ljavax/swing/UIDefaults;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSystemTheme", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDesktopColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInactiveControlTextColor", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuDisabledForeground", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconResource", "(Ljava/lang/String;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource PRIMARY1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource PRIMARY2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource PRIMARY3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource SECONDARY1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource SECONDARY2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource SECONDARY3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource CONTROL_TEXT_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource INACTIVE_CONTROL_TEXT_COLOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource MENU_DISABLED_FOREGROUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource OCEAN_BLACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource OCEAN_DROP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OceanTheme(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public OceanTheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/OceanTheme;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/UIDefaults;)Ljavax/swing/Icon;", "private")]
	public Dova.JDK.javax.swing.Icon getHastenedIcon(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.UIDefaults arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getBlack()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/UIDefaults;)V", "public")]
	public void addCustomEntriesToTable(Dova.JDK.javax.swing.UIDefaults arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isSystemTheme()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getControlTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getDesktopColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getInactiveControlTextColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getMenuDisabledForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getIconResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/OceanTheme$IFIcon;", "private static")]
	public partial class IFIcon
		: Dova.JDK.javax.swing.plaf.IconUIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IFIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/OceanTheme$IFIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pressed", "Ljavax/swing/Icon;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Icon;Ljavax/swing/Icon;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/Icon;", "private")]
		public Dova.JDK.javax.swing.Icon pressed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IFIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/Icon;Ljavax/swing/Icon;)V", "public")]
		public IFIcon(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.javax.swing.Icon arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/OceanTheme$IFIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/OceanTheme$COIcon;", "private static")]
	public partial class COIcon
		: Dova.JDK.javax.swing.plaf.IconUIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static COIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/OceanTheme$COIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rtl", "Ljavax/swing/Icon;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Icon;Ljavax/swing/Icon;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/Icon;", "private")]
		public Dova.JDK.javax.swing.Icon rtl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public COIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/Icon;Ljavax/swing/Icon;)V", "public")]
		public COIcon(Dova.JDK.javax.swing.Icon arg0, Dova.JDK.javax.swing.Icon arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/OceanTheme$COIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}
}
