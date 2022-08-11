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

namespace Dova.JDK.com.sun.tools.javac.processing;

[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "public")]
public partial class JavacProcessingEnvironment
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.annotation.processing.ProcessingEnvironment
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavacProcessingEnvironment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lcom/sun/tools/javac/util/Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printProcessorInfo", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printRounds", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verbose", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lint", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fatalErrors", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "werror", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showResolveErrors", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filer", "Lcom/sun/tools/javac/processing/JavacFiler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messager", "Lcom/sun/tools/javac/processing/JavacMessager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementUtils", "Lcom/sun/tools/javac/model/JavacElements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeUtils", "Lcom/sun/tools/javac/model/JavacTypes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compiler", "Lcom/sun/tools/javac/main/JavaCompiler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modules", "Lcom/sun/tools/javac/comp/Modules;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotate", "Lcom/sun/tools/javac/comp/Annotate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "discoveredProcs", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorOptions", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unmatchedProcessorOptions", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "platformAnnotations", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specifiedPackages", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorClassLoader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceLoader", "Ljava/util/ServiceLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorLoaderException", "Ljava/lang/SecurityException;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileManager", "Ljavax/tools/JavaFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "messages", "Lcom/sun/tools/javac/util/JavacMessages;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "taskListener", "Lcom/sun/tools/javac/api/MultiTaskListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symtab", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcfh", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enter", "Lcom/sun/tools/javac/comp/Enter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialCompleter", "Lcom/sun/tools/javac/code/Symbol$Completer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/tools/javac/util/Context;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preview", "Lcom/sun/tools/javac/code/Preview;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeCleaner", "Lcom/sun/tools/javac/tree/TreeScanner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noMatches", "Ljava/util/regex/Pattern;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "join", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "()Lcom/sun/tools/javac/util/Context;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceLoader", "(Ljava/lang/Class;)Ljava/util/ServiceLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidOptionName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPkgInfo", "(Ljavax/tools/JavaFileObject;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPkgInfo", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOptions", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleException", "(Ljava/lang/String;Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModuleInfo", "(Ljavax/tools/JavaFileObject;Ljavax/tools/JavaFileObject$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageInfoFilesFromClasses", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleInfoFiles", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setProcessors", "(Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProcessorLoader", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProcessorIterator", "(Ljava/lang/Iterable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atLeastOneProcessor", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callProcessor", "(Ljavax/annotation/processing/Processor;Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFiler_0", "()Lcom/sun/tools/javac/processing/JavacFiler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFiler_1", "()Ljavax/annotation/processing/Filer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warnIfUnmatchedOptions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "warnAndNoMatches", "(Ljava/lang/String;Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Z)Ljava/util/regex/Pattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initUnmatchedProcessorOptions", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPlatformAnnotations", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProcessorClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needClassLoader", "(Ljava/lang/String;Ljava/lang/Iterable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "discoverAndRunProcs", "(Ljava/util/Set;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moreToDo", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTopLevelClassesFromClasses", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTopLevelClasses", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProcessorOptions", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleServiceLoaderUnavailability", "(Ljava/lang/String;Ljava/lang/Exception;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doProcessing", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/lang/Iterable;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageInfoFiles", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMessager", "()Ljavax/annotation/processing/Messager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPreviewEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecifiedPackages", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "importStringToPattern", "(ZLjava/lang/String;Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Z)Ljava/util/regex/Pattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementUtils_0", "()Ljavax/lang/model/util/Elements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementUtils_1", "()Lcom/sun/tools/javac/model/JavacElements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceVersion", "()Ljavax/lang/model/SourceVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeUtils_0", "()Lcom/sun/tools/javac/model/JavacTypes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeUtils_1", "()Ljavax/lang/model/util/Types;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Options;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool printProcessorInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool printRounds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool verbose_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool lint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool fatalErrors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool werror_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool showResolveErrors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacFiler;", "private final")]
	public Dova.JDK.com.sun.tools.javac.processing.JavacFiler filer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacFiler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacMessager;", "private final")]
	public Dova.JDK.com.sun.tools.javac.processing.JavacMessager messager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacMessager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/model/JavacElements;", "private final")]
	public Dova.JDK.com.sun.tools.javac.model.JavacElements elementUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.model.JavacElements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/model/JavacTypes;", "private final")]
	public Dova.JDK.com.sun.tools.javac.model.JavacTypes typeUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.model.JavacTypes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler;", "private final")]
	public Dova.JDK.com.sun.tools.javac.main.JavaCompiler compiler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Modules;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Modules modules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Modules>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Annotate;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Annotate annotate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Annotate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;", "private")]
	public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors discoveredProcs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map processorOptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set unmatchedProcessorOptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set platformAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set specifiedPackages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "final")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "")]
	public Dova.JDK.com.sun.tools.javac.code.Source source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader processorClassLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ServiceLoader;", "private")]
	public Dova.JDK.java.util.ServiceLoader serviceLoader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/SecurityException;", "private")]
	public Dova.JDK.java.lang.SecurityException processorLoaderException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.SecurityException>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "private final")]
	public Dova.JDK.javax.tools.JavaFileManager fileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JavacMessages;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.JavacMessages messages_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JavacMessages>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/MultiTaskListener;", "private")]
	public Dova.JDK.com.sun.tools.javac.api.MultiTaskListener taskListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.MultiTaskListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab symtab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler dcfh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Enter;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Enter enter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Enter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$Completer;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.Completer initialCompleter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.Completer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "private final")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Context context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Preview;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Preview preview_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Preview>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeScanner;", "private final")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeScanner treeCleaner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeScanner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "public static final")]
	public static Dova.JDK.java.util.regex.Pattern noMatches_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavacProcessingEnvironment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public JavacProcessingEnvironment(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private static")]
	public static Dova.JDK.com.sun.tools.javac.util.List join(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Context;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Context getContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/ServiceLoader;", "public")]
	public Dova.JDK.java.util.ServiceLoader getServiceLoader(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public static")]
	public static bool isValidOptionName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljavax/tools/JavaFileObject$Kind;)Z", "private")]
	public bool isPkgInfo(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)Z", "private")]
	public bool isPkgInfo(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Exception;)V", "private")]
	public void handleException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Exception arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljavax/tools/JavaFileObject$Kind;)Z", "private")]
	public bool isModuleInfo(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getPackageInfoFilesFromClasses(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getModuleInfoFiles(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public")]
	public void setProcessors(Dova.JDK.java.lang.Iterable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initProcessorLoader()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "private")]
	public void initProcessorIterator(Dova.JDK.java.lang.Iterable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool atLeastOneProcessor()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/annotation/processing/Processor;Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z", "private")]
	public bool callProcessor(Dova.JDK.javax.annotation.processing.Processor arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.javax.annotation.processing.RoundEnvironment arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/processing/JavacFiler;", "public")]
	public Dova.JDK.com.sun.tools.javac.processing.JavacFiler getFiler_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacFiler>(ret);
	}

	[JniSignatureAttribute("()Ljavax/annotation/processing/Filer;", "public volatile")]
	public Dova.JDK.javax.annotation.processing.Filer getFiler_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Filer>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void warnIfUnmatchedOptions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Z)Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern warnAndNoMatches(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.annotation.processing.Processor arg1, Dova.JDK.com.sun.tools.javac.util.Log arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set initUnmatchedProcessorOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set initPlatformAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getProcessorClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Iterable;)Z", "private")]
	public bool needClassLoader(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Iterable arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Set;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "private")]
	public void discoverAndRunProcs(Dova.JDK.java.util.Set arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool moreToDo()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getTopLevelClassesFromClasses(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getTopLevelClasses(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map initProcessorOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Exception;)Ljava/util/Iterator;", "private")]
	public Dova.JDK.java.util.Iterator handleServiceLoaderUnavailability(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Exception arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/lang/Iterable;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Z", "public")]
	public bool doProcessing(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.java.lang.Iterable arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List getPackageInfoFiles(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljavax/annotation/processing/Messager;", "public")]
	public Dova.JDK.javax.annotation.processing.Messager getMessager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Messager>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPreviewEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getSpecifiedPackages()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(ZLjava/lang/String;Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Z)Ljava/util/regex/Pattern;", "private static")]
	public static Dova.JDK.java.util.regex.Pattern importStringToPattern(bool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.annotation.processing.Processor arg2, Dova.JDK.com.sun.tools.javac.util.Log arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Elements;", "public volatile")]
	public Dova.JDK.javax.lang.model.util.Elements getElementUtils_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/model/JavacElements;", "public")]
	public Dova.JDK.com.sun.tools.javac.model.JavacElements getElementUtils_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.model.JavacElements>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/SourceVersion;", "public")]
	public Dova.JDK.javax.lang.model.SourceVersion getSourceVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.SourceVersion>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/model/JavacTypes;", "public")]
	public Dova.JDK.com.sun.tools.javac.model.JavacTypes getTypeUtils_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.model.JavacTypes>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/util/Types;", "public volatile")]
	public Dova.JDK.javax.lang.model.util.Types getTypeUtils_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;", "")]
	public partial class DiscoveredProcessors
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Iterable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DiscoveredProcessors()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorIterator", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "procStateList", "Ljava/util/ArrayList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/Iterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_0", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator_1", "()Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors$ProcessorStateIterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "")]
		public Dova.JDK.java.util.Iterator processorIterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "")]
		public Dova.JDK.java.util.ArrayList procStateList_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "final")]
		public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DiscoveredProcessors(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/Iterator;)V", "")]
		public DiscoveredProcessors(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.java.util.Iterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public volatile")]
		public Dova.JDK.java.util.Iterator iterator_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors$ProcessorStateIterator;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors.ProcessorStateIterator iterator_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors.ProcessorStateIterator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors$ProcessorStateIterator;", "")]
		public partial class ProcessorStateIterator
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.Iterator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ProcessorStateIterator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors$ProcessorStateIterator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "psi", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "innerIter", "Ljava/util/Iterator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "onProcIterator", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ProcessorState;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runContributingProcs", "(Ljavax/annotation/processing/RoundEnvironment;)V"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;", "")]
			public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors psi_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Iterator;", "")]
			public Dova.JDK.java.util.Iterator innerIter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "")]
			public bool onProcIterator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;", "final")]
			public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ProcessorStateIterator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors;)V", "")]
			public ProcessorStateIterator(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors arg0, Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.DiscoveredProcessors arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$DiscoveredProcessors$ProcessorStateIterator;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void remove()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasNext()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object next_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ProcessorState;", "public")]
			public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.ProcessorState next_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.ProcessorState>(ret);
			}

			[JniSignatureAttribute("(Ljavax/annotation/processing/RoundEnvironment;)V", "public")]
			public void runContributingProcs(Dova.JDK.javax.annotation.processing.RoundEnvironment arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ServiceIterator;", "private")]
	public partial class ServiceIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ServiceIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ServiceIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iterator", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loader", "Ljava/util/ServiceLoader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/lang/ClassLoader;Lcom/sun/tools/javac/util/Log;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/ServiceLoader;Lcom/sun/tools/javac/util/Log;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljavax/annotation/processing/Processor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalHasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalNext", "()Ljavax/annotation/processing/Processor;"));
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "")]
		public Dova.JDK.java.util.Iterator iterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "")]
		public Dova.JDK.com.sun.tools.javac.util.Log log_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/ServiceLoader;", "")]
		public Dova.JDK.java.util.ServiceLoader loader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ServiceIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/lang/ClassLoader;Lcom/sun/tools/javac/util/Log;)V", "")]
		public ServiceIterator(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.com.sun.tools.javac.util.Log arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/ServiceLoader;Lcom/sun/tools/javac/util/Log;)V", "")]
		public ServiceIterator(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.java.util.ServiceLoader arg1, Dova.JDK.com.sun.tools.javac.util.Log arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ServiceIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljavax/annotation/processing/Processor;", "public")]
		public Dova.JDK.javax.annotation.processing.Processor next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool internalHasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/annotation/processing/Processor;", "")]
		public Dova.JDK.javax.annotation.processing.Processor internalNext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameServiceIterator;", "private")]
	public partial class NameServiceIterator
		: Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.ServiceIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NameServiceIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameServiceIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namedProcessorsMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorNames", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextProc", "Ljavax/annotation/processing/Processor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/ServiceLoader;Lcom/sun/tools/javac/util/Log;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalHasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalNext", "()Ljavax/annotation/processing/Processor;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map namedProcessorsMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "private")]
		public Dova.JDK.java.util.Iterator processorNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/annotation/processing/Processor;", "private")]
		public Dova.JDK.javax.annotation.processing.Processor nextProc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NameServiceIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Ljava/util/ServiceLoader;Lcom/sun/tools/javac/util/Log;Ljava/lang/String;)V", "public")]
		public NameServiceIterator(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.java.util.ServiceLoader arg1, Dova.JDK.com.sun.tools.javac.util.Log arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameServiceIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "")]
		public bool internalHasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/annotation/processing/Processor;", "")]
		public Dova.JDK.javax.annotation.processing.Processor internalNext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameProcessIterator;", "private static")]
	public partial class NameProcessIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NameProcessIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameProcessIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextProc", "Ljavax/annotation/processing/Processor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Ljava/util/Iterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processorCL", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;Lcom/sun/tools/javac/util/Log;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Ljavax/annotation/processing/Processor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextProcessor", "(Ljava/lang/String;)Ljavax/annotation/processing/Processor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureReadable", "(Ljava/lang/Class;)V"));
		}

		[JniSignatureAttribute("Ljavax/annotation/processing/Processor;", "")]
		public Dova.JDK.javax.annotation.processing.Processor nextProc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Iterator;", "")]
		public Dova.JDK.java.util.Iterator names_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "")]
		public Dova.JDK.java.lang.ClassLoader processorCL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "")]
		public Dova.JDK.com.sun.tools.javac.util.Log log_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NameProcessIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;Lcom/sun/tools/javac/util/Log;)V", "")]
		public NameProcessIterator(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.com.sun.tools.javac.util.Log arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$NameProcessIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljavax/annotation/processing/Processor;", "public")]
		public Dova.JDK.javax.annotation.processing.Processor next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/annotation/processing/Processor;", "private")]
		public Dova.JDK.javax.annotation.processing.Processor getNextProcessor(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
		public void ensureReadable(Dova.JDK.java.lang.Class arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ProcessorState;", "static")]
	public partial class ProcessorState
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProcessorState()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ProcessorState;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processor", "Ljavax/annotation/processing/Processor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contributed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedAnnotationStrings", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedAnnotationPatterns", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedOptionNames", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;ZLjavax/annotation/processing/ProcessingEnvironment;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotationSupported", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSupportedOptions", "(Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSourceVersionCompatibility", "(Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/Log;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkOptionName", "(Ljava/lang/String;Lcom/sun/tools/javac/util/Log;)Z"));
		}

		[JniSignatureAttribute("Ljavax/annotation/processing/Processor;", "public")]
		public Dova.JDK.javax.annotation.processing.Processor processor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.annotation.processing.Processor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool contributed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set supportedAnnotationStrings_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set supportedAnnotationPatterns_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set supportedOptionNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProcessorState(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/annotation/processing/Processor;Lcom/sun/tools/javac/util/Log;Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;ZLjavax/annotation/processing/ProcessingEnvironment;Z)V", "")]
		public ProcessorState(Dova.JDK.javax.annotation.processing.Processor arg0, Dova.JDK.com.sun.tools.javac.util.Log arg1, Dova.JDK.com.sun.tools.javac.code.Source arg2, Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler arg3, bool arg4, Dova.JDK.javax.annotation.processing.ProcessingEnvironment arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ProcessorState;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
		public bool annotationSupported(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;)V", "public")]
		public void removeSupportedOptions(Dova.JDK.java.util.Set arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Source;Lcom/sun/tools/javac/util/Log;)V", "private")]
		public void checkSourceVersionCompatibility(Dova.JDK.com.sun.tools.javac.code.Source arg0, Dova.JDK.com.sun.tools.javac.util.Log arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/util/Log;)Z", "private")]
		public bool checkOptionName(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.util.Log arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;", "")]
	public partial class Round
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Round()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "number", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferredDiagnosticHandler", "Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "roots", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treesToClean", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genClassFiles", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationsPresent", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topLevelClasses", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageInfoFiles", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleInfoFiles", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ACCEPT_NON_RECOVERABLE", "Ljava/util/function/Predicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ACCEPT_ALL", "Ljava/util/function/Predicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;Ljava/util/Set;Ljava/util/Map;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/util/Set;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;ILjava/util/Set;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "(ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "(Ljava/util/Set;Ljava/util/Map;)Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enterTrees", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRound", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warningCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finalCompiler", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unrecoverableError", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showDiagnostics", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAnnotationsPresent", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enterClassFiles", "(Ljava/util/Map;)Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printRoundInfo", "(Z)V"));
		}

		[JniSignatureAttribute("I", "final")]
		public int number_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler deferredDiagnosticHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List roots_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set treesToClean_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "")]
		public Dova.JDK.java.util.Map genClassFiles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set annotationsPresent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List topLevelClasses_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List packageInfoFiles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "")]
		public Dova.JDK.com.sun.tools.javac.util.List moduleInfoFiles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
		public Dova.JDK.java.util.function.Predicate ACCEPT_NON_RECOVERABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
		public Dova.JDK.java.util.function.Predicate ACCEPT_ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "final")]
		public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Round(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;Ljava/util/Set;Ljava/util/Map;)V", "private")]
		public Round(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.Round arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Ljava/util/Set;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V", "")]
		public Round(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;ILjava/util/Set;Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V", "private")]
		public Round(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, int arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ZZ)V", "")]
		public void run(bool arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Map;)Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$Round;", "")]
		public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.Round next(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Map arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment.Round>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int errorCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "private")]
		public void enterTrees(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void newRound()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()I", "")]
		public int warningCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void finalCompiler()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool unrecoverableError()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "")]
		public void showDiagnostics(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void findAnnotationsPresent()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Lcom/sun/tools/javac/util/List;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.List enterClassFiles(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Z)V", "private")]
		public void printRoundInfo(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ImplicitCompleter;", "")]
	public partial class ImplicitCompleter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.code.Symbol.Completer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplicitCompleter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ImplicitCompleter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topLevel", "Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lcom/sun/tools/javac/code/Symbol;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit topLevel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "final")]
		public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImplicitCompleter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V", "public")]
		public ImplicitCompleter(Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ImplicitCompleter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol;)V", "public")]
		public void complete(Dova.JDK.com.sun.tools.javac.code.Symbol arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ComputeAnnotationSet;", "public static")]
	public partial class ComputeAnnotationSet
		: Dova.JDK.javax.lang.model.util.ElementScanner14
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComputeAnnotationSet()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ComputeAnnotationSet;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elements", "Ljavax/lang/model/util/Elements;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/util/Elements;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Ljavax/lang/model/element/Element;Ljava/util/Set;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Ljavax/lang/model/element/PackageElement;Ljava/util/Set;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Ljavax/lang/model/element/PackageElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/util/Set;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/util/Set;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAnnotations", "(Ljavax/lang/model/element/Element;Ljava/util/Set;)V"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "final")]
		public Dova.JDK.javax.lang.model.util.Elements elements_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComputeAnnotationSet(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/util/Elements;)V", "public")]
		public ComputeAnnotationSet(Dova.JDK.javax.lang.model.util.Elements arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment$ComputeAnnotationSet;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object scan(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/Set;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set scan(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljava/util/Set;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set visitPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/util/Set;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/util/Set;)Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.util.Set arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/util/Set;)V", "")]
		public void addAnnotations(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.util.Set arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}
	}
}
