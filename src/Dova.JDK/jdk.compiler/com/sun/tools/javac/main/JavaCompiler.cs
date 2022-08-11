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

[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler;", "public")]
public partial class JavaCompiler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaCompiler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/JavaCompiler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "compilerKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "versionRBName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "versionRB", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_COMPILE_POLICY", "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Lcom/sun/tools/javac/util/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diagFactory", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "make", "Lcom/sun/tools/javac/tree/TreeMaker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finder", "Lcom/sun/tools/javac/code/ClassFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reader", "Lcom/sun/tools/javac/jvm/ClassReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Lcom/sun/tools/javac/jvm/ClassWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jniWriter", "Lcom/sun/tools/javac/jvm/JNIWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enter", "Lcom/sun/tools/javac/comp/Enter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syms", "Lcom/sun/tools/javac/code/Symtab;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Lcom/sun/tools/javac/code/Source;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preview", "Lcom/sun/tools/javac/code/Preview;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gen", "Lcom/sun/tools/javac/jvm/Gen;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attr", "Lcom/sun/tools/javac/comp/Attr;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "analyzer", "Lcom/sun/tools/javac/comp/Analyzer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chk", "Lcom/sun/tools/javac/comp/Check;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flow", "Lcom/sun/tools/javac/comp/Flow;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modules", "Lcom/sun/tools/javac/comp/Modules;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleFinder", "Lcom/sun/tools/javac/code/ModuleFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dcfh", "Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transTypes", "Lcom/sun/tools/javac/comp/TransTypes;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lower", "Lcom/sun/tools/javac/comp/Lower;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotate", "Lcom/sun/tools/javac/comp/Annotate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completionFailureName", "Lcom/sun/tools/javac/util/Name;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Lcom/sun/tools/javac/code/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileManager", "Ljavax/tools/JavaFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parserFactory", "Lcom/sun/tools/javac/parser/ParserFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "taskListener", "Lcom/sun/tools/javac/api/MultiTaskListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceCompleter", "Lcom/sun/tools/javac/code/Symbol$Completer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Lcom/sun/tools/javac/util/Options;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/tools/javac/util/Context;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationProcessingOccurred", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implicitSourceFilesRead", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enterDone", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compileStates", "Lcom/sun/tools/javac/comp/CompileStates;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verbose", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceOutput", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineDebugInfo", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genEndPos", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "devVerbose", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processPcks", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "werror", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "explicitAnnotationProcessingRequested", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compilePolicy", "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implicitSourcePolicy", "Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "verboseCompilePolicy", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldStopPolicyIfError", "Lcom/sun/tools/javac/comp/CompileStates$CompileState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "shouldStopPolicyIfNoError", "Lcom/sun/tools/javac/comp/CompileStates$CompileState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "todo", "Lcom/sun/tools/javac/comp/Todo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closeables", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputFiles", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "silentFail", "Lcom/sun/tools/javac/code/Symbol;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keepComments", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasBeenUsed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start_msec", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elapsed_msec", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootClasses", "Lcom/sun/tools/javac/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processAnnotations", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferredDiagnosticHandler", "Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "procEnvImpl", "Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "desugaredEnvs", "Ljava/util/HashMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "version", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "version", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Iterable;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/main/JavaCompiler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljavax/tools/JavaFileObject;Ljava/lang/CharSequence;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "elapsed", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generate", "(Ljava/util/Queue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generate", "(Ljava/util/Queue;Ljava/util/Queue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Ljava/util/Queue;)Ljava/util/Queue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldStop", "(Lcom/sun/tools/javac/comp/CompileStates$CompileState;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveIdent", "(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readModuleName", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "keepComments", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProcessAnnotations", "(Ljava/lang/Iterable;Ljava/util/Collection;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseFiles", "(Ljava/lang/Iterable;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseFiles", "(Ljava/lang/Iterable;Z)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initModules", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enterTrees", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAnnotations", "(Lcom/sun/tools/javac/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processAnnotations", "(Lcom/sun/tools/javac/util/List;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flow", "(Ljava/util/Queue;)Ljava/util/Queue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flow", "(Lcom/sun/tools/javac/comp/Env;)Ljava/util/Queue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flow", "(Lcom/sun/tools/javac/comp/Env;Ljava/util/Queue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "desugar", "(Lcom/sun/tools/javac/comp/Env;Ljava/util/Queue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "desugar", "(Ljava/util/Queue;)Ljava/util/Queue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportDeferredDiagnostics", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fullVersion", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newRound", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnterDone", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findPackageInFile", "(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "genCode", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseAndGetName", "(Ljavax/tools/JavaFileObject;Ljava/util/function/Function;)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "explicitAnnotationProcessingRequested", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "explicitAnnotationProcessingRequested", "(Lcom/sun/tools/javac/util/Options;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warningCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "continueAfterProcessAnnotations", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printNote", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enterDone", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unrecoverableError", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDeferredDiagnosticHandler", "(Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printSource", "(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeMethodBodies", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkReusable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopIfError", "(Lcom/sun/tools/javac/comp/CompileStates$CompileState;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopIfError", "(Lcom/sun/tools/javac/comp/CompileStates$CompileState;Ljava/util/Queue;)Ljava/util/Queue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupByFile", "(Ljava/util/Queue;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printCount", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printSuppressedCount", "(IILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readSource", "(Ljavax/tools/JavaFileObject;)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveBinaryNameOrIdent", "(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveBinaryNameOrIdent", "(Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readSourceFile", "(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readSourceFile", "(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key compilerKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String versionRBName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private static")]
	public static Dova.JDK.java.util.ResourceBundle versionRB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "private static final")]
	public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy DEFAULT_COMPILE_POLICY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Log log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diagFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/TreeMaker;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.TreeMaker make_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.TreeMaker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/ClassFinder;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.ClassFinder finder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.ClassFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassReader;", "protected")]
	public Dova.JDK.com.sun.tools.javac.jvm.ClassReader reader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/ClassWriter;", "protected")]
	public Dova.JDK.com.sun.tools.javac.jvm.ClassWriter writer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.ClassWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/JNIWriter;", "protected")]
	public Dova.JDK.com.sun.tools.javac.jvm.JNIWriter jniWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.JNIWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Enter;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Enter enter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Enter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symtab;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Symtab syms_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symtab>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Source;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Source source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Source>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Preview;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Preview preview_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Preview>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/Gen;", "protected")]
	public Dova.JDK.com.sun.tools.javac.jvm.Gen gen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.Gen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Attr;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Attr attr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Attr>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Analyzer;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Analyzer analyzer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Analyzer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Check;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Check chk_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Check>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Flow;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Flow flow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Flow>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Modules;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Modules modules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Modules>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/ModuleFinder;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.ModuleFinder moduleFinder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.ModuleFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/DeferredCompletionFailureHandler;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler dcfh_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.DeferredCompletionFailureHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/TransTypes;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.TransTypes transTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.TransTypes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Lower;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Lower lower_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Lower>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Annotate;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.Annotate annotate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Annotate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.util.Name completionFailureName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Types;", "protected")]
	public Dova.JDK.com.sun.tools.javac.code.Types types_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "protected")]
	public Dova.JDK.javax.tools.JavaFileManager fileManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ParserFactory;", "protected")]
	public Dova.JDK.com.sun.tools.javac.parser.ParserFactory parserFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ParserFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/MultiTaskListener;", "protected")]
	public Dova.JDK.com.sun.tools.javac.api.MultiTaskListener taskListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.MultiTaskListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$Completer;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol.Completer sourceCompleter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.Completer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Options;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Options options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Options>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Context context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool annotationProcessingOccurred_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool implicitSourceFilesRead_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool enterDone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/CompileStates;", "protected")]
	public Dova.JDK.com.sun.tools.javac.comp.CompileStates compileStates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.CompileStates>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool verbose_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool sourceOutput_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool lineDebugInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool genEndPos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool devVerbose_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool processPcks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool werror_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool explicitAnnotationProcessingRequested_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "protected")]
	public Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy compilePolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "protected")]
	public Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy implicitSourcePolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool verboseCompilePolicy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/CompileStates$CompileState;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState shouldStopPolicyIfError_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/CompileStates$CompileState;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState shouldStopPolicyIfNoError_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Todo;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Todo todo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Todo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List closeables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "protected")]
	public Dova.JDK.java.util.Set inputFiles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "private final")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol silentFail_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public")]
	public bool keepComments_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasBeenUsed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long start_msec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("J", "public")]
	public long elapsed_msec_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[60]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[60], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List rootClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool processAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[62]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[62], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;", "")]
	public Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler deferredDiagnosticHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/JavacProcessingEnvironment;", "private")]
	public Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment procEnvImpl_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.JavacProcessingEnvironment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "")]
	public Dova.JDK.java.util.HashMap desugaredEnvs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaCompiler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "public")]
	public JavaCompiler(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/JavaCompiler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String version()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String version(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Ljava/util/Collection;Ljava/lang/Iterable;Ljava/util/Collection;)V", "public")]
	public void compile(Dova.JDK.java.util.Collection arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.lang.Iterable arg2, Dova.JDK.java.util.Collection arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "public")]
	public void compile(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/main/JavaCompiler;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit parse(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit parse(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/lang/CharSequence;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit parse(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
	}

	[JniSignatureAttribute("(J)J", "private static")]
	public static long elapsed(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Queue;)V", "public")]
	public void generate(Dova.JDK.java.util.Queue arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;Ljava/util/Queue;)V", "public")]
	public void generate(Dova.JDK.java.util.Queue arg0, Dova.JDK.java.util.Queue arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/comp/Env;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Env attribute(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;)Ljava/util/Queue;", "public")]
	public Dova.JDK.java.util.Queue attribute(Dova.JDK.java.util.Queue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
	}

	[JniSignatureAttribute("()J", "private static")]
	public static long now()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/CompileStates$CompileState;)Z", "protected")]
	public bool shouldStop(Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol resolveIdent(Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/Name;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Name readModuleName(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int errorCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool keepComments()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Ljava/util/Collection;Ljava/util/Collection;)V", "public")]
	public void initProcessAnnotations(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.java.util.Collection arg1, Dova.JDK.java.util.Collection arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List parseFiles(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Z)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List parseFiles(Dova.JDK.java.lang.Iterable arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List initModules(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.List enterTrees(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "public")]
	public void processAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Ljava/util/Collection;)V", "public")]
	public void processAnnotations(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.java.util.Collection arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;)Ljava/util/Queue;", "public")]
	public Dova.JDK.java.util.Queue flow(Dova.JDK.java.util.Queue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)Ljava/util/Queue;", "public")]
	public Dova.JDK.java.util.Queue flow(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Ljava/util/Queue;)V", "protected")]
	public void flow(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.java.util.Queue arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Ljava/util/Queue;)V", "protected")]
	public void desugar(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.java.util.Queue arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;)Ljava/util/Queue;", "public")]
	public Dova.JDK.java.util.Queue desugar(Dova.JDK.java.util.Queue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void reportDeferredDiagnostics()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String fullVersion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void newRound()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnterDone()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Lcom/sun/tools/javac/util/Name;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Name findPackageInFile(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljavax/tools/JavaFileObject;", "")]
	public Dova.JDK.javax.tools.JavaFileObject genCode(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;Ljava/util/function/Function;)Lcom/sun/tools/javac/util/Name;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Name parseAndGetName(Dova.JDK.javax.tools.JavaFileObject arg0, Dova.JDK.java.util.function.Function arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool explicitAnnotationProcessingRequested()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;)Z", "static")]
	public static bool explicitAnnotationProcessingRequested(Dova.JDK.com.sun.tools.javac.util.Options arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int warningCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool continueAfterProcessAnnotations()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void printNote(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void enterDone()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44]);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool unrecoverableError()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)V", "public")]
	public void setDeferredDiagnosticHandler(Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljavax/tools/JavaFileObject;", "")]
	public Dova.JDK.javax.tools.JavaFileObject printSource(Dova.JDK.com.sun.tools.javac.comp.Env arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl removeMethodBodies(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void checkReusable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/CompileStates$CompileState;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/util/List;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.util.List stopIfError(Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/CompileStates$CompileState;Ljava/util/Queue;)Ljava/util/Queue;", "protected final")]
	public Dova.JDK.java.util.Queue stopIfError(Dova.JDK.com.sun.tools.javac.comp.CompileStates.CompileState arg0, Dova.JDK.java.util.Queue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Queue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Queue;)Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map groupByFile(Dova.JDK.java.util.Queue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void printCount(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)V", "private")]
	public void printSuppressedCount(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Ljava/lang/CharSequence;", "public")]
	public Dova.JDK.java.lang.CharSequence readSource(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol resolveBinaryNameOrIdent(Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/code/Symbol;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Symbol resolveBinaryNameOrIdent(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "public")]
	public void readSourceFile(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit arg0, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "private")]
	public void readSourceFile(Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "protected static final")]
	public partial class CompilePolicy
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompilePolicy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE", "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BY_FILE", "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BY_TODO", "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy SIMPLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy BY_FILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy BY_TODO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompilePolicy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public CompilePolicy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "static")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy decode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/JavaCompiler$CompilePolicy;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.CompilePolicy>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "protected static final")]
	public partial class ImplicitSourcePolicy
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplicitSourcePolicy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSET", "Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decode", "(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy UNSET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImplicitSourcePolicy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ImplicitSourcePolicy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "static")]
		public static Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy decode(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/main/JavaCompiler$ImplicitSourcePolicy;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.main.JavaCompiler.ImplicitSourcePolicy>>(ret);
		}
	}
}
