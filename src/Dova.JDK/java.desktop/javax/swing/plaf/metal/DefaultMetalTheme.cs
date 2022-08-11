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

[JniSignatureAttribute("Ljavax/swing/plaf/metal/DefaultMetalTheme;", "public")]
public partial class DefaultMetalTheme
	: Dova.JDK.javax.swing.plaf.metal.MetalTheme
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultMetalTheme()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/DefaultMetalTheme;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLAIN_FONTS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fontNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fontStyles", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fontSizes", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primary1", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primary2", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primary3", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "secondary1", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "secondary2", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "secondary3", "Ljavax/swing/plaf/ColorUIResource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fontDelegate", "Ljavax/swing/plaf/metal/DefaultMetalTheme$FontDelegate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(I)Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSystemTheme", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getControlTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSystemTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMenuTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindowTitleFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubTextFont", "()Ljavax/swing/plaf/FontUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary2", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary1", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecondary3", "()Ljavax/swing/plaf/ColorUIResource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultFontName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultFontSize", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultFontStyle", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultPropertyName", "(I)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool PLAIN_FONTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> fontNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> fontStyles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> fontSizes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> defaultNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/ColorUIResource;", "private static final")]
	public static Dova.JDK.javax.swing.plaf.ColorUIResource primary1_Property
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
	public static Dova.JDK.javax.swing.plaf.ColorUIResource primary2_Property
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
	public static Dova.JDK.javax.swing.plaf.ColorUIResource primary3_Property
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
	public static Dova.JDK.javax.swing.plaf.ColorUIResource secondary1_Property
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
	public static Dova.JDK.javax.swing.plaf.ColorUIResource secondary2_Property
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
	public static Dova.JDK.javax.swing.plaf.ColorUIResource secondary3_Property
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

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/DefaultMetalTheme$FontDelegate;", "private")]
	public Dova.JDK.javax.swing.plaf.metal.DefaultMetalTheme.FontDelegate fontDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.metal.DefaultMetalTheme.FontDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultMetalTheme(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultMetalTheme() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/DefaultMetalTheme;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void install()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/plaf/FontUIResource;", "private")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getFont(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isSystemTheme()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getControlTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getSystemTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getUserTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getMenuTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getWindowTitleFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/FontUIResource;", "public")]
	public Dova.JDK.javax.swing.plaf.FontUIResource getSubTextFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getPrimary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ColorUIResource;", "protected")]
	public Dova.JDK.javax.swing.plaf.ColorUIResource getSecondary3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ColorUIResource>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getDefaultFontName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)I", "static")]
	public static int getDefaultFontSize(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "static")]
	public static int getDefaultFontStyle(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getDefaultPropertyName(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/DefaultMetalTheme$FontDelegate;", "private static")]
	public partial class FontDelegate
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FontDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/DefaultMetalTheme$FontDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultMapping", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fonts", "[Ljavax/swing/plaf/FontUIResource;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(I)Ljavax/swing/plaf/FontUIResource;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivilegedFont", "(I)Ljava/awt/Font;"));
		}

		[JniSignatureAttribute("[I", "private static")]
		public static JavaArray<int> defaultMapping_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/swing/plaf/FontUIResource;", "")]
		public JavaArray<Dova.JDK.javax.swing.plaf.FontUIResource> fonts_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.plaf.FontUIResource>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FontDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public FontDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/DefaultMetalTheme$FontDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljavax/swing/plaf/FontUIResource;", "public")]
		public Dova.JDK.javax.swing.plaf.FontUIResource getFont(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/awt/Font;", "protected")]
		public Dova.JDK.java.awt.Font getPrivilegedFont(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/metal/DefaultMetalTheme$WindowsFontDelegate;", "private static")]
	public partial class WindowsFontDelegate
		: Dova.JDK.javax.swing.plaf.metal.DefaultMetalTheme.FontDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WindowsFontDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/metal/DefaultMetalTheme$WindowsFontDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "props", "[Ljavax/swing/plaf/metal/MetalFontDesktopProperty;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkedPriviledged", "[Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(I)Ljavax/swing/plaf/FontUIResource;"));
		}

		[JniSignatureAttribute("[Ljavax/swing/plaf/metal/MetalFontDesktopProperty;", "private")]
		public JavaArray<Dova.JDK.javax.swing.plaf.metal.MetalFontDesktopProperty> props_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.plaf.metal.MetalFontDesktopProperty>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Z", "private")]
		public JavaArray<bool> checkedPriviledged_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WindowsFontDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public WindowsFontDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/metal/DefaultMetalTheme$WindowsFontDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljavax/swing/plaf/FontUIResource;", "public")]
		public Dova.JDK.javax.swing.plaf.FontUIResource getFont(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.FontUIResource>(ret);
		}
	}
}
