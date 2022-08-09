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

namespace Dova.JDK.jdk.@internal.org.jline.utils;

[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp;", "public final")]
public partial class InfoCmp
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InfoCmp()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/utils/InfoCmp;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CAPS", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InfoCmp", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getCapabilitiesByName", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getLoadedInfoCmp", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "loadDefaultInfoCmp", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setDefaultInfoCmp", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "setDefaultInfoCmp", "(Ljava/lang/String;Ljava/util/function/Supplier;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getInfoCmp", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "parseInfoCmp", "(Ljava/lang/String;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map CAPS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InfoCmp(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public InfoCmp() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/InfoCmp;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map getCapabilitiesByName()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getLoadedInfoCmp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String loadDefaultInfoCmp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public static")]
	public static void setDefaultInfoCmp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/function/Supplier;)V", "public static")]
	public static void setDefaultInfoCmp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.function.Supplier arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getInfoCmp(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;)V", "public static")]
	public static void parseInfoCmp(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
	public partial class Capability
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Capability()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/org/jline/utils/InfoCmp$Capability;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "auto_left_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "auto_right_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "back_color_erase", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "can_change", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ceol_standout_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "col_addr_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cpi_changes_res", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cr_cancels_micro_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dest_tabs_magic_smso", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "eat_newline_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "erase_overstrike", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "generic_type", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "hard_copy", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "hard_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "has_meta_key", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "has_print_wheel", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "has_status_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "hue_lightness_saturation", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "insert_null_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lpi_changes_res", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "memory_above", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "memory_below", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "move_insert_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "move_standout_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "needs_xon_xoff", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "no_esc_ctlc", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "no_pad_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "non_dest_scroll_region", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "non_rev_rmcup", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "over_strike", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prtr_silent", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "row_addr_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "semi_auto_right_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "status_line_esc_ok", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "tilde_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "transparent_underline", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "xon_xoff", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "columns", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_tabs", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "label_height", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "label_width", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lines", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lines_of_memory", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "magic_cookie_glitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "max_attributes", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "max_colors", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "max_pairs", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "maximum_windows", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "no_color_video", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "num_labels", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "padding_baud_rate", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "virtual_terminal", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "width_status_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bit_image_entwining", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bit_image_type", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "buffer_capacity", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "buttons", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dot_horz_spacing", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dot_vert_spacing", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "max_micro_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "max_micro_jump", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_col_size", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_line_size", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "number_of_pins", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "output_res_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "output_res_horz_inch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "output_res_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "output_res_vert_inch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "print_rate", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "wide_char_size", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "acs_chars", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "back_tab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bell", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "carriage_return", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "change_char_pitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "change_line_pitch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "change_res_horz", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "change_res_vert", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "change_scroll_region", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "char_padding", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clear_all_tabs", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clear_margins", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clear_screen", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clr_bol", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clr_eol", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "clr_eos", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "column_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "command_character", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "create_window", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_down", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_home", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_invisible", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_left", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_mem_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_normal", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_right", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_to_ll", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_up", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "cursor_visible", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "define_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "delete_character", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "delete_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dial_phone", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "dis_status_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "display_clock", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "down_half_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ena_acs", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_alt_charset_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_am_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_blink_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_bold_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_ca_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_delete_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_dim_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_doublewide_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_draft_quality", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_insert_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_italics_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_leftward_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_micro_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_near_letter_quality", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_normal_quality", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_protected_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_reverse_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_secure_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_shadow_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_standout_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_subscript_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_superscript_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_underline_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_upward_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_xon_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "erase_chars", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_alt_charset_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_am_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_attribute_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_ca_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_delete_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_doublewide_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_insert_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_italics_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_leftward_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_micro_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_shadow_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_standout_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_subscript_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_superscript_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_underline_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_upward_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_xon_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "fixed_pause", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "flash_hook", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "flash_screen", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "form_feed", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "from_status_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "goto_window", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "hangup", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_1string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_2string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_3string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_file", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "init_prog", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "initialize_color", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "initialize_pair", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "insert_character", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "insert_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "insert_padding", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_a1", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_a3", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_b2", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_backspace", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_beg", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_btab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_c1", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_c3", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_cancel", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_catab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_clear", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_close", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_command", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_copy", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_create", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ctab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_dc", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_dl", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_down", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_eic", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_end", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_enter", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_eol", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_eos", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_exit", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f0", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f1", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f10", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f11", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f12", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f13", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f14", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f15", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f16", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f17", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f18", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f19", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f2", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f20", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f21", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f22", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f23", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f24", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f25", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f26", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f27", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f28", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f29", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f3", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f30", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f31", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f32", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f33", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f34", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f35", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f36", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f37", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f38", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f39", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f4", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f40", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f41", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f42", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f43", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f44", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f45", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f46", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f47", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f48", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f49", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f5", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f50", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f51", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f52", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f53", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f54", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f55", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f56", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f57", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f58", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f59", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f6", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f60", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f61", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f62", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f63", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f7", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f8", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_f9", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_find", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_help", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_home", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ic", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_il", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_left", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ll", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_mark", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_message", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_move", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_next", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_npage", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_open", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_options", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ppage", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_previous", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_print", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_redo", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_reference", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_refresh", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_replace", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_restart", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_resume", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_right", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_save", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sbeg", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_scancel", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_scommand", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_scopy", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_screate", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sdc", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sdl", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_select", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_send", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_seol", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sexit", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sf", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sfind", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_shelp", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_shome", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sic", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sleft", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_smessage", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_smove", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_snext", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_soptions", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sprevious", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sprint", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sr", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sredo", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sreplace", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sright", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_srsume", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ssave", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_ssuspend", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_stab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_sundo", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_suspend", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_undo", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_up", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "keypad_local", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "keypad_xmit", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f0", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f1", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f10", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f2", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f3", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f4", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f5", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f6", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f7", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f8", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "lab_f9", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "label_format", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "label_off", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "label_on", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "meta_off", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "meta_on", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_column_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_down", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_left", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_right", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_row_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "micro_up", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "newline", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "order_of_pins", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "orig_colors", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "orig_pair", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pad_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_dch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_delete_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_down_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_down_micro", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_ich", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_index", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_insert_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_left_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_left_micro", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_right_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_right_micro", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_rindex", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_up_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "parm_up_micro", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pkey_key", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pkey_local", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pkey_xmit", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "plab_norm", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "print_screen", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prtr_non", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prtr_off", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "prtr_on", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pulse", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "quick_dial", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "remove_clock", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "repeat_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "req_for_input", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "reset_1string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "reset_2string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "reset_3string", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "reset_file", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "restore_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "row_address", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "save_cursor", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scroll_forward", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scroll_reverse", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "select_char_set", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_attributes", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_background", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_bottom_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_bottom_margin_parm", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_clock", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_color_pair", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_foreground", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_left_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_left_margin_parm", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_right_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_right_margin_parm", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_tab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_top_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_top_margin_parm", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_window", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "start_bit_image", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "start_char_set_def", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "stop_bit_image", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "stop_char_set_def", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "subscript_characters", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "superscript_characters", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "tab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "these_cause_cr", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "to_status_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "tone", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "underline_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "up_half_line", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user0", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user1", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user2", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user3", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user4", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user5", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user6", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user7", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user8", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "user9", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "wait_tone", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "xoff_character", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "xon_character", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "zero_motion", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "alt_scancode_esc", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bit_image_carriage_return", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bit_image_newline", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "bit_image_repeat", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "char_set_names", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "code_set_init", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "color_names", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "define_bit_image_region", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "device_type", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "display_pc_char", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "end_bit_image_region", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_pc_charset_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_scancode_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_pc_charset_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "exit_scancode_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "get_mouse", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "key_mouse", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "mouse_info", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pc_term_options", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "pkey_plab", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "req_mouse_pos", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "scancode_escape", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set0_des_seq", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set1_des_seq", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set2_des_seq", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set3_des_seq", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_a_background", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_a_foreground", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_color_band", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_lr_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_page_length", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_tb_margin", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_horizontal_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_left_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_low_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_right_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_top_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "enter_vertical_hl_mode", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_a_attributes", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "set_pglen_inch", "Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "Capability", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "byName", "(Ljava/lang/String;)Ljdk/internal/org/jline/utils/InfoCmp$Capability;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNames", "()[Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability auto_left_margin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability auto_right_margin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability back_color_erase_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability can_change_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability ceol_standout_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability col_addr_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cpi_changes_res_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cr_cancels_micro_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability dest_tabs_magic_smso_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability eat_newline_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability erase_overstrike_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability generic_type_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability hard_copy_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability hard_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability has_meta_key_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability has_print_wheel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability has_status_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability hue_lightness_saturation_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability insert_null_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lpi_changes_res_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability memory_above_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability memory_below_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability move_insert_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability move_standout_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability needs_xon_xoff_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability no_esc_ctlc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability no_pad_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability non_dest_scroll_region_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability non_rev_rmcup_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability over_strike_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability prtr_silent_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability row_addr_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability semi_auto_right_margin_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability status_line_esc_ok_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability tilde_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability transparent_underline_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability xon_xoff_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability columns_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_tabs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability label_height_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability label_width_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lines_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lines_of_memory_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability magic_cookie_glitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability max_attributes_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability max_colors_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability max_pairs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability maximum_windows_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability no_color_video_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability num_labels_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability padding_baud_rate_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability virtual_terminal_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability width_status_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bit_image_entwining_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bit_image_type_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability buffer_capacity_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability buttons_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability dot_horz_spacing_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability dot_vert_spacing_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability max_micro_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability max_micro_jump_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_col_size_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_line_size_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability number_of_pins_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability output_res_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability output_res_horz_inch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability output_res_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability output_res_vert_inch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability print_rate_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability wide_char_size_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability acs_chars_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability back_tab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bell_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability carriage_return_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability change_char_pitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability change_line_pitch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability change_res_horz_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability change_res_vert_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability change_scroll_region_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability char_padding_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clear_all_tabs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clear_margins_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clear_screen_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clr_bol_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clr_eol_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability clr_eos_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability column_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability command_character_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability create_window_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_down_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_home_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_invisible_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_mem_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_normal_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_to_ll_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_up_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability cursor_visible_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability define_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability delete_character_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability delete_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability dial_phone_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability dis_status_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability display_clock_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability down_half_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability ena_acs_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_alt_charset_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_am_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_blink_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_bold_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_ca_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_delete_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_dim_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_doublewide_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_draft_quality_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_insert_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[117]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[117], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_italics_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[118]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[118], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_leftward_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[119]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[119], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_micro_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[120]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[120], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_near_letter_quality_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[121]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[121], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_normal_quality_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[122]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[122], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_protected_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[123]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[123], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_reverse_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[124]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[124], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_secure_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[125]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[125], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_shadow_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[126]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[126], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_standout_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[127]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[127], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_subscript_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[128]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[128], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_superscript_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[129]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[129], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_underline_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[130]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[130], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_upward_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[131]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[131], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_xon_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[132]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[132], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability erase_chars_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[133]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[133], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_alt_charset_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[134]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[134], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_am_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[135]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[135], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_attribute_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[136]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[136], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_ca_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[137]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[137], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_delete_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[138]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[138], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_doublewide_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[139]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[139], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_insert_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[140]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[140], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_italics_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[141]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[141], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_leftward_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[142]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[142], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_micro_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[143]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[143], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_shadow_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[144]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[144], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_standout_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[145]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[145], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_subscript_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[146]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[146], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_superscript_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[147]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[147], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_underline_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[148]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[148], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_upward_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[149]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[149], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_xon_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[150]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[150], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability fixed_pause_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[151]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[151], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability flash_hook_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[152]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[152], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability flash_screen_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[153]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[153], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability form_feed_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[154]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[154], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability from_status_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[155]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[155], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability goto_window_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[156]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[156], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability hangup_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[157]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[157], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_1string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[158]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[158], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_2string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[159]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[159], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_3string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[160]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[160], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_file_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[161]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[161], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability init_prog_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[162]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[162], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability initialize_color_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[163]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[163], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability initialize_pair_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[164]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[164], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability insert_character_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[165]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[165], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability insert_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[166]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[166], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability insert_padding_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[167]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[167], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_a1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[168]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[168], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_a3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[169]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[169], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_b2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[170]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[170], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_backspace_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[171]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[171], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_beg_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[172]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[172], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_btab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[173]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[173], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_c1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[174]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[174], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_c3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[175]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[175], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_cancel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[176]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[176], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_catab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[177]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[177], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_clear_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[178]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[178], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_close_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[179]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[179], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_command_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[180]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[180], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_copy_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[181]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[181], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_create_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[182]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[182], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ctab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[183]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[183], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_dc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[184]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[184], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_dl_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[185]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[185], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_down_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[186]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[186], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_eic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[187]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[187], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_end_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[188]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[188], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_enter_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[189]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[189], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_eol_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[190]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[190], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_eos_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[191]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[191], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_exit_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[192]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[192], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[193]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[193], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[194]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[194], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f10_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[195]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[195], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f11_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[196]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[196], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f12_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[197]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[197], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f13_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[198]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[198], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f14_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[199]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[199], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f15_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[200]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[200], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f16_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[201]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[201], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f17_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[202]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[202], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f18_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[203]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[203], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f19_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[204]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[204], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[205]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[205], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f20_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[206]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[206], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f21_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[207]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[207], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f22_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[208]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[208], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f23_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[209]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[209], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f24_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[210]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[210], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f25_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[211]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[211], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f26_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[212]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[212], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f27_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[213]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[213], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f28_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[214]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[214], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f29_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[215]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[215], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[216]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[216], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f30_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[217]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[217], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f31_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[218]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[218], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f32_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[219]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[219], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f33_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[220]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[220], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f34_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[221]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[221], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f35_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[222]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[222], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f36_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[223]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[223], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f37_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[224]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[224], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f38_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[225]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[225], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f39_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[226]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[226], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f4_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[227]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[227], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f40_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[228]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[228], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f41_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[229]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[229], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f42_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[230]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[230], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f43_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[231]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[231], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f44_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[232]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[232], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f45_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[233]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[233], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f46_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[234]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[234], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f47_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[235]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[235], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f48_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[236]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[236], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f49_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[237]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[237], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f5_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[238]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[238], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f50_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[239]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[239], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f51_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[240]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[240], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f52_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[241]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[241], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f53_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[242]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[242], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f54_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[243]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[243], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f55_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[244]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[244], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f56_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[245]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[245], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f57_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[246]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[246], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f58_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[247]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[247], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f59_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[248]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[248], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f6_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[249]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[249], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f60_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[250]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[250], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f61_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[251]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[251], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f62_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[252]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[252], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f63_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[253]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[253], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f7_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[254]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[254], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f8_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[255]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[255], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_f9_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[256]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[256], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_find_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[257]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[257], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_help_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[258]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[258], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_home_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[259]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[259], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[260]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[260], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_il_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[261]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[261], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[262]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[262], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ll_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[263]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[263], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_mark_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[264]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[264], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_message_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[265]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[265], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_move_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[266]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[266], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_next_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[267]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[267], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_npage_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[268]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[268], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_open_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[269]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[269], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_options_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[270]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[270], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ppage_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[271]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[271], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_previous_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[272]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[272], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_print_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[273]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[273], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_redo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[274]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[274], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_reference_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[275]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[275], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_refresh_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[276]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[276], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_replace_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[277]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[277], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_restart_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[278]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[278], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_resume_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[279]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[279], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[280]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[280], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_save_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[281]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[281], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sbeg_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[282]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[282], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_scancel_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[283]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[283], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_scommand_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[284]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[284], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_scopy_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[285]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[285], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_screate_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[286]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[286], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sdc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[287]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[287], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sdl_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[288]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[288], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_select_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[289]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[289], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_send_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[290]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[290], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_seol_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[291]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[291], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sexit_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[292]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[292], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sf_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[293]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[293], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sfind_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[294]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[294], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_shelp_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[295]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[295], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_shome_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[296]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[296], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[297]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[297], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sleft_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[298]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[298], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_smessage_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[299]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[299], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_smove_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[300]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[300], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_snext_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[301]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[301], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_soptions_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[302]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[302], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sprevious_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[303]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[303], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sprint_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[304]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[304], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sr_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[305]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[305], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sredo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[306]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[306], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sreplace_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[307]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[307], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sright_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[308]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[308], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_srsume_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[309]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[309], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ssave_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[310]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[310], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_ssuspend_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[311]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[311], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_stab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[312]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[312], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_sundo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[313]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[313], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_suspend_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[314]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[314], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_undo_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[315]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[315], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_up_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[316]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[316], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability keypad_local_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[317]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[317], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability keypad_xmit_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[318]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[318], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[319]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[319], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[320]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[320], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f10_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[321]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[321], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[322]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[322], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[323]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[323], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f4_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[324]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[324], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f5_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[325]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[325], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f6_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[326]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[326], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f7_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[327]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[327], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f8_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[328]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[328], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability lab_f9_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[329]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[329], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability label_format_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[330]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[330], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability label_off_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[331]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[331], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability label_on_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[332]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[332], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability meta_off_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[333]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[333], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability meta_on_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[334]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[334], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_column_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[335]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[335], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_down_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[336]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[336], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_left_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[337]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[337], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_right_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[338]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[338], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_row_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[339]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[339], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability micro_up_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[340]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[340], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability newline_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[341]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[341], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability order_of_pins_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[342]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[342], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability orig_colors_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[343]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[343], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability orig_pair_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[344]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[344], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pad_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[345]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[345], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_dch_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[346]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[346], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_delete_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[347]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[347], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_down_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[348]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[348], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_down_micro_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[349]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[349], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_ich_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[350]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[350], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[351]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[351], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_insert_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[352]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[352], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_left_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[353]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[353], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_left_micro_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[354]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[354], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_right_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[355]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[355], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_right_micro_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[356]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[356], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_rindex_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[357]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[357], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_up_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[358]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[358], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability parm_up_micro_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[359]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[359], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pkey_key_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[360]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[360], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pkey_local_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[361]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[361], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pkey_xmit_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[362]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[362], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability plab_norm_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[363]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[363], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability print_screen_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[364]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[364], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability prtr_non_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[365]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[365], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability prtr_off_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[366]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[366], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability prtr_on_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[367]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[367], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pulse_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[368]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[368], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability quick_dial_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[369]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[369], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability remove_clock_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[370]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[370], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability repeat_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[371]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[371], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability req_for_input_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[372]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[372], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability reset_1string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[373]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[373], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability reset_2string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[374]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[374], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability reset_3string_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[375]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[375], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability reset_file_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[376]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[376], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability restore_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[377]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[377], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability row_address_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[378]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[378], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability save_cursor_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[379]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[379], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability scroll_forward_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[380]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[380], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability scroll_reverse_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[381]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[381], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability select_char_set_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[382]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[382], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__attributes__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[383]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[383], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__background__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[384]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[384], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__bottom__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[385]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[385], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__bottom__margin__parm__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[386]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[386], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__clock__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[387]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[387], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__color__pair__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[388]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[388], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__foreground__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[389]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[389], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__left__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[390]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[390], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__left__margin__parm__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[391]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[391], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__right__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[392]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[392], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__right__margin__parm__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[393]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[393], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__tab__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[394]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[394], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__top__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[395]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[395], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__top__margin__parm__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[396]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[396], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__window__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[397]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[397], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability start_bit_image_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[398]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[398], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability start_char_set_def_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[399]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[399], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability stop_bit_image_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[400]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[400], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability stop_char_set_def_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[401]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[401], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability subscript_characters_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[402]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[402], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability superscript_characters_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[403]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[403], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability tab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[404]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[404], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability these_cause_cr_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[405]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[405], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability to_status_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[406]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[406], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability tone_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[407]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[407], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability underline_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[408]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[408], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability up_half_line_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[409]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[409], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user0_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[410]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[410], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user1_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[411]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[411], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user2_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[412]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[412], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user3_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[413]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[413], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user4_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[414]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[414], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user5_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[415]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[415], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user6_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[416]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[416], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user7_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[417]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[417], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user8_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[418]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[418], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability user9_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[419]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[419], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability wait_tone_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[420]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[420], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability xoff_character_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[421]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[421], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability xon_character_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[422]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[422], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability zero_motion_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[423]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[423], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability alt_scancode_esc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[424]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[424], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bit_image_carriage_return_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[425]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[425], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bit_image_newline_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[426]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[426], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability bit_image_repeat_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[427]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[427], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability char_set_names_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[428]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[428], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability code_set_init_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[429]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[429], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability color_names_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[430]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[430], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability define_bit_image_region_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[431]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[431], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability device_type_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[432]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[432], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability display_pc_char_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[433]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[433], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability end_bit_image_region_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[434]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[434], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_pc_charset_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[435]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[435], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_scancode_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[436]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[436], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_pc_charset_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[437]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[437], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability exit_scancode_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[438]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[438], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability get__mouse__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[439]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[439], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability key_mouse_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[440]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[440], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability mouse_info_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[441]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[441], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pc_term_options_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[442]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[442], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability pkey_plab_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[443]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[443], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability req_mouse_pos_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[444]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[444], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability scancode_escape_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[445]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[445], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set0_des_seq_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[446]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[446], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set1_des_seq_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[447]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[447], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set2_des_seq_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[448]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[448], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set3_des_seq_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[449]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[449], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__a__background__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[450]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[450], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__a__foreground__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[451]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[451], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__color__band__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[452]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[452], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__lr__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[453]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[453], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__page__length__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[454]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[454], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__tb__margin__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[455]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[455], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_horizontal_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[456]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[456], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_left_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[457]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[457], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_low_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[458]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[458], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_right_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[459]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[459], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_top_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[460]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[460], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability enter_vertical_hl_mode_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[461]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[461], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__a__attributes__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[462]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[462], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static final")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability set__pglen__inch__Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[463]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[463], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[464]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[464], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Capability(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Capability(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/org/jline/utils/InfoCmp$Capability;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/org/jline/utils/InfoCmp$Capability;", "public static")]
		public static Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability byName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.jline.utils.InfoCmp.Capability>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
		public JavaArray<Dova.JDK.java.lang.String> getNames()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
	}
}
