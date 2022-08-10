/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/PageAttributes;", "public final")]
public partial class PageAttributes
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PageAttributes()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "color", "Ljava/awt/PageAttributes$ColorType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "media", "Ljava/awt/PageAttributes$MediaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "orientationRequested", "Ljava/awt/PageAttributes$OrientationRequestedType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "origin", "Ljava/awt/PageAttributes$OriginType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "printQuality", "Ljava/awt/PageAttributes$PrintQualityType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "printerResolution", "[I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PageAttributes", "(Ljava/awt/PageAttributes$ColorType;Ljava/awt/PageAttributes$MediaType;Ljava/awt/PageAttributes$OrientationRequestedType;Ljava/awt/PageAttributes$OriginType;Ljava/awt/PageAttributes$PrintQualityType;[I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PageAttributes", "(Ljava/awt/PageAttributes;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PageAttributes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(Ljava/awt/PageAttributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setColor", "(Ljava/awt/PageAttributes$ColorType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMediaToDefault", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOrientationRequestedToDefault", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOrigin", "(Ljava/awt/PageAttributes$OriginType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintQualityToDefault", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrinterResolutionToDefault", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMedia", "(Ljava/awt/PageAttributes$MediaType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOrientationRequested", "(Ljava/awt/PageAttributes$OrientationRequestedType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOrientationRequested", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintQuality", "(Ljava/awt/PageAttributes$PrintQualityType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintQuality", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrinterResolution", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrinterResolution", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrientationRequested", "()Ljava/awt/PageAttributes$OrientationRequestedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "()Ljava/awt/PageAttributes$OriginType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrintQuality", "()Ljava/awt/PageAttributes$PrintQualityType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrinterResolution", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMedia", "()Ljava/awt/PageAttributes$MediaType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getColor", "()Ljava/awt/PageAttributes$ColorType;"));
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$ColorType;", "private")]
	public Dova.JDK.java.awt.PageAttributes.ColorType color_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.ColorType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "private")]
	public Dova.JDK.java.awt.PageAttributes.MediaType media_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$OrientationRequestedType;", "private")]
	public Dova.JDK.java.awt.PageAttributes.OrientationRequestedType orientationRequested_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OrientationRequestedType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$OriginType;", "private")]
	public Dova.JDK.java.awt.PageAttributes.OriginType origin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OriginType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$PrintQualityType;", "private")]
	public Dova.JDK.java.awt.PageAttributes.PrintQualityType printQuality_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.PrintQualityType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> printerResolution_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PageAttributes(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$ColorType;Ljava/awt/PageAttributes$MediaType;Ljava/awt/PageAttributes$OrientationRequestedType;Ljava/awt/PageAttributes$OriginType;Ljava/awt/PageAttributes$PrintQualityType;[I)V", "public")]
	public PageAttributes(Dova.JDK.java.awt.PageAttributes.ColorType arg0, Dova.JDK.java.awt.PageAttributes.MediaType arg1, Dova.JDK.java.awt.PageAttributes.OrientationRequestedType arg2, Dova.JDK.java.awt.PageAttributes.OriginType arg3, Dova.JDK.java.awt.PageAttributes.PrintQualityType arg4, JavaArray<int> arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes;)V", "public")]
	public PageAttributes(Dova.JDK.java.awt.PageAttributes arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PageAttributes() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes;)V", "public")]
	public void set(Dova.JDK.java.awt.PageAttributes arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$ColorType;)V", "public")]
	public void setColor(Dova.JDK.java.awt.PageAttributes.ColorType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setMediaToDefault()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setOrientationRequestedToDefault()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$OriginType;)V", "public")]
	public void setOrigin(Dova.JDK.java.awt.PageAttributes.OriginType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setPrintQualityToDefault()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setPrinterResolutionToDefault()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$MediaType;)V", "public")]
	public void setMedia(Dova.JDK.java.awt.PageAttributes.MediaType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$OrientationRequestedType;)V", "public")]
	public void setOrientationRequested(Dova.JDK.java.awt.PageAttributes.OrientationRequestedType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setOrientationRequested(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/PageAttributes$PrintQualityType;)V", "public")]
	public void setPrintQuality(Dova.JDK.java.awt.PageAttributes.PrintQualityType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setPrintQuality(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void setPrinterResolution(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setPrinterResolution(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/PageAttributes$OrientationRequestedType;", "public")]
	public Dova.JDK.java.awt.PageAttributes.OrientationRequestedType getOrientationRequested()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OrientationRequestedType>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/PageAttributes$OriginType;", "public")]
	public Dova.JDK.java.awt.PageAttributes.OriginType getOrigin()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OriginType>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/PageAttributes$PrintQualityType;", "public")]
	public Dova.JDK.java.awt.PageAttributes.PrintQualityType getPrintQuality()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.PrintQualityType>(ret);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getPrinterResolution()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/PageAttributes$MediaType;", "public")]
	public Dova.JDK.java.awt.PageAttributes.MediaType getMedia()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/PageAttributes$ColorType;", "public")]
	public Dova.JDK.java.awt.PageAttributes.ColorType getColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.ColorType>(ret);
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$ColorType;", "public static final")]
	public partial class ColorType
		: Dova.JDK.java.awt.AttributeValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ColorType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes$ColorType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_COLOR", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_MONOCHROME", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMES", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLOR", "Ljava/awt/PageAttributes$ColorType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MONOCHROME", "Ljava/awt/PageAttributes$ColorType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ColorType", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_COLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_MONOCHROME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$ColorType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.ColorType COLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.ColorType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$ColorType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.ColorType MONOCHROME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.ColorType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ColorType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public ColorType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes$ColorType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public volatile")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$OriginType;", "public static final")]
	public partial class OriginType
		: Dova.JDK.java.awt.AttributeValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OriginType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes$OriginType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_PHYSICAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_PRINTABLE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMES", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PHYSICAL", "Ljava/awt/PageAttributes$OriginType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PRINTABLE", "Ljava/awt/PageAttributes$OriginType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OriginType", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_PHYSICAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_PRINTABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$OriginType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.OriginType PHYSICAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OriginType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$OriginType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.OriginType PRINTABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OriginType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OriginType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public OriginType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes$OriginType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public volatile")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
	public partial class MediaType
		: Dova.JDK.java.awt.AttributeValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MediaType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes$MediaType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_4A0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_2A0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A3", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A4", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A5", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A6", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A7", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A8", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A9", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_A10", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B3", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B4", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B5", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B6", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B7", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B8", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B9", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_B10", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B3", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B4", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B5", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B6", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B7", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B8", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B9", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_JIS_B10", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C0", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C1", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C2", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C3", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C4", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C5", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C6", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C7", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C8", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C9", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_C10", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ISO_DESIGNATED_LONG", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_EXECUTIVE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_FOLIO", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_INVOICE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_LEDGER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_LETTER", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_LEGAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_QUARTO", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_A", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_B", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_C", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_D", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_E", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_10X15_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_10X14_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_10X13_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_9X12_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_9X11_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_7X9_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_6X9_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_NUMBER_9_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_NUMBER_10_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_NUMBER_11_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_NUMBER_12_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NA_NUMBER_14_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_INVITE_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_ITALY_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_MONARCH_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_PERSONAL_ENVELOPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMES", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_4A0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_2A0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_DESIGNATED_LONG", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXECUTIVE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOLIO", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INVOICE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEDGER", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_LETTER", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_LEGAL", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "QUARTO", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "D", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "E", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X15_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X14_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X13_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_9X12_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_9X11_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_7X9_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_6X9_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_9_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_10_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_11_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_12_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_14_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INVITE_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ITALY_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MONARCH_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PERSONAL_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "A10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B4_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B5_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "B10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C0", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C0_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C1", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C1_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C2", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C2_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C3", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C3_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C4", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C4_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C5", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C5_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C6", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C6_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C7", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C7_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C8", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C8_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C9_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "C10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C10_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_DESIGNATED_LONG_ENVELOPE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STATEMENT", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TABLOID", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LETTER", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOTE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEGAL", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_10X15", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_10X14", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_10X13", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_9X12", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_9X11", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_7X9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_6X9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_9", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_10", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_11", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_12", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_14", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_INVITE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_ITALY", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_MONARCH", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENV_PERSONAL", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INVITE", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ITALY", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MONARCH", "Ljava/awt/PageAttributes$MediaType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PERSONAL", "Ljava/awt/PageAttributes$MediaType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MediaType", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_4A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_2A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_A10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_B10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_JIS_B10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_C10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ISO_DESIGNATED_LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_EXECUTIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_FOLIO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_INVOICE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_LEDGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[50]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[50], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[51]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[51], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_LEGAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[52]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[52], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_QUARTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[53]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[53], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_A_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[54]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[54], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_B_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[55]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[55], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_C_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[56]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[56], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_D_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[57]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[57], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_E_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[58]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[58], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_10X15_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[59]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[59], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_10X14_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[60]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[60], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_10X13_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[61]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[61], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_9X12_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[62]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[62], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_9X11_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[63]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[63], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_7X9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[64]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[64], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_6X9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[65]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[65], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_NUMBER_9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[66]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[66], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_NUMBER_10_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[67]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[67], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_NUMBER_11_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[68]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[68], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_NUMBER_12_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[69]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[69], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NA_NUMBER_14_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[70]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[70], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_INVITE_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[71]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[71], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_ITALY_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[72]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[72], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_MONARCH_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[73]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[73], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_PERSONAL_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[74]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[74], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_4A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_2A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_A10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType JIS_B10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_DESIGNATED_LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType EXECUTIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType FOLIO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType INVOICE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType LEDGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_LEGAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType QUARTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType D_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType E_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_10X15_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_10X14_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_10X13_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_9X12_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_9X11_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_7X9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_6X9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_NUMBER_9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_NUMBER_10_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_NUMBER_11_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_NUMBER_12_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NA_NUMBER_14_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType INVITE_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ITALY_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType MONARCH_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType PERSONAL_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType A10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B4_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_B5_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType B10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C0_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C1_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C2_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C3_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C4_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C5_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C6_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C7_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C7_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C8_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C9_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType C10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_C10_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ISO_DESIGNATED_LONG_ENVELOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType TABLOID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType LETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType NOTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType LEGAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_10X15_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_10X14_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_10X13_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_9X12_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_9X11_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_7X9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_6X9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_9_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_10_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_11_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_12_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_14_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_INVITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_ITALY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_MONARCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ENV_PERSONAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType INVITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType ITALY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType MONARCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$MediaType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.MediaType PERSONAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.MediaType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MediaType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public MediaType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes$MediaType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public volatile")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$OrientationRequestedType;", "public static final")]
	public partial class OrientationRequestedType
		: Dova.JDK.java.awt.AttributeValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrientationRequestedType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes$OrientationRequestedType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_PORTRAIT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_LANDSCAPE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMES", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PORTRAIT", "Ljava/awt/PageAttributes$OrientationRequestedType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LANDSCAPE", "Ljava/awt/PageAttributes$OrientationRequestedType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OrientationRequestedType", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_PORTRAIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_LANDSCAPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$OrientationRequestedType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.OrientationRequestedType PORTRAIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OrientationRequestedType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$OrientationRequestedType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.OrientationRequestedType LANDSCAPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.OrientationRequestedType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrientationRequestedType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public OrientationRequestedType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes$OrientationRequestedType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public volatile")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/awt/PageAttributes$PrintQualityType;", "public static final")]
	public partial class PrintQualityType
		: Dova.JDK.java.awt.AttributeValue
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintQualityType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/PageAttributes$PrintQualityType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_HIGH", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_NORMAL", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I_DRAFT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAMES", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "HIGH", "Ljava/awt/PageAttributes$PrintQualityType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NORMAL", "Ljava/awt/PageAttributes$PrintQualityType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DRAFT", "Ljava/awt/PageAttributes$PrintQualityType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintQualityType", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_HIGH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int I_DRAFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$PrintQualityType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.PrintQualityType HIGH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.PrintQualityType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$PrintQualityType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.PrintQualityType NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.PrintQualityType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/awt/PageAttributes$PrintQualityType;", "public static final")]
		public static Dova.JDK.java.awt.PageAttributes.PrintQualityType DRAFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PageAttributes.PrintQualityType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintQualityType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "private")]
		public PrintQualityType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/awt/PageAttributes$PrintQualityType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public volatile")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}
}
