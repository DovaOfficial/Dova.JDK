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

namespace Dova.JDK.javax.print.attribute.standard;

[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public")]
public partial class PrinterStateReason
	: Dova.JDK.javax.print.attribute.EnumSyntax
	, Dova.JDK.javax.print.attribute.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrinterStateReason()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/attribute/standard/PrinterStateReason;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIA_NEEDED", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIA_JAM", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MOVING_TO_PAUSED", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PAUSED", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SHUTDOWN", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONNECTING_TO_DEVICE", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TIMED_OUT", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STOPPING", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STOPPED_PARTLY", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TONER_LOW", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TONER_EMPTY", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SPOOL_AREA_FULL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COVER_OPEN", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERLOCK_OPEN", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DOOR_OPEN", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INPUT_TRAY_MISSING", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIA_LOW", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEDIA_EMPTY", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OUTPUT_TRAY_MISSING", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OUTPUT_AREA_ALMOST_FULL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OUTPUT_AREA_FULL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARKER_SUPPLY_LOW", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARKER_SUPPLY_EMPTY", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARKER_WASTE_ALMOST_FULL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MARKER_WASTE_FULL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FUSER_OVER_TEMP", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FUSER_UNDER_TEMP", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OPC_NEAR_EOL", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OPC_LIFE_OVER", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEVELOPER_LOW", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEVELOPER_EMPTY", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERPRETER_RESOURCE_UNAVAILABLE", "Ljavax/print/attribute/standard/PrinterStateReason;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "myStringTable", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "myEnumValueTable", "[Ljavax/print/attribute/standard/PrinterStateReason;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrinterStateReason", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCategory", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStringTable", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEnumValueTable", "()[Ljavax/print/attribute/EnumSyntax;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OTHER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MEDIA_NEEDED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MEDIA_JAM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MOVING_TO_PAUSED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason PAUSED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason SHUTDOWN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason CONNECTING_TO_DEVICE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason TIMED_OUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason STOPPING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason STOPPED_PARTLY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason TONER_LOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason TONER_EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason SPOOL_AREA_FULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason COVER_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason INTERLOCK_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason DOOR_OPEN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason INPUT_TRAY_MISSING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MEDIA_LOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MEDIA_EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OUTPUT_TRAY_MISSING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OUTPUT_AREA_ALMOST_FULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OUTPUT_AREA_FULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MARKER_SUPPLY_LOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MARKER_SUPPLY_EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MARKER_WASTE_ALMOST_FULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason MARKER_WASTE_FULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason FUSER_OVER_TEMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason FUSER_UNDER_TEMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OPC_NEAR_EOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason OPC_LIFE_OVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason DEVELOPER_LOW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason DEVELOPER_EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/print/attribute/standard/PrinterStateReason;", "public static final")]
	public static Dova.JDK.javax.print.attribute.standard.PrinterStateReason INTERPRETER_RESOURCE_UNAVAILABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> myStringTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljavax/print/attribute/standard/PrinterStateReason;", "private static final")]
	public static JavaArray<Dova.JDK.javax.print.attribute.standard.PrinterStateReason> myEnumValueTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.standard.PrinterStateReason>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrinterStateReason(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public PrinterStateReason(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/print/attribute/standard/PrinterStateReason;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public final")]
	public Dova.JDK.java.lang.Class getCategory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "protected")]
	public JavaArray<Dova.JDK.java.lang.String> getStringTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/print/attribute/EnumSyntax;", "protected")]
	public JavaArray<Dova.JDK.javax.print.attribute.EnumSyntax> getEnumValueTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.attribute.EnumSyntax>>(ret);
	}
}
