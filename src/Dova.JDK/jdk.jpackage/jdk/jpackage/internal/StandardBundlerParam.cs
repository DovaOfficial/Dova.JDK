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

namespace Dova.JDK.jdk.jpackage.@internal;

[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "")]
public partial class StandardBundlerParam
	: Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardBundlerParam()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jpackage/internal/StandardBundlerParam;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JAVABASEJMOD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_VERSION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_RELEASE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_JLINK_OPTIONS", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LAUNCHER_DATA", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SOURCE_DIR", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAIN_JAR", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAIN_CLASS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREDEFINED_RUNTIME_IMAGE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREDEFINED_APP_IMAGE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "APP_NAME", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTALLER_NAME", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ICON", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ABOUT_URL", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VENDOR", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DESCRIPTION", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COPYRIGHT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARGUMENTS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JAVA_OPTIONS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VERSION", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RELEASE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LICENSE_FILE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TEMP_ROOT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONFIG_ROOT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VERBOSE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SHORTCUT_HINT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MENU_HINT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RESOURCE_DIR", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTALL_DIR", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ADD_LAUNCHERS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FILE_ASSOCIATIONS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FA_EXTENSIONS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FA_CONTENT_TYPE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FA_DESCRIPTION", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FA_ICON", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DMG_CONTENT", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "APP_CONTENT", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULE_PATH", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULE", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ADD_MODULES", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JLINK_OPTIONS", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LIMIT_MODULES", "Ljdk/jpackage/internal/BundlerParamInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SIGN_BUNDLE", "Ljdk/jpackage/internal/StandardBundlerParam;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StandardBundlerParam", "(Ljava/lang/String;Ljava/lang/Class;Ljava/util/function/Function;Ljava/util/function/BiFunction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPredefinedAppImage", "(Ljava/util/Map;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDefaultModulePath", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "findPathOfModule", "(Ljava/util/List;Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDefaultAppVersion", "(Ljava/util/Map;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isRuntimeInstaller", "(Ljava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "copyPredefinedRuntimeImage", "(Ljava/util/Map;Ljdk/jpackage/internal/ApplicationLayout;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String JAVABASEJMOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String DEFAULT_RELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> DEFAULT_JLINK_OPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam LAUNCHER_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam SOURCE_DIR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam MAIN_JAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam MAIN_CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam PREDEFINED_RUNTIME_IMAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam PREDEFINED_APP_IMAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam APP_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam INSTALLER_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam ICON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam ABOUT_URL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam VENDOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam COPYRIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam ARGUMENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam JAVA_OPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam RELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "public static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam LICENSE_FILE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam TEMP_ROOT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "public static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam CONFIG_ROOT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam VERBOSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam SHORTCUT_HINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam MENU_HINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam RESOURCE_DIR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo INSTALL_DIR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam ADD_LAUNCHERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam FILE_ASSOCIATIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam FA_EXTENSIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam FA_CONTENT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam FA_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam FA_ICON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo DMG_CONTENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam APP_CONTENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo MODULE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo ADD_MODULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam JLINK_OPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/BundlerParamInfo;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo LIMIT_MODULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.BundlerParamInfo>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jpackage/internal/StandardBundlerParam;", "static final")]
	public static Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam SIGN_BUNDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jpackage.@internal.StandardBundlerParam>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardBundlerParam(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;Ljava/util/function/Function;Ljava/util/function/BiFunction;)V", "")]
	public StandardBundlerParam(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.function.Function arg2, Dova.JDK.java.util.function.BiFunction arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jpackage/internal/StandardBundlerParam;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/nio/file/Path;", "static")]
	public static Dova.JDK.java.nio.file.Path getPredefinedAppImage(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List getDefaultModulePath()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)Ljava/nio/file/Path;", "private static")]
	public static Dova.JDK.java.nio.file.Path findPathOfModule(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getDefaultAppVersion(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Z", "static")]
	public static bool isRuntimeInstaller(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljdk/jpackage/internal/ApplicationLayout;)V", "static")]
	public static void copyPredefinedRuntimeImage(Dova.JDK.java.util.Map arg0, Dova.JDK.jdk.jpackage.@internal.ApplicationLayout arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
	}
}
