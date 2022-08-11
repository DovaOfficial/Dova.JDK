/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.main;

[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public")]
public partial class Option
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Option()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "G", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "G_NONE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "G_CUSTOM", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XLINT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XLINT_CUSTOM", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDOCLINT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDOCLINT_CUSTOM", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDOCLINT_PACKAGE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOWARN", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERBOSE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEPRECATION", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_SOURCE_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UPGRADE_MODULE_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PATCH_MODULE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOT_CLASS_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XBOOTCLASSPATH_PREPEND", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XBOOTCLASSPATH_APPEND", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XBOOTCLASSPATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTDIRS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DJAVA_EXT_DIRS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENDORSEDDIRS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DJAVA_ENDORSED_DIRS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROC", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSOR", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSOR_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROCESSOR_MODULE_PATH", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAMETERS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "D", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLICIT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCODING", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TARGET", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RELEASE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREVIEW", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROFILE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERSION", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULLVERSION", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "A", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_MODULE_FOR_CREATED_FILES", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "X", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_LINT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "J", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOREINFO", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WERROR", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROMPT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRINTSOURCE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARNUNCHECKED", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMAXERRS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XMAXWARNS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSTDOUT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XPRINT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XPRINTROUNDS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XPRINTPROCESSORINFO", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XPREFER", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XXUSERPATHSFIRST", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XPKGINFO", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "O", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XJCOV", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUGIN", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XDIAGS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHOULDSTOP", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIAGS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XD", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_EXPORTS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_OPENS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_READS", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADD_MODULES", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIMIT_MODULES", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_VERSION", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCEFILE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTIRELEASE", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INHERIT_RUNTIME_ENVIRONMENT", "Lcom/sun/tools/javac/main/Option;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primaryName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argsNameKey", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descrKey", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/main/Option$OptionKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "Lcom/sun/tools/javac/main/Option$OptionGroup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argKind", "Lcom/sun/tools/javac/main/Option$ArgKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "choiceKind", "Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "choices", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SMALL_INDENT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LARGE_INDENT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_SYNOPSIS_WIDTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_MAX_LINE_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT_FORMAT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ArgKind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ArgKind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;[Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;Ljava/util/Set;Lcom/sun/tools/javac/main/Option$ArgKind;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(Ljava/lang/String;Ljava/util/Set;)Lcom/sun/tools/javac/main/Option;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "help", "(Lcom/sun/tools/javac/util/Log;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "help", "(Lcom/sun/tools/javac/util/Log;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "helpSynopsis", "(Ljava/lang/String;Lcom/sun/tools/javac/util/Log;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavaCompilerOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgKind", "()Lcom/sun/tools/javac/main/Option$ArgKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findSeparator", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getXLintChoices", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/util/Iterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavacToolOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasSeparateArg", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getOptions", "(Lcom/sun/tools/javac/main/Option$OptionGroup;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimaryName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavacFileManagerOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasArg", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "showHelp", "(Lcom/sun/tools/javac/util/Log;Lcom/sun/tools/javac/main/Option$OptionKind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/tools/javac/main/Option$OptionKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern", "()Ljava/util/regex/Pattern;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option G_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option G_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option G_CUSTOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XLINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XLINT_CUSTOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XDOCLINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XDOCLINT_CUSTOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XDOCLINT_PACKAGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option NOWARN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option VERBOSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DEPRECATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option CLASS_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option SOURCE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MODULE_SOURCE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MODULE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option UPGRADE_MODULE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option SYSTEM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PATCH_MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option BOOT_CLASS_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XBOOTCLASSPATH_PREPEND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XBOOTCLASSPATH_APPEND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XBOOTCLASSPATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option EXTDIRS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DJAVA_EXT_DIRS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ENDORSEDDIRS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DJAVA_ENDORSED_DIRS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROCESSOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROCESSOR_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROCESSOR_MODULE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PARAMETERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option D_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option H_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option IMPLICIT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ENCODING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option SOURCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option TARGET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option RELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PREVIEW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROFILE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option FULLVERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option HELP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DEFAULT_MODULE_FOR_CREATED_FILES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option X_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option HELP_LINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option J_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MOREINFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option WERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PROMPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DOE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PRINTSOURCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option WARNUNCHECKED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XMAXERRS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XMAXWARNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XSTDOUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XPRINT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XPRINTROUNDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XPRINTPROCESSORINFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XPREFER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XXUSERPATHSFIRST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XPKGINFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option O_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XJCOV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option PLUGIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XDIAGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option SHOULDSTOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option DIAGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option XD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ADD_EXPORTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ADD_OPENS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ADD_READS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option ADD_MODULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option LIMIT_MODULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MODULE_VERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option AT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option SOURCEFILE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option MULTIRELEASE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.main.Option INHERIT_RUNTIME_ENVIRONMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String primaryName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "public final")]
	public JavaArray<Dova.JDK.java.lang.String> names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String argsNameKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String descrKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionKind;", "private final")]
	public Dova.JDK.com.sun.tools.javac.main.Option.OptionKind kind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "private final")]
	public Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup group_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ArgKind;", "private final")]
	public Dova.JDK.com.sun.tools.javac.main.Option.ArgKind argKind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ChoiceKind;", "private final")]
	public Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind choiceKind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set choices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String SMALL_INDENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String LARGE_INDENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_SYNOPSIS_WIDTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[94]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[94], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_MAX_LINE_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[95]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[95], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String COMPACT_FORMAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option;", "private static final")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Option(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ArgKind;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg5, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg6, Dova.JDK.com.sun.tools.javac.main.Option.ArgKind arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ArgKind;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg5, Dova.JDK.com.sun.tools.javac.main.Option.ArgKind arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg5, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;[Ljava/lang/String;)V", "private transient")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg5, Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind arg6, JavaArray<Dova.JDK.java.lang.String> arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;Ljava/util/Set;Lcom/sun/tools/javac/main/Option$ArgKind;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg5, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg6, Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind arg7, Dova.JDK.java.util.Set arg8, Dova.JDK.com.sun.tools.javac.main.Option.ArgKind arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/tools/javac/main/Option$OptionKind;Lcom/sun/tools/javac/main/Option$OptionGroup;Lcom/sun/tools/javac/main/Option$ChoiceKind;Ljava/util/Set;)V", "private")]
	public Option(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg5, Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg6, Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind arg7, Dova.JDK.java.util.Set arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.main.Option valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool matches(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "private")]
	public bool matches(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Set;)Lcom/sun/tools/javac/main/Option;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.main.Option lookup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.main.Option lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option;", "private static")]
	public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void process(Dova.JDK.com.sun.tools.javac.main.OptionHelper arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;)V", "public")]
	public void process(Dova.JDK.com.sun.tools.javac.main.OptionHelper arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log;)V", "protected")]
	public void help(Dova.JDK.com.sun.tools.javac.util.Log arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log;Ljava/lang/String;)V", "protected")]
	public void help(Dova.JDK.com.sun.tools.javac.util.Log arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/util/Log;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String helpSynopsis(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.util.Log arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set getJavaCompilerOptions()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/main/Option$ArgKind;", "public")]
	public Dova.JDK.com.sun.tools.javac.main.Option.ArgKind getArgKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private static")]
	public static int findSeparator(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "private static")]
	public static Dova.JDK.java.util.Set getXLintChoices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/util/Iterator;)V", "public")]
	public void handleOption(Dova.JDK.com.sun.tools.javac.main.OptionHelper arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Iterator arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getJavacToolOptions()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasSeparateArg()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/main/Option$OptionGroup;)Ljava/util/Set;", "private static")]
	public static Dova.JDK.java.util.Set getOptions(Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getPrimaryName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public static")]
	public static Dova.JDK.java.util.Set getJavacFileManagerOptions()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasArg()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log;Lcom/sun/tools/javac/main/Option$OptionKind;)V", "private static")]
	public static void showHelp(Dova.JDK.com.sun.tools.javac.util.Log arg0, Dova.JDK.com.sun.tools.javac.main.Option.OptionKind arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/main/Option$OptionKind;", "public")]
	public Dova.JDK.com.sun.tools.javac.main.Option.OptionKind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/regex/Pattern;", "public")]
	public Dova.JDK.java.util.regex.Pattern getPattern()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionKind;", "public static final")]
	public partial class OptionKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OptionKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$OptionKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD", "Lcom/sun/tools/javac/main/Option$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDED", "Lcom/sun/tools/javac/main/Option$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HIDDEN", "Lcom/sun/tools/javac/main/Option$OptionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$OptionKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$OptionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$OptionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$OptionKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionKind STANDARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionKind EXTENDED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionKind HIDDEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$OptionKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OptionKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$OptionKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$OptionKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$OptionKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$OptionKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ArgKind;", "public static final")]
	public partial class ArgKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$ArgKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lcom/sun/tools/javac/main/Option$ArgKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REQUIRED", "Lcom/sun/tools/javac/main/Option$ArgKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADJACENT", "Lcom/sun/tools/javac/main/Option$ArgKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$ArgKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$ArgKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$ArgKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$ArgKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ArgKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ArgKind NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ArgKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ArgKind REQUIRED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ArgKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ArgKind ADJACENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$ArgKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArgKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ArgKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$ArgKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$ArgKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$ArgKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ArgKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$ArgKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ArgKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "static final")]
	public partial class OptionGroup
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OptionGroup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$OptionGroup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASIC", "Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILEMANAGER", "Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INFO", "Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPERAND", "Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$OptionGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$OptionGroup;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup BASIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup FILEMANAGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup OPERAND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$OptionGroup;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OptionGroup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OptionGroup(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$OptionGroup;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$OptionGroup;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$OptionGroup;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.OptionGroup>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ChoiceKind;", "static final")]
	public partial class ChoiceKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChoiceKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$ChoiceKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONEOF", "Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANYOF", "Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$ChoiceKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ChoiceKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind ONEOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$ChoiceKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind ANYOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$ChoiceKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChoiceKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ChoiceKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$ChoiceKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$ChoiceKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$ChoiceKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$ChoiceKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.ChoiceKind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$InvalidValueException;", "public static")]
	public partial class InvalidValueException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvalidValueException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$InvalidValueException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvalidValueException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public InvalidValueException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public InvalidValueException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$InvalidValueException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static final")]
	public partial class PkgInfo
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PkgInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$PkgInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALWAYS", "Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEGACY", "Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONEMPTY", "Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Lcom/sun/tools/javac/util/Options;)Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$PkgInfo;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$PkgInfo;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo ALWAYS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo LEGACY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo NONEMPTY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$PkgInfo;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PkgInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public PkgInfo(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$PkgInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;)Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo get(Dova.JDK.com.sun.tools.javac.util.Options arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$PkgInfo;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$PkgInfo;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.PkgInfo>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$HiddenGroup;", "static final")]
	public partial class HiddenGroup
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HiddenGroup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/Option$HiddenGroup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIAGS", "Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHOULDSTOP", "Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/Option$HiddenGroup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "process", "(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$HiddenGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup DIAGS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$HiddenGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup DEBUG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/Option$HiddenGroup;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup SHOULDSTOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/Option$HiddenGroup;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HiddenGroup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public HiddenGroup(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/Option$HiddenGroup;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$HiddenGroup;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/Option$HiddenGroup;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/Option$HiddenGroup;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.Option.HiddenGroup>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/main/OptionHelper;Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public void process(Dova.JDK.com.sun.tools.javac.main.OptionHelper arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}
}
