/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.print.attribute.standard;

[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public")]
public partial class MediaSizeName
	: Dova.JDK.javax.print.attribute.standard.Media
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MediaSizeName()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/attribute/standard/MediaSizeName;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A0", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A1", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A2", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A3", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A4", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A5", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A6", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A7", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A8", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A9", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_A10", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B0", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B1", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B2", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B3", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B4", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B5", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B6", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B7", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B8", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B9", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_B10", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B0", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B1", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B2", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B3", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B4", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B5", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B6", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B7", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B8", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B9", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JIS_B10", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C0", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C1", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C2", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C3", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C4", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C5", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_C6", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_LETTER", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_LEGAL", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "EXECUTIVE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "LEDGER", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "TABLOID", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INVOICE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "FOLIO", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "QUARTO", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAPANESE_POSTCARD", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "JAPANESE_DOUBLE_POSTCARD", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "A", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "B", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "C", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "D", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "E", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ISO_DESIGNATED_LONG", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ITALY_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MONARCH_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PERSONAL_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_9_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_10_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_11_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_12_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_NUMBER_14_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_6X9_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_7X9_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_9X11_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_9X12_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X13_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X14_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_10X15_ENVELOPE", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_5X7", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NA_8X10", "Ljavax/print/attribute/standard/MediaSizeName;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "myStringTable", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "myEnumValueTable", "[Ljavax/print/attribute/standard/MediaSizeName;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "MediaSizeName", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getStringTable", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEnumValueTable", "()[Ljavax/print/attribute/EnumSyntax;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A0_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A4_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A6_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A8_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A9_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_A10_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B0_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B4_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B6_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B8_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B9_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_B10_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B0_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B4_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B6_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B8_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B9_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JIS_B10_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C0_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C1_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C2_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C3_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C4_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C5_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_C6_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_LETTER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_LEGAL_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName EXECUTIVE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName LEDGER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName TABLOID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName INVOICE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName FOLIO_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName QUARTO_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JAPANESE_POSTCARD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName JAPANESE_DOUBLE_POSTCARD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName A_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName B_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName C_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName D_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName E_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ISO_DESIGNATED_LONG_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName ITALY_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName MONARCH_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName PERSONAL_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_NUMBER_9_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_NUMBER_10_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_NUMBER_11_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_NUMBER_12_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_NUMBER_14_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_6X9_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_7X9_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_9X11_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_9X12_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_10X13_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_10X14_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_10X15_ENVELOPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_5X7_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/MediaSizeName;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.MediaSizeName NA_8X10_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaSizeName>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> myStringTable_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljavax/print/attribute/standard/MediaSizeName;", "private static final")]
	public static JavaArray<Dova.JDK.javax.print.attribute.standard.MediaSizeName> myEnumValueTable_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.standard.MediaSizeName>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MediaSizeName(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public MediaSizeName(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/print/attribute/standard/MediaSizeName;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/lang/String;", "protected")]
	public JavaArray<Dova.JDK.java.lang.String> getStringTable()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/print/attribute/EnumSyntax;", "protected")]
	public JavaArray<Dova.JDK.javax.print.attribute.EnumSyntax> getEnumValueTable()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.EnumSyntax>>(ret);
	}
}
