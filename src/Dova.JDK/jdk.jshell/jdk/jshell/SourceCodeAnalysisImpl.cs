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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysisImpl;", "")]
public partial class SourceCodeAnalysisImpl
	: Dova.JDK.jdk.jshell.SourceCodeAnalysis
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SourceCodeAnalysisImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/SourceCodeAnalysisImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "PATH_TO_INDEX", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "INDEXER", "Ljava/util/concurrent/ExecutorService;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "proc", "Ljdk/jshell/JShell;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ca", "Ljdk/jshell/CompletenessAnalyzer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "closeables", "Ljava/util/List;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "currentIndexes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "indexVersion", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "classpathVersion", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "suspendLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "suspend", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "JAVA_IDENTIFIER", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS_KINDS", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "TRUE", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "FALSE", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_STATIC", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_CONSTRUCTOR", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_METHOD", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_PACKAGE", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_CLASS", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_INTERFACE", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_TYPE", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IS_VOID", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "STATIC_ONLY", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "INSTANCE_ONLY", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "IDENTITY", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "DEFAULT_PAREN", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "NO_PAREN", "Ljava/util/function/Function;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "keepParameterNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "availableSourcesOverride", "Ljava/util/List;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "availableSources", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SourceCodeAnalysisImpl", "(Ljdk/jshell/JShell;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "simpleName", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isAccessible", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "parameterType", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/type/ExecutableType;IZ)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrapper", "(Ljdk/jshell/Snippet;)Ljdk/jshell/SourceCodeAnalysis$SnippetWrapper;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "typeParametersOpt", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isNewClass", "(Lcom/sun/source/util/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hasSyntheticParameterNames", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitBackgroundTaskFinished", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "classpathChanged", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "suspendIndexing", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resumeIndexing", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "analyzeType", "(Ljava/lang/String;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "wrappers", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dependents", "(Ljdk/jshell/Snippet;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "listQualifiedNames", "(Ljava/lang/String;I)Ljdk/jshell/SourceCodeAnalysis$QualifiedNames;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sourceToSnippets", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "unwrapArrayType", "(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "analyzeCompletion", "(Ljava/lang/String;)Ljdk/jshell/SourceCodeAnalysis$CompletionInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "documentation", "(Ljava/lang/String;IZ)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "completionSuggestions", "(Ljava/lang/String;I[I)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isClass", "(Lcom/sun/source/util/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "completionSuggestionsImpl", "(Ljava/lang/String;I[I)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getEnclosedElements", "(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "pathFor", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/util/SourcePositions;Ljdk/jshell/GeneralWrap;I)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addElements", "(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addElements", "(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/function/Function;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "membersOf", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "membersOf", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findTargetType", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeActualInvocationTypes", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;Lcom/sun/source/util/TreePath;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "newClassCandidates", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeSmartTypesForExecutableType", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/Iterable;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "documentationImpl", "(Ljava/lang/String;IZ)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "elementHeader", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/element/Element;ZZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "guessKind", "(Ljava/lang/String;)Lcom/sun/source/tree/Tree$Kind;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isThrowsClause", "(Lcom/sun/source/util/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "methodCandidates", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "filterExecutableTypesByArguments", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/Iterable;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "scopeContent", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/util/function/Function;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createAccessibilityFilter", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isStaticContext", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "computeSuggestions", "(Ljdk/jshell/OuterWrap;I[I)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createDotClassSymbol", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "listPackages", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/String;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "appendDot", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "appendPaths", "(Ljdk/jshell/MemoryFileManager;Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "waitIndexingNotSuspended", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "indexForPath", "(Ljava/nio/file/Path;)Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isJRTMarkerFile", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createArrayLengthSymbol", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "doIndex", "(JLjava/nio/file/Path;Ljava/lang/Iterable;)Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isEmptyArgumentsContext", "(Ljava/util/List;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findSources", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "constructDocumentation", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljdk/internal/shellsupport/doc/JavadocHelper;Ljavax/lang/model/element/Element;Z)Ljdk/jshell/SourceCodeAnalysis$Documentation;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createPackageElement", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/String;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "refreshIndexes", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "localElements", "(Lcom/sun/source/tree/Scope;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findImport", "(Lcom/sun/source/util/TreePath;)Lcom/sun/source/tree/ImportTree;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addScopeElements", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/util/function/Function;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "primitivesOrVoid", "(Ljdk/jshell/TaskFactory$AnalyzeTask;)Ljava/util/List;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "smartFilterFromList", "(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;Ljava/util/Collection;Lcom/sun/source/tree/Tree;)Ljava/util/function/Predicate;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isVariable", "(Lcom/sun/source/util/TreePath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "resultTypeOf", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "addClassName2Map", "(Ljava/util/Map;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isTypeParameter", "(Lcom/sun/source/util/TreePath;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map PATH_TO_INDEX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ExecutorService;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ExecutorService INDEXER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jshell/JShell;", "private final")]
	public Dova.JDK.jdk.jshell.JShell proc_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.JShell>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jshell/CompletenessAnalyzer;", "private final")]
	public Dova.JDK.jdk.jshell.CompletenessAnalyzer ca_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.CompletenessAnalyzer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List closeables_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map currentIndexes_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int indexVersion_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int classpathVersion_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object suspendLock_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int suspend_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private final")]
	public Dova.JDK.java.util.regex.Pattern JAVA_IDENTIFIER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set CLASS_KINDS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate TRUE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate FALSE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_STATIC_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_CONSTRUCTOR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_METHOD_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_PACKAGE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_CLASS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_INTERFACE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_TYPE_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate IS_VOID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate STATIC_ONLY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
	public Dova.JDK.java.util.function.Predicate INSTANCE_ONLY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
	public Dova.JDK.java.util.function.Function IDENTITY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
	public Dova.JDK.java.util.function.Function DEFAULT_PAREN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Function;", "private final")]
	public Dova.JDK.java.util.function.Function NO_PAREN_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> keepParameterNames_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List availableSourcesOverride_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List availableSources_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SourceCodeAnalysisImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/JShell;)V", "")]
	public SourceCodeAnalysisImpl(Dova.JDK.jdk.jshell.JShell arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/SourceCodeAnalysisImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String simpleName(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/lang/String;)Z", "private")]
	public bool isAccessible(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.tree.Scope arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/type/ExecutableType;IZ)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream parameterType(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.type.ExecutableType arg1, int arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Ljdk/jshell/SourceCodeAnalysis$SnippetWrapper;", "public")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysis.SnippetWrapper wrapper(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.SnippetWrapper>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;Z)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String typeParametersOpt(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isNewClass(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool hasSyntheticParameterNames(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void waitBackgroundTaskFinished()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()V", "")]
	public void classpathChanged()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void suspendIndexing()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void resumeIndexing()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String analyzeType(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List wrappers(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/Snippet;)Ljava/util/Collection;", "public")]
	public Dova.JDK.java.util.Collection dependents(Dova.JDK.jdk.jshell.Snippet arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljdk/jshell/SourceCodeAnalysis$QualifiedNames;", "public")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysis.QualifiedNames listQualifiedNames(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.QualifiedNames>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List sourceToSnippets(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/type/TypeMirror;", "private")]
	public Dova.JDK.javax.lang.model.type.TypeMirror unwrapArrayType(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/jshell/SourceCodeAnalysis$CompletionInfo;", "public")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysis.CompletionInfo analyzeCompletion(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.CompletionInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List documentation(Dova.JDK.java.lang.String arg0, int arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I[I)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List completionSuggestions(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isClass(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I[I)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List completionSuggestionsImpl(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getEnclosedElements(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/util/SourcePositions;Ljdk/jshell/GeneralWrap;I)Lcom/sun/source/util/TreePath;", "private")]
	public Dova.JDK.com.sun.source.util.TreePath pathFor(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.util.SourcePositions arg1, Dova.JDK.jdk.jshell.GeneralWrap arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/List;)V", "private")]
	public void addElements(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.java.util.function.Predicate arg2, Dova.JDK.java.util.List arg3)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/function/Function;Ljava/util/List;)V", "private")]
	public void addElements(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.java.util.function.Predicate arg1, Dova.JDK.java.util.function.Predicate arg2, Dova.JDK.java.util.function.Function arg3, Dova.JDK.java.util.List arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List membersOf(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;Z)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List membersOf(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable findTargetType(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/util/List;Lcom/sun/source/util/TreePath;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List computeActualInvocationTypes(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.util.List arg1, Dova.JDK.com.sun.source.util.TreePath arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable newClassCandidates(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/Iterable;Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List computeSmartTypesForExecutableType(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.lang.Iterable arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List documentationImpl(Dova.JDK.java.lang.String arg0, int arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/element/Element;ZZ)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String elementHeader(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.javax.lang.model.element.Element arg1, bool arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/tree/Tree$Kind;", "private")]
	public Dova.JDK.com.sun.source.tree.Tree.Kind guessKind(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isThrowsClause(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable methodCandidates(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/Iterable;Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List filterExecutableTypesByArguments(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.lang.Iterable arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/util/function/Function;)Ljava/lang/Iterable;", "private")]
	public Dova.JDK.java.lang.Iterable scopeContent(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.tree.Scope arg1, Dova.JDK.java.util.function.Function arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Ljava/util/function/Predicate;", "private")]
	public Dova.JDK.java.util.function.Predicate createAccessibilityFilter(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isStaticContext(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/OuterWrap;I[I)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List computeSuggestions(Dova.JDK.jdk.jshell.OuterWrap arg0, int arg1, JavaArray<int> arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;", "private")]
	public Dova.JDK.javax.lang.model.element.Element createDotClassSymbol(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/String;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set listPackages(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String appendDot(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/MemoryFileManager;Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V", "private")]
	public void appendPaths(Dova.JDK.jdk.jshell.MemoryFileManager arg0, Dova.JDK.javax.tools.JavaFileManager.Location arg1, Dova.JDK.java.util.Collection arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "private")]
	public void waitIndexingNotSuspended()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;", "private")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysisImpl.ClassIndex indexForPath(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysisImpl.ClassIndex>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "static")]
	public static bool isJRTMarkerFile(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljavax/lang/model/type/TypeMirror;)Ljavax/lang/model/element/Element;", "private")]
	public Dova.JDK.javax.lang.model.element.Element createArrayLengthSymbol(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(JLjava/nio/file/Path;Ljava/lang/Iterable;)Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;", "private")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysisImpl.ClassIndex doIndex(long arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.lang.Iterable arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysisImpl.ClassIndex>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Z", "private")]
	public bool isEmptyArgumentsContext(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List findSources()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljdk/internal/shellsupport/doc/JavadocHelper;Ljavax/lang/model/element/Element;Z)Ljdk/jshell/SourceCodeAnalysis$Documentation;", "private")]
	public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Documentation constructDocumentation(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.jdk.@internal.shellsupport.doc.JavadocHelper arg1, Dova.JDK.javax.lang.model.element.Element arg2, bool arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Documentation>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Ljava/lang/String;)Ljavax/lang/model/element/PackageElement;", "private")]
	public Dova.JDK.javax.lang.model.element.PackageElement createPackageElement(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void refreshIndexes(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Scope;)Ljava/util/stream/Stream;", "private")]
	public Dova.JDK.java.util.stream.Stream localElements(Dova.JDK.com.sun.source.tree.Scope arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Lcom/sun/source/tree/ImportTree;", "private")]
	public Dova.JDK.com.sun.source.tree.ImportTree findImport(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ImportTree>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/tree/Scope;Ljava/util/function/Function;Ljava/util/function/Predicate;Ljava/util/function/Predicate;Ljava/util/List;)V", "private")]
	public void addScopeElements(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.tree.Scope arg1, Dova.JDK.java.util.function.Function arg2, Dova.JDK.java.util.function.Predicate arg3, Dova.JDK.java.util.function.Predicate arg4, Dova.JDK.java.util.List arg5)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List primitivesOrVoid(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jshell/TaskFactory$AnalyzeTask;Lcom/sun/source/util/TreePath;Ljava/util/Collection;Lcom/sun/source/tree/Tree;)Ljava/util/function/Predicate;", "private")]
	public Dova.JDK.java.util.function.Predicate smartFilterFromList(Dova.JDK.jdk.jshell.TaskFactory.AnalyzeTask arg0, Dova.JDK.com.sun.source.util.TreePath arg1, Dova.JDK.java.util.Collection arg2, Dova.JDK.com.sun.source.tree.Tree arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isVariable(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/type/TypeMirror;", "private")]
	public Dova.JDK.javax.lang.model.type.TypeMirror resultTypeOf(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/lang/String;)V", "private static")]
	public static void addClassName2Map(Dova.JDK.java.util.Map arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isTypeParameter(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysisImpl$CompletionInfoImpl;", "private static")]
	public partial class CompletionInfoImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.jshell.SourceCodeAnalysis.CompletionInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompletionInfoImpl()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/SourceCodeAnalysisImpl$CompletionInfoImpl;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "completeness", "Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "source", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "remaining", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CompletionInfoImpl", "(Ljdk/jshell/SourceCodeAnalysis$Completeness;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remaining", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "source", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "completeness", "()Ljdk/jshell/SourceCodeAnalysis$Completeness;"));
		}

		[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysis$Completeness;", "private final")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness completeness_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String source_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String remaining_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompletionInfoImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/jshell/SourceCodeAnalysis$Completeness;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public CompletionInfoImpl(Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/SourceCodeAnalysisImpl$CompletionInfoImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String remaining()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String source()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljdk/jshell/SourceCodeAnalysis$Completeness;", "public")]
		public Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness completeness()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.SourceCodeAnalysis.Completeness>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysisImpl$SuggestionImpl;", "private static")]
	public partial class SuggestionImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.jshell.SourceCodeAnalysis.Suggestion
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SuggestionImpl()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/SourceCodeAnalysisImpl$SuggestionImpl;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "continuation", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "matchesType", "Z"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SuggestionImpl", "(Ljava/lang/String;Z)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "continuation", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "matchesType", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String continuation_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool matchesType_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SuggestionImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
		public SuggestionImpl(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/SourceCodeAnalysisImpl$SuggestionImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String continuation()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool matchesType()
		{
			var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysisImpl$DocumentationImpl;", "private static final")]
	public partial class DocumentationImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.jshell.SourceCodeAnalysis.Documentation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocumentationImpl()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/SourceCodeAnalysisImpl$DocumentationImpl;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "signature", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "javadoc", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DocumentationImpl", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "signature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "javadoc", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String signature_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String javadoc_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DocumentationImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public DocumentationImpl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/SourceCodeAnalysisImpl$DocumentationImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String signature()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String javadoc()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;", "public static final")]
	public partial class ClassIndex
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassIndex()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "timestamp", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "forPath", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "packages", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "classSimpleName2FQN", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ClassIndex", "(JLjava/nio/file/Path;Ljava/util/Set;Ljava/util/Map;)V"));
		}

		[JniSignatureAttribute("J", "public final")]
		public long timestamp_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "public final")]
		public Dova.JDK.java.nio.file.Path forPath_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "public final")]
		public Dova.JDK.java.util.Set packages_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Map;", "public final")]
		public Dova.JDK.java.util.Map classSimpleName2FQN_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassIndex(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLjava/nio/file/Path;Ljava/util/Set;Ljava/util/Map;)V", "public")]
		public ClassIndex(long arg0, Dova.JDK.java.nio.file.Path arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jshell/SourceCodeAnalysisImpl$ClassIndex;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}